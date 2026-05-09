using System;

class Program
{
    static void Main()
    {
        int billete;
        int contador100 = 0;
        int suma100 = 0;

        Console.WriteLine("*************************");
        Console.WriteLine("Cajero de Supermercado");
        Console.WriteLine("*************************");

        for (int i = 1; i <= 1000; i++)
        {
            Console.Write("Ingrese el valor del billete (20, 50 o 100): ");
            billete = int.Parse(Console.ReadLine());

            Console.WriteLine("Billete registrado, el billete es: " + billete);

            if (billete == 100)
            {
                contador100++;
                suma100 += billete;

                // Verificar si llegó a 1000
                if (suma100 >= 1000)
                {
                    Console.WriteLine("Se alcanzaron $1000 en billetes de 100.");
                    break; // Termina el ciclo
                }
            }
        }

        Console.WriteLine("Dinero total en billetes de 100: $" + suma100);
    }
}