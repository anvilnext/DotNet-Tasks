using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class RArray
    {
        int[] base_arr;

        private int N { get; }
        private int Low { get; }
        private int High { get; set; }

        public RArray(int n, int low)
        {
            base_arr = new int[n];
            N = n;
            Low = low;
            High = Low + N - 1;
        }

        public int this[int i]
        {
            get
            {
                return base_arr[i - Low];
            }
            set
            {
                base_arr[i - Low] = value;
            }
        }
    }
}
