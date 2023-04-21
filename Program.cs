
string input = "Holaaa y adios";
string content = File.ReadAllText(input);
string longestWord = GetLongestWord.LongestWord(content);
Console.WriteLine("Longest word: " + longestWord);