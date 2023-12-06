using ChallengeApp;

var employee = new Employee("Tadeusz", "Górniak");
employee.AddGrade(1.24f);
employee.AddGrade(200);
for (int i = 0; i < 10; i++)
{
    employee.AddGrade(i);
}
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");