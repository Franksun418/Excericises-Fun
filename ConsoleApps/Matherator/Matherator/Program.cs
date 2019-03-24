using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matherator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input number range(from 0 to ?, Default(empty) is 100): ");
            int range = int.Parse(Console.ReadLine());
            Matherator matherator = new Matherator(range);
            Console.WriteLine();
            Console.WriteLine("You want to get Nth Even Number: ");
            int nth = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("The rank of "+nth+" of the even numbers is "+ matherator.GetNthEvenNumber(nth)+".");
            Console.WriteLine();
            Console.WriteLine("The 10th even number is "+ matherator.GetTenthEvenNumber()+".");
            Console.WriteLine();
            Console.WriteLine("You want to print M to N. M is: ");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine("You want to print M to N. N is: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();
            matherator.PrintMtoN(M, N);
            Console.WriteLine();
            matherator.PrintOneToTen();
        }
    }

    public class Matherator {

        public Matherator() :this(100){

        }

        List<int> allNums = new List<int>();
        public Matherator(int m)
        {
            for (int i = 0; i < m; i++)
            {
                if (i % 2 != 0)
                {
                    allNums.Add(i);
                }
            }
        }
        public int GetNthEvenNumber(int n)
        {
            return allNums[n];
        }
        public int GetTenthEvenNumber() {
            return allNums[9];
        }
        public void PrintMtoN(int m, int n)
        {
            for (int i = m; i < n+1; i++) {
                Console.WriteLine(i);
            }
        }

        public void PrintOneToTen() {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
