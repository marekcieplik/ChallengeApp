namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname) // ctor - emmed do konstruktora
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name {  get; private set; }
        public string Surname { get; private set; }
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))  // validation
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("string is not float");
            }
        }
        public void AddGrade(double grade)
        {
            if(grade <= float.MaxValue && grade >= float.MinValue) 
            {
                var valueFloat = (float)grade;
                this.AddGrade(valueFloat);
            }
            else 
            { 
                Console.WriteLine("grade is out of float range"); 
            }
        }
        public void AddGrae(long grade)
        {
            if (grade <= float.MaxValue && grade >= float.MinValue)
            {
                var valueFloat = (float)grade;
                this.AddGrade(valueFloat);
            }
            else
            {
                Console.WriteLine("grade is out of float range");
            }
        }
        public Statistics GetStatistics()  //podsumowanie: model danych jako referencja do obiektu
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            var index = 0;
            if (this.grades.Count > 0)
            {
                do
                {
                    statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                    statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                    statistics.Average += this.grades[index];
                    index++;
                } while ( index < this.grades.Count);
                statistics.Average /= this.grades.Count;
            }
            else
            {
                Console.WriteLine("grade list is empty");
            }
            return statistics;
        }
        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics(); 
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            var index = 0;
            while (index < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                index++;
            }
            if (this.grades.Count > 0)
            {
                statistics.Average /= this.grades.Count;
            }
            return statistics;
        }
        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            for(int i = 0; i < this.grades.Count; i++)
            {
                statistics.Min = Math.Min(statistics.Min, this.grades[i]);
                statistics.Max = Math.Max(statistics.Max, this.grades[i]);
                statistics.Average += this.grades[i];
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithForeach()
        {
            var statisticsForeach = new Statistics();
            statisticsForeach.Average = 0;
            statisticsForeach.Max = float.MinValue;
            statisticsForeach.Min = float.MaxValue;

            foreach(var item in this.grades)
            {
                statisticsForeach.Min = Math.Min(statisticsForeach.Min, item);
                statisticsForeach.Max = Math.Max(statisticsForeach.Max, item);
                statisticsForeach.Average += item;
            }
            if (this.grades.Count > 0)
            {
                statisticsForeach.Average /= this.grades.Count;
            }
            return statisticsForeach;

        }
    }
}
