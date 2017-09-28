using Cricket;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace ClassicCricket.Specs
{
    [Binding]
    public class ScoreSteps
    {
        CricketGame game;
        [Given(@"I started a game of cricket")]
        public void GivenIStartedAGameOfCricket()
        {
            game = new CricketGame();
        }
        
        [When(@"Batter gets out")]
        public void WhenBatterGetsOut()
        {
            game.Score(-1);
        }
        
        [Then(@"Batter score should be (.*)")]
        public void ThenBatterScoreShouldBe(int p0)
        {
            Assert.Equal(game.TotalScore, p0);
        }
        [Given(@"Batter scores (.*) runs")]
        public void GivenBatterScoresRuns(int p0)
        {
            game.Score(p0);
        }
        [Then(@"game should be finished")]
        public void ThenGameShouldBeFinished()
        {
            game.Score(-1);
            Assert.Equal(game.Finished, true);
        }
        [Given(@"Batter gets out")]
        public void GivenBatterGetsOut()
        {
            game.Score(-1);
        }

        [When(@"Batter scores (.*) runs")]
        public void WhenBatterScoresRuns(int p0)
        {
            game.Score(p0);
        }

    }
}
