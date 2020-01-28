using System;
using System.Linq;

namespace Contraband
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            Console.WriteLine("How many car shall be created?");

            int carAmount = 0;

            while (carAmount < 1)
            {
                Console.Write("Amount: ");
                string pCarAmount = Console.ReadLine();

                if (string.IsNullOrEmpty(pCarAmount) || pCarAmount.All(char.IsLetter))
                {
                    Console.WriteLine("Please, write a number!");

                    carAmount = 0;
                }
                else
                {
                    carAmount = Int32.Parse(pCarAmount);
                }

                if (carAmount > 10)
                {
                    Console.WriteLine("Lower than 10 please!");
                    carAmount = 0;
                }
            }

            for (int i = 0; i < carAmount; i++)
            {
                car.passenger = car.generator.Next(1, 4);
                car.contrabandAmount = car.generator.Next(0, 4);

                if (car.passenger <= 3 && car.contrabandAmount <= 0)
                {
                    car = new CleanCar();
                    //Console.WriteLine("Clean");
                }
                else if (car.passenger <= 4 && car.contrabandAmount >= 1)
                {
                    car = new ContrabandCar();
                    //Console.WriteLine("Contraband");
                }

                //Console.WriteLine(i + " amount of cars where created");
            }

            Console.WriteLine("Which car would you like to examine?");

            Console.ReadLine();
        }
    }
}
