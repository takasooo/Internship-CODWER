using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_CODWER
{
    internal class LanguageBasics3
    {
        public static void Excersise3()
        {
            Console.WriteLine("Please insert three different names.");
            string input = Console.ReadLine();

            string[] names = input.Split(' ');

            if (names.Length != 3)
            {
                Console.WriteLine("Introduceti 3 nume.");
            }

            char[] allChars = (names[0] + names[1] + names[2]).ToLower().ToCharArray();

            foreach (char character in allChars)
            {
                if (char.IsLetter(character))
                {
                    int frequency = 0;

                    for (int i = 0; i < allChars.Length; i++)
                    {
                        if (allChars[i] == character)
                        {
                            frequency++;
                            allChars[i] = ' ';
                        }
                    }
                    Console.WriteLine(character + ": " + frequency);
                }
            }
        }
    }
}
