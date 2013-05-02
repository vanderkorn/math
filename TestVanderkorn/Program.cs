using System;
using System.Collections;
using System.Collections.Generic;
using Vanderkorn.Matrixes;

namespace TestVanderkorn
{
    class Program
    {
        static void Main()
        {
            //var matrix=new Matrix(3,4);
            //for (ulong i = 0; i < matrix.RowsCount; i++)
            //    for (ulong j = 0; j < matrix.ColumnsCount; j++)
            //        matrix[i, j] = new Random(Convert.ToInt32(i)).NextDouble();
            //matrix.Transpose();
            //var matrix = new Matrix(4, 4);

            //matrix[0, 0] = 2.0;
            //matrix[0, 1] = -1.0;
            //matrix[0, 2] = 3.0;
            //matrix[0, 3] = 2.0;

            //matrix[1, 0] = 3.0;
            //matrix[1, 1] = 1.0;
            //matrix[1, 2] = 7.0;
            //matrix[1, 3] = 0.0;

            //matrix[2, 0] = -4.0;
            //matrix[2, 1] = -1.0;
            //matrix[2, 2] = 2.0;
            //matrix[2, 3] = 1.0;

            //matrix[3, 0] = -6.0;
            //matrix[3, 1] = 7.0;
            //matrix[3, 2] = 1.0;
            //matrix[3, 3] = -1.0;

           //var matrix = new Matrix(3, 3);
           

           // //double[,] matrix =new double[3,3];

           // matrix[0, 0] = 2.0;
           // matrix[0, 1] = 0.0;
           // matrix[0, 2] = 3.0;

           // matrix[1, 0] = 2.0;
           // matrix[1, 1] = 1.0;
           // matrix[1, 2] = 5.0;

           // matrix[2, 0] = 2.0;
           // matrix[2, 1] = 1.0;
           // matrix[2, 2] = 4.0;

           //// double[,] matrix2=MatrixOld.INV(matrix);
           
           // matrix.Invertible();
           // return;
            var matrix = new Matrix
            (
                new double[,]
                {
                    {1,2,0,0},
                    {4,6,0,0},
                    {7,3,0,0}
                }
            );
            IEnumerator elements = matrix.GetEnumerator();

            double[] data = new double[matrix.RowsCount*matrix.ColumnsCount];
            int i = 0;
            while (elements.MoveNext())
            {
                data[i++] = (double)elements.Current;
            }
            //matrix[0, 0] = 4.0;
            //matrix[0, 1] = 3.0;
            //matrix[0, 2] = -4.0;
            //matrix[0, 3] = 2.0;
            //matrix[0, 4] = 2.0;

            //matrix[1, 0] = 2.0;
            //matrix[1, 1] = -1.0;
            //matrix[1, 2] = -3.0;
            //matrix[1, 3] = -4.0;
            //matrix[1, 4] = 2.0;

            //matrix[2, 0] = 3.0;
            //matrix[2, 1] = 1.0;
            //matrix[2, 2] = 1.0;
            //matrix[2, 3] = 2.0;
            //matrix[2, 4] = -1.0;

            //matrix[3, 0] = 1.0;
            //matrix[3, 1] = 2.0;
            //matrix[3, 2] = 3.0;
            //matrix[3, 3] = 4.0;
            //matrix[3, 4] = -1.0;

            //matrix[4, 0] = -1.0;
            //matrix[4, 1] = 1.0;
            //matrix[4, 2] = -1.0;
            //matrix[4, 3] = -2.0;
            //matrix[4, 4] = 3.0;

           /* matrix[0, 0] = 1.0;
            matrix[0, 1] = 2.0;
            matrix[0, 2] = 0.0;
            matrix[0, 3] = 0.0;

            matrix[1, 0] = 4.0;
            matrix[1, 1] = 6.0;
            matrix[1, 2] = 0.0;
            matrix[1, 3] = 0.0;

            matrix[2, 0] = 7.0;
            matrix[2, 1] = 3.0;
            matrix[2, 2] = 0.0;
            matrix[2, 3] = 0.0;*/
      
            ulong rank = matrix.Rank();
            // double det = matrix.Det();
        }
    }
}
