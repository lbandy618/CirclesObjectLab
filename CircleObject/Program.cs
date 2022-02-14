using CircleObject;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool runProgram = true;
            List<Circle> myCircles = new List<Circle>();

            while (runProgram)
            {
                Console.Write("Please enter a radius: ");

                double radius;


                while (!double.TryParse(Console.ReadLine(), out radius))
                {
                    Console.Write("Not a valid side length, please try again: ");
                }

                Circle circle = new Circle(radius);

                Console.WriteLine("Circumfrence: " + circle.CalculateFormattedCircumfrence());
                Console.WriteLine("Area: " + circle.CalculateFormattedArea());
                myCircles.Add(circle);

                runProgram = GetContinue();
            }
            Console.WriteLine($"Goodbye. You created {myCircles.Count} circles.");
        }
        static bool GetContinue()
        {
            bool result = true;
            while (true)
            {
                Console.Write("Do you want to continue? y/n: ");
                string choice = Console.ReadLine().Trim().ToLower();
                if (choice == "y")
                {
                    result = true;
                    break;
                }
                else if (choice == "n")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Not valid.");
                }
            }
            return result;
        }
    }
}