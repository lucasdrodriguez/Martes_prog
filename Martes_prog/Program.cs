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

            string[,] matrizNombres = new string[2, 3];

            int[] arrayEdades = new int[5];

            arrayEdades[0] = 10;
            arrayEdades[1] = 12;
            arrayEdades[2] = 14;
            arrayEdades[3] = 15;

            for (int i = 0; i < arrayEdades.Length; i++)
            {
                Console.WriteLine($"{arrayEdades[i]}");
            }

            while (MainMenu())
            {
            }




            /// <summary>
            /// Funcion generica para mostrar menues
            /// </summary>
            /// <param name="ShowMenu"></param>
            /// <returns></returns>
            static void ShowMenu(string[] menu)
            {
                int ind = 1;
                for (var i = 0; i < menu.Length; i++)
                {
                    Console.WriteLine($"{ind}) {menu[i]}");
                    ind++;
                }

            }

            static void MenuHeading(string text)
            {
                Console.WriteLine(text);
                Console.WriteLine("------------------------------------");
            }

            /// <summary>
            /// Fucion que maneja el menu principal
            /// </summary>
            /// <returns></returns>
            static bool MainMenu()
            {
                Console.Clear();

                MenuHeading("Bienvenidx! Elija una opción para continuar:");

                string[] menu =
                    {
                                    "OP 1",
                                    "OP 2",
                                    "OP 3",
                                    "OP 4"
                                };

                ShowMenu(menu);

                Console.Write("\r\nSeleccionar una opción: ");

                //switch de menu
                switch (Console.ReadLine())
                {
                    case "1":
                        return true;
                    case "2":
                        return true;
                    case "3":
                        return true;
                    case "4":
                        return false;
                    default:
                        return true;
                }
            }




            Console.ReadKey();

        }

    }
}
