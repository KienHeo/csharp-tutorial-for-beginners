using System;

namespace Conditionals
{
    public class Exercises
    {
        public static void Main(string[] argc)
        {
            /*// Exercise 1: 
            Console.Write("Enter a number: ");
            var number = int.Parse(Console.ReadLine());
            if (number <= 10 && number >= 1)
                Console.WriteLine("Valid.");
            else
                Console.WriteLine("Invalid.");*/

            /*// Exercise 2:
            Console.WriteLine("Enter two numbers: ");
            Console.Write("Number 1 = ");
            var number1 = int.Parse(Console.ReadLine());
            Console.Write("Number 2 = ");
            var number2 = int.Parse(Console.ReadLine());

            // display maximum of two numbers
            var maximum = Math.Max(number2, number1);
            Console.WriteLine($"Maximum value = {{0}}", maximum);*/

            /*// Exercise 3:
            Console.WriteLine("Enter the width and height of an image: ");
            Console.Write("Width = ");
            var width = int.Parse(Console.ReadLine());
            Console.Write("Height = ");
            var height = int.Parse(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("The image is landscape.");
            }
            else if (width < height)
            {
                Console.WriteLine("The image is portrait.");
            }
            else
            {
                Console.WriteLine("I dunno what type of that image!!!");
            }*/

            // Exercise 4:
            Console.Write("Enter the speed limit: ");
            var speedLimit = int.Parse(Console.ReadLine());
            if (speedLimit <= 0)
            {
                Console.WriteLine("Wrong input!!!. Do it again.");
            }

            Console.Write("Enter the speed of car: ");
            var carSpeed = int.Parse(Console.ReadLine());
            if (carSpeed < speedLimit)
            {
                Console.WriteLine("Ok.");
            }
            else
            {
                if (carSpeed <= speedLimit) return;
                var demeritPoints = (carSpeed - speedLimit > 5) ? (carSpeed - speedLimit) / 5 : 0;

                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended.");
                }
                else
                {
                    Console.WriteLine($"Demerit Points = {{0}}", demeritPoints);
                }
            }
        }
    }
}