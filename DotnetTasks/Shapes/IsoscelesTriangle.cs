using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetTasks.Shapes
{
    class IsoscelesTriangle : Triangle
    {
        string Type { get; set; }

        public IsoscelesTriangle(string name, int a, int h) : base("triangle", a, h)
        {
            Type = "isosceles " + name;
        }

        public override string GetName()
        {
            return Type;
        }

        public override double GetArea()
        {
            return base.GetArea();
        }
    }
}
