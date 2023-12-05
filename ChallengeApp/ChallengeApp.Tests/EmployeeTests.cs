namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMax()
        {
            // arrange
            var employee = new Employee("Andrzej", "Surname");
            employee.AddGrade(3);
            employee.AddGrade(3);
            employee.AddGrade(4);
            // act
            var statistics = employee.GetStatistics();
            // asserte
            Assert.AreEqual(4, statistics.Max);
        }
        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMin()
        {
            // arrange
            var employee = new Employee("name", "surname");
            employee.AddGrade(3);
            employee.AddGrade(2);
            employee.AddGrade(3);
            // act
            var statistics = employee.GetStatistics();
            // assert
            Assert.AreEqual(2, statistics.Min);
        }
        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectAverage()
        {
            // arrange
            var employee = new Employee("name", "surname");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);
            // act
            var statistics = employee.GetStatistics();
            float average = (2 + 2 + 6) / 3f;
            // assert
            Assert.AreEqual(Math.Round(average, 2), Math.Round(statistics.Average, 2));
        }
    }
}
