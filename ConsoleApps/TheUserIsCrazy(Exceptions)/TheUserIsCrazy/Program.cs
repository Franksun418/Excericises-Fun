using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheUserIsCrazy
{
    class Program
    {
        static int num;
        static void Main(string[] args)
        {
            while (true) {
                try
                {
                    Console.WriteLine("Input an integer please:");
                    num = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("What you input is not an integer. Try again.");
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("What you input is too big or small. Try again");
                }
                finally {
                    Console.WriteLine("HAHA");
                }
            }
        }
    }
}
