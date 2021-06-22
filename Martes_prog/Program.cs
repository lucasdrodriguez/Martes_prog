using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martes_prog
{
    class Program
    {

        static void Main(string[] args)
        {

            string[,] matrizNombres = new string[2,3];

            int[] arrayEdades = new int[5];

            arrayEdades[0] = 10;
            arrayEdades[1] = 12;
            arrayEdades[2] = 14;
            arrayEdades[3] = 15;

            for (int i = 0; i < arrayEdades.Length; i++)
            {
                Console.WriteLine($"{arrayEdades[i]}");
            }


            Console.ReadKey();

        }

    }
}
