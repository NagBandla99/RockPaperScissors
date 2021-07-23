using System;
using System.Linq;
using RockPaperScissors.Implementations;

namespace RockPaperScissors
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int _playerType1;
            int _playerType2;
            string _name1;
            string _name2;
           
            Console.WriteLine("Welcome to Rock, Paper, Scissors Game \n");
            Game newGame = new Game();
            string input = "";
            string startGame = "";
            do
            {
                Console.WriteLine("Start Game (Y/N)?:");
                startGame = Console.ReadLine();
                if (startGame != "Y" && startGame != "N")
                {
                    Console.WriteLine("That is not a valid choice.");
                }
            } while (startGame != "Y" && startGame != "N");


            if (startGame == "Y")
            {
                Console.Clear();
                Console.WriteLine("OK. We will start Rock, Paper, Scissors Game.");
                Console.WriteLine();

                _playerType1 = 1; // actual user playing the game
                _playerType2 = 2; // Computer 

                _name1 = PlayerNamer(1);
                _name2 = "Computer";

                Console.Clear();
                MatchResult matechResult;
                int winCount;
                do
                {
                    Player player1 = PlayerCreator(_playerType1, _name1);
                    Player player2 = PlayerCreator(_playerType2, _name2);
                    matechResult = newGame.PlayRound(player1, player2);

                    winCount = newGame.GameResults.Where(r => r.Value.ToString() == "Win").Count();
                    if (newGame.gameCount >= 3)
                    {
                        bool? gameFinalResult = newGame.CheckFinalResults(newGame.GameResults, player1, player2);
                        if (gameFinalResult != null)
                            break;
                    }

                    Console.WriteLine("\nWould you like to continue (y)? (enter \"Q\" to Quit):");
                    input = Console.ReadLine();
                } while (input.ToUpper() != "Q"); 

            }

            else if (startGame == "N")
            {
                Console.WriteLine("Ok.");
            }

        }
        //Player Name Method
        public static string PlayerNamer(int PlayerNum)
        {
            string name = "";
            bool playerNameOK = false;
            string response = "";

            Console.Clear();
            Console.WriteLine("Player {0}, please enter your desired name: ", PlayerNum);
            name = Console.ReadLine();

            do
            {
                Console.WriteLine("{0} is what we will call Player {1}. Continue? (Y)es or (N)o: ", name, PlayerNum);
                response = Console.ReadLine().ToUpper();

                while (response != "N" && response != "Y")
                {
                    Console.WriteLine("I'm sorry. I didn't get that. Is {0} what we will call Player {1}? (Y)es or (N)o: ", name, PlayerNum);
                    response = Console.ReadLine().ToUpper();
                }
                if (response == "N")
                {
                    Console.WriteLine("OK, Player {0}. Please enter your new desired name: ", PlayerNum);
                    name = Console.ReadLine();
                }
                if (response == "Y")
                {
                    playerNameOK = true;
                }
            } while (!playerNameOK);

            return name;
        }



        //Player Creator method
        public static Player PlayerCreator(int Choice, string Name)
        {
            //1 is HumanPlayer
            //2 is ComputerPlayer

            if (Choice == 1)
            {
                return new HumanPlayer(Name);
            }
            else
            {
                return new ComputerPlayer(Name);
            }

        }
    }
}
