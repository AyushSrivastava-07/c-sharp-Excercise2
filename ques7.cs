using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise2
{
    class ques7
    {
        public static void Main2()
        {
            float Height;
            Console.Write("\n\n");
            Console.Write("Test Data:");
            Height = Convert.ToInt32(Console.ReadLine());

            if (Height < 150.0)
                Console.Write("The person is Dwarf. \n\n");
            else if ((Height >= 150.0) && (Height <= 165.0))
                Console.Write("The person is  average heighted. \n\n");
            else if ((Height >= 165.0) && (Height <= 195.0))
                Console.Write("The person is taller. \n\n");
            else
                Console.Write("Abnormal height.\n\n");
            Console.ReadKey();
        }
    }
}
