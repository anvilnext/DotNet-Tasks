using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Polynom
    {
        private int degree;
        private int[] base_arr;

        public Polynom(int degree, int[] base_arr)
        {
            Degree = degree;
            this.base_arr = base_arr;
        }

        public Polynom(int degree)
        {
            Degree = degree;
            base_arr = new int[degree + 1];
        }

        public int Degree
        {
            get { return degree; }
            set { if (value >= 0) degree = value; }
        }

        public int this[int i]
        {
            get { return base_arr[i]; }
            set { base_arr[i] = value; }

        }

        public void Add(int a)
        {
            base_arr[0] += a;
        }

        public void Add(Polynom polynom)
        {
            int smaller = Math.Min(base_arr.Length, polynom.base_arr.Length);
            for (int i = 0; i < smaller; i++)
                base_arr[i] += polynom.base_arr[i];
                
            if (base_arr.Length < polynom.base_arr.Length)
            {
                Array.Resize(ref base_arr, polynom.base_arr.Length);
                degree = base_arr.Length - 1;
                for (int i = smaller; i < polynom.base_arr.Length; i++)
                    base_arr[i] = polynom.base_arr[i];
            }   
        }

        public void Subtract(int a)
        {
            base_arr[0] -= a;
        }

        public void Subtract(Polynom polynom)
        {
            int smaller = Math.Min(base_arr.Length, polynom.base_arr.Length);
            for (int i = 0; i < smaller; i++)
                base_arr[i] -= polynom.base_arr[i];

            if (base_arr.Length < polynom.base_arr.Length)
            {
                Array.Resize(ref base_arr, polynom.base_arr.Length);
                degree = base_arr.Length - 1;
                for (int i = smaller; i < polynom.base_arr.Length; i++)
                    base_arr[i] = polynom.base_arr[i];
            }
        }

        public void Multiply(int a)
        {
            for (int i = 0; i < base_arr.Length; i++)
            {
                base_arr[i] *= a;
            }
        }

        public void Multiply(Polynom polynom)
        {
            int oldsize = base_arr.Length;
            degree = degree + polynom.degree;
            Array.Resize(ref base_arr, degree + 1);

            Polynom[] elem = new Polynom[polynom.base_arr.Length];
            for (int i = 0; i < elem.Length; i++)
            {
                elem[i] = new Polynom(degree);
                for (int j = 0; j < oldsize; j++)
                {
                    elem[i].base_arr[j + i] = base_arr[j] * polynom.base_arr[i];
                }
            }

            for (int i = 1; i < elem.Length; i++)
            {
                elem[0].Add(elem[i]);
            }

            base_arr = elem[0].base_arr;
        }

        public string WritePol()
        {
            string res = null;
            for (int i = degree; i >= 0; i--)
            {
                if ((base_arr[i] > 0) && (i != Degree) && (i != 0) && (i != 1))
                {
                    res += " + " + base_arr[i] + "x^" + i;
                }
                else if ((base_arr[i] < 0) && (i != Degree) && (i != 0) && (i != 1))
                {
                    res += " - " + (-1)*base_arr[i] + "x^" + i;
                }
                else if ((base_arr[i] != 0) && (i == Degree))
                {
                    res += base_arr[i] + "x^" + i;
                }
                else if ((base_arr[i] != 0) && (i == 0))
                {
                    res += " + " + base_arr[i];
                }
                else if ((base_arr[i] != 0) && (i == 1))
                {
                    res += " + " + base_arr[i] + "x";
                }
                else
                {
                    continue;
                }
            }
            return res;
        }
    }
}
