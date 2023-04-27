

public class StringUtility {
    public static string ConvertirAMayusculas(string word) {
        return word.ToUpper();
    }
    public string SortWords(string content){

    string[] palabras = content.Split(' ');
    Array.Sort(palabras);
    string resultado = string.Join(" ", palabras);

    return resultado;
    }
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
    public int CountLines(string content) 
{
    if (string.IsNullOrEmpty(content))
    {
        return 0;
    }

    string[] lines = content.Split(Environment.NewLine);
    int count = lines.Length;

    return count;
}
 public static string ShortestWord(string input2)
    {
        string[] words = input2.Split(' ');
        string ShortestWord = "";

        foreach (string word in words)
        {
            if (word.Length < ShortestWord.Length)
            {
                ShortestWord = word;
            }
        }

        return ShortestWord;
    }

} 






