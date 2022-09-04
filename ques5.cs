using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise2
{
    class vote
    {
        public static void Main2()
        {
            int vote_age;
            Console.Write("Input the age of the candidate : ");
            vote_age = Convert.ToInt32(Console.ReadLine());
            if (vote_age < 18)
            {
                Console.Write("Sorry, You are not eligible to caste your vote.\n");
                Console.Write("You would be able to caste your vote after {0} year.\n\n", 18 - vote_age);
            }
            else
                Console.Write("Congratulation! You are eligible for casting your vote.\n\n");
            Console.ReadKey();
        }
    }
}
