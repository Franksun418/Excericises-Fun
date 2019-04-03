using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    /// <summary>
    /// Exercise 1 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Tests LastIndexOf and AllIndexesOf methods
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // build test dynamic array
            UnorderedIntDynamicArray unorderedIntDynamicArray = new UnorderedIntDynamicArray();

            unorderedIntDynamicArray.Add(1);
            unorderedIntDynamicArray.Add(3);
            unorderedIntDynamicArray.Add(5);
            unorderedIntDynamicArray.Add(4);
            unorderedIntDynamicArray.Add(4);
            unorderedIntDynamicArray.Add(2);
            unorderedIntDynamicArray.Add(0);
            // test LastIndexOf with one item in dynamic array
            Console.WriteLine(unorderedIntDynamicArray.LastIndexOf(0).ToString());
            // test LastIndexOf with multiple items in the dynamic array
            Console.WriteLine(unorderedIntDynamicArray.LastIndexOf(4).ToString());
            // test LastIndexOf with item not in dynamic array
            Console.WriteLine(unorderedIntDynamicArray.LastIndexOf(6).ToString());
            // test AllIndexesOf with one item in dynamic array
            PrintIndexes(unorderedIntDynamicArray.AllIndexesOf(1));
            // test AllIndexesOf with multiple items in dynamic array
            PrintIndexes(unorderedIntDynamicArray.AllIndexesOf(4));
            // test AllIndexesOf with item not in dynamic array
            PrintIndexes(unorderedIntDynamicArray.AllIndexesOf(8));
            Console.WriteLine();
        }

        public static void PrintIndexes(List<int> nums)
        {
            if (nums.Count!=0)
            {
                foreach (int i in nums)
                {
                    Console.Write(i.ToString() + " ");
                }
                Console.WriteLine();
            }
            else {
                Console.WriteLine("Empty list!");
            }
        }
    }
}
