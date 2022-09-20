using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую сторону ");
            double a;
            if (double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Введите вторую сторону ");
                double b;
                if (double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Введите третью сторону ");
                    double c;
                    if (double.TryParse(Console.ReadLine(), out c))
                    {
                        if (a <= 0 || b <= 0 || c <= 0 || (a + b) <= c || (a + c) <= b || (b + c) <= a)
                        {
                            Console.WriteLine("Треугольник не существует ");
                        }
                        else
                        {
                            double p;
                            p = (a + b + c) / 2;
                            double result;
                            result = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                            Console.WriteLine("Площадь = "+result);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода ");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка ввода ");
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода ");
            }
        }
    }
}
