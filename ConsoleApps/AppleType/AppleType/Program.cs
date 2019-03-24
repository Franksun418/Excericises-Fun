using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleType
{
    class Program
    {
        static void Main(string[] args)
        {
            //Apple apple = new Apple();
            Apple apple = new Apple(false,5);
            Console.WriteLine("How many apples would you like to eat?");
            float eatAmount = float.Parse(Console.ReadLine());
            apple.eatMe(eatAmount);

        }
    }
    public class Apple {
        bool pesticided;
        float amountLeft;
        AppleTypes appleType;
        public bool Pesticided
        {
            get { return pesticided; }
        }
        public float AmountLeft
        {
            get { return amountLeft; }
        }
        public AppleTypes AppleType
        {
            get { return appleType; }
        }


        public Apple(bool pesticided, float amount) {
            this.pesticided = pesticided;
            amountLeft = amount;
        }

        public Apple() : this(false,10)
        {

        }

        public void eatMe(float size) {
            if (pesticided)
            {
               Console.WriteLine("It is not origanic!");
                return;
            }

            while (amountLeft > size)
            {
                    Console.WriteLine("You ate " + size + " of " + amountLeft + " apples");
                    amountLeft -= size; 
            }

            if (amountLeft < size)
            {
                Console.WriteLine("Not enough apples for u to eat! You ate " + amountLeft + " apples and that's all there are. " + (size - amountLeft) + " amount of apples are not satisified!");
                amountLeft = 0;
            }
            else if(amountLeft==size)
            {
                Console.WriteLine("Well done! You have eaten all the apples.");
                amountLeft = 0;
            }
        }

    }
    public enum AppleTypes {
        a,
        b,
        c,
    }
}
