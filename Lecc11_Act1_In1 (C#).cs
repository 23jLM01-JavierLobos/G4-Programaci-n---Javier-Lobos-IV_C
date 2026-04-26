using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int cajones = 200;

        do
        {
            Console.WriteLine("Cajones disponibles: " + cajones);
            cajones=cajones-1;
        }
        while (cajones > 0);

        Console.WriteLine("Ya no hay cajones libres");
    }
}