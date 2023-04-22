

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
}




