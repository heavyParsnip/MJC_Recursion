using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJC_RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int value;

            do
            {
                Console.WriteLine("Enter a number:");
                input = Console.ReadLine().Trim();

                if (input == "q")
                {
                    break;
                }
                else if (int.TryParse(input, out value))
                {
                    Console.WriteLine(Fibofy(value));
                }
                else
                {
                    Console.WriteLine("Bad Input.");
                }
            } while (input != "q");
        }

        //Fibonacci iteration
        //F(n) = F(n-1) + F(n-2)
        static int Fibofy(int n)
        {

            if (n == 0)
            {
                return 0;
            }
            else if(n == 1)
            {
                return 1;
            }
            else if (n > 1)
            {
                return Fibofy(n - 1) + Fibofy(n - 2);
            }
            else
            {
                Console.WriteLine($"{n} is not a valid number.");
                return -1;
            }
        }
    }
}

