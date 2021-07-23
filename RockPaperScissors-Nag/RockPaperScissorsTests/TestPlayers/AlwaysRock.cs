using RockPaperScissors.Enums;
using RockPaperScissors.Implementations;

namespace RockPaperScissorsTests.TestPlayers
{
    class AlwaysRock : Player
    {
        public AlwaysRock() : base("Rock Player")
        {
        }

        public override Choice GetChoice()
        {
            return Choice.Rock;


        }
    
    }
}
