internal class Program
{
    private static void Main(string[] args)
    {
        const int TOTAL_SELLOS = 8;
        Console.WriteLine("----BIENVENIDO A LA BARBERÍA DON CRUP----");

        for (int i = 1; i <=TOTAL_SELLOS; i++)
        {
            Console.WriteLine("\nSello actual {0} de {1} ", i, TOTAL_SELLOS);
            Console.WriteLine("Presione cualquier tecla para Registar esta visita");
            Console.ReadKey();

            Console.WriteLine(">>Sellos #{} registrado correctamente...");
        }

        Console.WriteLine("\n***********************************************");
        Console.WriteLine("CUPONERA COMPLETA");
        Console.WriteLine("Orozco, has ganado tu corte de cabello GRATIS!!!");
        Console.WriteLine("\n***********************************************");
        Console.WriteLine("\nPresione una tecla para cerrar");
        Console.ReadKey();     
    }
}