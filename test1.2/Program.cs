using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n:");
            int n;
            if (int.TryParse(Console.ReadLine(), out n)) ;
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
