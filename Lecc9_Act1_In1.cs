internal class Program
{
    private static void Main(string[] args)
    {
        //Variables
        int pesoManzana, pesoTotal, ToMan;
        //Inicializar

        pesoManzana = 0;
        pesoTotal = 0;
        ToMan = 0;

        while (pesoTotal<1000) 
        {
            Console.WriteLine("Ingrese el peso de la manzana: ");
            pesoManzana = Convert.ToInt32(Console.ReadLine());

            if (pesoManzana >= 180)
            {
                pesoTotal = pesoTotal+pesoManzana;
                Console.WriteLine("Llevo un total de " + pesoTotal + " gramos");
                ToMan++;

            }  
            else 
            {
                Console.WriteLine("ERROR - El peso de la manzana no cumple con lo solicitado");
            }
        }
        Console.WriteLine("Ya alcanzo o supero 1 kilo de manzanas");
        Console.WriteLine("Usted compro" + ToMan + " manzanas");
    }
}