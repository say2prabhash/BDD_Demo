using System;
using Xunit;
using Cricket;

namespace CricketGame.Test
{
    public class CricketGameTest
    {
        [Fact]
        public void Score_Negative_Value_ExpectedResult()
        {
            var game = new Cricket.CricketGame();
            game.Score(1);
            game.Score(-1);
            Assert.Equal(game.TotalScore,1);
        }
        [Fact]
        public void Score_BatterScore_Value_ExpectedResult()
        {
            var game = new Cricket.CricketGame();
            game.Score(4);
            Assert.Equal(game.TotalScore, 4);
        }
        [Fact]
        public void Score_BatterScore_On_Multiple_Balls_ExpectedResult()
        {
            var game = new Cricket.CricketGame();
            game.Score(4);
            game.Score(2);
            game.Score(6);
            Assert.Equal(game.TotalScore, 12);
        }
        [Fact]
        public void Score_Game_Finished_ExpectedResult()
        {
            var game = new Cricket.CricketGame();
            game.Score(-1);
            Assert.Equal(game.Finished,true);
        }
        [Fact]
        public void Score_Batter_Scores_After_Getting_Out_ExpectedResult()
        {
            var game = new Cricket.CricketGame();
            game.Score(4);
            game.Score(6);
            game.Score(4);
            game.Score(-1);
            Assert.Equal(game.TotalScore,14);
        }
    }
}
