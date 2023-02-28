using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1
{
    class Program
    {
       static void Main(string[] args)
            {
                Console.Write("Enter  first name: ");
                string firstName = Console.ReadLine();

                Console.Write("Enter  last name: ");
                string lastName = Console.ReadLine();

                Display(firstName, lastName);
                Console.Read();
            }

            static void Display(string firstName, string lastName)
            {
                Console.WriteLine(firstName.ToUpper());
                Console.WriteLine(lastName.ToUpper());
                Console.Read();
            }

       
    }
}
