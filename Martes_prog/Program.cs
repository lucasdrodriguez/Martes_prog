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
            int edadesSumadas;
            int kmSumados;


            int[] arrayEdades = new int[5];


            Funciones2.MostrarMensajito();



            arrayEdades[0] = 10;
            arrayEdades[1] = 12;
            arrayEdades[2] = 14;
            arrayEdades[3] = 15;

            AgregarAlArray(arrayEdades, 499);

            Console.WriteLine(arrayEdades[4]);

            int valorInicial = 9;

            valorInicial = Funciones.ModificarInt(valorInicial, 200);

            Console.WriteLine(valorInicial);

            //int[] arrayKm = { 1056, 321, 312, 455, 66, 6 };

            //edadesSumadas = SumarEnterosArray(arrayEdades);
            //kmSumados = SumarEnterosArray(arrayKm);



            Console.ReadKey();

        }




        static void AgregarAlArray(int[] auxArray, int num)
        {
            int[] arrayCopia=new int[auxArray.Length];

            /*
              auxArray                     arrayCopia   
                0     10                   0    50
                1     40                   1    60
                2     50                   2    11
                3     60                   3    0
                4     11                   4    0


                      */

            auxArray.CopyTo(arrayCopia, 0);



            for (int i = 0; i < auxArray.Length; i++)
            {
                if(auxArray[i] == 0)
                {
                    auxArray[i] = num;
                }
            }


        }








        /// <summary>
        ///  Este metodo suma los valores incluidos en todo el array
        /// </summary>
        /// <param name="auxArray"> array del cual se van a sumar los valores que incluye</param>
        /// <returns> devuelve la suma </returns>
        static int SumarEnterosArray(int[] auxArray)
        {
            int suma = 0;

            for (int i = 0; i < auxArray.Length; i++)
            {
                suma += auxArray[i];
            }
            return suma;

        }



        static void MostrarMensaje(string mensaje, bool repetir)
        {
            Console.WriteLine(mensaje);

            if (repetir == true)
            {
                Console.WriteLine(mensaje);

            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static int DevolverEdad()
        {
            return 10;
        }



    }
}
