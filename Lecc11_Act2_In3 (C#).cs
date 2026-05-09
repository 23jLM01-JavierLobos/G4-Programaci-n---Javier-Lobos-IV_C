// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        int num1, num2, menor, mayor, i;

        Console.Write("Digite el primer numero: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite el segundo numero: ");
        num2 = int.Parse(Console.ReadLine());

        if (num1 < num2)
        {
            menor = num1;
            mayor = num2;
        }
        else
        {
            menor = num2;
            mayor = num1;
        }

        i = menor;

        do
        {
            if (i % 4 == 0)
            {
                Console.WriteLine(i);
            }

            i++;
        }
        while (i <= mayor);
    }
}