using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Zadanie_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Temp\Numbers.txt";
            Random random = new Random();
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(-10, 10));
                }
            }
            int k = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    k = k + Convert.ToInt32(sr.ReadLine());
                     


                }
                Console.WriteLine(k);
                Console.ReadKey();

            }
        }
    }
}
