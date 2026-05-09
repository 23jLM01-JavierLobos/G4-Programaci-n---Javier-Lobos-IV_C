internal class Program
{
    private static void Main(string[] args)
    {
        string tipo;
        int TotBo = 0;
        int BoletosAdult = 0;
        int BoNinos = 0;
        double TotD = 0;
        string seguir = "S";

        while (seguir == "S")
        {
            Console.WriteLine("Ingrese el tipo de su boleto (1=Adulto / 2=Niño):");
            tipo = Console.ReadLine();

            if (tipo == "1")
            {
                BoletosAdult = BoletosAdult + 1;
                TotD = TotD + 15;
            }
            else if (tipo == "2")
            {
                BoNinos = BoNinos + 1;
                TotD = TotD + 10;
            }

            TotBo = TotBo + 1;

            Console.WriteLine("¿Desea seguir? (S/N):");
            seguir = Console.ReadLine();
        }

        Console.WriteLine("-----RESUMEN-----");
        Console.WriteLine("Total de boletos: " + TotBo);
        Console.WriteLine("Boletos de adultos: " + BoletosAdult);
        Console.WriteLine("Boletos de niños: " + BoNinos);
        Console.WriteLine("Total de dinero: Q " + TotD);
    }
}
