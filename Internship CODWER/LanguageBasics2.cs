using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_CODWER
{
    internal class LanguageBasics2
    {
        public static void Excersise2()
        {
            Console.WriteLine("Please insert several number. The numbers do not have to be integers.");
            string input = Console.ReadLine();

            string[] stringNumbers = input.Split(' ');
            double[] numbers = new double[stringNumbers.Length];
            double minNumber = double.MaxValue;

            for (int i = 0; i < stringNumbers.Length; i++)
            {
                if (double.TryParse(stringNumbers[i], out double number))
                {
                    numbers[i] = number;

                    if (numbers[i] % 1 != 0)
                    {
                        Console.Write(numbers[i].ToString() + ' ');
                        if (numbers[i] < minNumber)
                        {
                            minNumber = numbers[i];
                        }
                        
                    }
                }
                else
                {
                    Console.WriteLine("Some of the data is not a number.");
                }
            }
            Console.WriteLine("\nThe smallest number is: " + minNumber);
        }
    }
}
