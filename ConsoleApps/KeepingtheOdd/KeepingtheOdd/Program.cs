using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepingtheOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                integers.Add(i);
            }
            for (int i = 0; i < integers.Count; i++)
            {
                Console.WriteLine(integers[i]);
            }

            Console.WriteLine();

            for (int i = integers.Count - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    integers.Remove(integers[i]);
                }
            }

            for (int i = 0; i < integers.Count; i++)
            {
                Console.WriteLine(integers[i]);
            }

            integers.Clear();

            Console.WriteLine();

            for (int i = 1; i < 6; i++)
            {
                integers.Add(i);
            }

            for (int i = 0; i < integers.Count; i++)
            {
                if (i < 3)
                {
                    integers.Remove(integers[i]);
                }
            }

            for (int i = 0; i < integers.Count; i++)
            {
                Console.WriteLine(integers[i]);
            }
        }
    }
}
