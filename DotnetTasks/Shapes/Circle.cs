using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetTasks.Shapes
{
    class Circle : IShape
    {
        string Type { get; set; }
        int Radius { get; set; }

        //r for radius
        public Circle(string t, int r)
        {
            Type = t;
            Radius = r;
        }

        public double GetArea()
        {
            return (Radius * Math.Pow((Math.PI), 2));
        }

        public string GetName()
        {
            return Type;
        }
    }
}
