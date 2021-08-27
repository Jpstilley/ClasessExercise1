using System;

namespace ClassesExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.make = "Toyota";
            myCar.model = "Corolla";
            myCar.year = 2014;

            Console.WriteLine($"My car is a {myCar.year} {myCar.make} {myCar.model}.");
            
        }
    }
}
