

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
}



