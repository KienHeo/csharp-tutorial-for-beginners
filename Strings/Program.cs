using System;

namespace Strings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string firstName = "Mosh";
            const string lastName = "Hamedani";

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[]
            {
                "John", "Jack", "Mary"
            };
            var formmatedNames = string.Join(",", names);
            Console.WriteLine(formmatedNames);
            const string text = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text);
        }
    }
}