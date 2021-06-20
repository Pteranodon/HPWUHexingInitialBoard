using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPWUHexingTrainer.Classes
{
    public class Result
    {
        public int LobbyNumber { get; set; }
        public List<Foe> FoesList { get; set; }
        public LobbyResult LobbyResult { get; set; }
        public bool CorrectAnswer { get; set; }

        public int OtherAnswer { get; set; }
        public bool ProficiencyAnswer { get; set; }

        public P1Stuff P1Results = new P1Stuff();


        public Result()
        {
        }

        public Result(int lobbyNumber, List<Foe> foesList, LobbyResult lobbyResult, bool proficiencyAnswer, int otherAnswer, bool correctAnswer, P1Stuff p1)
        {
            LobbyNumber = lobbyNumber;
            FoesList = foesList;
            LobbyResult = lobbyResult;
            ProficiencyAnswer = proficiencyAnswer;
            OtherAnswer = otherAnswer;
            CorrectAnswer = correctAnswer;
            P1Results = p1;
        }
    }


}
