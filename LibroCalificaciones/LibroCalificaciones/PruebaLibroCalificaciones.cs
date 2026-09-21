using System;

public class PruebaLibroCalificaciones
{
    public static void Main(string[] args)
    {
        LibroCalificaciones miLibroCalificaciones = new LibroCalificaciones(
           "CS101 Introducción a la programación en C#");

        miLibroCalificaciones.MostrarMensaje();

        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\n--- MENÚ ---");
            Console.WriteLine("1. Promedio con contador (10 calificaciones)");
            Console.WriteLine("2. Promedio con centinela (-1 para terminar)");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    miLibroCalificaciones.DeterminarPromedioClase();
                    break;
                case "2":
                    miLibroCalificaciones.DeterminaPromedioClase();
                    break;
                case "3":
                    Console.WriteLine("Hasta luego.");
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    break;
            } // fin de switch
        } // fin de while
    } // fin de Main
} // fin de la clase PruebaLibroCalificaciones