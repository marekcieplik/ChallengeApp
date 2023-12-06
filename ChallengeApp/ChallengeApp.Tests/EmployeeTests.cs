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
        [Test]
        public void WhenGetStatistiscCalled_ShouldMaxIsLessOrEqual100()
        {
            // arrange
            var employee = new Employee("name", "surname");
            employee.AddGrade(200);
            employee.AddGrade(2);
            var statistics = employee.GetStatistics();
            Assert.LessOrEqual(statistics.Max, 100f);
        }
        [Test]
        public void WhenGetStatisticsCalled_ShouldMinIsGreaterOrEqualZero()
        {
            var employee = new Employee("name", "surname");
            employee.AddGrade(-10);
            employee.AddGrade(2);
            var statistics = employee.GetStatistics();
            Assert.GreaterOrEqual(statistics.Min, 0);
        }
        [Test]
        public void WhenAddGradeString_ShouldBeEqualWithAddGradeFloat()
        {
            // arrange
            var employerString = new Employee("name", "surname");
            var employerFloat = new Employee("name", "surname");
            employerFloat.AddGrade(5f);
            employerString.AddGrade("5");
            // act
            var statisticsString = employerString.GetStatistics();
            var statisticsFloat = employerFloat.GetStatistics();
            // assert
            Assert.AreEqual(statisticsFloat.Max, statisticsString.Max);
        }
    }
}
