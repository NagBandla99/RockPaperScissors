using System;
using RockPaperScissors.Enums;

namespace RockPaperScissors.Implementations
{
    public class ComputerPlayer : Player
    {
        private static Random _randomGenerator = new Random();

        public ComputerPlayer(string Name) : base (Name)
        {
        }

        public override Choice GetChoice()
        {
            int i = _randomGenerator.Next(1, 4);

            return (Choice) i;

        }
    }
}
