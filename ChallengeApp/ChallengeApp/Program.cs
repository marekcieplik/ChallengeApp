
using ChallengeApp;

//2. stwórz 3 pracowników
Employee empl1 = new Employee("Jan", "Kowalski", 25);
Employee empl2 = new Employee("Tadeusz", "Nowak", 25);
Employee empl3 = new Employee("Marian", "Mazur", 62);

//przydzielenie punktów
for (int i = 0; i < 5; i++)
{
    empl1.AddScore(i + 1);
    empl2.AddScore(i * 2 + 1);
    empl3.AddScore(10 - i);
}

//Wyszukaj pracownika z największą liczbą ocen
Personnel personnel = new Personnel();
personnel.AddEmployee(empl1);
personnel.AddEmployee(empl2);
personnel.AddEmployee(empl3);

Console.WriteLine("Max score emploee searching...");
Console.WriteLine(personnel.MaximumScoreEmploee().EmployeeKard());