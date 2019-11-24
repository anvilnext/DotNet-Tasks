using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetTasks.Shapes
{
    class Circle : Shape
    {
        string Type { get; set; }

        //r for radius
        public Circle(string t, int r) : base("circle", r)
        {
            Type = t;
        }

        public override double GetArea()
        {
            return (Width * Math.Pow((Math.PI), 2));
        }

        public override string GetName()
        {
            return Type;
        }
    }
}
