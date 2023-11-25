namespace ChallengeApp
{
    public class Personnel
    {
        private List<Employee> list = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            this.list.Add(employee);
        }
        public Employee MaximumScoreEmploee()
        {
            int maxScoreEmploeeId = 0;
            int maxScore = this.list[0].ScoreSum();
            for (int i = 1; i < this.list.Count(); i++)
                {
                    if (maxScore < this.list[i].ScoreSum())
                    {
                        maxScoreEmploeeId = i;
                        maxScore = this.list[i].ScoreSum();
                    }
                }
            return this.list[maxScoreEmploeeId];
        }
    }
}
