﻿using ChallengeApp;

Console.WriteLine("Witamy w programie XYX do oceny Pracowników");
Console.WriteLine("===========================================");

var employeeInMemory = new EmployeeInMemory("In", "Memory");
employeeInMemory.GradeAdded += MethodStartedWhenEvent;
employeeInMemory.GradeAdded += employeeInMemory.GetStatistics;
employeeInMemory.AddGrade(60);

void MethodStartedWhenEvent(object sender, EventArgs args)
{
    Console.WriteLine("Event shooted: Dodano nową ocenę!");
}

try
{
    var statistics = employeeInMemory.GetStatistics();
    Console.WriteLine($"Employee {employeeInMemory.Name} {employeeInMemory.Surname}");
    Console.WriteLine($"Average: {statistics.Average}");
    Console.WriteLine($"Min: {statistics.Min}");
    Console.WriteLine($"Max: {statistics.Max}");
    Console.WriteLine($"Note Letter: {statistics.AverageLetter}");
}
catch (Exception e)
{
    Console.WriteLine($"Exception catched: {e.Message}");
}

var employeeInFile = new EmployeeInFile("employee", "InFile");
employeeInFile.GradeAdded += MethodStartedWhenEvent;
employeeInFile.AddGrade("A");
try
{
    var statistics = employeeInFile.GetStatistics();
    Console.WriteLine($"Employee {employeeInFile.Name} {employeeInFile.Surname}");
    Console.WriteLine($"Average: {statistics.Average}");
    Console.WriteLine($"Min: {statistics.Min}");
    Console.WriteLine($"Max: {statistics.Max}");
    Console.WriteLine($"Note Letter: {statistics.AverageLetter}");
}
catch (Exception e)
{
    Console.WriteLine($"Exception catched: {e.Message}");
}

Console.WriteLine("Do zobaczenia");