using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetTasks.Shapes
{
    class Triangle : IShape
    {
        string Type { get; set; }
        int a { get; set; }
        int b { get; set; }

        //triangle with 2 different sides and height
        public Triangle(string t, int a, int b, int h)
        {
            Type = t;
            this.a = a;
            this.b = b;
        }

        public double GetArea()
        {
            return (a * b) / 2;
        }

        public string GetName()
        {
            return Type;
        }
    }
}