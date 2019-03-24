using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input <pyramid slot number>,<block letter>,<whether or not the block should be lit>.");
            string wholeString = Console.ReadLine();
            int CommaLocation = wholeString.IndexOf(',');
            int pradmidSlotNum = int.Parse(wholeString.Substring(0, CommaLocation));
            wholeString = wholeString.Substring(CommaLocation + 1);
            CommaLocation = wholeString.IndexOf(',');
            char blockLetter = char.Parse(wholeString.Substring(0,CommaLocation));
            wholeString = wholeString.Substring(CommaLocation + 1);
            bool lit = bool.Parse(wholeString);
            Console.WriteLine("Pyramid slot num is: "+pradmidSlotNum);
            Console.WriteLine("Block letter is: " + blockLetter);
            Console.WriteLine("Lit or not: " + lit);
        }
    }
}
