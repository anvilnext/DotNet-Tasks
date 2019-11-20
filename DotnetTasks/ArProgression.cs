using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetTasks
{
    class ArProgression
    {
        private readonly int a1;
        private readonly int d;

        public ArProgression(int a1, int d)
        {
            this.a1 = a1;
            this.d = d;
        }
        
        public int GetNItem(int n)
        {
            return a1 + (n - 1) * d;
        }

        public int GetSum(int n)
        {
            return (a1 + GetNItem(n)) * n / 2;
        }

        public int GetAverage(int n)
        {
            return GetSum(n) / n;
        }

    }
}
