
﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

StringUtility method = new StringUtility();
Console.Write("Ingresa una palabra: ");
string method2 = Console.ReadLine();
string salida = StringUtility.ConvertirAMayusculas(method2);
Console.WriteLine("La palabra en mayúsculas es: " + salida);


StringUtility sorter = new StringUtility();
string input = "El veloz murciélago hindú comía feliz cardillo y kiwi. La cigüeña tocaba el saxofón detrás del palenque de paja";
string output = sorter.SortWords(input);

Console.WriteLine($"Palabra original: {input}\n",input);
Console.WriteLine($"Palabra ordenada alfabéticamente: {output}",output);

