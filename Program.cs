
// Encuentra la palabra mas larga
Console.Write("Ingresa un texto: ");
string input = Console.ReadLine();
string longestWord = StringUtility.LongestWord(input);
Console.WriteLine($"La palabra mas larga es: {longestWord}");


﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

StringUtility method = new StringUtility();
Console.Write("Ingresa una palabra: ");
string method2 = Console.ReadLine();
string salida = StringUtility.ConvertirAMayusculas(method2);
Console.WriteLine("La palabra en mayúsculas es: " + salida);


StringUtility sorter = new StringUtility();
//string input = "El veloz murciélago hindú comía feliz cardillo y kiwi. La cigüeña tocaba el saxofón detrás del palenque de paja";
string output = sorter.SortWords(input);

Console.WriteLine($"Palabra original: {input}\n",input);
Console.WriteLine($"Palabra ordenada alfabéticamente: {output}",output);

