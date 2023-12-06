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
        [Test]
        public void WhenGetStatisticsWithDoWhileCalled_ShouldEqualWithGetStatistics()
        {
            // arrange
            var employer = new Employee("name", "surname");
            var employerDoWhile = new Employee("loop", "DoWhile");
            for(int i = 0; i < 10; i++)
            {
                employerDoWhile.AddGrade(i);
                employer.AddGrade(i);
            }
            // act
            var statistics = employer.GetStatistics();
            var statisticsDoWhile = employerDoWhile.GetStatisticsWithDoWhile();
            // asset
            Assert.AreEqual(statisticsDoWhile.Max, statistics.Max); 
            Assert.AreEqual(statisticsDoWhile.Min, statistics.Min);
            Assert.AreEqual(statisticsDoWhile.Average, statistics.Average);
        }
        [Test]
        public void WhenGetStatisticsWithWhileCalled_ShouldEqualWithGetStatistics()
        {
            // arrange
            var employer = new Employee("name", "surname");
            var employerWhile = new Employee("loop", "While");
            for (int i = 0; i < 10; i++)
            {
                employerWhile.AddGrade(i);
                employer.AddGrade(i);
            }
            // act
            var statistics = employer.GetStatistics();
            var statisticsWhile = employerWhile.GetStatisticsWithWhile();
            // asset
            Assert.AreEqual(statisticsWhile.Max, statistics.Max);
            Assert.AreEqual(statisticsWhile.Min, statistics.Min);
            Assert.AreEqual(statisticsWhile.Average, statistics.Average);
        }
        [Test]
        public void WhenGetStatisticsWithForCalled_ShouldEqualWithGetStatistics()
        {
            // arrange
            var employer = new Employee("name", "surname");
            var employerFor = new Employee("loop", "for");
            for (int i = 0; i < 10; i++)
            {
                employerFor.AddGrade(i);
                employer.AddGrade(i);
            }
            // act
            var statistics = employer.GetStatistics();
            var statisticsFor = employerFor.GetStatisticsWithFor();
            // asset
            Assert.AreEqual(statisticsFor.Max, statistics.Max);
            Assert.AreEqual(statisticsFor.Min, statistics.Min);
            Assert.AreEqual(statisticsFor.Average, statistics.Average);
        }
        [Test]
        public void WhenGetStatisticsWithForeach_ShouldEqualWithGetStatistics()
        {
            // arrange
            var employer = new Employee("name", "surname");
            var employerForeach = new Employee("loop", "foreach");
            for (int i = 0; i < 10; i++)
            {
                employerForeach.AddGrade(i);
                employer.AddGrade(i);
            }
            // act
            var statistics = employer.GetStatistics();
            var statisticsForeach = employerForeach.GetStatisticsWithForeach();
            // asset
            Assert.AreEqual(statisticsForeach.Max, statistics.Max);
            Assert.AreEqual(statisticsForeach.Min, statistics.Min);
            Assert.AreEqual(statisticsForeach.Average, statistics.Average);
        }

    }
}
