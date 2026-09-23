using Arreglos.Logica;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\nArreglos");

        MiArreglo oMiArreglo = new MiArreglo(10);

        oMiArreglo.Llenar(5, 20);

        Console.WriteLine("\nDatos desordenados");
        Console.WriteLine(oMiArreglo);

        Console.WriteLine("\nDatos ordenados ascendete");
        oMiArreglo.Ordenar();
        Console.WriteLine(oMiArreglo);

        Console.WriteLine("\nDatos ordenados descendete");
        oMiArreglo.Ordenar(false);
        Console.WriteLine(oMiArreglo);


        Console.ReadKey();
    }
}