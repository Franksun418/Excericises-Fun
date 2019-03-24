using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which month is your birthday month?");
            String month = Console.ReadLine();
            Console.WriteLine("Which day is your birthday on that month?");
            int day = int.Parse(Console.ReadLine());
            string shortCase;
            shortCase = GetShortCase(day);
            Console.WriteLine("Your were born on " + day +shortCase + " of " + month+".");
            int lastDay = day - 1;
            shortCase = GetShortCase(lastDay);
            Console.WriteLine("You will be sent a gift reminder on " + lastDay + shortCase + " of " + month + ".");
        }

        public static string GetShortCase(int d)
        {
            string s;
            if (d % 10 == 1)
            {
                s = "st";
            }
            else if (d % 10 == 2)
            {
                s = "nd";
            }
            else if (d % 10 == 3)
            {
                s = "rd";
            }
            else
            {
                s = "th";
            }
            return s;
        }
    }
}
