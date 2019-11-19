using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetTasks
{
    class Quadrate
    {
        public int side;

        public int Perimeter()
        {
            return 2 * side;
        }

        public int Area()
        {
            return side * side;
        }
    }
}
