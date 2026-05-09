internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        int facto = 1;

        Console.WriteLine("Digite un numero:");
        num = Convert.ToInt32(Console.ReadLine());

        do
        {
            facto = facto * num;
            num--;
        }
        while (num > 0);

        Console.WriteLine("El factorial es: " + facto);
    }
}