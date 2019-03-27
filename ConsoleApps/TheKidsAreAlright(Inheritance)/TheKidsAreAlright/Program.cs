using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheKidsAreAlright
{
    class Program
    {
        static void Main(string[] args)
        {
            Kid kid = new Kid();
            kid.PrintMessage();
            Disobedient disobedient = new Disobedient();
            disobedient.OnlyME();  //child class totally inherented everything from the father class.
            Kid disbobedientKid = new Disobedient(); //This works but we dont do it.
        }
    }
}
