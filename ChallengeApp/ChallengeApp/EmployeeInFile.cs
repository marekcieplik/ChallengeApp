namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grade.txt";

        public EmployeeInFile(string name, string surname) 
            : base(name, surname)
        {
            base.grades = new List<float>();
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
                throw new Exception("Invalid grade value");
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
                    throw new Exception("wrong letter");
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        try
                        {
                            var valueFloat = float.Parse(line);
                            this.grades.Add(valueFloat);
                        }catch(Exception e)
                        {
                            Console.WriteLine($"wrong value in file: '{line}', Exception Message: {e.Message}");                           
                        }
                    }
                }
                result = base.GetStatistics();
            }
            else
            {
                throw new FileNotFoundException(fileName);
            }
            return result;
        }
    }
}
