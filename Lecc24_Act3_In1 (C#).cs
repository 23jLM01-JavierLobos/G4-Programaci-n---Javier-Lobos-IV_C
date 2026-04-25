using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int i, j, contador, suma;

        suma = 0;

        for (i = 2; i <= 50; i++)
        {
            contador = 0;

            for (j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    contador = contador + 1;
                }
            }

            if (contador == 2)
            {
                suma = suma + i;
            }
        }

        Console.WriteLine("La suma de los numeros primos entre 1 y 50 es: " + suma);
    }
}