
// Encuentra la palabra mas larga
Console.Write("Ingresa un texto: ");
string input = Console.ReadLine();
string longestWord = GetLongestWord.LongestWord(input);
Console.WriteLine($"La palabra mas larga es: {longestWord}");
class GetLongestWord
{
    public static string LongestWord(string input)
    {
        string[] words = input.Split(' ');
        string longestWord = "";

        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }

        return longestWord;
    }
}