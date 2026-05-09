using System;

class Program
{
    static void Main()
    {
        int numero;
        int suma = 0;

        do
        {
            Console.Write("Ingrese un numero (9 para terminar): ");
            numero = int.Parse(Console.ReadLine());

            if (numero != 9)
            {
                suma += numero;
            }

        } while (numero != 9);

        Console.WriteLine("La suma total es: " + suma);
    }
}