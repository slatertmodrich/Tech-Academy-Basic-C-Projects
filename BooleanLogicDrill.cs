using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicDrill
{
    class BooleanLogicDrill
    {
        static void Main(string[] args)
        {
            Console.Write("Find out if you qualify for our Car Insurance Program: Press Enter to Start");
            Console.ReadLine();



            Console.WriteLine("What is your age?");
            int age = Convert.ToInt16(Console.ReadLine());
            bool tooYoung = (age < 16);

            Console.WriteLine("Have you ever had a DUI?");
            string dui = Console.ReadLine();
            bool noDui = (dui == "no" || dui == "No");
            bool yesDui = (dui == "yes" || dui == "Yes");

            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt16(Console.ReadLine());
            bool tooFast = (tickets > 3);

           


            Console.WriteLine("Your age: " +age);

            Console.WriteLine("DUI Present?");
            if(noDui == true)
            {
                Console.WriteLine("False");
            }
            if(yesDui == true)
            {
                Console.WriteLine("True");
            }


            Console.WriteLine("Number of speeding tickets: " + tickets);



            Console.WriteLine("Qualified?");
            if (noDui == true && tooYoung == false && tooFast == false)
            {
                Console.WriteLine("Yes! You qualify!");
            }

            if (yesDui == true || tooYoung == true || tooFast == true)
            {
                Console.WriteLine("Sorry, you do not qualify.");
            }

            Console.ReadLine();








        }
    }
}
