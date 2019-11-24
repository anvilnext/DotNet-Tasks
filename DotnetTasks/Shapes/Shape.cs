using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetTasks.Shapes
{
    abstract class Shape
    {
        public int Width { get; set; }
        public int Length { get; set; }
        public int Height { get; set; }
        public string Name { get; set; }

        public Shape(string name, int w, int l, int h)
        {
            Name = name;
            Width = w;
            Length = l;
            Height = h;
        }

        public Shape(string name, int w, int h)
        {
            Name = name;
            Width = w;
            Height = h;
        }

        public Shape(string name, int x)
        {
            Width = Length = x;
            Name = name;
        }

        public abstract string GetName();
        public abstract double GetArea();
    }
}