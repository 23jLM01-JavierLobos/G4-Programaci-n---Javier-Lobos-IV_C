internal class Program
{
    private static void Main(string[] args)
    {
        int num;


        Console.WriteLine("Escriba un numero: ");
        num = Convert.ToInt32(Console.ReadLine());

        for (int comprendido = 2; comprendido <= num; comprendido+=2)
        {
            Console.WriteLine(comprendido);
        }
    }
}