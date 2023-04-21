// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Convertidor metodo = new Convertidor();
Console.Write("Ingresa una palabra: ");
string metodo2 = Console.ReadLine();
string salida = Convertidor.ConvertirAMayusculas(metodo2);
Console.WriteLine("La palabra en mayúsculas es: " + salida);

