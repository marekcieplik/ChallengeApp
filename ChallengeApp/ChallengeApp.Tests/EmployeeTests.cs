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
        public void WhenGetStatistiscCalled_ShouldBeMaxIsLessOrEqual100()
        {
            // arrange
            var employee = new Employee("name", "surname");
            employee.AddGrade(200);
            employee.AddGrade(2);
            var statistics = employee.GetStatistics();
            Assert.LessOrEqual(statistics.Max, 100f);
        }
        [Test]
        public void WhenGetStatisticsCalled_ShouldBeMinIsGreaterOrEqualZero()
        {
            var employee = new Employee("name", "surname");
            employee.AddGrade(-10);
            employee.AddGrade(2);
            var statistics = employee.GetStatistics();
            Assert.GreaterOrEqual(statistics.Min, 0);
        }
        [Test]
        public void WhenAddGradeString5_ShouldBeEqualWithAddGradeFloat5()
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
        public void WhenAddGradeLetterA_ShouldAdd100()
        {
            // arrange
            var employee = new Employee("char", "A");
            employee.AddGrade('A');
            // act
            var statistics = employee.GetStatistics();
            // assert
            Assert.AreEqual(100, statistics.Max);
            Assert.AreEqual(100, statistics.Min);
            Assert.AreEqual(100, statistics.Average);
        }
        [Test]
        public void WhenAddGradeLetterSmallA_ShouldAdd100()
        {
            // arrange
            var employee = new Employee("char", "a");
            employee.AddGrade('a');
            // act
            var statistics = employee.GetStatistics();
            // assert
            Assert.AreEqual(100, statistics.Max);
            Assert.AreEqual(100, statistics.Min);
            Assert.AreEqual(100, statistics.Average);
        }
        [Test]
        public void WhenAddGradeLetterB_ShouldAdd80()
        {
            // arrange
            var employee = new Employee("char", "B");
            employee.AddGrade('B');
            // act
            var statistics = employee.GetStatistics();
            // assert
            Assert.AreEqual(80, statistics.Max);
            Assert.AreEqual(80, statistics.Min);
            Assert.AreEqual(80, statistics.Average);
        }
        [Test]
        public void WhenAddGradeLetterSmallB_ShouldAdd80()
        {
            // arrange
            var employee = new Employee("char", "b");
            employee.AddGrade('b');
            // act
            var statistics = employee.GetStatistics();
            // assert
            Assert.AreEqual(80, statistics.Max);
            Assert.AreEqual(80, statistics.Min);
            Assert.AreEqual(80, statistics.Average);
        }
        [Test]
        public void WhenAddGradeLetterC_ShouldAdd60()
        {
            // arrange
            var employee = new Employee("char", "C");
            employee.AddGrade('C');
            // act
            var statistics = employee.GetStatistics();
            // assert
            Assert.AreEqual(60, statistics.Max);
            Assert.AreEqual(60, statistics.Min);
            Assert.AreEqual(60, statistics.Average);
        }
        [Test]
        public void WhenAddGradeLetterSmallC_ShouldAdd60()
        {
            // arrange
            var employee = new Employee("char", "c");
            employee.AddGrade('c');
            // act
            var statistics = employee.GetStatistics();
            // assert
            Assert.AreEqual(60, statistics.Max);
            Assert.AreEqual(60, statistics.Min);
            Assert.AreEqual(60, statistics.Average);
        }
        [Test]
        public void WhenAddGradeLetterD_ShouldAdd40()
        {
            // arrange
            var employee = new Employee("char", "D");
            employee.AddGrade('D');
            // act
            var statistics = employee.GetStatistics();
            // assert
            Assert.AreEqual(40, statistics.Max);
            Assert.AreEqual(40, statistics.Min);
            Assert.AreEqual(40, statistics.Average);
        }
        [Test]
        public void WhenAddGradeLetterSmallD_ShouldAdd40()
        {
            // arrange
            var employee = new Employee("char", "d");
            employee.AddGrade('d');
            // act
            var statistics = employee.GetStatistics();
            // assert
            Assert.AreEqual(40, statistics.Max);
            Assert.AreEqual(40, statistics.Min);
            Assert.AreEqual(40, statistics.Average);
        }
        [Test]
        public void WhenAddGradeLetterE_ShouldAdd20()
        {
            // arrange
            var employee = new Employee("char", "E");
            employee.AddGrade('E');
            // act
            var statistics = employee.GetStatistics();
            // assert
            Assert.AreEqual(20, statistics.Max);
            Assert.AreEqual(20, statistics.Min);
            Assert.AreEqual(20, statistics.Average);
        }
        [Test]
        public void WhenAddGradeLetterSmallE_ShouldAdd20()
        {
            // arrange
            var employee = new Employee("char", "e");
            employee.AddGrade('e');
            // act
            var statistics = employee.GetStatistics();
            // assert
            Assert.AreEqual(20, statistics.Max);
            Assert.AreEqual(20, statistics.Min);
            Assert.AreEqual(20, statistics.Average);
        }
    }
}
