// Combina las figuras 5.5 y 5.7 en una sola clase con menú de selección.
using System;

public class LibroCalificaciones
{
    private string nombreCurso; // nombre del curso que representa este LibroCalificaciones

    // el constructor inicializa nombreCurso
    public LibroCalificaciones(string nombre)
    {
        NombreCurso = nombre; // inicializa nombreCurso usando la propiedad
    } // fin del constructor

    // propiedad para obtener (get) y establecer (set) el nombre del curso
    public string NombreCurso
    {
        get
        {
            return nombreCurso;
        } // fin de get
        set
        {
            nombreCurso = value; // set debería validar
        } // fin de set
    } // fin de la propiedad NombreCurso

    // muestra un mensaje de bienvenida para el usuario de LibroCalificaciones
    public void MostrarMensaje()
    {
        Console.WriteLine("Bienvenido al libro de calificaciones de\n{0}!\n",
           NombreCurso);
    } // fin del método MostrarMensaje

    // Fig. 5.5: repetición controlada por un contador (10 calificaciones fijas)
    public void DeterminarPromedioClase()
    {
        int total; // suma de las calificaciones introducidas por el usuario
        int contadorCalif; // número de la siguiente calificación a introducir
        int calificacion; // valor de la calificación introducida por el usuario
        int promedio; // promedio de las calificaciones

        // fase de inicialización
        total = 0; // inicializa el total
        contadorCalif = 1; // inicializa el contador del ciclo

        // fase de procesamiento
        while (contadorCalif <= 10) // itera 10 veces
        {
            Console.Write("Escriba calificación: "); // mensaje para el usuario
            calificacion = Convert.ToInt32(Console.ReadLine()); // lee calificación
            total = total + calificacion; // suma la calificación al total
            contadorCalif = contadorCalif + 1; // incrementa el contador en 1
        } // fin de while

        // fase de terminación
        promedio = total / 10; // división entera produce resultado entero

        // muestra el total y el promedio de las calificaciones
        Console.WriteLine("\nEl total de las 10 calificaciones es {0}", total);
        Console.WriteLine("El promedio de la clase es {0}", promedio);
    } // fin del método DeterminarPromedioClase

    // Fig. 5.7: repetición controlada por un centinela (-1 para salir)
    public void DeterminaPromedioClase()
    {
        int total; // suma de las calificaciones
        int contadorCalif; // número de calificaciones introducidas
        int calificacion; // valor de la calificación
        double promedio; // número con punto decimal para el promedio

        // fase de inicialización
        total = 0; // inicializa total
        contadorCalif = 0; // inicializa contador de ciclo

        // fase de procesamiento
        Console.Write("Escriba calificación o -1 para salir: ");
        calificacion = Convert.ToInt32(Console.ReadLine());

        // itera hasta que se lee el valor centinela del usuario
        while (calificacion != -1)
        {
            total = total + calificacion; // suma calificacion a total
            contadorCalif = contadorCalif + 1; // incrementa el contador

            Console.Write("Escriba calificación o -1 para salir: ");
            calificacion = Convert.ToInt32(Console.ReadLine());
        } // fin de while

        // fase de terminación
        if (contadorCalif != 0)
        {
            promedio = (double)total / contadorCalif;

            Console.WriteLine("\nEl total de las {0} calificaciones introducidas es {1}",
               contadorCalif, total);
            Console.WriteLine("El promedio de la clase es {0:F2}", promedio);
        } // fin del if
        else
            Console.WriteLine("No se introdujeron calificaciones");
    } // fin del método DeterminaPromedioClase
} // fin de la clase LibroCalificaciones