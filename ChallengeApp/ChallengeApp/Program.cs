using ChallengeApp;

Console.WriteLine("Witamy w programie XYX do oceny Pracowników");
Console.WriteLine("===========================================");

var employee = new EmployeeInFile("In", "Memory");
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę!");
}

while(true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika:");
    var input = Console.ReadLine();
    if (input.ToLower() == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e) 
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

    var statistics = employee.GetStatistics();
    Console.WriteLine($"Average: {statistics.Average}");
    Console.WriteLine($"Min: {statistics.Min}");
    Console.WriteLine($"Max: {statistics.Max}");
