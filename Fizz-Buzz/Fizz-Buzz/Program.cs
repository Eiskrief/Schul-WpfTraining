using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizz_Buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie die Zahl zu der gezählt werden soll ein: ");
            if (int.TryParse(Console.ReadLine(), out int endNumber))
            {
                for (int i = 1; i <= endNumber; i++)
                {
                    Checker(i);
                }
                Console.ReadKey();
            }
            else 
            {
                Console.WriteLine("Ungülitge Eingabe!");
                Console.ReadKey();
            }
        }

        public static void Checker(int number) 
        {
            if(number % 3 == 0 && number % 5 == 0) 
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 3 == 0) 
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 5 == 0) 
            {
                Console.WriteLine("Buzz");
            }
            else 
            {
                Console.WriteLine($"{number}");
            }
        }
    }
}
