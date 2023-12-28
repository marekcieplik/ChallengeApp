namespace ChallengeApp
{
    public interface IEmployee
    {
        public string Name { get; }
        public string Surname { get; }
        public void AddGrade( float grade );
        public void AddGrade( double grade );
        public void AddGrade( int grade );
        public void AddGrade( char grade );
        public void AddGrade( string grade );
        public Statistics GetStatistics();
    }
}
