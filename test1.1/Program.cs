using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину");
            double a;
            if (double.TryParse(Console.ReadLine(), out a))
            {
                if (a > 0)
                {
                    Console.WriteLine("Введите ширину");
                    double b;

                    if (double.TryParse(Console.ReadLine(), out b))
                    {
                        if (b > 0)
                        {
                            double result;
                            result = a * b;
                            Console.WriteLine("Площадь = " + result);
                        }
                        else
                        {
                            Console.WriteLine("Ошибка ввода");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода");
                    }
                }

                else
                {
                    Console.WriteLine("Ошибка ввода");
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода");
            }
        }
    }
}
