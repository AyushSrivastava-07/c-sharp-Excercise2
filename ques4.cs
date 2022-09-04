using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise2
{
    class LeapYear
    {
        public static void Main2()
        {
            int chk_year;
            Console.Write("Test data : ");
            chk_year = Convert.ToInt32(Console.ReadLine());

            if ((chk_year % 400) == 0)
                Console.WriteLine("{0} is a leap year.\n", chk_year);
            else if ((chk_year % 100) == 0)
                Console.WriteLine("{0} is not a leap year.\n", chk_year);
            else if ((chk_year % 4) == 0)
                Console.WriteLine("{0} is a leap year.\n", chk_year);
            else
                Console.WriteLine("{0} is not a leap year.\n", chk_year);
            Console.ReadKey();
        }
    }
}
