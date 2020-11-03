using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Buick";
            myCar.Model = "Skylark";
            myCar.Year = 1988;

            var nissan = new Car()
            {
                Make = "Nissan",
                Model = "Pathfinder",
                Year = 2013
            };

            var ford = new Car("Ford", "Focus", 2005);

            var carList = new List<Car>() { myCar, nissan, ford };
            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }

        }
    }
}
