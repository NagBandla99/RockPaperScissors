using RockPaperScissors.Enums;
using RockPaperScissors.Interfaces;

namespace RockPaperScissors.Implementations
{
    public abstract class Player : IChoiceSelector
    {
        public string Name { get; }

        public Player(string Name)
        {
            this.Name = Name;
        }

        public abstract Choice GetChoice();
    }
}
