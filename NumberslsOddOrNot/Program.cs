Console.Write("Ingrese número: ");
var number = int.Parse(Console.ReadLine()!);
if (number % 2 == 0)
{
    Console.WriteLine($"El numero: {number} es par.");
}
else
{
    Console.WriteLine($"El numero: {number} es impar.");
}


