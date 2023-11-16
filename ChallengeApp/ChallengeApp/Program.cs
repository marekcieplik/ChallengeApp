var number = 4556;
int[] countLetters = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();
foreach (char c in letters)
{
    int inde = Convert.ToInt32(c) - Convert.ToInt32('0');
    countLetters[inde] = countLetters[inde] + 1;
}
for(int i = 0; i < countLetters.Length; i ++) 
{  
    Console.WriteLine(i+" => " + countLetters[i]); 
}