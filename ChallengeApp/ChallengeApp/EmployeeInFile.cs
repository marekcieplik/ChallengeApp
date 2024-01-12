namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("FILE.ADDGRADE.FLOAT: Float value is out range: <0,100>");
            }
        }

        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            else
            {
                throw new FileNotFoundException();
            }
            return grades;
        }

        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }

        private const string fileName = "grade.txt";

        public override void AddGrade(char grade)
        {
            switch (char.ToLower(grade))
            {
                case 'a':
                    this.AddGrade(100f);
                    break;
                case 'b':
                    this.AddGrade(80f);
                    break;
                case 'c':
                    this.AddGrade(60f);
                    break;
                case 'd':
                    this.AddGrade(40f);
                    break;
                case 'e':
                    this.AddGrade(20f);
                    break;
                default:
                    throw new Exception("FILE.ADDGRADE.CHAR: note letter is out of range [A..E]");
            }
        }

        public override void AddGrade(string grade)
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
                throw new Exception("FILE.ADDGRADE.STRING: string is not float or string is not note (A-E)");
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

        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            
            var statistics = new Statistics();

            foreach (var grade in gradesFromFile)
            {
                statistics.AddGrade(grade);
            }

            return statistics;
        }
    }
}
