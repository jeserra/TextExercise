SortWord sorter = new SortWord();
string input = "El veloz murciélago hindú comía feliz cardillo y kiwi. La cigüeña tocaba el saxofón detrás del palenque de paja";
string output = sorter.SortWords(input);

Console.WriteLine($"Palabra original: {input}\n",input);
Console.WriteLine($"Palabra ordenada alfabéticamente: {output}",output);
