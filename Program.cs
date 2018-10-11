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
            do
            {
                Console.WriteLine("Please enter an Integer from 1 to 20");
                long num;
                while (true)
                {
                 num = long.Parse(Console.ReadLine());
                    if (num <=20)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter an Integer from 1 to 20");
                    }
                }
                long fact = Factorial(num);               
                Console.WriteLine("The Factorial of {0} is {1}", num, fact);
            }
            while (Continue() == true);
        }

        public static long Factorial(long i)
        {
            return i == 0 ? 1 : i * Factorial(i - 1);
        }

        public static bool Continue()
        {
            Console.WriteLine("Again? {Y/N}");
            string input = Console.ReadLine().ToLower();
            if (input == "y")
            {
               return true;
            }
            else if (input == "n")
            {
               return false;                
            }
            else Console.WriteLine("I'm sorry but I do not understand.");
            return Continue();
        }
    }
}
