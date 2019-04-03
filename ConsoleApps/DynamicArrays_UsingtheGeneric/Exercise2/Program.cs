using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    /// <summary>
    /// Exercise 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Uses ordered generic dynamic array
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(2, 4);
            Rectangle rectangle2 = new Rectangle(2, 3);
            Console.WriteLine(rectangle1.CompareTo(rectangle2).ToString());

            OrderedDynamicArray<Rectangle> orderedDynamicArray = new OrderedDynamicArray<Rectangle>();
            orderedDynamicArray.Add(new Rectangle(2, 3));
            orderedDynamicArray.Add(new Rectangle(2, 2));
            orderedDynamicArray.Add(new Rectangle(2, 1));
            orderedDynamicArray.Print();
        }

    }
}
