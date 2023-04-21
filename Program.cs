// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Convertidor method = new Convertidor();
Console.Write("Ingresa una palabra: ");
string method2 = Console.ReadLine();
string salida = Convertidor.ConvertirAMayusculas(method2);
Console.WriteLine("La palabra en mayúsculas es: " + salida);

