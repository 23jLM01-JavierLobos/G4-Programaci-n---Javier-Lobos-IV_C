internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        int tabla = 1;
        int resultado;

        Console.WriteLine("Escriba un numero: ");
        num = Convert.ToInt32(Console.ReadLine());

        while (tabla <= 10)
        {
            resultado = num * tabla;
            Console.WriteLine(num + " x " + tabla + " = " + resultado);
            tabla++;
        }
    }
}