using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int contadorP = 0;
        int sumaPar = 0;

        for (int i = 300; i >= 1; i--)
        {
            if (i % 2 == 0)
            {
                sumaPar += i;
            }

            bool Primo = true;

            if (i < 2)
            {
                Primo = false;
            }
            else
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        Primo = false;
                    }
                }
            }

            if (Primo)
            {
                contadorP++;
            }
        }

        Console.WriteLine("Cantidad de números primos entre 300 y 1: " + contadorP);
        Console.WriteLine("Suma de números pares entre 300 y 1: " + sumaPar);
    }
}