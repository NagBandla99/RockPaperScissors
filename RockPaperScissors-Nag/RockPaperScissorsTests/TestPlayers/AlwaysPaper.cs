using RockPaperScissors.Enums;
using RockPaperScissors.Implementations;

namespace RockPaperScissorsTests.TestPlayers
{
    class AlwaysPaper : Player
    {
        public AlwaysPaper() : base ("Paper Player")
        {
        }

        public override Choice GetChoice()
        {
            return Choice.Paper;
        }
    }
}
