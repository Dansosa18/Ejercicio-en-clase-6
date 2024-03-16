
using System.Diagnostics.CodeAnalysis;
using System.Reflection.PortableExecutable;

static void ejemplo1()
{
    int[] calificaciones;
    calificaciones = new int[] { 85, 92, 77, 68, 96,89,85,99,95, 80};
    Array.Sort(calificaciones);
    Console.WriteLine(calificaciones[2]);
    double sum = 0;
    int cantidad = calificaciones.Length;
    foreach (int numero in calificaciones)
    {
        Console.WriteLine(numero);
        sum += numero;       
    }
        double promedio= (double)sum / cantidad;
    Console.WriteLine("\nPromedio {0}\n", promedio);
    for (int i = 0; i < calificaciones.Length; i++)
    {
        Console.WriteLine($"Calificacion {i + 1}: {calificaciones[i]}");
    }
    bool hayaprobados = Array.Exists(calificaciones, calif => calif >= 60);
    Console.WriteLine(hayaprobados);

    int primernumero= Array.Find (calificaciones, num=> num )

}
ejemplo1();
