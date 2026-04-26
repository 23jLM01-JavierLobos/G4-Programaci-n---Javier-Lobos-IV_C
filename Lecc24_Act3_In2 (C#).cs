using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int numero, suma = 0;

        Console.WriteLine("Ingrese un numero entero:");
        numero = int.Parse(Console.ReadLine());

        for (int i = numero; i >= 1; i--)
        {
            Console.WriteLine(i);
            suma += i;
        }

        Console.WriteLine("La suma total es: " + suma);
    }
}