using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetTasks.Shapes
{
    class Triangle : Shape
    {
        string Type { get; set; }

        //triangle with 2 different sides and height
        public Triangle(string t, int a, int b, int h) : base("triangle", a, b, h)
        {
            Type = t;
        }

        //triangle with 1 defined side and height
        public Triangle(string t, int a, int h) : base("triangle", a, h)
        {
            Type = t;
        }

        public override double GetArea()
        {
            return (Width * Height) / 2;
        }

        public override string GetName()
        {
            return Type;
        }
    }
}