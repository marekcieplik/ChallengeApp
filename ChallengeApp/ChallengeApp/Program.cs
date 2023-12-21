using ChallengeApp;

Console.WriteLine("Witamy w programie XYX do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

Console.WriteLine("Podaj typ stanowisak:");
Console.WriteLine("EM / EF / SU lub EX - zakonczenie programu");
var input = Console.ReadLine();
input = input.ToUpper();
while ((!input.Equals("EX") && (!input.Equals("EM")) && (!input.Equals("EF")) && (!input.Equals("SU"))))
{
    input = Console.ReadLine();
}
string name = "employee";
string surname = "";
switch (input.ToUpper())
{
    case "EM":
        surname = "InMemory";
        break;
    case "EF":
        surname = "InFile";
        break;
    case "SU":
        surname = "Supervisor";
        break;
    case "EX":
        input = "q";
        break;
}

if (input.ToUpper() != "Q")
{
    var employee = new EmployeeInFile(name, surname);

    Console.WriteLine("Podaj ocenę Pracownika, lub (q) - zakończ program :");
    input = Console.ReadLine();

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
                Console.WriteLine($"Average: {statistics.Average}");
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
            if (input != "s" || input != "S")
            {
                employee.AddGrade(input);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("Podaj kolejną ocenę pracownika lub (s) - statystyki lub (q) - zakończ program:");
        input = Console.ReadLine();
    }
    while (true);

}
EXIT:
Console.WriteLine("Do zobaczenia");