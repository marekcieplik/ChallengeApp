namespace ChallengeApp.Tests
{
    public class EmployeeInMemoryTests
    {
        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMax()
        {
            // arrange
            var employee = new EmployeeInMemory("In", "Max");
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
            var employee = new EmployeeInMemory("In", "Min");
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
            var employee = new EmployeeInMemory("In", "Average");
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
        public void WhenAddGradeString5_ShouldBeEqualWithAddGradeFloat5()
        {
            // arrange
            var employerString = new EmployeeInMemory("name", "surname");
            var employerFloat = new EmployeeInMemory("name", "surname");
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
            var employee = new EmployeeInMemory("char", "A");
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
            var employee = new EmployeeInMemory("char", "a");
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
            var employee = new EmployeeInMemory("char", "B");
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
            var employee = new EmployeeInMemory("char", "b");
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
            var employee = new EmployeeInMemory("char", "C");
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
            var employee = new EmployeeInMemory("char", "c");
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
            var employee = new EmployeeInMemory("char", "D");
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
            var employee = new EmployeeInMemory("char", "d");
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
            var employee = new EmployeeInMemory("char", "E");
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
            var employee = new EmployeeInMemory("char", "e");
            employee.AddGrade('e');
            // act
            var statistics = employee.GetStatistics();
            // assert
            Assert.AreEqual(20, statistics.Max);
            Assert.AreEqual(20, statistics.Min);
            Assert.AreEqual(20, statistics.Average);
        }
        [Test]
        public void WhenAddGradeA_ShouldAvarageLetterA()
        {
            // arrange
            var employee = new EmployeeInMemory("AddGradeA", "AverageLetterA");
            employee.AddGrade("A");
            // act
            var statistics = employee.GetStatistics();
            // assert
            Assert.That(statistics.AverageLetter, Is.EqualTo('A'));
        }
        [Test]
        public void WhenAddGradeB_ShouldAvarageLetterB()
        {
            // arrange
            var employee = new EmployeeInMemory("AddGradeB", "AverageLetterB");
            employee.AddGrade("B");
            // act
            var statistics = employee.GetStatistics();
            // assert
            Assert.That(statistics.AverageLetter, Is.EqualTo('B'));
        }
        [Test]
        public void WhenAddGradeC_ShouldAvarageLetterC()
        {
            // arrange
            var employee = new EmployeeInMemory("AddGradeC", "AverageLetterA");
            employee.AddGrade("C");
            // act
            var statistics = employee.GetStatistics();
            // assert
            Assert.That(statistics.AverageLetter, Is.EqualTo('C'));
        }
        [Test]
        public void WhenAddGradeD_ShouldAvarageLetterD()
        {
            // arrange
            var employee = new EmployeeInMemory("AddGradeD", "AverageLetterD");
            employee.AddGrade("D");
            // act
            var statistics = employee.GetStatistics();
            // assert
            Assert.That(statistics.AverageLetter, Is.EqualTo('D'));
        }
        [Test]
        public void WhenAddGradeE_ShouldAvarageLetterE()
        {
            // arrange
            var employee = new EmployeeInMemory("AddGradeE", "AverageLetterE");
            employee.AddGrade("E");
            // act
            var statistics = employee.GetStatistics();
            // assert
            Assert.That(statistics.AverageLetter, Is.EqualTo('E'));
        }
        [Test]
        public void AddGrade_ThrowsExceptionWhenGradeIsLowerThan0()
        {
            // arrange
            var employee = new EmployeeInMemory("Throw", "Invalid grade value");
            // assert
            Assert.Throws<Exception>(() => employee.AddGrade(-100));
            Assert.That(() => employee.AddGrade(-100), Throws.Exception.With.Message.EqualTo("MEMORY.ADDGRADE.FLOAT: Float value is out range: <0,100>"));
        }
        [Test]
        public void AddGrade_ThrowsExceptionWhenGradeIsMoreThan100()
        {
            // arrange
            var employee = new EmployeeInMemory("Throw", "Invalid grade value");
            // assert
            Assert.Throws<Exception>(() => employee.AddGrade(100.1f));
            Assert.That(() => employee.AddGrade(100.1f), Throws.Exception.With.Message.EqualTo("MEMORY.ADDGRADE.FLOAT: Float value is out range: <0,100>"));
        }
    }
}
