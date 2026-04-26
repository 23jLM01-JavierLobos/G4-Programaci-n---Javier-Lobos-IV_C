internal class Program
{
    private static void Main(string[] args)
    {
        int num1;
        int num2;
        int menor;
        int mayor;
        int suma;
        int i;

        Console.WriteLine("Escriba el primero numero:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escriba el segundo numero:");
        num2 = Convert.ToInt32(Console.ReadLine());

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

        suma = 0;
        i = menor;

        do
        {
            suma = suma + i;
            i= i + 1;
        }
        while (i<=mayor);
        Console.WriteLine("La suma es:" + suma);
    }
}