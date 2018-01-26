using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterations
{
    class Exercises
    {
        public static void Main(string[] argc)
        {
            /*// ex1
            var j = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 != 0) continue;
                j++;
            }

            Console.WriteLine(j);*/

            /*  // ex2
              int sum = 0;
              string s = "";
              while (s != "ok")
              {
                  Console.Write("Enter the number: ");
                  int number = int.Parse(Console.ReadLine());
                  Console.Write("Enter \"ok\" to exit or keep enter number by enter nothing. Your choice: ");
                  s = Console.ReadLine();
                  sum += number;
              }
  
              Console.WriteLine("Sum = " + sum);*/

            /*// ex3
            Console.Write("Enter number for calculating factorial: ");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Format($"{{0}}! = {{1}}", number, Factorial(number)));*/

            /*// ex4
            var random = new Random();
            var randomNumber = random.Next(1, 10);
            Console.WriteLine("Random Number = " + randomNumber);
            var count = 0;
            while (count < 4)
            {
                Console.Write("Enter the number to guest: ");
                var guestNumber = int.Parse(Console.ReadLine());
                Console.WriteLine(guestNumber == randomNumber ? "Great Job." : "You SUCK.");
                count++;
            }*/

            // ex5
            Console.Write("Enter a series of numbers: ");
            var s = Console.ReadLine();
            var array = s?.Split(",");
            var maximum = FindMaximum(array);
            Console.WriteLine(maximum);
        }

        public static int Factorial(int i)
        {
            if (i == 0)
            {
                return 1;
            }

            return i * Factorial(i - 1);
        }

        public static int FindMaximum(string[] strings)
        {
            var max = int.Parse(strings[0]);
            foreach (var s in strings)
            {
                if (int.Parse(s) >= max)
                {
                    max = int.Parse(s);
                }
            }

            return max;
        }
    }
}