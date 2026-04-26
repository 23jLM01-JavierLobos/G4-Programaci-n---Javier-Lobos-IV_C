internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        int i = 21;
        
        Console.WriteLine("Ingrese un numero");
        num = Convert.ToInt32(Console.ReadLine());

        while (i <= num)
        {
            Console.WriteLine(i);
            i = i + 2;
        }

    }
}