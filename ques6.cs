using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise2
{
    class ques6
    {
        public static void Main2()
        {
            int m, n;
           
            Console.Write("Input the  value of m :");
            m = Convert.ToInt32(Console.ReadLine());
            if (m != 0)
                if (m > 0)
                    n = 1;
                else
                    n = -1;
            else
                n = 0;
            Console.Write("The value of n = {0} \n\n", n);
            Console.ReadKey();

        }
    }
}
