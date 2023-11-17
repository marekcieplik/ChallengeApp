//zadanie: https://discord.com/channels/922475032091959348/1071383050497306665
Console.WriteLine("Program sprawdzi czy liczba jest dodatnia, ujemna, czy równa zero.\nPodaj liczbę: ");
int number;
string text = Console.ReadLine(); // Odczytuje tekst z klawiatury
int.TryParse(text, out number); // Konwertuje tekst na typ int i przypisuje do zmiennej number
if (number == 0)
{
    Console.WriteLine("number równa zero");
}else if (number > 0)
{
    Console.WriteLine("number jest dodatnia");
}
else
{
    Console.WriteLine("number jest ujemna");
}