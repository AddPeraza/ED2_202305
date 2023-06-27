using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetododeOrdenamient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese una serie de números:");
            string entrada = Console.ReadLine();

            
            string[] numeros = entrada.Split(' ');

            
            int[] array = new int[numeros.Length];
            for (int i = 0; i < numeros.Length; i++)
            {
                array[i] = int.Parse(numeros[i]);
            }

            BubbleSort(array);

           
            Console.WriteLine("Números ordenados de menor a mayor:");
            foreach (int numero in array)
            {
                Console.Write(numero + " ");
            }
            Console.Read();
        }

        static void BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    
                    if (array[j] > array[j + 1])
                    {
                        
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                   Console.WriteLine(j + " ");  
                }
            }
            
        }
        
    }
    
 }

