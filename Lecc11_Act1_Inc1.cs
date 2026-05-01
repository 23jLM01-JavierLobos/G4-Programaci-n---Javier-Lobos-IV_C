internal class Program
{
    private static void Main(string[] args)
    {
        int cajocup = 0;
        const int captotal = 10;
        string op = "";


        Console.WriteLine("==========CONTROL DE ACCESO AL CENTRO COMERCIAL==========");

        do
        {
            Console.WriteLine("\n ESTADO: {0} ocupados | {1} disponibles", cajocup, captotal - cajocup);
            Console.WriteLine("¿Ingresar nuevo vehículo? (S/N)");
            op = Console.ReadLine().ToUpper();

            if (op == "S")
            {
                cajocup++;
                Console.WriteLine(">>Acceso Concedido. Levantando Talanquera...");
            }
            else if (op != "N")
            {
                Console.WriteLine(">>Opción Inválida. Use 'S' para sí |'N' para no.");
            }

        }
        while (op != "N" && cajocup < captotal);

        if (cajocup >= captotal)
        {
            Console.WriteLine("\n*******************************************************");
            Console.WriteLine("ALERTA: Cupo completado. Barrera bloqueada.");
            Console.WriteLine("\n*******************************************************");
        }
        Console.WriteLine("\nApagando el sistema de control.");
        Console.WriteLine("Presione una tecla para continuar.");
        Console.ReadKey();
    }
}