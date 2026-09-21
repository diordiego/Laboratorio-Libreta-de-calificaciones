// Fig. 5.7: LibroCalificaciones.cs
// Clase LibroCalificaciones que resuelve el problema del promedio de la clase
// usando la repetición controlada por un centinela.
using System;

public class LibroCalificaciones2
{
    private string nombreCurso; // nombre del curso que representa este LibroCalificaciones

    // el constructor inicializa nombreCurso
    public LibroCalificaciones2(string nombre)
    {
        NombreCurso = nombre; // inicializa nombreCurso utilizando la propiedad
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

    // muestra un mensaje de bienvenida al usuario de LibroCalificaciones
    public void MostrarMensaje()
    {
        Console.WriteLine("Bienvenido al libro de calificaciones para\n{0}!\n",
           NombreCurso);
    } // fin del método MostrarMensaje

    // determina el promedio de un número arbitrario de calificaciones
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
        // mensaje para recibir como entrada la calificación del usuario
        Console.Write("Escriba calificación o -1 para salir: ");
        calificacion = Convert.ToInt32(Console.ReadLine());

        // itera hasta que se lee el valor centinela del usuario
        while (calificacion != -1)
        {
            total = total + calificacion; // suma calificacion a total
            contadorCalif = contadorCalif + 1; // incrementa el contador

            // mensaje para recibir como entrada la siguiente calificación del usuario
            Console.Write("Escriba calificación o -1 para salir: ");
            calificacion = Convert.ToInt32(Console.ReadLine());
        } // fin de while

        // fase de terminación
        // si el usuario introdujo cuando menos una calificación...
        if (contadorCalif != 0)
        {
            // calcula el promedio de todas las calificaciones introducidas
            promedio = (double)total / contadorCalif;

            // muestra el total y el promedio (con dos dígitos de precisión)
            Console.WriteLine("\nEl total de las {0} calificaciones introducidas es {1}",
               contadorCalif, total);
            Console.WriteLine("El promedio de la clase es {0:F2}", promedio);
        } // fin del if
        else // no se introdujeron calificaciones, entonces mostrar mensaje de error
            Console.WriteLine("No se introdujeron calificaciones.");
    } // fin del método DeterminaPromedioClase
} // fin de la clase LibroCalificaciones