using System;

class Program
{
    static void Main()
    {
        int numero;

        Console.Write("Ingrese un número: ");
        numero = int.Parse(Console.ReadLine());

        Console.WriteLine("Tabla de multiplicar del " + numero);

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(numero + " x " + i + " = " + (numero * i));
        }
    }
}
