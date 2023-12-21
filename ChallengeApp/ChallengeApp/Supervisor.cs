namespace ChallengeApp
{
    public class Supervisor : EmployeeBase
    {

        public Supervisor(string name, string surname) 
            : base(name, surname) 
        {
            base.grades = new List<float>();
        }

        public override void AddGrade(string grade)
        {
            char[] charArray = grade.ToCharArray();
            if ((grade.Length == 1) && (char.ToLower(charArray[0]) >= 'a') && (char.ToLower(charArray[0]) <= 'e'))
            {
                this.AddGrade(charArray[0]);
            }
            else
            {
                switch (grade)
                {
                    case "6":
                        this.AddGrade(100f);
                        break;
                    case "6-":
                    case "-6":
                        this.AddGrade(95f);
                        break;
                    case "5+":
                    case "+5":
                        this.AddGrade(85f);
                        break;
                    case "5":
                        this.AddGrade(80f);
                        break;
                    case "5-":
                    case "-5":
                        this.AddGrade(75f);
                        break;
                    case "4+":
                    case "+4":
                        this.AddGrade(65f);
                        break;
                    case "4":
                        this.AddGrade(60f);
                        break;
                    case "4-":
                    case "-4":
                        this.AddGrade(55f);
                        break;
                    case "3+":
                    case "+3":
                        this.AddGrade(45f);
                        break;
                    case "3":
                        this.AddGrade(40f);
                        break;
                    case "3-":
                    case "-3":
                        this.AddGrade(35f);
                        break;
                    case "2+":
                    case "+2":
                        this.AddGrade(25f);
                        break;
                    case "2":
                        this.AddGrade(20f);
                        break;
                    case "2-":
                    case "-2":
                        this.AddGrade(15f);
                        break;
                    case "1+":
                    case "+1":
                        this.AddGrade(05f);
                        break;
                    case "1":
                        this.AddGrade(00f);
                        break;
                    default:
                        throw new Exception("Note Out Of Range From 1 To 6");
                }

            }
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 &&  grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Grade Out Of Range From 0 To 100");
            }
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
                    throw new Exception("Note letter from A to E");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = base.GetStatistics();

            switch (statistics.Average)
            {
                case var average when average == 100f:
                    statistics.AverageNote = "6";
                    break;
                case var average when average >= 95f:
                    statistics.AverageNote = "6-";
                    break;
                case var average when average >= 85f:
                    statistics.AverageNote = "5+";
                    break;
                case var average when average >= 80f:
                    statistics.AverageNote = "5";
                    break;
                case var average when average >= 75f:
                    statistics.AverageNote = "5-";
                    break;
                case var average when average >= 65f:
                    statistics.AverageNote = "4+";
                    break;
                case var average when average >= 60f:
                    statistics.AverageNote = "4";
                    break;
                case var average when average >= 55f:
                    statistics.AverageNote = "4-";
                    break;
                case var average when average >= 45f:
                    statistics.AverageNote = "3+";
                    break;
                case var average when average >= 40f:
                    statistics.AverageNote = "3";
                    break;
                case var average when average >= 35f:
                    statistics.AverageNote = "3-";
                    break;
                case var average when average >= 25f:
                    statistics.AverageNote = "2+";
                    break;
                case var average when average >= 20f:
                    statistics.AverageNote = "2";
                    break;
                case var average when average >= 15f:
                    statistics.AverageNote = "2-";
                    break;
                case var average when average >= 05f:
                    statistics.AverageNote = "1+";
                    break;
                case var average when average >= 00f:
                    statistics.AverageNote = "1";
                    break;
            }
            return statistics;
        }
    }
}
