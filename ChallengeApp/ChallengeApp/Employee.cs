namespace ChallengeApp
{
    public class Employee
    {
        private List<int> score = new List<int>();
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; set; }

        public Employee(string name, string lastName, int age)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
        }
        public void AddScore(int score)
        {
            if (score > 0)
            {
                this.score.Add(score);

            }
            else
            {
                Console.WriteLine("Scores should by positive numbers");
            }
        }
        public void PenaltyPoints(int score)
        {
            if (score < 0)
            {
                this.score.Add(score);
            }
            else
            {
                Console.WriteLine("PenaltyPoints should by negative numbers");
            }
        }
        public int ScoreSum()
        {
            return this.score.Sum();
        }
        public string EmployeeKard()
        {
            return this.Name + " " + this.LastName + ", score = " + this.ScoreSum().ToString();
        }
    }
}
