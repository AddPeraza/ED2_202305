using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creando la tabla hash
            Dictionary<int, string> tablaHash = new Dictionary<int, string>();

            // Agregando los elemenos a la tabla
            tablaHash[1] = "Manzana";
            tablaHash[2] = "Platano";
            tablaHash[3] = "Naranja";

            //  provocando una colisión
            try
            {
                tablaHash.Add(2, "Pera");
            }
            catch (ArgumentException)
            {
                Console.WriteLine(" Existe una colision al ingregar la clave 2.");
            }

            // Acceder y mostrar el valor asociado a una clave
            Console.WriteLine("El valor de la clave 3 es: " + tablaHash[3]);

            // Verificar si una clave existe en la tabla hash
            if (tablaHash.ContainsKey(2))
            {
                Console.WriteLine("La clave 2 si existe en la tabla hash.");
            }

            // para eliminar un elemento de la tabla hash
            tablaHash.Remove(1);

            // Recorriendo la tabla 
            Console.WriteLine("Elementos de la tabla hash:");
            foreach (var elemento in tablaHash)
            {
                Console.WriteLine("Clave: " + elemento.Key + ", Valor: " + elemento.Value);
                Console.Read();
            }
            
        }
    }
    }

