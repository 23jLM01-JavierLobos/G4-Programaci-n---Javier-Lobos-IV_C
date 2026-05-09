using System;

class Program
{
    static void Main()
    {
        int numero;

        Console.Write("Ingrese un número: ");
        numero = int.Parse(Console.ReadLine());

        Console.WriteLine("Primeros 20 múltiplos de " + numero);

        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine(numero + " x " + i + " = " + (numero * i));
        }
    }
}