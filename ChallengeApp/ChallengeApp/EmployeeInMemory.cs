namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        private List<float> grades = new List<float>();

        public override event GradeAddedDelegate GradeAdded;

        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("MEMORY.ADDGRADE.FLOAT: Float value is out range: <0,100>");
            }
        }        

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (grade.Length == 1)
            {
                char[] charArray = grade.ToCharArray();
                this.AddGrade(charArray[0]);
            }
            else
            {
                throw new Exception("MEMORY.ADDGRADE.STRING: string is not float or string is not note (A-E)");
            }
        }

        public override void AddGrade(int grade)
        {
            var valueFloat = (float)grade;
            this.AddGrade(valueFloat);
        }

        public override void AddGrade(double grade)
        {
            var valueFloat = (float)grade;
            this.AddGrade(valueFloat);
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("MEMORY.ADDGRADE.CHAR: note letter is out of range [A..E]");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach(var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }

            return statistics;
        }
    }
}
