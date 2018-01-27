using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Path
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\sue18\source\repos\csharp-tutorial-for-beginners\csharp-tutorial-for-beginners.sln";

            var dotIndex = path.IndexOf('.');
            var extention = path.Substring(dotIndex);

            Console.WriteLine("Extension: " + System.IO.Path.GetExtension(path));
            Console.WriteLine("File Name: " + System.IO.Path.GetFileName(path));
            Console.WriteLine("File Name Without Extension: " + System.IO.Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory: " + System.IO.Path.GetDirectoryName(path));
        }
    }
}