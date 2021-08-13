using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Elementos_Basicos_II
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            //Crear un diccionario con los datos de 4 familiares, almacene el nombre y la edad incluya sus datos 
            //e imprimir los datos del diccionario ordenados.

            Dictionary<string, int> familia = new Dictionary<string, int>();
            familia.Add("Francisca Santos de Ayala", 74);
            familia.Add("Maria Ayala Santos", 52);
            familia.Add("Victoria Ayala Santos", 43);
            familia.Add("Fatima Del Carmen Ayala Santos", 18);

            foreach (KeyValuePair<string, int> employee in familia)
            {
                Console.WriteLine("Nombre: {0}, Edad: {1}", employee.Key, employee.Value);

            }

            Console.WriteLine("---------------------------------------------------------------------");

            var dici = familia.Keys.ToList();
            dici.Sort();

            Console.WriteLine("Diccionario Familiar Ordenado");
            foreach (var ite in dici)
            {
                Console.WriteLine("{0}: {1}", ite, familia[ite]);
            }
            Console.ReadKey();
        }
    }
}
