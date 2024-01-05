using System;
using System.IO;
namespace Zadanie_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Temp";
            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            foreach(string file in files)
            {
                Console.WriteLine(file);
            }
            Console.ReadKey();
        }
    }
}
