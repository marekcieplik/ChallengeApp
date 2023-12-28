namespace ChallengeApp.Tests
{
    public class EmployeeInFileTests
    {
        [Test]
        public void AddGrade_ThrowsExceptionWhenGradeIsLowerThan0()
        {
            // arrange
            var employee = new EmployeeInFile("Throw", "Invalid grade value");
            // assert
            Assert.Throws<Exception>(() => employee.AddGrade(-100));
            Assert.That(() => employee.AddGrade(-100), Throws.Exception.With.Message.EqualTo("FILE.ADDGRADE.FLOAT: Float value is out range: <0,100>"));
        }
        [Test]
        public void AddGrade_ThrowsExceptionWhenGradeIsMoreThan100()
        {
            // arrange
            var employee = new EmployeeInFile("Throw", "Invalid grade value");
            // assert
            Assert.Throws<Exception>(() => employee.AddGrade(100.1f));
            Assert.That(() => employee.AddGrade(100.1f), Throws.Exception.With.Message.EqualTo("FILE.ADDGRADE.FLOAT: Float value is out range: <0,100>"));
        }
        [Test]
        public void AddGrade_CreatFile()
        {
            // arrage
            var employee = new EmployeeInFile("File", "NotExist");
            var fileName = "grade.txt";
            if (!File.Exists($"{fileName}"))
            {
                employee.AddGrade("b");
            }
            Assert.AreEqual(true, File.Exists($"{fileName}"));
        }
    }
}
