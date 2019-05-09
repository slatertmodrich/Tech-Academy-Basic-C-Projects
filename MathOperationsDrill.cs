using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationsDrill
{
    class MathOperationsDrill
    {
        static void Main(string[] args)
        {

            int timesFifty;
            Console.WriteLine("Enter a number to have it multiplied by 50:");
            timesFifty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(timesFifty * 50);
            Console.ReadLine();


            int plusTwentyFive;
            Console.WriteLine("Enter a number to add 25 to it:");
            plusTwentyFive = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(plusTwentyFive + 25);
            Console.ReadLine();


            float divideTwelvePointFive;
            Console.WriteLine("Enter a number to divide it by 12.5:");
            divideTwelvePointFive = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(divideTwelvePointFive / 12.5);
            Console.ReadLine();


            bool trueOrFalse;
            long input1;
            Console.WriteLine("Enter any number you can think of:");
            input1 = Convert.ToInt64(Console.ReadLine());
            trueOrFalse = (input1 > 50);

            if (trueOrFalse == true)
            {
                Console.WriteLine("Your number, " + input1 + ", is greater than 50.");
            };

            if (trueOrFalse == false)
            {
                Console.WriteLine("Your number, " + input1 + ", is less than 50.");
            };
            Console.ReadLine();


            int modulus;
            Console.WriteLine("Enter a whole number to divide it by 7 and show the remainder:");
            modulus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(modulus % 7);
            Console.ReadLine();





        }
    }
}
