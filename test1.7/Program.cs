using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1 число: ");
            byte a;
            if (byte.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Введите 2 число: ");
                byte b;
                if (byte.TryParse(Console.ReadLine(), out b))
                {
                    Console.Write("побитовое ИЛИ = ");
                    Console.WriteLine(a | b);
                    Console.Write("побитовое И = ");
                    Console.WriteLine(a & b);
                    Console.Write("побитовое исключающее ИЛИ = ");
                    Console.WriteLine(a ^ b);
                }
            }
        }
    }
}
