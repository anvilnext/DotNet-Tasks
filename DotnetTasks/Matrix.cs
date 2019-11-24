using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetTasks
{
    class Matrix
    {
        private int[,] matrix;
        private int Rows, Cols;

        public Matrix(int rows, int cols)
        {
            matrix = new int[rows, cols];
            Rows = rows;
            Cols = cols;
        }

        public Matrix(int N)
        {
            matrix = new int[N, N];
            Rows = Cols = N;
        }

        public int this[int i, int j]
        {
            get { return matrix[i, j]; }
            set { matrix[i, j] = value; }
        }

        public Matrix Add(Matrix m2)
        {
            try
            {
                if ((Rows == m2.Rows) && (Cols == m2.Cols))
                {
                    for (int i = 0; i < Rows; i++)
                    {
                        for (int j = 0; j < Cols; j++)
                        {
                            matrix[i, j] += m2[i, j];
                        }
                    }
                    return this;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Matrixes don't have the same size");
                return null;
            }
        }

        public Matrix Subtract(Matrix m2)
        {
            try
            {
                if ((Rows == m2.Rows) && (Cols == m2.Cols))
                {
                    for (int i = 0; i < Rows; i++)
                    {
                        for (int j = 0; j < Cols; j++)
                        {
                            matrix[i, j] -= m2[i, j];
                        }
                    }
                    return this;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Matrixes don't have the same size");
                return null;
            }
        }

        public Matrix Multiply(int a)
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    matrix[i, j] *= a;
                }
            }
            return this;
        }

        public Matrix Multiply(Matrix m2)
        {
            try
            {
                if (Cols == m2.Rows)
                {
                    Matrix res = new Matrix(Rows, m2.Cols);
                    for (int i = 0; i < Rows; i++)
                    {
                        for (int j = 0; j < Cols; j++)
                        {
                            int sum = 0;
                            for (int r = 0; r < Rows; r++)
                            {
                                sum += matrix[i, r] * m2[r, j];
                            }
                            res[i, j] = sum;
                        }
                    }
                    return res;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Number of Matrix 1 columns and Matrix 2 rows don't match");
                return null;
            }
        }

        public void Print()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
