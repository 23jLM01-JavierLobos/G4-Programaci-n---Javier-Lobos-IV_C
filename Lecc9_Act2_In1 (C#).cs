internal class Program
{
    private static void Main(string[] args)
    {
        int Nivel = 0;
        int Monedas = 0;
        int TotalMonedas = 0;

        while (TotalMonedas<350)
        {
            Console.WriteLine("Ingrese la cantidad de monedas: ");
            Monedas = Convert.ToInt32(Console.ReadLine());
            TotalMonedas = TotalMonedas + Monedas;
            Console.WriteLine("Total de Monedas: " + TotalMonedas);
        }
        if (TotalMonedas >= 350)
        {
            Console.WriteLine("¡¡¡HAS LLEGADO AL NIVEL 5!!!");
        }
        else
        {
            Console.WriteLine("Necesita mas monedas para subir de nivel");
        }
    }
}