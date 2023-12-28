namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grade.txt";

        public EmployeeInFile(string name, string surname) 
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("FILE.ADDGRADE.FLOAT: Float value is out range: <0,100>");
            }
        }

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
            var result = this.CountStatistics(gradesFromFile);
            return result;
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

        private Statistics CountStatistics(List<float> grades)
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

            switch (statistics.Average)
            {
                case var average when average > 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average > 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average > 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average > 20:
                    statistics.AverageLetter = 'D';
                    break;
                case var average when average > 0:
                    statistics.AverageLetter = 'E';
                    break;
                default:
                    throw new Exception("FILE.GETSTATISTISC: average LETTER is not defined");
            }

            return statistics;
        }
    }
}
