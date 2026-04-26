internal class Program
{
    private static void Main(string[] args)
    {
        int i;
        int numero;
        int suma=0;
        int cont=0;

        for (i = 1; i <= 20; i = i + 1)
        {
            numero = i*7;
            suma += numero;

        if (numero % 2 ==0)
            {
                cont = cont + 1;
            }
        }
        Console.WriteLine("La sumatoria de los primeros 20 múltiplos de 7 es: " + suma);
        Console.WriteLine("Cantidad de múltiplos de 7 que son pares: " + cont);

    }
}