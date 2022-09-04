using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise2
{
    class PositiveOrNegative
    {
        public static void Main2()
        {
            int num;
            Console.Write("Test data : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Expected output:");
            if (num >= 0)

                Console.WriteLine("{0} is a positive number.\n", num);
            else
                Console.WriteLine("{0} is a negative number. \n", num);
            Console.ReadKey();
        }
    }
}
