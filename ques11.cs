using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise2
{
    class ques11
    {
        public static void Main2()
        {
            int i, c;
            Console.Write("Input number of terms : ");
            c = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= c; i++)
            {
                Console.Write("Number is : {0} and cube of the {1} is :{2} \n", i, i, (i * i * i));
            }
            Console.ReadKey();
        }

    }
}
