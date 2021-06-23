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


            while (MainMenu())
            {
            }
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

        static void MatrizPersonas()
        {
            string[,] personas = new string[3, 4];

            personas[0, 0] = "Giuliana";
            personas[1, 0] = "Juan";
            personas[2, 0] = "Lucy";

            personas[0, 1] = "Melluso";
            personas[1, 1] = "Perez";
            personas[2, 1] = "Cortes";

            personas[0, 2] = "23";
            personas[1, 2] = "20";
            personas[2, 2] = "21";

            personas[0, 3] = "Perro";
            personas[1, 3] = "Gato";
            personas[2, 3] = "Pez";

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
            Console.ReadKey();

        }



    }

}

