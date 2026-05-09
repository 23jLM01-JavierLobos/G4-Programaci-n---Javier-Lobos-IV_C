internal class Program
{
    private static void Main(string[] args)
    {
        int num = 1;
        int i;

        for (num = 1; num <= 20; i = num++)
        {
            i = num * 4;
            Console.WriteLine("Multiplos: " + i);
        }
    }
}