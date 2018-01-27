using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryAndDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp\folder1");
            var files = Directory.GetFiles(@"C:\Users\sue18\source\repos\csharp-tutorial-for-beginners", "*.csproj",
                SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var directories =
                Directory.GetDirectories(@"C:\Users\sue18\source\repos\csharp-tutorial-for-beginners", "*.*",
                    SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            Directory.Exists("...");
            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

        }
    }
}