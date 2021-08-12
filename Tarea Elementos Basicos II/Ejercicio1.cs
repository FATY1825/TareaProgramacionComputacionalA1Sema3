using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Elementos_Basicos_II
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            //escribir un ciclo que permita capturar los valores
            //almacenar en el arreglo de numbers con un tamaño de 10

            int[] nume = new int[10];

            for (int f = 0; f < nume.Length; f++) 
            {
                Console.WriteLine("Introduzca un numero");
                nume[f] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Los numeros que usten ingreso son:");
            foreach (int item in nume)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
