using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_CODWER
{
    internal class LanguageBasics1
    {
        public static void Excersise1()
        {
            int number;
            bool isValid = false;

            do
            {
                Console.WriteLine("Please insert a number, that contains at least 3 digits.");
                string response = Console.ReadLine();

                if (int.TryParse(response, out number) && response.Length >= 3)
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("The number is invalid. Please insert a 3-digit number.");
                }
            } while (!isValid);

            int reversedNumber = ReverseNumber(number);
            Console.WriteLine("The mirrored number is - " + reversedNumber);

            if (IsPerfectSquare(reversedNumber))
            {
                Console.WriteLine("The mirrored number is a perfect square.");
            }
            else
            {
                Console.WriteLine("The mirrored number is not a perfect square.");
            }
        }
    
        public static int ReverseNumber(int num)
        {
            int reversedNum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                reversedNum = reversedNum * 10 + digit;
                num /= 10;
            }

            return reversedNum;
        }

        public static bool IsPerfectSquare(int num)
        {
            int sqrt = (int)Math.Sqrt(num);
            return sqrt * sqrt == num;
        }
    }
}
