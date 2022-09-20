using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n:");
            int n;
            int count = 0;
            if (int.TryParse(Console.ReadLine(), out n)) ;
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = n; j > i; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j <= count; j++)
                    {
                        Console.Write("*");

                    }
                    count += 2;
                    Console.WriteLine();
                }
            }
        }
    }
}
