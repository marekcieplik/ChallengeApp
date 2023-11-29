namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenPositiveByAddScore_ShouldReturnSum()
        {
            // arrange
            var emplTest = new Employee("WhenPositive", "ByAddScore", 33);
            emplTest.AddScore(5);
            emplTest.AddScore(6);
            // act
            var result = emplTest.ScoreSum();
            // assert
            Assert.AreEqual(11, result);
        }

        [Test]
        public void WhenPositiveByPenaltyPoints_ShouldNotSubstractThisNumberToSum()
        {
            // arrange
            var emplTest = new Employee("WhenPositive", "ByPenaltyPoints", 33);
            emplTest.AddScore(5);
            emplTest.PenaltyPoints(6);
            // act
            var result = emplTest.ScoreSum();
            // assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void WhenNegativeByAddScore_ShouldNotAddThisNumberSum()
        {
            // arrange
            var emplTest = new Employee("WhenNegative", "ByAddScore", 33);
            emplTest.AddScore(5);
            emplTest.AddScore(-6);
            // act
            var result = emplTest.ScoreSum();
            // assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void WhendNegtiveByPenaltyPoints_ShouldSubstractThisNumberToSum()
        {
            // arrange
            var emplTest = new Employee("WhenNegative", "ByPenaltyPoints", 33);
            emplTest.AddScore(5);
            emplTest.PenaltyPoints(-6);
            // act
            var result = emplTest.ScoreSum();
            // assert
            Assert.AreEqual(-1, result);
        }


    }
}