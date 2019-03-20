/*******************************************************************
Programa de Introduccion a colecciones en c# del ejecicio en clase de la materia PCYP donde dado *****/////


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUI
{
    class Program
    {
        private static string[] colors = { "MAGENTA", "RED", "WHITE", "BLUE", "CYAN" };
        private static string[] removeColors = { "RED", "WHITE", "BLUE" };
        static void Main(string[] args)
        {


            List<String> colores = new List<string>();
            List<String> removecolors = new List<string>();
          
            string rojo = "RED";
            string blanco = "WHITE";
            string azul = "BLUE";
            string magenta = "MAGENTA";
            foreach (var item in colors)
            {
                colores.Add(item);
            }

            foreach (var item in colores)
            {
                Console.WriteLine(item);
            }
            for(int i=0;i<colors.Length;i++){
                if (colors[i] == rojo || colors[i] == blanco || colors[i] == azul)
                {
                    colores.Remove(colors[i]);
                }
                //else
                //{                   
                //    removecolors.Add(colors[i]);
                    
                //}
                

            }

            // List<String> listanueva = new List<string>(colores);
            Console.WriteLine();
            Console.WriteLine("lista final con eliminados");
            foreach (var item in colores)
            {
                Console.WriteLine(item);
            }




        }
    }
}
