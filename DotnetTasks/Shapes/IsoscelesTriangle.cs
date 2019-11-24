﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetTasks.Shapes
{
    class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(string name, int a, int h) : base("isosceles triangle", a, a, h) { }
    }
}
