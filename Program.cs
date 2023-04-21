
// Encuentra la palabra mas larga
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