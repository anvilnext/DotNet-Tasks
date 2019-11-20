using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace DotnetTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //5-1 Array
            Console.WriteLine("Array");
            int n = 5, low = 11;
            RArray a = new RArray(n, low);
            for (int i = low - 1; i <= low + n; i++)
            {
                try
                {
                    a[i] = 1;
                    Console.WriteLine("a["+i+"] = "+a[i]);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("out of range");
                }
            }
            Console.ReadLine();

            //4-2 Arithmetic progression
            Console.WriteLine("Arithmetic progression");
            ArProgression arith = new ArProgression(4, 2);
            Console.WriteLine(arith.GetNItem(10));
            Console.WriteLine(arith.GetSum(10));
            Console.WriteLine(arith.GetAverage(10));
            Console.ReadLine();

            //4-1 Quadrate
            Console.WriteLine("Quadrate");
            Quadrate quadr = new Quadrate(4);
            Console.WriteLine(quadr.Area());
            Console.WriteLine(quadr.Perimeter());
            Console.ReadLine();
        }
    }
}
