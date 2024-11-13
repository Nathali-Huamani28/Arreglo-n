using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Solicitar el tamaño del arreglo
        Console.Write("Ingrese la cantidad de elementos del arreglo: ");
        int n = int.Parse(Console.ReadLine());

        // Crear y llenar el arreglo
        List<int> arreglo = new List<int>();
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Ingrese el elemento {i + 1}: ");
            arreglo.Add(int.Parse(Console.ReadLine()));
        }

        // Mostrar el arreglo original
        Console.WriteLine("\nArreglo original:");
        foreach (int elemento in arreglo)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();

        // Solicitar la posición a eliminar
        Console.Write("\nIngrese la posición del elemento que desea eliminar (1 a n): ");
        int posicion = int.Parse(Console.ReadLine()) - 1;

        // Validar que la posición esté dentro del rango
        if (posicion >= 0 && posicion < arreglo.Count)
        {
            // Eliminar el elemento
            arreglo.RemoveAt(posicion);

            // Mostrar el arreglo después de la eliminación
            Console.WriteLine("\nArreglo después de eliminar el elemento:");
            foreach (int elemento in arreglo)
            {
                Console.Write(elemento + " ");
            }
        }
        else
        {
            Console.WriteLine("Posición no válida.");
        }

    }
}