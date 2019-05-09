using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incomeComparisonDrill
{
    class IncomeComparisonDrill
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program: Press Enter");
            Console.ReadLine();

            Console.WriteLine("Person 1:");

            Console.WriteLine("Hourly rate?");
            string hourlyRate1 = Console.ReadLine();
            int rate1 = Convert.ToInt32(hourlyRate1);
            
            Console.WriteLine("Hours worked per week?");
            string weekHours1 = Console.ReadLine();
            int hours1 = Convert.ToInt32(weekHours1);

            Console.WriteLine("Person 2:");

            Console.WriteLine("Hourly rate?");
            string hourlyRate2 = Console.ReadLine();
            int rate2 = Convert.ToInt32(hourlyRate2);

            Console.WriteLine("Hours worked per week?");
            string weekHours2 = Console.ReadLine();
            int hours2 = Convert.ToInt32(weekHours2);

            int salary1 = (rate1 * hours1 * 52);
            int salary2 = (rate2 * hours2 * 52);
            string annualSalary1 = Convert.ToString(salary1);
            string annualSalary2 = Convert.ToString(salary2);

            Console.WriteLine("Annual Salary of Person 1 (Assuming no vacations taken):");
            Console.WriteLine(annualSalary1);

            Console.WriteLine("Annual Salary of Person 2 (Assuming no vacations taken):");
            Console.WriteLine(annualSalary2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            if (salary1 > salary2)
            {
                Console.WriteLine("Yes.");
            }
            
            else
            {
                Console.WriteLine("No.");
            }

            Console.WriteLine("Press Enter to exit program");
            Console.ReadLine();







        }
    }
}
