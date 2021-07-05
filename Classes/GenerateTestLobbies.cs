using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPWUHexingTrainer
{
    class GenerateTestLobbies
    {

        public static List<TestLobby> Create()
        {
            List<TestLobby> lobbies = new List<TestLobby>();

            List<Foe> foes = new List<Foe>();


            foes.Clear(); foes.AddRange(new Foe[] {});
            lobbies.Add(new TestLobby("Lobby 1", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula) });
            lobbies.Add(new TestLobby("Lobby 2", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling) });
            lobbies.Add(new TestLobby("Lobby 3", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie) });
            lobbies.Add(new TestLobby("Lobby 4", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Pixie) });
            lobbies.Add(new TestLobby("Lobby 5", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 6", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 7", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula) });
            lobbies.Add(new TestLobby("Lobby 8", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 9", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 10", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 11", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 12", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie) });
            lobbies.Add(new TestLobby("Lobby 13", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Pixie) });
            lobbies.Add(new TestLobby("Lobby 14", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 15", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 16", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 17", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie) });
            lobbies.Add(new TestLobby("Lobby 18", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Pixie) });
            lobbies.Add(new TestLobby("Lobby 19", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 20", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 21", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 22", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 23", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 24", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 25", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 26", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 27", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 28", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 29", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 30", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie) });
            lobbies.Add(new TestLobby("Lobby 31", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 32", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 33", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 34", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 35", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 36", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 37", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 38", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 39", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 40", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 41", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 42", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 43", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 44", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 45", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 46", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 47", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 48", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 49", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 50", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 51", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 52", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 53", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 54", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 55", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 56", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 57", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 58", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 59", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 60", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 61", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 62", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 63", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 64", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 65", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 66", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 67", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 68", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 69", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 70", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie) });
            lobbies.Add(new TestLobby("Lobby 71", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 72", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 73", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 74", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 75", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 76", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 77", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 78", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 79", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 80", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie) });
            lobbies.Add(new TestLobby("Lobby 81", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 82", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 83", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 84", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 85", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 86", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 87", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 88", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 89", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf) });
            lobbies.Add(new TestLobby("Lobby 90", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 91", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 92", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 93", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 94", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 95", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 96", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 97", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 98", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 99", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 100", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 101", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 102", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 103", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 104", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 105", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 106", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 107", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 108", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 109", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 110", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 111", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 112", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 113", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 114", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 115", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 116", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 117", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 118", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 119", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 120", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 121", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 122", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 123", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 124", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 125", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 126", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 127", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 128", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 129", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 130", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 131", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 132", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 133", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 134", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 135", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 136", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 137", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 138", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 139", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 140", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 141", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 142", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 143", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 144", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 145", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 146", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 147", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 148", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 149", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 150", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 151", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 152", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 153", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 154", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 155", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 156", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 157", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 158", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 159", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 160", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 161", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 162", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 163", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 164", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 165", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 166", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 167", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 168", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 169", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 170", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 171", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 172", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 173", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 174", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 175", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 176", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 177", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 178", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 179", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 180", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 181", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 182", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 183", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 184", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 185", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 186", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 187", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 188", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 189", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 190", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 191", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 192", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 193", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 194", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 195", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 196", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 197", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 198", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 199", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 200", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 201", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 202", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 203", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 204", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 205", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 206", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 207", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 208", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 209", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 210", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 211", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 212", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 213", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 214", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 215", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 216", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 217", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 218", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 219", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 220", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 221", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 222", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 223", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 224", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 225", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 226", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 227", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 228", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 229", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 230", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 231", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 232", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 233", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 234", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 235", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 236", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 237", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 238", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 239", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 240", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 241", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 242", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 243", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 244", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 245", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 246", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 247", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 248", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 249", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 250", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 251", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 252", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 253", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 254", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 255", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 256", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 257", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 258", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 259", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 260", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 261", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 262", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 263", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 264", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 265", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 266", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 267", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 268", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 269", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 270", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 271", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 272", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 273", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 274", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 275", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 276", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 277", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 278", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 279", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 280", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 281", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 282", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 283", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 284", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 285", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 286", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 287", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 288", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 289", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 290", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 291", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 292", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 293", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 294", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 295", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 296", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 297", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 298", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 299", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 300", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 301", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 302", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 303", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 304", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 305", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 306", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 307", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 308", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 309", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 310", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 311", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 312", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 313", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 314", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 315", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 316", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 317", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 318", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 319", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 320", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 321", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 322", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 323", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 324", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 325", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 326", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 327", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 328", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 329", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 330", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 331", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 332", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 333", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 334", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 335", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 336", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 337", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 338", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 339", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 340", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 341", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 342", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 343", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 344", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 345", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 346", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 347", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 348", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 349", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 350", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 351", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 352", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 353", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 354", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 355", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 356", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 357", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 358", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 359", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 360", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 361", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 362", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 363", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 364", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 365", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 366", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 367", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 368", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 369", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 370", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 371", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 372", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 373", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 374", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 375", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 376", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 377", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 378", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 379", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 380", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 381", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 382", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 383", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 384", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 385", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 386", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 387", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 388", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 389", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 390", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 391", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 392", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 393", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 394", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 395", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 396", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 397", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 398", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 399", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 400", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 401", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 402", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 403", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 404", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 405", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 406", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 407", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 408", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 409", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 410", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 411", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 412", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 413", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 414", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 415", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 416", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 417", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 418", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 419", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 420", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 421", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 422", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 423", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 424", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 425", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 426", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 427", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 428", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 429", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 430", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 431", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 432", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 433", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 434", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 435", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 436", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 437", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 438", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 439", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 440", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 441", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 442", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 443", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 444", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 445", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 446", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 447", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 448", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 449", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 450", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 451", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 452", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 453", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 454", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 455", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 456", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 457", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 458", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 459", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 460", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 461", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 462", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 463", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 464", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 465", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 466", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 467", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 468", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 469", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 470", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 471", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 472", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 473", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 474", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 475", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 476", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 477", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 478", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 479", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 480", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 481", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 482", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 483", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 484", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 485", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 486", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 487", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 488", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 489", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 490", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 491", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 492", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 493", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 494", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 495", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 496", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 497", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 498", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 499", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 500", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 501", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 502", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 503", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 504", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 505", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 506", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 507", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 508", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 509", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 510", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 511", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 512", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 513", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 514", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 515", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 516", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 517", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 518", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 519", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 520", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 521", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 522", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 523", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 524", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 525", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 526", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 527", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 528", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 529", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 530", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 531", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 532", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 533", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 534", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 535", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 536", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 537", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 538", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 539", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 540", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 541", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 542", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 543", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 544", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 545", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 546", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 547", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 548", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 549", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 550", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 551", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 552", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 553", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 554", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 555", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 556", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 557", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 558", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 559", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 560", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 561", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 562", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 563", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 564", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 565", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 566", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 567", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 568", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 569", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 570", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 571", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 572", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 573", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 574", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 575", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 576", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 577", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 578", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 579", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 580", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 581", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 582", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 583", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 584", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 585", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 586", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 587", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 588", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 589", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 590", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 591", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 592", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 593", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 594", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 595", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 596", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 597", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 598", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 599", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 600", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 601", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 602", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 603", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 604", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 605", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 606", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 607", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 608", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 609", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 610", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 611", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 612", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 613", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 614", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 615", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 616", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 617", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 618", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 619", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Dangerous, FoeType.Acromantula), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 620", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 621", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 622", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 623", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 624", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 625", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 626", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 627", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 628", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 629", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 630", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 631", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 632", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 633", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 634", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 635", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 636", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 637", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 638", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 639", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 640", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 641", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 642", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 643", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 644", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 645", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 646", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 647", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 648", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 649", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 650", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 651", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 652", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 653", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 654", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 655", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 656", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 657", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 658", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 659", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Pixie), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 660", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 661", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 662", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 663", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 664", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 665", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 666", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 667", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 668", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 669", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 670", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 671", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 672", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 673", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 674", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 675", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 676", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 677", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 678", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 679", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 680", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 681", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 682", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 683", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 684", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 685", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 686", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 687", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 688", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 689", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Imposing, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 690", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 691", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 692", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 693", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 694", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 695", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 696", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 697", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 698", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 699", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 700", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 701", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 702", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 703", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 704", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 705", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 706", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 707", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 708", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 709", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Dangerous, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 710", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Imposing, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 711", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 712", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 713", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Imposing, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 714", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DeathEater) });
            lobbies.Add(new TestLobby("Lobby 715", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 716", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DeathEater), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 717", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Dangerous, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 718", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Dangerous, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 719", "images/blankboard.png", foes.ToList()));
            foes.Clear(); foes.AddRange(new Foe[] { new Foe(StarName.Fierce, FoeType.Erkling), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.Werewolf), new Foe(StarName.Fierce, FoeType.DarkWizard), new Foe(StarName.Fierce, FoeType.DarkWizard) });
            lobbies.Add(new TestLobby("Lobby 720", "images/blankboard.png", foes.ToList()));











            //foes.Clear();
            //foes.AddRange(new Foe[] {
            //    new Foe(StarName.Fierce, FoeType.Pixie, true),
            //    new Foe(StarName.Fierce, FoeType.Acromantula),
            //    new Foe(StarName.Dangerous, FoeType.Acromantula),
            //    new Foe(StarName.Dangerous, FoeType.Werewolf),
            //    new Foe(StarName.Imposing, FoeType.Erkling)
            //});
            //lobbies.Add(new TestLobby("Lobby 3", "images/lobbies/Lobby3.png", foes.ToList()));

            //foes.Clear();
            //foes.AddRange(new Foe[] {
            //    new Foe(StarName.Fierce, FoeType.Erkling),
            //    new Foe(StarName.Dangerous, FoeType.DarkWizard),
            //    new Foe(StarName.Dangerous, FoeType.DeathEater),
            //    new Foe(StarName.Dangerous, FoeType.DarkWizard),
            //    new Foe(StarName.Fierce, FoeType.Pixie, true)
            //});
            //lobbies.Add(new TestLobby("Lobby 4", "images/lobbies/Lobby4.png", foes.ToList()));

            //foes.Clear();
            //foes.AddRange(new Foe[] {
            //    new Foe(StarName.Imposing, FoeType.Acromantula),
            //    new Foe(StarName.Dangerous, FoeType.Acromantula),
            //    new Foe(StarName.Imposing, FoeType.Acromantula),
            //    new Foe(StarName.Imposing, FoeType.Acromantula),
            //    new Foe(StarName.Dangerous, FoeType.DarkWizard, true)
            //});
            //lobbies.Add(new TestLobby("Lobby 5", "images/lobbies/Lobby5.png", foes.ToList()));

            //foes.Clear();
            //foes.AddRange(new Foe[] {
            //    new Foe(StarName.Imposing, FoeType.Pixie),
            //    new Foe(StarName.Fierce, FoeType.DarkWizard),
            //    new Foe(StarName.Fierce, FoeType.DeathEater),
            //    new Foe(StarName.Fierce, FoeType.Erkling, true),
            //    new Foe(StarName.Dangerous, FoeType.Werewolf)
            //});
            //lobbies.Add(new TestLobby("Lobby 6", "images/lobbies/Lobby6.png", foes.ToList()));

            //foes.Clear();
            //foes.AddRange(new Foe[] {
            //    new Foe(StarName.Fierce, FoeType.Erkling),
            //    new Foe(StarName.Fierce, FoeType.Pixie),
            //    new Foe(StarName.Dangerous, FoeType.Werewolf),
            //    new Foe(StarName.Dangerous, FoeType.Werewolf, true),
            //    new Foe(StarName.Fierce, FoeType.Acromantula)
            //});
            //lobbies.Add(new TestLobby("Lobby 29", "images/lobbies/Lobby29.png", foes.ToList()));

            //foes.Clear();
            //foes.AddRange(new Foe[] {
            //    new Foe(StarName.Fierce, FoeType.Werewolf),
            //    new Foe(StarName.Imposing, FoeType.Pixie),
            //    new Foe(StarName.Fierce, FoeType.Acromantula, true),
            //    new Foe(StarName.Dangerous, FoeType.Erkling),
            //    new Foe(StarName.Fierce, FoeType.DeathEater)
            //});
            //lobbies.Add(new TestLobby("Lobby 31", "images/lobbies/Lobby31.png", foes.ToList()));

            //foes.Clear();
            //foes.AddRange(new Foe[] {
            //    new Foe(StarName.Dangerous, FoeType.Pixie),
            //    new Foe(StarName.Imposing, FoeType.Werewolf),
            //    new Foe(StarName.Imposing, FoeType.DarkWizard),
            //    new Foe(StarName.Dangerous, FoeType.DeathEater),
            //    new Foe(StarName.Fierce, FoeType.Werewolf, true)
            //});
            //lobbies.Add(new TestLobby("Lobby 84", "images/lobbies/Lobby84.png", foes.ToList()));

            //foes.Clear();
            //foes.AddRange(new Foe[] {
            //    new Foe(StarName.Dangerous, FoeType.Erkling),
            //    new Foe(StarName.Fierce, FoeType.DarkWizard),
            //    new Foe(StarName.Fierce, FoeType.Erkling, true),
            //    new Foe(StarName.Fierce, FoeType.DarkWizard, true),
            //    new Foe(StarName.Fierce, FoeType.Erkling, true)
            //});
            //lobbies.Add(new TestLobby("Lobby 85", "images/lobbies/Lobby85.png", foes.ToList()));

            //foes.Clear();
            //foes.AddRange(new Foe[] {
            //    new Foe(StarName.Dangerous, FoeType.DeathEater),
            //    new Foe(StarName.Dangerous, FoeType.Acromantula),
            //    new Foe(StarName.Imposing, FoeType.DarkWizard),
            //    new Foe(StarName.Dangerous, FoeType.Acromantula),
            //    new Foe(StarName.Fierce, FoeType.Erkling)
            //});
            //lobbies.Add(new TestLobby("Lobby 86", "images/lobbies/Lobby86.png", foes.ToList()));

            //foes.Clear();
            //foes.AddRange(new Foe[] {
            //    new Foe(StarName.Dangerous, FoeType.DeathEater),
            //    new Foe(StarName.Fierce, FoeType.Pixie),
            //    new Foe(StarName.Dangerous, FoeType.DeathEater),
            //    new Foe(StarName.Fierce, FoeType.DeathEater, true),
            //    new Foe(StarName.Fierce, FoeType.Acromantula)
            //});
            //lobbies.Add(new TestLobby("Lobby 87", "images/lobbies/Lobby87.png", foes.ToList()));

            //foes.Clear();
            //foes.AddRange(new Foe[] {
            //    new Foe(StarName.Dangerous, FoeType.Erkling),
            //    new Foe(StarName.Dangerous, FoeType.DeathEater),
            //    new Foe(StarName.Dangerous, FoeType.Werewolf),
            //    new Foe(StarName.Dangerous, FoeType.Erkling),
            //    new Foe(StarName.Dangerous, FoeType.DarkWizard)
            //});
            //lobbies.Add(new TestLobby("Lobby 88", "images/lobbies/Lobby88.png", foes.ToList()));

            //foes.Clear();
            //foes.AddRange(new Foe[] {
            //    new Foe(StarName.Dangerous, FoeType.Pixie, true),
            //    new Foe(StarName.Fierce, FoeType.DeathEater),
            //    new Foe(StarName.Dangerous, FoeType.Erkling, true),
            //    new Foe(StarName.Fierce, FoeType.Pixie),
            //    new Foe(StarName.Imposing, FoeType.Werewolf)
            //});
            //lobbies.Add(new TestLobby("Lobby 89", "images/lobbies/Lobby89.png", foes.ToList()));

            //foes.Clear();
            //foes.AddRange(new Foe[] {
            //    new Foe(StarName.Fierce, FoeType.DarkWizard),
            //    new Foe(StarName.Dangerous, FoeType.DarkWizard),
            //    new Foe(StarName.Dangerous, FoeType.DeathEater),
            //    new Foe(StarName.Imposing, FoeType.Werewolf),
            //    new Foe(StarName.Dangerous, FoeType.Werewolf)
            //});
            //lobbies.Add(new TestLobby("Lobby 90", "images/lobbies/Lobby90.png", foes.ToList()));

            //foes.Clear();
            //foes.AddRange(new Foe[] {
            //    new Foe(StarName.Imposing, FoeType.Acromantula),
            //    new Foe(StarName.Dangerous, FoeType.Pixie),
            //    new Foe(StarName.Fierce, FoeType.Pixie),
            //    new Foe(StarName.Fierce, FoeType.Pixie),
            //    new Foe(StarName.Dangerous, FoeType.Acromantula)
            //});
            //lobbies.Add(new TestLobby("Lobby 91", "images/lobbies/Lobby91.png", foes.ToList()));

            //lobbies.Add(new TestLobby("Lobby 92", "images/lobbies/Lobby92.png", new List<Foe>{
            //    new Foe(StarName.Fierce, FoeType.Acromantula),
            //    new Foe(StarName.Fierce, FoeType.DarkWizard),
            //    new Foe(StarName.Imposing, FoeType.DeathEater),
            //    new Foe(StarName.Dangerous, FoeType.DeathEater),
            //    new Foe(StarName.Fierce, FoeType.Erkling)
            //}));

            //foes.Clear();
            //foes.AddRange(new Foe[] {
            //    new Foe(StarName.Fierce, FoeType.Pixie),
            //    new Foe(StarName.Imposing, FoeType.Pixie),
            //    new Foe(StarName.Dangerous, FoeType.Erkling),
            //    new Foe(StarName.Imposing, FoeType.Acromantula),
            //    new Foe(StarName.Dangerous, FoeType.Acromantula)
            //});
            //lobbies.Add(new TestLobby("Lobby 93", "images/lobbies/Lobby93.png", foes.ToList()));

            //foes.Clear();
            //foes.AddRange(new Foe[] {
            //    new Foe(StarName.Dangerous, FoeType.DeathEater),
            //    new Foe(StarName.Dangerous, FoeType.Acromantula),
            //    new Foe(StarName.Imposing, FoeType.Werewolf),
            //    new Foe(StarName.Dangerous, FoeType.Acromantula, true),
            //    new Foe(StarName.Imposing, FoeType.Pixie)
            //});
            //lobbies.Add(new TestLobby("Lobby 94", "images/lobbies/Lobby94.png", foes.ToList()));

            //foes.Clear();
            //foes.AddRange(new Foe[] {
            //    new Foe(StarName.Imposing, FoeType.DeathEater, true),
            //    new Foe(StarName.Dangerous, FoeType.DeathEater, true),
            //    new Foe(StarName.Imposing, FoeType.Acromantula),
            //    new Foe(StarName.Fierce, FoeType.Erkling),
            //    new Foe(StarName.Fierce, FoeType.DarkWizard)
            //});
            //lobbies.Add(new TestLobby("Lobby 95", "images/lobbies/Lobby95.png", foes.ToList()));

            //foes.Clear();
            //foes.AddRange(new Foe[] {
            //    new Foe(StarName.Dangerous, FoeType.Acromantula, true),
            //    new Foe(StarName.Fierce, FoeType.Werewolf, true),
            //    new Foe(StarName.Dangerous, FoeType.Pixie),
            //    new Foe(StarName.Fierce, FoeType.Pixie),
            //    new Foe(StarName.Dangerous, FoeType.Acromantula)
            //});
            //lobbies.Add(new TestLobby("Lobby 96", "images/lobbies/Lobby96.png", foes.ToList()));

            //foes.Clear();
            //foes.AddRange(new Foe[] {
            //    new Foe(StarName.Fierce, FoeType.Erkling),
            //    new Foe(StarName.Dangerous, FoeType.Acromantula),
            //    new Foe(StarName.Dangerous, FoeType.Acromantula),
            //    new Foe(StarName.Fierce, FoeType.Acromantula),
            //    new Foe(StarName.Dangerous, FoeType.Pixie)
            //});
            //lobbies.Add(new TestLobby("Lobby 97", "images/lobbies/Lobby97.png", foes.ToList()));

            //foes.Clear();
            //foes.AddRange(new Foe[] {
            //    new Foe(StarName.Imposing, FoeType.Acromantula),
            //    new Foe(StarName.Fierce, FoeType.DarkWizard, true),
            //    new Foe(StarName.Imposing, FoeType.Acromantula),
            //    new Foe(StarName.Fierce, FoeType.Erkling),
            //    new Foe(StarName.Fierce, FoeType.Erkling)
            //});
            //lobbies.Add(new TestLobby("Lobby 98", "images/lobbies/Lobby98.png", foes.ToList()));

            //foes.Clear();
            //foes.AddRange(new Foe[] {
            //    new Foe(StarName.Fierce, FoeType.DeathEater),
            //    new Foe(StarName.Fierce, FoeType.Erkling, true),
            //    new Foe(StarName.Dangerous, FoeType.Acromantula),
            //    new Foe(StarName.Fierce, FoeType.Acromantula),
            //    new Foe(StarName.Fierce, FoeType.DeathEater)
            //});
            //lobbies.Add(new TestLobby("Lobby 99", "images/lobbies/Lobby99.png", foes.ToList()));

            //foes.Clear();
            //foes.AddRange(new Foe[] {
            //    new Foe(StarName.Fierce, FoeType.Acromantula, true),
            //    new Foe(StarName.Fierce, FoeType.Acromantula, true),
            //    new Foe(StarName.Fierce, FoeType.Werewolf),
            //    new Foe(StarName.Dangerous, FoeType.DeathEater),
            //    new Foe(StarName.Dangerous, FoeType.DeathEater)
            //});
            //lobbies.Add(new TestLobby("Lobby 100", "images/lobbies/Lobby100.png", foes.ToList()));


            return lobbies;
        }
    }
}
