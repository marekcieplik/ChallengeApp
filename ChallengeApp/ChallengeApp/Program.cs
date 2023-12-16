using ChallengeApp;

Console.WriteLine("Witamy w programie XYX do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();
Console.WriteLine("Podaj ocenę Pracownika, lub (q) - zakończ program :");
var input = Console.ReadLine();

//var employee = new Employee("name", "surname");
var employee = new Supervisor("name", "surname");

do
{
    if (input.ToUpper() == "Q")
    {
        break;
    }
    if (input.ToUpper() == "S")
    {
        try
        {
        var statistics = employee.GetStatistics();
        Console.WriteLine($"Average: { statistics.Average}");
        Console.WriteLine($"Min: {statistics.Min}");
        Console.WriteLine($"Max: {statistics.Max}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }
    }
    try
    {
        if (input != "s" || input != "s")
        {
            employee.AddGrade(input);
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
    Console.WriteLine("Podaj kolejną ocenę pracownika lub (s) - statystyki:");
    input = Console.ReadLine();
}
while (true);
Console.WriteLine("Do zobaczenia");