using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int suma = 0;

        for (int i = 2; i <= 22; i++)
        {
            int contador = 0;

            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    contador++;
                }
            }

            if (contador == 2)
            {
                suma = suma + i;
            }
        }

        Console.WriteLine("La suma de los numeros primos entre 1 y 22 es: " + suma);
    }
}