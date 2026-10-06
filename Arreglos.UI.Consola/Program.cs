using Arreglos.Logica;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\nArreglos");

        MiArreglo oMiArreglo = new MiArreglo(5);

        try
        {
            //for (int i = 0; i < oMiArreglo.N; i++)
            //{
            //    oMiArreglo.Agregar(i * 3);
            //}

            oMiArreglo.Agregar(10);
            oMiArreglo.Agregar(5);
            oMiArreglo.Agregar(4);

            Console.WriteLine(oMiArreglo);
            Console.ReadKey();

            oMiArreglo.Insertar(200, 1);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            
        }

        Console.WriteLine(oMiArreglo);

        //Console.WriteLine(oMiArreglo);


        //oMiArreglo.Llenar(5, 20);

        //Console.WriteLine("\nDatos desordenados");
        //Console.WriteLine(oMiArreglo);

        //Console.WriteLine("\nDatos ordenados ascendete");
        //oMiArreglo.Ordenar();
        //Console.WriteLine(oMiArreglo);

        //Console.WriteLine("\nDatos ordenados descendete");
        //oMiArreglo.Ordenar(false);
        //Console.WriteLine(oMiArreglo);


        Console.ReadKey();
    }
}