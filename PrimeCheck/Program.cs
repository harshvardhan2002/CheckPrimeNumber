using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int number, countDivisor = 0;
            Console.WriteLine("Write the number to check: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number <= 1)
            {
                Console.WriteLine($"{number} is not a prime num");
                return;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    countDivisor++;
                    break;
                }
            }
            string result = CheckPrime(countDivisor, number);
            Console.WriteLine(result);
        }
        public  static string CheckPrime(int countDivisor, int number)
        {
            if (countDivisor == 0)
                return $"{number} is a prime number";
            return $"{number} is not a prime number";
        }

    }
}
