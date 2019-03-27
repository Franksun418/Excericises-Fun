using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheKidsAreAlright
{
    class Disobedient : Kid
    {
        public Disobedient() : base()
        {

        }

        public override void PrintMessage()
        {
            Console.WriteLine("I am disobedient.");
        }
    }
}
