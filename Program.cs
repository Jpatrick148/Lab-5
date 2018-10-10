using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter an Integer from 1 to 10");
            int num = int.Parse(Console.ReadLine());

            long fact = Factorial(num);

            Console.WriteLine("The Factorial of {0} is {1}", num, fact);

            Console.ReadLine();
        }

        public static long Factorial(int i)
        {

            if (i == 0)
            {
                return 1;
            }

            return i * Factorial(i - 1);
        }
        
    }
}
