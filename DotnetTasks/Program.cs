using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //4-2 Arithmetic progression
            Console.WriteLine("Arithmetic progression");
            ArProgression arith = new ArProgression();
            arith.a1 = 4;
            arith.d = 2;
            Console.WriteLine(arith.GetNItem(10));
            Console.WriteLine(arith.GetSum(10));
            Console.WriteLine(arith.GetAverage(10));
            Console.ReadLine();

            //4-1 Quadrate
            Console.WriteLine("Quadrate");
            Quadrate quadr = new Quadrate();
            quadr.side = 4;
            Console.WriteLine(quadr.Area());
            Console.WriteLine(quadr.Perimeter());
            Console.ReadLine();
        }
    }
}
