using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection = 0;
            while (selection != 4)
            {
                Console.WriteLine("*********************");
            Console.WriteLine();
            Console.WriteLine("Menu: ");
            Console.WriteLine();
            Console.WriteLine("1-NewGame");
            Console.WriteLine();
            Console.WriteLine("2-LoadGame");
            Console.WriteLine();
            Console.WriteLine("3-Options");
            Console.WriteLine();
            Console.WriteLine("4-Quit");
            Console.WriteLine();
            Console.WriteLine("*********************");

            Console.WriteLine();
            Console.WriteLine("Please input your choice(1-4).");
            selection = int.Parse(Console.ReadLine());



                while (selection < 1 || selection > 4)
            {
                Console.WriteLine("Wrong Input. Please input your choice(1-4).");
                selection = int.Parse(Console.ReadLine());
            }

                if (selection == 1)
                {
                    Console.WriteLine("Creating an new game...");
                }
                else if (selection == 2)
                {
                    Console.WriteLine("Loading...");
                }
                else if (selection == 3)
                {
                    Console.WriteLine("Loading Options...");
                }
            }

        }
    }
}
