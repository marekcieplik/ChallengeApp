namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public abstract void AddGrade(float grade);

        public abstract void AddGrade(char grade);

        protected List<float> grades; 
        
        public string Name { get; private set; }
        
        public string Surname { get; private set; }
        
        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public virtual void AddGrade(string grade)
        {
            char[] charArray = grade.ToCharArray();
            if ((charArray.Length == 1) && (char.ToLower(charArray[0]) >= 'a') && (char.ToLower(charArray[0]) <= 'e'))
            {
                this.AddGrade(charArray[0]);
            }
            else if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("string is not float");
            }
        }

        public virtual void AddGrade(int grade)
        {
            var valueFloat = (float)grade;
            this.AddGrade(valueFloat);
        }

        public virtual void AddGrade(double grade)
        {
            var valueFloat = (float)grade;
            this.AddGrade(valueFloat);
        }

        public virtual void AddGrade(long grade)
        {
            var valueFloat = (float)grade;
            this.AddGrade(valueFloat);
        }

        public virtual Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            foreach (var grade in grades)
            {
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Average += grade;
            }
            if (grades.Count > 0) 
            {
                statistics.Average /= grades.Count;
            }
            return statistics;
        }
    }
}
