﻿using HPWUHexingTrainer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HPWUHexingTrainer
{
    public class LobbyReader
    {
        UserSettings _state;
        List<Foe> foes;
        LobbyResult result = new LobbyResult();

        List<Foe> orderedMagiFoes = new List<Foe>();
        List<Foe> orderedAurorFoes = new List<Foe>();
        List<Foe> orderedProfFoes = new List<Foe>();
        List<Foe> orderedAurorFoesFull = new List<Foe>();
        List<Foe> originalAurorFoes = new List<Foe>();
        List<FoeFighter> originalFoeFighters = new List<FoeFighter>();


        int profFoeValue, aurorFoeValue, magiFoeValue, foeValue; // A2 always passes 1, we add that in as necessary later

        public LobbyReader(List<Foe> foes, UserSettings state)
        {
            this.foes = foes;
            _state = state;
        }
        public LobbyResult Read()
        {
            //LobbyResult br = new LobbyResult();
            result.Advanced = _state.ShowAdvancedRules;
            result.A2Hexes = new List<Hex>();
            result.A1Hexes = new List<Hex>();
            result.FoeFighters = new List<FoeFighter>();
            result.Decisions = new List<string>();

            if (_state.ShowAdvancedRules)
            {
                ReadAdvanced();
                return result;
            }

            List<Foe> orderedAurorFoes = SetA2Details();
            SetA1Details();
            AssessProficiencyAndShieldForA2();

            result.Foes = foes;

            return result;
            //return PrepareReturnString(br);
        }


        #region standard rules

        #region A1
        private void SetA1Details()
        {
            List<Foe> orderedProfFoes = GetProfFoes();

            if (orderedProfFoes.Count == 0)
            {
                result.A1FocusPassed = 1;
                result.A1FocusKept = 3;

            }
            else if (orderedProfFoes.Count == 1)
                result.A1FocusKept = 2; // keep 2 for the 2nd prof that has nothing to fight straight away


            for (int cnt = 0; cnt < orderedProfFoes.Count(); cnt++)
            //foreach (Foe f in orderedProfFoes)
            {
                Foe f = orderedProfFoes[cnt];

                if (cnt == 0)
                {
                    result.P1Fights = true;
                    result.P1Foe = _state.FoeFullName(f);
                }
                else
                {
                    result.P2Fights = true;
                    result.P2Foe = _state.FoeFullName(f);
                }

                if (f.Type == FoeType.Pixie)
                {
                    //int pixieStars = 3;

                    //if (_state.ShowAdvancedRules) // don't weaken 4 star pixies with advanced rules
                    //    pixieStars = 4;

                    // standard rules changed by Andolov to not weaken 4* pixie
                    if ((int)f.Stars > 4)
                        AddHex(HexType.Weakening, _state.FoeFullName(f), true);
                }
                // it is a wolf
                else
                {
                    AddHex(HexType.Weakening, _state.FoeFullName(f), true);

                    if (f.Stars == StarName.Fierce)
                        AddHex(HexType.Confusion, _state.FoeFullName(f), true);



                    // if it is a 4 star wolf AND there will be no proficiency, also add a confusion
                    else if (f.Stars == StarName.Dangerous)
                    {
                        // if A2 passed 3 -> Automatic proficiency - no confusion 

                        /* 
                         * 3 star pixie (0 hexes, pass 2) + 1 x 4 star wolf => 3 star Pixie == automatic proficiency unless hard auror foes - no confusion on wolf
                         * 4,5 star pixie (1 hex, pass 1) + 1 x 4 star wolf => if A2 passed 1 & we pass 1 for pixie, we can pass 1 and get prof -> no confusion on wolf 
                         * 1 x 5 star wolf(2 hexes) + 1 x 4 star wolf => we need 2 for wolf. If A2 passed 2 we could pass 1 & get prof -> no confusion. If A2 passed 1, we need to double hex
                         * 2 x 4 star wolves - can single hex both, pass 2 -> proficiency - no confusion on wolf
                         */

                        // we need to double hex the 4 star wolf if P2 has shielded A2 or we need lots of hexes and A2 only passed 1
                        if (result.A2FocusPassed == 1 && result.A1Hexes.Count == 3 || result.P2ShieldsA2)

                            AddHex(HexType.Confusion, _state.FoeFullName(f), true);
                    }
                }
            }
            result.A1FocusPassed = 4 - result.A1Hexes.Count() - result.A1FocusKept;
        }

        private List<Foe> GetProfFoes()
        {
            return foes
                .Where(p => p.Elite == false && (p.Type == FoeType.Pixie || p.Type == FoeType.Werewolf))
                .OrderBy(p => p.Type.ToString())
                .ThenBy(p => p.Stars)
                .Take(2)
                .ToList();
        }
        #endregion

        #region A2
        private List<Foe> SetA2Details()
        {
            result.A2FocusPassed = 1; // A2 ALWAYS passes a focus regardless of the lobby

            AssessMagiFoes();
            List<Foe> orderedAurorFoes = AssessAurorFoes();

            result.A2FocusPassed = 4 - result.A2Hexes.Count - result.A2FocusKept;
            return orderedAurorFoes;
        }

        private void AssessMagiFoes()
        {
            //Imposing Erkling -> 
            //Imposing Acromantula -> 
            //Dangerous Acromantula -> 
            //Fierce Acromantula->
            //Dangerous Erkling->
            //Fierce Erkling

            List<Foe> orderedMagiFoes = GetMagiFoe();

            // if no magi mon, keep a focus for when one shows up
            if (orderedMagiFoes.Count() == 0)
                result.A2FocusKept += 1;
            else
            {
                if (orderedMagiFoes[0].Type == FoeType.Erkling && (int)orderedMagiFoes[0].Stars > 3)
                    AddHex(HexType.Confusion, _state.FoeFullName(orderedMagiFoes[0]), false);
                //AddHex(br, HexType.Confusion, orderedMagiFoes[0].ToString(), false);


                result.MagiFights = true;
                result.MagiFoe = _state.FoeFullName(orderedMagiFoes[0]);
            }
        }

        private List<Foe> GetMagiFoe()
        {
            // we just take the top 1 magi foe as we only have 1 magi
            return foes
                .Where(m => m.Elite == false && (m.Type == FoeType.Acromantula || m.Type == FoeType.Erkling))
                .OrderBy(m => m.Type == FoeType.Erkling && m.Stars == StarName.Imposing)
                .OrderBy(m => m.Type == FoeType.Acromantula && m.Stars == StarName.Imposing)
                .OrderBy(m => m.Type == FoeType.Acromantula && m.Stars == StarName.Dangerous)
                .OrderBy(m => m.Type == FoeType.Acromantula && m.Stars == StarName.Fierce)
                .OrderBy(m => m.Type == FoeType.Erkling && m.Stars == StarName.Dangerous)
                .OrderBy(m => m.Type == FoeType.Erkling && m.Stars == StarName.Fierce)
                .Take(1)
                .ToList();
        }

        private List<Foe> AssessAurorFoes()
        {
            //List<Foe> orderedAurorFoes = new List<Foe>();

            if (_state.ShowAdvancedRules)
                //    Imposing Dark Wizard->
                //    Imposing Death Eater ->
                //    Dangerous Death Eater ->  
                //    Dangerous Dark Wizard->
                //    Fierce Death Eater -> 
                //    Fierce Dark Wizard

                // I think this is too simplistic as this order is for shielded Aurors. A2 may not have a shield in which case it would be wrong. 
                // Possibly we need to take top 3 and make a decision on the 2nd auror foe based on shields later.

                orderedAurorFoes = orderedAurorFoes = foes
                     .Where(m => m.Elite == false && (m.Type == FoeType.DeathEater || m.Type == FoeType.DarkWizard))
                     .OrderBy(m => m.Type == FoeType.DarkWizard && m.Stars == StarName.Imposing)
                     .OrderBy(m => m.Type == FoeType.DeathEater && m.Stars == StarName.Imposing)
                     .OrderBy(m => m.Type == FoeType.DeathEater && m.Stars == StarName.Dangerous)
                     .OrderBy(m => m.Type == FoeType.DarkWizard && m.Stars == StarName.Dangerous)
                     .OrderBy(m => m.Type == FoeType.DeathEater && m.Stars == StarName.Fierce)
                     .OrderBy(m => m.Type == FoeType.DarkWizard && m.Stars == StarName.Fierce)
                     .Take(2)
                     .ToList(); // keep all of the list as we can't decide at this point what the correct order should be

            else
                //    Imposing Dark Wizard->
                //    Imposing Death Eater -> 
                //    Dangerous Dark Wizard->
                //    Dangerous Death Eater -> 
                //    Fierce Death Eater -> 
                //    Fierce Dark Wizard
                orderedAurorFoes = orderedAurorFoes = foes
                     .Where(m => m.Elite == false && (m.Type == FoeType.DeathEater || m.Type == FoeType.DarkWizard))
                     .OrderBy(m => m.Type == FoeType.DarkWizard && m.Stars == StarName.Imposing)
                     .OrderBy(m => m.Type == FoeType.DeathEater && m.Stars == StarName.Imposing)
                     .OrderBy(m => m.Type == FoeType.DarkWizard && m.Stars == StarName.Dangerous)
                     .OrderBy(m => m.Type == FoeType.DeathEater && m.Stars == StarName.Dangerous)
                     .OrderBy(m => m.Type == FoeType.DeathEater && m.Stars == StarName.Fierce)
                     .OrderBy(m => m.Type == FoeType.DarkWizard && m.Stars == StarName.Fierce)
                     .Take(2)
                     .ToList();


            //List<Foe> orderedAurorFoes = foes
            //    .Where(a => a.Elite == false && (a.Type == FoeType.DeathEater || a.Type == FoeType.DarkWizard))
            //    .OrderBy(a => a.Stars)
            //    .ThenBy(a => a.Type.ToString())
            //    .Take(2)
            //    .ToList();

            // if no auror mons, keep 2 focus for when they show up
            if (orderedAurorFoes.Count == 0)
                result.A2FocusKept += 2;

            else if (orderedAurorFoes.Count == 1)
                result.A2FocusKept += 1; // keep 1 for the 2nd auror that has nothing to fight straight away

            else
            {
                // standard rule - we have 2 auror foes, reverse the order as A1 has a shield so gets the harder foe
                if (!_state.ShowAdvancedRules)
                    orderedAurorFoes.Reverse();
                else
                    // advanced rule - don't reverse if easier mon could be taken by A1 without a hex and next mon is dangerous dark wizard
                    if (!(orderedAurorFoes[0].Stars == StarName.Imposing &&
                            orderedAurorFoes[1].Stars == StarName.Dangerous && orderedAurorFoes[1].Type == FoeType.DarkWizard))
                    orderedAurorFoes.Reverse();
            }

            for (int cnt = 0; cnt < orderedAurorFoes.Count(); cnt++)
            {
                Foe f = orderedAurorFoes[cnt];

                if (cnt == 0)
                {
                    result.A1Fights = true;
                    result.A1Foe = _state.FoeFullName(f);

                    // This is the foe that Auror 1 will take, this Auror will always have a shield so don't hex 3 star
                    if ((int)f.Stars == 3)
                        continue;
                }
                else
                {
                    result.A2Fights = true;
                    result.A2Foe = _state.FoeFullName(f);
                }

                if (f.Stars == StarName.Fierce && f.Type == FoeType.DarkWizard)
                {
                    AddHex(HexType.Confusion, _state.FoeFullName(orderedAurorFoes[cnt]), false);

                    // Double hex the 5 star dark wizard for A1 as it always has a shield 
                    // & A2 as it will also need a shield due to 2 x 5 star Auror foes

                    // Don't double weaken in the initial lobby to get proficiency up quicker.
                    //if (br.A2Hexes.Count <= 3) // if we've hexed the magi + double hexed A1, we can only add 1 hex for A2
                    //    AddHex(br, HexType.Weakening, orderedAurorFoes[cnt].ToString(), false);
                }
                else
                {
                    if (!_state.ShowAdvancedRules)
                        AddHex(HexType.Weakening, _state.FoeFullName(orderedAurorFoes[cnt]), false);
                    else
                    {
                        // Advance rules, hold off on weakening 4* DE at this stage. Wait until the proficiency stage to determine that.
                        if (!(orderedAurorFoes[cnt].Stars == StarName.Dangerous && orderedAurorFoes[cnt].Type == FoeType.DeathEater))
                        {
                            AddHex(HexType.Weakening, _state.FoeFullName(orderedAurorFoes[cnt]), false);
                        }
                    }


                }
            }

            // we need to shield A2 due to hard Auror foes
            var num5StarAurorFoes = orderedAurorFoes.Where(a => a.Stars == StarName.Fierce).Count();
            result.P2ShieldsA2 = num5StarAurorFoes == 2 ? true : false;



            return orderedAurorFoes;
        }

        #endregion


        private void AssessProficiencyAndShieldForA2()
        {
            var focusAvailableToProfs = result.A1FocusPassed + result.A2FocusPassed;
            var num5StarAurorFoes = orderedAurorFoes.Where(a => a.Stars == StarName.Fierce).Count();

            if (_state.ShowAdvancedRules)
                // advanced rules
                FocusAdvancedRules(focusAvailableToProfs, num5StarAurorFoes);
            else
            {
                /* determine if we need 2 shields 
                            *  - P2 has 7 focus but both Aurors will fight 5 stars
                            *  - P2 doesn't have 7 focus and lobby has 5 star mon or 4 star DE
                            */
                // we've got enough focus for proficiency
                if (focusAvailableToProfs >= 3)
                {
                    // how many hard auror foes?


                    if (!_state.ShowAdvancedRules)
                    {
                        // if we have 2 hard auror foes, proficiency is false. Either way P2 shield A2 is opposite value to proficiency
                        result.Proficiency = num5StarAurorFoes != 2;
                        result.P2ShieldsA2 = !result.Proficiency;
                    }

                }
                else
                {
                    // we don't have enough for proficiency, give all we've got to P2
                    //focusForP2 = focusAvailableToProfs;

                    // we didn't get proficiency and have hard auror foes??
                    result.Proficiency = false; // we didn't get passed enough focus

                    // if we have 2 auror foes and not enough focus, see if A2 needs a shield
                    if (orderedAurorFoes.Count == 2)
                    {
                        var a2Shield = orderedAurorFoes[1].Stars == StarName.Fierce ||
                                (orderedAurorFoes[1].Stars == StarName.Dangerous && orderedAurorFoes[1].Type == FoeType.DeathEater);
                        result.P2ShieldsA2 = a2Shield;
                    }
                }
            }


        }

        private void FocusAdvancedRules(int focusAvailableToProfs, int num5StarAurorFoes)
        {
            result.Proficiency = true; // we'll work out the real answer below, default to true for now.

            // get the count of 4* DEs, these haven't been hexed yet,
            int DangerousDeathEaters = orderedAurorFoes.Where(a => a.Stars == StarName.Dangerous && a.Type == FoeType.DeathEater).Count();


            // if we have 5 focus passed, we have enough to shield both aurors AND cast proficiency
            if (focusAvailableToProfs >= 5)
            {
                result.P1ShieldsA2 = true;
                // don't add a weakening hex to any 4* Death Eater, don't need to change hexes
            }
            else if (num5StarAurorFoes == 2) // we don't have enough focus for P1 to shield A2 so P2 needs to do so as we have 2 x 5* auror foes
            {
                result.Proficiency = false;
                result.P2ShieldsA2 = !result.Proficiency;

                //// as P2 has used focus to Shield A2, A1 & A2 pass all focus to P2 to work towards proficiency
                //br.A1FocusPassedToP2 = br.A1FocusPassed;
                //br.A2FocusPassedToP2 = br.A2FocusPassed;

                // we don't have any 4* as we have 2 x 5*, don't need to change hexes
            }
            else
            // we don't have 5 focus passed and we don't have 2 5* auror foes, these are the hard cases
            {
                if (DangerousDeathEaters == 0)
                {
                    // easy peasy, nothing to do
                }
                else if (focusAvailableToProfs < 3)
                {
                    // we are NOT getting proficency, add a weakening hex to each dangerous death eater
                    foreach (Foe f in orderedAurorFoes)
                    {
                        if (f.Stars == StarName.Dangerous && f.Type == FoeType.DeathEater)
                        {
                            AddHex(HexType.Weakening, _state.FoeFullName(f), false);
                            result.A2FocusPassed -= 1;
                        }
                    }
                }
                else // we potentially have enough for proficiency - hardest case
                {
                    // if we have only 1 4* DE & Auror 1 is fighting it, he will have a shield so long as focus passed >= 3
                    if (DangerousDeathEaters == 1 && orderedAurorFoes[0].Stars == StarName.Dangerous && orderedAurorFoes[0].Type == FoeType.DeathEater)
                    {
                        // do nothing, proficiency is up and A1 always gets a shield
                    }
                    else
                    {
                        // if A2 is fighting a 4* DE he needs a hex 
                        if (orderedAurorFoes[1].Stars == StarName.Dangerous && orderedAurorFoes[1].Type == FoeType.DeathEater)
                        {
                            AddHex(HexType.Weakening, _state.FoeFullName(orderedAurorFoes[1]), false);
                            result.A2FocusPassed -= 1;
                        }

                        // if A1 is also fighting a 4* DE we need to check if we still have enough for proficiency? If not, A1 also needs a hex
                        if (result.A1FocusPassed + result.A2FocusPassed < 3 &&
                                orderedAurorFoes[0].Stars == StarName.Dangerous && orderedAurorFoes[0].Type == FoeType.DeathEater)
                        {
                            AddHex(HexType.Weakening, _state.FoeFullName(orderedAurorFoes[0]), false);
                            result.A2FocusPassed -= 1;
                        }
                    }
                }
            }


            // do we still have enough focus for proficiency?
            result.Proficiency = result.A1FocusPassed + result.A2FocusPassed >= 3;

            if (result.Proficiency)
            {
                // if A2 has 4 focus, send 3 to P2 and 1 to P1, otherwise send it all to P2
                if (result.A2FocusPassed == 4)
                {
                    result.A2FocusPassedToP2 = 3;
                    result.A2FocusPassedToP1 = 1;
                }
                else
                {
                    result.A2FocusPassedToP2 = result.A2FocusPassed;
                    result.A2FocusPassedToP1 = 0;
                }

                // A1 needs to pass enough so that P2 gets 3 total and P1 gets the rest
                result.A1FocusPassedToP2 = 3 - result.A2FocusPassedToP2;
                result.A1FocusPassedToP1 = result.A1FocusPassed - result.A1FocusPassedToP2;
            }
            else
            {
                // no proficiency, send it all to P2
                result.A2FocusPassedToP2 = result.A2FocusPassed;
                result.A1FocusPassedToP2 = result.A1FocusPassed;

            }
        }
        #endregion



        #region advanced rules
        public void ReadAdvanced()
        {
            // You have 8 focus between both Aurors. A1 is hexing for the Professions and A2 is hexing for the Aurors and the Magi.
            //int magiFoeValue = 0, profFoeValue = 0, aurorFoeValue = 0; // A2 always passes 1, we add that in as necessary later

            /*
             * After this, the mental process is complicated.But the main idea is to assign “focus value” to the foes. Only one Magi foe can have value, 
             * two for Professor and two for Auror.
             * If the total value of foes is 2 or higher, it means that we can get Proficiency up (Unless we have two Fierce Dark Forces).
             * If the total value of foes is 4 or higher, it means that we can get Proficiency up and both shields.
             */
            AddDecision($"A2 always passes 1 focus. Add 1 to focus passed.");

            magiFoeValue = SortOutMagi();
            orderedProfFoes = SortOutProfs();
            aurorFoeValue = SortOutAurors();



            // Ultra rule 2 - if we have only 1 prof foe and there is a pixie or a 3* DF in the lobby, pass an extra focus to the profs
            if (_state.UseUltraRule2 && orderedProfFoes.Count == 1)
            {
                bool profFoeIsPixie = orderedProfFoes[0].Type == FoeType.Pixie;
                bool auror3starDFExists = orderedAurorFoes.Any(a => a.Stars == StarName.Imposing);

                if (profFoeIsPixie || auror3starDFExists)
                {
                    profFoeValue++;
                    AddDecision($"Ultra Rule 2: 1 curiosity and we have either a pixie or a 3* Dark Foe. Add 1 to focus passed.");
                }
            }

            /*
             * At this point, we assumed that we are in the best case scenario, where FoeValue >= 4, which means both shields and Proficiency up.
             * Now, let’s see what happen in each case.
             */
            int foeValue = magiFoeValue + profFoeValue + aurorFoeValue;
            AddDecision($"Focus that can be passed: {foeValue + 1}.");

            //if (foeValue < 7)
            DetermineProficiencyAndOptionalHexes();

            DetermineFocusPassed();
            DetermineAurorFoeSelection();
            SetFoeDetails();
        }


        private int SortOutMagi()
        {
            int magiFoeValue;
            /*
             Magi foe order = 
            Imposing Erkling -> #Value 1
            Imposing Acromantula -> #Value 1
            Dangerous Acromantula -> #Value 1
            Fierce Acromantula -> #Value 1
            Dangerous Erkling -> #Value 0
            Fierce Erkling #Value 0
            */
            orderedMagiFoes = GetMagiFoe();

            //AddDecision($"Magi has { (orderedMagiFoes.Count > 0 ? "a foe" : "nothing") } to fight.");

            if (orderedMagiFoes.Count == 0)
            {
                magiFoeValue = 0;
                // AddDecision($"Magi has nothing to fight. Keep a focus for the next Magi foe to turn up.");
            }
            else
            {
                result.MagiFights = true;
                result.MagiFoe = _state.FoeFullName(orderedMagiFoes[0]);

                if (orderedMagiFoes[0].Type == FoeType.Erkling && (int)orderedMagiFoes[0].Stars > 3)
                {
                    magiFoeValue = 0;
                    AddDecision($"Magi will fight a {_state.FoeFullName(orderedMagiFoes[0])}, add a Confusion hex to 4* or 5* Erklings.");
                    AddFoeFighter(orderedMagiFoes[0], new List<HexType> { HexType.Confusion }, "M");

                    //result.MagiFoe = $"{result.MagiFoe} with Confusion";
                }
                else
                {
                    magiFoeValue = 1;
                    AddFoeFighter(orderedMagiFoes[0], null, "M");
                    AddDecision($"Magi will fight a { _state.FoeFullName(orderedMagiFoes[0]) }, no hex. Add 1 to focus passed.");
                }
            }
            return magiFoeValue;
        }

        private List<Foe> SortOutProfs()
        {
            orderedProfFoes = GetProfFoes();

            /*
             *  prof foe order = 
                Imposing Pixie -> #Value 2
                Dangerous Pixie -> #Value 2
                Fierce Pixie-> #Value 1
                Imposing Werewolf -> #Value 1
                Dangerous Werewolf-> #Value 1, but it can change
                Fierce Werewolf #Value 0
            */
            if (orderedProfFoes.Count == 0)
            {
                AddDecision($"There are no foes for the professors to fight. Add 1 to focus passed.");
                profFoeValue = 1;
            }
            else
            {
                //foreach (var f in orderedProfFoes)
                for (int i = 0; i < orderedProfFoes.Count; i++)
                {
                    string foughtBy = i == 0 ? "P1" : "P2";

                    var f = orderedProfFoes[i];
                    AddFoeFighter(f, null, foughtBy);

                    AddDecision($"{foughtBy} - will fight a {_state.FoeFullName(f)}.");

                    var ff = result.FoeFighters.Where(f => f.FoughtBy == foughtBy).FirstOrDefault();



                    //// if prof is fighting 3 or 4* pixie, no hexes
                    //if (f.Type == FoeType.Pixie && (int)f.Stars < 5)
                    //    profFoeValue += 2;

                    //// if P2 is fighting a 3* wolf or a 5* pixie, don't hex at this stage. Check focus first as it may get a shield
                    //else if (i == 1 && f.Type == FoeType.Werewolf && (int)f.Stars == 3)
                    //    profFoeValue += 2;

                    //else if (i == 1 && f.Type == FoeType.Pixie && (int)f.Stars == 5)
                    //    profFoeValue += 2;


                    // if prof is fighting 3 or 4* pixie, no hexes
                    bool prof3or4Pixie = f.Type == FoeType.Pixie && (int)f.Stars < 5;
                    if (prof3or4Pixie)
                    {
                        profFoeValue += 2;
                        AddDecision($"{foughtBy} - No hexes as foe is a 3* pixie or a 4* pixie. Add 2 to focus passed.");
                    }

                    // if P2 is fighting a 3 * wolf or a 5 * pixie, don't hex at this stage. Check focus first as it may get a shield
                    bool p2_3Wolf = i == 1 && f.Type == FoeType.Werewolf && (int)f.Stars == 3;
                    bool p2_5starPixie = i == 1 && f.Type == FoeType.Pixie && (int)f.Stars == 5;

                    if (p2_3Wolf || p2_5starPixie)
                    {
                        profFoeValue += 2;
                        AddDecision($"{foughtBy} - No hexes (for now) as this is for P2 who may get a shield and foe is a 3* wolf or a 5* pixie. Add 2 to focus passed.");
                    }

                    // only automatically add hex to 5* pixie if P1 is going to fight it. P2 may get a shield in which case it wouldn't need a hex
                    else if ((f.Type == FoeType.Pixie && (int)f.Stars == 5) || (f.Type == FoeType.Werewolf && (int)f.Stars < 5))
                    {
                        ff.Hexes.Add(HexType.Weakening);
                        AddDecision($"{foughtBy} - Weakening hex added to {_state.FoeFullName(f)}. Add 1 to focus passed.");
                        profFoeValue++;
                    }
                    else if (f.Type == FoeType.Werewolf && (int)f.Stars == 5)
                    {
                        ff.Hexes.AddRange(new List<HexType> { HexType.Confusion, HexType.Weakening });
                        AddDecision($"{foughtBy} - Weakening and Confusion hex added to {_state.FoeFullName(f)}.");
                    }
                }
            }
            return orderedProfFoes;
        }

        private int SortOutAurors()
        {
            /*
             * #For Auror foe order we will assume that the total value will be 4, and then do exceptions if it is lower than 2, or 2-3.
                Auror foe order:
                        Imposing Dark Wizard -> #Value 1
                        Imposing Death Eater -> #Value 1
                        Dangerous Death Eater -> #Value 1
                        Dangerous Dark Wizard -> #Value 0
                        Fierce Death Eater -> #Value 0
                        Fierce Dark Wizard -> #Value 0
            */

            // we may need a 3rd foe later on, just have a full list and a shortened list
            orderedAurorFoesFull = foes
                 .Where(m => m.Elite == false && (m.Type == FoeType.DeathEater || m.Type == FoeType.DarkWizard))
                 .OrderBy(m => m.Type == FoeType.DarkWizard && m.Stars == StarName.Imposing)
                 .OrderBy(m => m.Type == FoeType.DeathEater && m.Stars == StarName.Imposing)
                 .OrderBy(m => m.Type == FoeType.DeathEater && m.Stars == StarName.Dangerous)
                 .OrderBy(m => m.Type == FoeType.DarkWizard && m.Stars == StarName.Dangerous)
                 .OrderBy(m => m.Type == FoeType.DeathEater && m.Stars == StarName.Fierce)
                 .OrderBy(m => m.Type == FoeType.DarkWizard && m.Stars == StarName.Fierce)
                 .ToList();

            orderedAurorFoes = orderedAurorFoesFull
                .Take(2)
                .ToList();


            FoeFighter magiInfo = result.FoeFighters.Where(f => f.FoughtBy == "M")
                                        .FirstOrDefault();

            // if we have no magi foes AND no auror foes, pass an extra focus to the profs
            if (magiInfo == null && orderedAurorFoes.Count == 0)
            {
                AddDecision($"There are no foes for the magis or the aurors to fight. Add 1 to focus passed.");
                aurorFoeValue++;
            }

            else if (orderedAurorFoes.Count > 0)
            {
                //foreach (var f in orderedAurorFoes)
                for (int i = 0; i < orderedAurorFoes.Count; i++)
                {
                    string foughtBy = i == 0 ? "A1" : "A2"; // who fights what may change later
                    var f = orderedAurorFoes[i];

                    AddFoeFighter(f, null, foughtBy);
                    AddDecision($"{foughtBy} - starts with a {_state.FoeFullName(f)}.");
                    var ff = result.FoeFighters.Last();

                    if (((int)f.Stars == 3) || (f.Type == FoeType.DeathEater && (int)f.Stars == 4))
                    {
                        AddDecision($"{foughtBy} - has a 3* foe or 4* Death Eater - no hex for now. Add 1 to focus passed.");
                        aurorFoeValue++;
                    }

                    else if (f.Type == FoeType.DarkWizard && (int)f.Stars == 5)
                    {
                        ff.Hexes.Add(HexType.Confusion);
                        AddDecision($"{foughtBy} - has a 5* Dark Wizard - these get a Confusion hex.");
                    }
                    else
                    {
                        // 4* DW or 5* DE
                        AddDecision($"{foughtBy} - has a 4* Dark Wizard or 5* Death Eater - these get a Weakening hex.");
                        ff.Hexes.Add(HexType.Weakening);
                    }
                }
            }
            return aurorFoeValue;
        }


        private void DetermineProficiencyAndOptionalHexes()
        {
            foeValue = magiFoeValue + profFoeValue + aurorFoeValue;

            if (foeValue == 7)
            {
                result.P1ShieldsP2 = true;
                AddDecision($"Focus passed = 8. We have a 🦄 lobby! P1 shields P2.");
            }

            else if (foeValue < 7)
            {
                /*
                1) If there is 1 Dark Force or less: In that case consider shielding one Auror and one Professor.
                For this you will need to count the focus assuming that the Professor that can get the shield is in fact shielded. 
                Therefore, 3 Werewolf doesn't get a Hex, 5 Pixie doesn't get a gex and Fierce Werewolf only gets Confusion Hex.
                */
                if (_state.UseUltraRule1 && orderedAurorFoes.Count <= 1 && foeValue >= 4)
                {
                    result.P1ShieldsP2 = true; 
                    AddDecision("Ultra rule 1 - Focus passed >= 5 and <= 1 dark foes, shield for both A1 and P2.");
                }


                // if P2 doesn't get a shield AND it is fighting a 3* wolf or 5* pixie, add a weakening hex
                if (result.P1ShieldsP2 == false && orderedProfFoes != null && orderedProfFoes.Count == 2)
                    if (
                            (orderedProfFoes[1].Type == FoeType.Werewolf && (int)orderedProfFoes[1].Stars == 3)
                            ||
                            (orderedProfFoes[1].Type == FoeType.Pixie && (int)orderedProfFoes[1].Stars == 5)
                    )
                    {
                        // find the foeFighter record for P2 then add a weakening hex
                        var ff = result.FoeFighters.Where(f => f.FoughtBy == "P2").First();
                        ff.Hexes.Add(HexType.Weakening);
                        profFoeValue--;
                        AddDecision($"P2 - no shield and has a 3* wolf or a 5* pixie, add Weakening to {_state.FoeFullName(ff.Foe)}. Subtract 1 from focus passed.");
                    }
            }

            foeValue = magiFoeValue + profFoeValue + aurorFoeValue;
            result.Proficiency = foeValue >= 2; // + 1 that is always passed :)


            // if foe value is between 5 and 7, the only optional hex was the prof 2 foe so we don't need to do any more checks
            if (foeValue >= 4) // this doesn't include the 1 focus always passed by A2 so we only need 4 here (5 focus passed in total)
            {
                result.Proficiency = true;
                //result.P1ShieldsA1 = true; // this always happens so it is implicit

                if (!result.P1ShieldsP2) // Ultra rule 1
                {
                    result.P1ShieldsA2 = true;
                    AddDecision("Focus passed >= 5, We have proficiency and shields for both A1 and A2.");
                    return;
                }
            }

            if (foeValue < 4)
            {
                AddDecision($"We {(result.Proficiency ? " have proficiency. This may still change." : "do not have proficiency.")}");

                //P1 will shield A2 if >= 4 foe value (focus passed = 5), so if that didn't happen, check if P2 needs to shield A2
                if (foeValue < 4 && !result.P1ShieldsA2)
                {
                    //  Check if we need to shield both Aurors due to hard auror foes 
                    var num5StarAurorFoes = orderedAurorFoes.Where(a => a.Stars == StarName.Fierce).Count();

                    if (num5StarAurorFoes == 2)
                    {
                        result.P2ShieldsA2 = true;
                        result.Proficiency = false;
                        AddDecision("A2 does not have a shield and we have 2 5* dark foes. P2 shields A2.");
                        AddDecision("We do not have proficiency.");
                    }
                }
            }
            aurorFoeValue = TwoAurorFoes();

            // recalculate proficiency (again) after the latest round of hexing - only if proficiency was true before
            if (result.Proficiency)
            {
                result.Proficiency = magiFoeValue + profFoeValue + aurorFoeValue >= 2; // + 1 that is always passed :)
                if (!result.Proficiency)
                    AddDecision("We do not have proficiency.");
            }

            // if we don't have proficiency and A1 is fighting a 4* DE, add a weakness hex
            if (orderedAurorFoes.Count > 0 && !result.Proficiency && orderedAurorFoes[0].Type == FoeType.DeathEater && (int)orderedAurorFoes[0].Stars == 4)
            {
                // weaken A1's foe
                FoeFighter a1 = result.FoeFighters.Where(f => f.FoughtBy == "A1").First();
                a1.Hexes.Add(HexType.Weakening);
                aurorFoeValue--;
                AddDecision($"A1 - no proficiency and is fighting a {_state.FoeFullName(a1.Foe)}, add a Weakness hex. Subtract 1 from focus passed.");
            }

            // recalculate proficiency (again) after the latest round of hexing - only if proficiency was true before
            if (result.Proficiency)
            {
                result.Proficiency = magiFoeValue + profFoeValue + aurorFoeValue >= 2; // + 1 that is always passed :)
                if (!result.Proficiency)
                    AddDecision("We do not have proficiency.");
            }

            if (!result.Proficiency)
            {
                //var profFoes = orderedProfFoes.Where(p => p.Type == FoeType.Werewolf && (int)p.Stars == 4).ToList();

                //for (int i = 0; i < profFoes.Count; i++)
                for (int i = 0; i < orderedProfFoes.Count; i++)
                {
                    string foughtBy = i == 0 ? "P1" : "P2";
                    FoeFighter profFoe = result.FoeFighters.Where(f => f.FoughtBy == foughtBy).First();

                    if (profFoe.Foe.Type == FoeType.Werewolf && profFoe.Foe.Stars == StarName.Dangerous)
                    {
                        profFoe.Hexes.Add(HexType.Confusion);
                        profFoeValue--;
                        AddDecision($"{foughtBy} - no proficiency and is fighting a {_state.FoeFullName(profFoe.Foe)}, add a Confusion hex. Subtract 1 from focus passed.");
                    }
                }

                // if A2 is fighting a 4* DE and we don't have proficiency, P2 should shield A2 as long as A2 doesn't already have a shield
                if ((orderedAurorFoes.Count == 2 && !result.Proficiency && !result.P1ShieldsA2 && !result.P2ShieldsA2
                    && orderedAurorFoes[1].Type == FoeType.DeathEater && (int)orderedAurorFoes[1].Stars == 4))
                {
                    result.P2ShieldsA2 = true;
                    AddDecision($"A2 - no proficiency and fighting a  {_state.FoeFullName(orderedAurorFoes[1])}, P2 shields A2.");
                }
            }
        }


        private int TwoAurorFoes()
        {
            bool hasBeenReversed = false; // we don't want to reverse twice...


            // if we have 2 auror foes
            if (orderedAurorFoes.Count == 2)
            {
                // take a copy of our ordered foes and our foe fighter list. If after doing the first 'decision tree' we fall below 3 focus, go to plan B and start again with our original data.
                //List<Foe> originalAurorFoes = orderedAurorFoes.ToList();
                //List<FoeFighter> originalFoeFighters = result.FoeFighters.ToList();

                //List<FoeFighter> originalFoeFighters = result.FoeFighters.Select(i => new FoeFighter(i.Foe, i.FoeName, i.Hexes, i.FoughtBy)).ToList();

                //List<FoeFighter> a = new List<FoeFighter>();
                //foreach (var f in result.FoeFighters)
                //{
                //    a.Add(f.ShallowCopy());
                //}

                originalAurorFoes = orderedAurorFoes.Select(i => i.ShallowCopy()).ToList();
                originalFoeFighters = result.FoeFighters.Select(i => i.ShallowCopy()).ToList();


                // START THE FIRST LIST OF DECISIONS
                // reverse if A2 has a 4 * DE
                if ((int)orderedAurorFoes[1].Stars == 4 && orderedAurorFoes[1].Type == FoeType.DeathEater)
                {
                    AddDecision("Reverse the auror foe order as A2 has a 4* Death Eater.");
                    hasBeenReversed = ReverseFoeOrder();
                }

                FoeFighter a2 = result.FoeFighters.Where(f => f.FoughtBy == "A2").First();

                if (!result.P1ShieldsA2 && !result.P2ShieldsA2)
                {
                    a2 = CheckFor4StarDarkWizard(result, orderedAurorFoesFull, a2);

                    // does A1 have a 3* foe or a 4* DW 
                    bool A1FoeIs3starOr4starDW = (int)orderedAurorFoes[0].Stars == 3 || (int)orderedAurorFoes[0].Stars == 4 && orderedAurorFoes[0].Type == FoeType.DeathEater;
                    bool A2FoeIs4starDW = (int)orderedAurorFoes[1].Stars == 4 && orderedAurorFoes[1].Type == FoeType.DarkWizard;

                    if (!hasBeenReversed) // only reverse once
                    {
                        if (A1FoeIs3starOr4starDW && A2FoeIs4starDW)
                            //AddDecision("A1 has a 3* foe or a 4* Dark Wizard and A2 has a 4* Dark Wizard. Keep this order.");
                            AddDecision("A1 has a 3* foe or a 4* Dark Wizard and A2 has a 4* Dark Wizard. Keep this order.");
                        else
                        {
                            AddDecision("If A1 has a 3* or 4*DE AND A2 has a 4* DW do nothing, otherwise reverse the foes.");
                            hasBeenReversed = ReverseFoeOrder();
                            a2 = result.FoeFighters.Where(f => f.FoughtBy == "A2").First();
                        }
                    }

                    //* if we don't have a shield for A2 (regardless of proficiency) add weakening to A2's foe if it is a 3* or 4* (that doesn't already have a weakening)
                    var hasWeakening = a2.Hexes.Any(a => a == HexType.Weakening);
                    if ((int)orderedAurorFoes[1].Stars < 5 && !hasWeakening)
                    {
                        // if our focus passed it on 3, this would drop us below three, do the alternative decision tree instead of adding the hex and dropping below 3 focus (and therefore no proficiency)
                        if (foeValue == 2)
                        {
                            AddDecision("With the decisions just made we'd drop below 3 focus passed. Go back to original foe order and try a 2nd decision branch.");

                            // restore our original lists
                            //orderedAurorFoes = originalAurorFoes.ToList();
                            orderedAurorFoes = originalAurorFoes.Select(i => i.ShallowCopy()).ToList();

                            result.FoeFighters = originalFoeFighters.ToList();
                            a2 = result.FoeFighters.Where(f => f.FoughtBy == "A2").First();

                            AddDecision($"A1 - is now fighting {_state.FoeFullName(orderedAurorFoes[0])}.");
                            AddDecision($"A2 - is now fighting {_state.FoeFullName(orderedAurorFoes[1])}.");

                            // If A2 doesn't have a shield and has a 4* DE, check if there is a 4* DW that could be swapped in. If so, change to the 4* DW
                            a2 = CheckFor4StarDarkWizard(result, orderedAurorFoesFull, a2);

                            // If A2 doesn't have a 4* DW, reverse foes
                            A2FoeIs4starDW = (int)orderedAurorFoes[1].Stars == 4 && orderedAurorFoes[1].Type == FoeType.DarkWizard;
                            if (A2FoeIs4starDW)
                                AddDecision("2nd decision branch - A2 has a 4* Dark Wizard. Keep this order.");
                            else
                            {
                                AddDecision("2nd decision branch - If A2 does NOT have a 4* DW reverse the foes.");
                                hasBeenReversed = ReverseFoeOrder();
                                a2 = result.FoeFighters.Where(f => f.FoughtBy == "A2").First();
                            }

                            hasWeakening = a2.Hexes.Any(a => a == HexType.Weakening);
                            if ((int)orderedAurorFoes[1].Stars < 5 && !hasWeakening)
                            {
                                aurorFoeValue = HexA2(result, aurorFoeValue, a2);
                            }
                        }
                        else
                        {
                            aurorFoeValue = HexA2(result, aurorFoeValue, a2);
                        }
                    }
                }
            }
            return aurorFoeValue;
        }

        private int HexA2(LobbyResult result, int aurorFoeValue, FoeFighter a2)
        {
            a2.Hexes.Add(HexType.Weakening);
            aurorFoeValue--;
            AddDecision("A2 - has a 3* or 4* foe. Add a Weakening hex. Subtract 1 from focus passed.");
            return aurorFoeValue;
        }

        private FoeFighter CheckFor4StarDarkWizard(LobbyResult result, List<Foe> orderedAurorFoesFull, FoeFighter a2)
        {
            // if A2 isn't shielded and has 4* DE, check if there is a 4* DW available
            if (orderedAurorFoes[1].Type == FoeType.DeathEater && (int)orderedAurorFoes[1].Stars == 4)
            {
                Foe f = orderedAurorFoesFull.Where(f => f.Stars == StarName.Dangerous && f.Type == FoeType.DarkWizard)
                    .FirstOrDefault();

                if (f != null)
                {
                    AddDecision("A2 - isn't shielded, is fighting a 4* Death Eater and there is a 4* Dark Wizard in the lobby.");
                    AddDecision("A2 - replace the 4* Death Eater with the 4* Dark Wizard.");

                    // replace the A2 foe with the DW and hex it
                    orderedAurorFoes[1] = f;
                    result.FoeFighters.Remove(a2);
                    AddFoeFighter(f, null, "A2");
                    a2 = result.FoeFighters.Where(f => f.FoughtBy == "A2").First();
                    AddDecision($"A2 - is now fighting {_state.FoeFullName(orderedAurorFoes[1])}.");
                }
            }

            return a2;
        }

        private bool ReverseFoeOrder()
        {
            orderedAurorFoes.Reverse();

            // we've changed the foe order so we need to update our foe fighter fought by 
            result.FoeFighters.Where(f => f.FoughtBy == "A1").First().FoughtBy = "ATemp";
            result.FoeFighters.Where(f => f.FoughtBy == "A2").First().FoughtBy = "A1";
            result.FoeFighters.Where(f => f.FoughtBy == "ATemp").First().FoughtBy = "A2";

            AddDecision($"A1 - is now fighting {_state.FoeFullName(orderedAurorFoes[0])}.");
            AddDecision($"A2 - is now fighting {_state.FoeFullName(orderedAurorFoes[1])}.");

            return true;
        }

        private void DetermineFocusPassed()
        {
            // work out how much focus passed/kept by each auror.
            result.A1FocusPassed = profFoeValue;

            var A1HexesCount = result.FoeFighters.Where(f => f.FoughtBy == "P1" || f.FoughtBy == "P2")
                .SelectMany(f => f.Hexes)
                .Count();

            result.A1FocusKept = 4 - A1HexesCount - profFoeValue;

            result.A2FocusPassed = magiFoeValue + aurorFoeValue + 1; // + 1 for the focus always passed


            var A2HexesCount = result.FoeFighters.Where(f => f.FoughtBy == "M" || f.FoughtBy == "A1" || f.FoughtBy == "A2")
                .SelectMany(f => f.Hexes)
                .Count();

            result.A2FocusKept = 4 - A2HexesCount - result.A2FocusPassed;

            // work out the which auror passes what focus to each prof. Only do this if proficiency is up, if not, all to P2
            if (result.Proficiency)
            {
                if (result.A2FocusPassed == 4)
                {
                    result.A2FocusPassedToP2 = 3;
                    result.A2FocusPassedToP1 = 1;
                    AddDecision($"A2 - has 4 focus to pass, pass 3 to P2 and 1 to P1.");
                }
                else
                {
                    result.A2FocusPassedToP2 = result.A2FocusPassed; // P2 gets it all
                    AddDecision($"A2 - has < 4 focus to pass, pass all to P2.");
                }


                // if A2 passed < 3 to P2, A1 should pass focus up to a max of 3 total (for both A1 & 2) or what they have. Only do this if proficiency is up
                // any remaining focus from A1 goes to P1

                if (result.A2FocusPassedToP2 < 3)
                {
                    result.A1FocusPassedToP2 = 3 - result.A2FocusPassedToP2 > result.A1FocusPassed ? result.A1FocusPassed : 3 - result.A2FocusPassedToP2;
                    AddDecision("A1 - A2 passed < 3 focus to P2, A1 passes what they can to P2 so P2 gets max 3. Rest to P1.");
                }
                else
                    AddDecision("A1 - A2 passed >= 3 focus to P2, A1 passes all focus to P1.");

                result.A1FocusPassedToP1 = result.A1FocusPassed - result.A1FocusPassedToP2;
            }
            else
            {
                // P2 gets it all
                result.A2FocusPassedToP2 = result.A2FocusPassed;
                result.A1FocusPassedToP2 = result.A1FocusPassed;
                AddDecision("A1 & A2 - we do not have proficiency, both pass all to P2.");
            }



            //// if A2 passed < 3 to P2, A1 should pass focus up to a max of 3 total (for both A1 & 2) or what they have. Only do this if proficiency is up
            //// any remaining focus from A1 goes to P1

            //if (result.A2FocusPassedToP2 < 3)
            //{
            //    result.A1FocusPassedToP2 = 3 - result.A2FocusPassedToP2 > result.A1FocusPassed ? result.A1FocusPassed : 3 - result.A2FocusPassedToP2;
            //    AddDecision("A1 - A2 passed < 3 focus to P2, A1 passes what they can to P2 so P2 gets max 3. Rest to P1.");
            //}
            //else
            //    AddDecision("A1 - A2 passed >= 3 focus to P2, A1 passes all focus to P1.");

            //result.A1FocusPassedToP1 = result.A1FocusPassed - result.A1FocusPassedToP2;

            // check if P1 got enough focus to shield A2 if it doesn't already have one
            if (result.A1FocusPassedToP1 + result.A2FocusPassedToP1 >= 2 && !result.P1ShieldsA2 && !result.P2ShieldsA2)
            {
                result.P1ShieldsA2 = true;
                AddDecision($"P1 - got {result.A1FocusPassedToP1 + result.A2FocusPassedToP1} focus, shields A2 =.");
            }

        }

        private void DetermineAurorFoeSelection()
        {
            // work out which auror fights what/waits
            for (int i = 0; i < orderedAurorFoes.Count; i++)
            {
                var f = orderedAurorFoes[i];

                if (i == 0)
                {
                    result.A1Fights = true;
                    result.A1Foe = _state.FoeFullName(f);
                }
                else
                {
                    result.A2Fights = true;
                    result.A2Foe = _state.FoeFullName(f);
                }
            }
        }

        private void AddFoeFighter(Foe f, List<HexType> hexes, string foughtBy)
        {
            if (hexes is null)
                hexes = new List<HexType>();

            result.FoeFighters.Add(new FoeFighter(
                    f,
                    _state.FoeFullName(f),
                    hexes,
                    foughtBy));
        }

        private void AddDecision(string decision)
        {
            int rowNum = result.Decisions.Count + 1;
            result.Decisions.Add($"{rowNum}) {decision}");
        }

        private void SetFoeDetails()
        {
            ///////////////////////////////////////////////////
            //A1 Hexes
            var foesThatA1Hexes = result.FoeFighters.Where(f => f.FoughtBy == "P1" || f.FoughtBy == "P2").ToList();

            foreach (var foe in foesThatA1Hexes)
                SetAurorHexes(foe, "A1");

            ///////////////////////////////////////////////////
            //A2 Hexes
            var foesThatA2Hexes = result.FoeFighters.Where(f => f.FoughtBy == "A1" || f.FoughtBy == "A2" || f.FoughtBy == "M").ToList();

            foreach (var foe in foesThatA2Hexes)
                SetAurorHexes(foe, "A2");
            ///////////////////////////////////////////////////


            FoeFighter magiInfo = result.FoeFighters.Where(f => f.FoughtBy == "M")
                                        .FirstOrDefault();

            result.MagiFights = false;
            if (magiInfo != null)
            {
                result.MagiFights = true;
                result.MagiFoe = magiInfo.FoeName;

                // we can only have max 1 hex on a magi foe
                if (magiInfo.Hexes.Count > 0)
                    result.MagiFoe = $"{ result.MagiFoe } with { magiInfo.Hexes[0]}";
            }

            ///////////////////////////////////////////////////
            FoeFighter p1Info = result.FoeFighters.Where(f => f.FoughtBy == "P1")
                                        .FirstOrDefault();

            result.P1Fights = false;
            if (p1Info != null)
            {
                result.P1Fights = true;
                result.P1Foe = $"{ p1Info.FoeNameWithHexes}";

                //for (int i = 0; i < p1Info.Hexes.Count; i++)
                //    result.P1Foe = $"{ p1Info.FoeName}{AddHexDetail(i)}{ p1Info.Hexes[i]}";
            }
            ///////////////////////////////////////////////////
            FoeFighter p2Info = result.FoeFighters.Where(f => f.FoughtBy == "P2")
                                        .FirstOrDefault();

            result.P2Fights = false;
            if (p2Info != null)
            {
                result.P2Fights = true;
                result.P2Foe = p2Info.FoeNameWithHexes;

                //for (int i = 0; i < p2Info.Hexes.Count; i++)
                //    result.P2Foe = $"{ p2Info.FoeName}{AddHexDetail(i)}{ p2Info.Hexes[i]}";
            }
            ///////////////////////////////////////////////////
            FoeFighter a1Info = result.FoeFighters.Where(f => f.FoughtBy == "A1")
                                        .FirstOrDefault();

            result.A1Fights = false;
            if (a1Info != null)
            {
                result.A1Fights = true;
                result.A1Foe = a1Info.FoeNameWithHexes;
            }
            ///////////////////////////////////////////////////
            FoeFighter a2Info = result.FoeFighters.Where(f => f.FoughtBy == "A2")
                                        .FirstOrDefault();

            result.A2Fights = false;
            if (a2Info != null)
            {
                result.A2Fights = true;
                result.A2Foe = a2Info.FoeNameWithHexes;
            }


            ///////////////////////////////////////////////////
        }

        private void SetAurorHexes(FoeFighter foe, string auror)
        {
            foe.FoeNameWithHexes = foe.FoeName;

            Hex h = new Hex();

            for (int i = 0; i < foe.Hexes.Count; i++)
            {
                foe.FoeNameWithHexes = $"{ foe.FoeNameWithHexes}{AddHexDetail(i)}{ foe.Hexes[i]}";
                h.FoeName = foe.FoeName;
                h.FoeNameWithHexes = foe.FoeNameWithHexes;
                h.HexType = h.HexType; // we no longer use this for advanced
            }

            if (foe.Hexes.Count == 0)
                return;

            if (auror == "A1")
                result.A1Hexes.Add(h);
            else
                result.A2Hexes.Add(h);

        }
        #endregion

        private void AddHex(HexType type, string foeName, bool isAuror1)
        {
            Hex h = new Hex();
            h.HexType = type;
            h.FoeName = foeName;

            if (isAuror1)
                result.A1Hexes.Add(h);
            else
                result.A2Hexes.Add(h);
        }


        public void CompareLobbyResults(LobbyResult b1, LobbyResult result)
        {
            // Magi response. Fight if at least 1 magi foe, else wait
            //bool IsMagiCorrect = CheckMagi(foes, userResult);
        }

        private static string AddHexDetail(int hexNumber)
        {
            if (hexNumber == 0)
                return " with ";
            else
                return " and ";
        }
    }

}




