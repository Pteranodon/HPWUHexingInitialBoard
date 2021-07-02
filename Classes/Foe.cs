using Humanizer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace HPWUHexingTrainer
{
    public class Foe
    {
        //public int Stars { get; set; }
        public StarName Stars { get; set; }

        public FoeType Type { get; set; }
        public bool Elite { get; set; }


        public string ImagePath => $"images/foes/{DefaultFoeName}.png";
        public int Col { get; set; }
        public int Row { get; set; }
        public string GridArea { get; set; }

        public string DefaultFoeName => $"{(Elite ? "Elite " : "")}{ Stars.ToString() } { FoeTypePretty(Type) }";
        public string StarFoeName => $"{(Elite ? "Elite " : "")}{ (int)Stars }* { FoeTypePretty(Type) }";
        public string FoeNameStarAndName => $"{(Elite ? "Elite " : "")}{ Stars.ToString() } ({ (int)Stars }*) { FoeTypePretty(Type) }";


        public Foe()
        {
        }

        public Foe(StarName stars, FoeType type, bool elite = false)
        {
            Stars = stars;
            Type = type;
            Elite = elite;
        }

        public static string FoeTypePretty(FoeType type)
        {
            return type.ToString().Humanize(LetterCasing.Title);
        }

        public static List<Foe> GetNewLobby(int foeCount = 5)
        {
            List<Foe> _foes = new List<Foe>();
            int PERCENT_ELITES = 10;
            Random rnd = new Random();

            // generate 5 random foes
            for (int cnt = 0; cnt < foeCount; cnt++)
            {
                Foe foe = new Foe();
                foe.Stars = (StarName)rnd.Next(3, 6);

                int foetype = rnd.Next(1, 7);
                foe.Type = (FoeType)foetype;

                int isElite = rnd.Next(1, PERCENT_ELITES);
                foe.Elite = (isElite == 1) ? true : false;

                _foes.Add(foe);
            }
            return _foes.ToList();
        }


        public static void PositionFoes(List<Foe> foes)
        {
            Random rnd = new Random();
            for (int cnt = 0; cnt < foes.Count; cnt++)
            {

                Foe f = foes[cnt];
                bool uniquePos = false;
                int rndRow = 1;
                int rndCol = 1;

                while (!uniquePos)
                {
                    rndRow = rnd.Next(2, 7);
                    rndCol = rnd.Next(1, 4);

                    // if we don't already have a foe in this position, use it
                    if (foes.Count(f => f.Col == rndCol && f.Row == rndRow) == 0)
                    {
                        f.Col = rndCol;
                        f.Row = rndRow;
                        uniquePos = true;
                    }
                }
                f.GridArea = $" {rndRow} / {rndCol} / {rndRow + 1} / {rndCol + 1} ";
            }
        }
        public Foe ShallowCopy()
        {
            return this.MemberwiseClone() as Foe;
        }
    }

    public enum FoeType
    {
        Erkling = 1,
        Acromantula = 2,
        Werewolf = 3,
        Pixie = 4,
        DarkWizard = 5,
        DeathEater = 6
    }

    public enum StarName
    {
        Imposing = 3,
        Dangerous = 4,
        Fierce = 5
    }

    public class P1Stuff
    {
        public bool ShieldsA2 { get; set; }
        public bool ShieldsP2 { get; set; }
        public bool Weakening { get; set; }
        public bool Confusion { get; set; }
        public string FoeName { get; set; }

        public bool ShieldA2Correct { get; set; }
        public bool ShieldP2Correct { get; set; }
        public bool WeakeningCorrect { get; set; }
        public bool ConfusionCorrect { get; set; }
        public bool FoeCorrect { get; set; }
        public bool P1Correct { get; set; }
    }

    public class AurorStuff
    {
        bool IsA1 { get; set; }
        public Foe MyFoe { get; set; }
        public Foe FoeToHex1 { get; set; }
        public Foe FoeToHex2 { get; set; }
        int FocusToP1 { get; set; }
        int FocusToP2 { get; set; }
        public bool FoeNameA1Correct { get; set; }
        public bool FoeNameP1Correct { get; set; }
        public bool FoeNameP2Correct { get; set; }

        public bool AurorCorrect { get; set; }
    }



    //public class A2Stuff
    //{
    //    public string FoeNameA1 { get; set; }
    //    public string FoeNameA2 { get; set; }
    //    public string FoeNameMagi { get; set; }

    //    // what hexes on each foe 
    //    // focus passed to P1 (0 -> 4)
    //    // focus passed to P2 (0 -> 4)

    //    public bool FoeNameA1Correct { get; set; }
    //    public bool FoeNameA2Correct { get; set; }
    //    public bool FoeNameMagiCorrect { get; set; }

    //    public bool A2Correct { get; set; }
    //}

    public class FoeForDetHex
    {
        public Foe Foe { get; set; }
        public int Id { get; set; }
        public string FoeStaminaImage { get; set; }
        public bool HasWeakening { get; set; }
        public bool HasConfusion { get; set; }

        public FoeForDetHex(Foe foe, int id, string foeStaminaImg, bool hasWeakening, bool hasConfusion)
        {
            this.Foe = foe;
            this.Id = id;
            FoeStaminaImage = foeStaminaImg;
            HasWeakening = hasWeakening;
            HasConfusion = hasConfusion;
        }
        public FoeForDetHex(int id)
        {
            this.Id = id;
        }
    }

}
