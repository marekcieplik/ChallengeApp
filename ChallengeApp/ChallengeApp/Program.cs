var name = "Paul";
var born = "male";
var age = 13;
if (age == 33 && name == "Ewa")
{
    Console.WriteLine("Ewa, lat 33");
}
else if (born == "female")
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
}
else //"male"
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
}