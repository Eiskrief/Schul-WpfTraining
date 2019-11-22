using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int sum = 0;
            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < 10; i++) 
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++) 
            {
                sum = numbers[i] + sum;
            }
            Console.WriteLine("The sum is: {0}", sum);
            Console.WriteLine("The average is:" + sum / 10);
            Console.ReadKey();
        }

    }
}
