using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lists
{
    internal class Exercises
    {
        public static void Main(string[] args)
        {
            /*// ex1:
            var nameList = new List<string>();

            while (true)
            {
                Console.Write("Enter a name: ");
                var name = Console.ReadLine();
                if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
                {
                    break;
                }

                nameList.Add(name);
                Console.Write("Press Enter to exit. Or type any word to continue. Your choice is: ");
                var choice = Console.ReadLine();
                if (choice == string.Empty)
                {
                    break;
                }
            }

            switch (nameList.Count)
            {
                case 0:
                    Console.WriteLine();
//                    Console.WriteLine("Count = " + nameList.Count);
                    break;
                case 1:
                    Console.WriteLine("{0} likes your post.", nameList[0]);
//                    Console.WriteLine("Count = " + nameList.Count);
                    break;
                case 2:
                    Console.WriteLine("{0} and {1} like your post.", nameList[0], nameList[1]);
//                    Console.WriteLine("Count = " + nameList.Count);
                    break;
                default:
                    Console.WriteLine("{0}, {1} and {2} others like your post.", nameList[0], nameList[1],
                        nameList.Count - 2);
//                    Console.WriteLine("Count = " + nameList.Count);
                    break;
            }*/

            /*// ex2:                                   
            Console.Write("Enter Your Name = ");
            var name = Console.ReadLine();
            var c = name?.ToCharArray();
            Array.Reverse(c);
            Console.WriteLine("Reverse the name is: " + new string(c));*/

            /*// ex3:
            var listNumber = new List<int>();
            var i = 0;
            while (true)
            {
                Console.WriteLine("Enter five unique numbers: ");
                for (; i < 5; i++)
                {
                    Console.Write("Enter number {0}: ", i + 1);
                    var testNumber = int.Parse(Console.ReadLine());
                    if (CheckNumberExist(listNumber, testNumber))
                    {
                        listNumber.Add(testNumber);
                    }
                    else
                    {
                        Console.Write("Found duplicate number. Type \"yes\" to re-try or \"no\" to stop. Your choice: ");
                        var choice = Console.ReadLine();
                        if (choice == "yes") continue;
                        if (choice == "no")
                            break;
                    }
                }

                break;
            }

            listNumber.Sort();
            Console.Write("Sorted List is: ");
            foreach (var number in listNumber)
            {
                Console.Write("\t" + number);
            }

            Console.WriteLine();*/

            /*// ex4:
            var listNumber = new List<int>();
            while (true)
            {
                Console.Write("Enter a number: ");
                var number = int.Parse(Console.ReadLine());
                RemoveDuplicateNumber(listNumber, number);
                listNumber.Add(number);
                Console.Write("Type \"Quit\" to exit. Your choice: ");
                var choice = Console.ReadLine();
                if (choice != "Quit")
                {
                    continue;
                }

                break;
            }

            Console.Write("Unique List Number is: ");
            foreach (var number in listNumber)
            {
                Console.Write("\t" + number);
            }

            Console.WriteLine();*/

            // ex5:
            /*while (true)
            {
                Console.WriteLine("Enter the list: ");
                var listNumber = Console.ReadLine();
                var stringArray = listNumber.Split(",");
                if (CheckInvalid(stringArray))
                {
                    Console.Write("Invalid List. Do you want to continue. Your choice: ");                    
                }
            }*/
        }

        public static bool CheckNumberExist(List<int> list, int testNumber)
        {
            foreach (var number in list)
            {
                if (testNumber == number)
                {
                    return false;
                }
            }

            return true;
        }

        public static void RemoveDuplicateNumber(List<int> list, int testNumber)
        {
            for (var i = 0; i < list.Count; i++)
            {
                if (testNumber == list[i])
                {
                    list.Remove(list[i]);
                }
            }
        }

        public static bool CheckInvalid(string[] stringArray)
        {
            foreach (var s in stringArray)
            {
                if (string.IsNullOrEmpty(s))
                {
                    return true;
                }
            }

            if (stringArray.Length < 5)
            {
                return true;
            }

            return false;
        }
    }
}