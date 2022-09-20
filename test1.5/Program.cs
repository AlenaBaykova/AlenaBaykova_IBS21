using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            result = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                    result += i;
                }
            }
            Console.WriteLine("Результат = " + result);
        }
    }
}
