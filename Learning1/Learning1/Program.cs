using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class Program
        {
        

        static void Main(string[] args)
        {
            Car car;
            Console.WriteLine("Enter first color");
            string colorA = Console.ReadLine();
            Console.WriteLine("Enter second color");
            string colorB = Console.ReadLine();
            Console.WriteLine("Enter the weight");
            int weight = int.Parse(Console.ReadLine());
            car = new Car(colorA, colorB, weight);
            car.Weight = weight;
            Console.WriteLine(car.Describe());
            Console.WriteLine("It is mostly " + car.ColorA);
            string test1 = car.ColorA;
            car.ColorA = Console.ReadLine();

            Console.ReadKey();

        }




    }

    class Car
    {
        private string colorC;
        private string colorD;
        private int weight;
        public Car(string color1, string color2, int weighted)
        {
            this.colorC = color1;
            this.colorD = color2;
            //this.weight = weight;
        }

        public string Describe()
        {
            return "This car is " + ColorA + " and " + ColorB + " and weights " + Weight + "kg";
        }

        public string ColorA
        {
            get { return colorC; }
            set { colorC = value; }
        }

        public string ColorB
        {
            get { return colorD; }

            set { colorD = value; }





        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}
