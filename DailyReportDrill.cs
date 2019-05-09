using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportDrill
{
    class DailyReportDrill
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy Portland");

            Console.WriteLine("Student Daily Report: >>>Press Enter to begin.");
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();
            Console.WriteLine("We hope you are enjoying the " + currentCourse + " course so far! >>>Enter to continue.");
            Console.ReadLine();

            Console.WriteLine("What page number?");
            string currentPage = Console.ReadLine();
            int pageNumber = Convert.ToInt16(currentPage);
            Console.WriteLine("Great job getting to page " + pageNumber + ", every minute spent learning will help you become a better developer :) >>>Enter to continue.");
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer true or false.");
            string helpStatus = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(helpStatus);
            if(needHelp == true)
                {
                Console.WriteLine("Email an instructor at services@learncodinganywhere.com to get some personalized help and extra tips! >>>Enter to continue.");
                }

            else if(needHelp == false)
                {
                Console.WriteLine("YOU ARE A CODING MASTER! >>>Enter to continue.");      
                }
            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you would like to share? Please be specific.");
            string positiveExperience = Console.ReadLine();
            Console.WriteLine("Thank you for your feedback, and we are so glad you are enjoying the course! >>>Enter to continue.");
            Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string Feedback = Console.ReadLine();
            Console.WriteLine("Thank you for your feedback, your response has been recorded. >>>Enter to continue.");
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string studyTime = Console.ReadLine();
            int hoursStudied = Convert.ToInt16(studyTime);
            if(hoursStudied > 6)
                 {
                    Console.WriteLine("Great Job! You are on track to finishing the course.");
                 }
            else if(hoursStudied < 6)
                 {
                    Console.WriteLine("Unless you are a part time student, we recommend putting in more hours of study time to stay on track.");
                 }

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
      

        }
    }
}
