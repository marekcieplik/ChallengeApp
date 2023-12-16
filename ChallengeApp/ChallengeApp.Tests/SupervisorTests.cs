namespace ChallengeApp.Tests
{
    public class SupervisorTests
    {
        [Test]
        public void AddGrade_ThrowsException_WhenNoteIsNotInRangeFrom1to6()
        {
            // arrange
            var supervisor = new Supervisor("Note", "OutOfRange");
            // assert
            Assert.That(() => supervisor.AddGrade("1-"), Throws.Exception.With.Message.EqualTo("Note Out Of Range From 1 To 6"));
            Assert.That(() => supervisor.AddGrade("-1"), Throws.Exception.With.Message.EqualTo("Note Out Of Range From 1 To 6"));
        }
        [Test]
        public void AddGrade_ThrowsException_WhenGradeIsNotInRangeFrom0to100()
        {
            // arrange
            var supervisor = new Supervisor("Grade", "OutOfRange");
            // assert
            Assert.That(() => supervisor.AddGrade(-1f), Throws.Exception.With.Message.EqualTo("Grade Out Of Range From 0 To 100"));
        }
        [Test]
        public void AddGradeA_ShouldNoteIs6()
        {
            // arrange
            var supervisor = new Supervisor("Note", "A");
            supervisor.AddGrade("a");
            // act
            var statistics = supervisor.GetStatistics();
            // assert
            Assert.That(statistics.AverageNote, Is.EqualTo("6"));
        }
    }
}
