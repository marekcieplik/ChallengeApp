using ChallengeApp;

var employee = new Employee("Tadeusz", "Górniak");
employee.AddGrade(1.24f);
for (int i = 0; i < 10; i++)
{
    employee.AddGrade(i);
}
var statistics = employee.GetStatistics();  // goto implementation - ^LKM
Console.WriteLine($"Average: {statistics.Average:N2}");  //string interpolation with precision
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");