using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.Write("\n-------------------Letter to count the number of occurence---------------- \n");
            Console.Write("Enter the letter to count: ");
            char letter = char.Parse(Console.ReadLine());

            int count = CountLetters(input, letter);

            Console.WriteLine("\nThe letter '{0}' appears {1} times in the string '{2}'.",letter, count, input);
            Console.Read();
        }

        static int CountLetters(string input, char letter)
        {
            int count = 0;

            foreach (char c in input)
            {
                if (c == letter)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

