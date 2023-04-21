public class SortWord{
    public string SortWords(string content){

    string[] palabras = content.Split(' ');
    Array.Sort(palabras);
    string resultado = string.Join(" ", palabras);

    return resultado;
    }
}