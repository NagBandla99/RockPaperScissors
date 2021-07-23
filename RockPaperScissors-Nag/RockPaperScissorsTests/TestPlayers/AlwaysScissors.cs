using RockPaperScissors.Enums;
using RockPaperScissors.Implementations;

namespace RockPaperScissorsTests.TestPlayers
{
    class AlwaysScissors : Player
    {
        public AlwaysScissors() : base("Scissors Player") { }

        public override Choice GetChoice()
        {
            return Choice.Scissors;
        }
    }
}
