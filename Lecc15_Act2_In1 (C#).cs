using System;

class Program
{
    static void Main()
    {
        int contador, suma = 0;

        for (int num = 1; num <= 100; num++)
        {
            contador = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    contador++;
                }
            }

            if (contador == 2)
            {
                Console.WriteLine(num);

                suma += num;
            }
        }

        Console.WriteLine("La suma de los numeros primos es: " + suma);
    }
}