# LibroCalificaciones — Repetición Controlada por Contador y por Centinela

Cálculo del promedio de una clase mediante ciclos `while` controlados por contador y por valor centinela, con C# y .NET 10.

**Universidad Tecnológica de Panamá** — Facultad de Ingeniería de Sistemas Computacionales
Herramientas de Programación Aplicada III (.Net) · Grupo 1IL133 · II Semestre 2026

- **Estudiante:** Diego Sanjur
- **Facilitadora:** Irina Fong

---

## Descripción

Este repositorio contiene una aplicación de consola basada en la clase `LibroCalificaciones`, que representa el libro de calificaciones de un curso. La clase implementa dos formas de calcular el promedio de la clase, correspondientes a las Figuras 5.5 y 5.7: una con un número fijo de calificaciones (repetición controlada por contador) y otra con un número indefinido que termina al introducir un valor especial (repetición controlada por centinela).

Ambos métodos siguen la misma división en tres fases: inicialización de las variables, procesamiento de las calificaciones dentro del ciclo y terminación, donde se calcula y muestra el resultado. La clase de prueba `PruebaLibroCalificaciones` crea el objeto y ofrece un menú para ejecutar cualquiera de las dos versiones tantas veces como se desee.

## Estructura del repositorio

```
LibroCalificaciones/
├── LibroCalificaciones.cs         Clase con la lógica de los dos promedios
└── PruebaLibroCalificaciones.cs   Método Main con el menú de opciones
```

---

## Clase LibroCalificaciones

Almacena el nombre del curso en el campo privado `nombreCurso`, al que se accede mediante la propiedad `NombreCurso`. El constructor recibe el nombre y lo asigna a través de la propiedad en lugar de hacerlo directamente sobre el campo, de modo que cualquier validación que se agregue luego al `set` se aplique también al crear el objeto. El método `MostrarMensaje` imprime la bienvenida usando esa misma propiedad.

**Conceptos:** encapsulamiento, campos privados, propiedades con `get` y `set`, constructores, formato compuesto con `Console.WriteLine`.

**Diagrama UML**

```
┌────────────────────────────────────────────┐
│           LibroCalificaciones              │
├────────────────────────────────────────────┤
│ - nombreCurso: string                      │
│ + <<property>> NombreCurso: string         │
├────────────────────────────────────────────┤
│ + LibroCalificaciones(nombre: string)      │
│ + MostrarMensaje()                         │
│ + DeterminarPromedioClase()                │
│ + DeterminaPromedioClase()                 │
└────────────────────────────────────────────┘
```

## Opción 1: Promedio con contador (Fig. 5.5)

El método `DeterminarPromedioClase` solicita exactamente 10 calificaciones. La variable `contadorCalif` inicia en 1 y el ciclo `while` se repite mientras sea menor o igual a 10; en cada vuelta se lee una calificación, se suma a `total` y se incrementa el contador.

Al terminar el ciclo, el promedio se obtiene dividiendo el total entre 10. Como `total` y `promedio` son de tipo `int`, la división es entera y la parte decimal se descarta: un total de 855 produce un promedio de 85, no de 85.5.

**Conceptos:** repetición controlada por contador, ciclo `while`, conversión con `Convert.ToInt32`, división entera.

## Opción 2: Promedio con centinela (Fig. 5.7)

El método `DeterminaPromedioClase` no conoce de antemano cuántas calificaciones se introducirán. Lee una primera calificación antes del ciclo y repite mientras el valor leído sea distinto de -1, el valor centinela. Dentro del ciclo suma la calificación, incrementa el contador y lee la siguiente, de modo que el -1 nunca se suma al total.

En la fase de terminación se verifica con un `if` que se haya introducido al menos una calificación, lo que evita una división entre cero. El promedio se declara como `double` y el total se convierte explícitamente con `(double)` antes de dividir, forzando una división de punto flotante; el resultado se muestra con dos decimales mediante el especificador `{0:F2}`.

**Conceptos:** repetición controlada por centinela, lectura previa al ciclo, conversión explícita (*casting*), promoción de tipos, especificadores de formato, validación contra división entre cero.

## Clase PruebaLibroCalificaciones

Contiene el método `Main`, que crea un objeto `LibroCalificaciones` para el curso *CS101 Introducción a la programación en C#* y muestra el mensaje de bienvenida. Después presenta un menú dentro de un ciclo `while` controlado por la variable booleana `salir`; un `switch` sobre la opción escrita llama al método correspondiente, termina el programa con la opción 3 o avisa si la opción no es válida.

**Conceptos:** instanciación de objetos, llamadas a métodos de instancia, ciclo `while` con bandera booleana, estructura `switch` sobre cadenas.

**Diagrama UML**

```
┌────────────────────────────────────────────┐
│        PruebaLibroCalificaciones           │
├────────────────────────────────────────────┤
├────────────────────────────────────────────┤
│ + <<static>> Main(args: string[])          │
└────────────────────────────────────────────┘
                    │ usa
                    ▼
┌────────────────────────────────────────────┐
│           LibroCalificaciones              │
└────────────────────────────────────────────┘
```
