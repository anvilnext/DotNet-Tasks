using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using DotnetTasks.Shapes;

namespace DotnetTasks
{
    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            //7-1 Shapes
            Circle shape = new Circle("circle", 4);
            Console.WriteLine(shape.GetName());
            Console.WriteLine(Math.Round(shape.GetArea(), 2));
            IsoscelesTriangle it = new IsoscelesTriangle("triangle", 4, 2);
            Console.WriteLine(it.GetName());
            Console.WriteLine(it.GetArea());
            Console.ReadLine();

            //6 Matrix
            //const int size = 2;
            //const int size2 = 2;
            //Matrix m = new Matrix(size);
            //Matrix n = new Matrix(size);
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0; j < size; j++)
            //    {
            //        m[i, j] = rand.Next(10);
            //        n[i, j] = rand.Next(10);
            //    }
            //}
            //m.Print();
            //Console.WriteLine();
            //n.Print();
            //Console.WriteLine();
            //m.Multiply(n).Print();
            //Console.ReadLine();

            //5-2 Polynom
            //const int degree1 = 3;
            //const int degree2 = 2;
            //int[] poly1 = new int[degree1 + 1] { 3, 6, 0, 2 }; //from junior to senior so the index is becoming a degree
            //int[] poly2 = new int[degree2 + 1] { 1, 0, 1 };
            //Polynom p = new Polynom(degree1, poly1);
            //Polynom m = new Polynom(degree2, poly2);
            //p.Multiply(2);
            //p.Multiply(m);
            //Console.WriteLine(p.WritePol());
            //Console.ReadLine();

            //5-1 Array
            //Console.WriteLine("Array");
            //int n = 5, low = 11;
            //RArray a = new RArray(n, low);
            //for (int i = low - 1; i <= low + n; i++)
            //{
            //    try
            //    {
            //        a[i] = 1;
            //        Console.WriteLine("a["+i+"] = "+a[i]);
            //    }
            //    catch (IndexOutOfRangeException)
            //    {
            //        Console.WriteLine("out of range");
            //    }
            //}
            //Console.ReadLine();

            //4-2 Arithmetic progression
            //Console.WriteLine("Arithmetic progression");
            //ArProgression arith = new ArProgression(4, 2);
            //Console.WriteLine(arith.GetNItem(10));
            //Console.WriteLine(arith.GetSum(10));
            //Console.WriteLine(arith.GetAverage(10));
            //Console.ReadLine();

            //4-1 Quadrate
            //Console.WriteLine("Quadrate");
            //Quadrate quadr = new Quadrate(4);
            //Console.WriteLine(quadr.Area());
            //Console.WriteLine(quadr.Perimeter());
            //Console.ReadLine();
        }
    }
}
