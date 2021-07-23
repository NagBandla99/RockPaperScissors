using NUnit.Framework;
using RockPaperScissors;
using RockPaperScissors.Enums;
using RockPaperScissorsTests.TestPlayers;


namespace RockPaperScissorsTests
{
    [TestFixture]
    public class RockPaperScissorsTests
    {
        private Game testGame;
        MatchResult result;

        [SetUp]
        public void Setup()
        {
            testGame = new Game();
            result = null;
        }

        [TestCase(Choice.Paper, Result.Tie)]
        [TestCase(Choice.Rock, Result.Win)]
        [TestCase(Choice.Scissors, Result.Loss)]
        [Test]
        public void TestPaperMethod(Choice choice, Result expected)
        {
            // Act
            switch (choice)
            {
                case Choice.Paper:
                    result = testGame.PlayRound(new AlwaysPaper(), new AlwaysPaper());
                    break;
                case Choice.Rock:
                    result = testGame.PlayRound(new AlwaysPaper(), new AlwaysRock());
                    break;
                default:
                    result = testGame.PlayRound(new AlwaysPaper(), new AlwaysScissors());
                    break;
            }

            // Assert
            Assert.AreEqual(expected, result.Match_Result);
        }



    }
}
