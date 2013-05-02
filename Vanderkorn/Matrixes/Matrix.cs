// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Matrix.cs" company="VanDerKorn">
//   Copyright (c) VanDerKorn (vanderkorn@gmail.com). All rights reserved.
// </copyright>
// <summary>
//   Matrix Class
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Vanderkorn.Matrixes
{
    using System;
    using System.Collections;

    /// <summary>
    /// Matrix Class
    /// </summary>
    public class Matrix : IComparable, IEquatable<Matrix>,IEnumerable
    {
        /// <summary>
        /// Array of elements of a matrix
        /// </summary>
        private double[,] _data;

        /// <summary>
        /// Count of rows
        /// </summary>
        private ulong _rowsCount;

        /// <summary>
        /// Count of columns
        /// </summary>
        private ulong _columnsCount;

        /// <summary>
        /// Count of rows
        /// </summary>
        public ulong RowsCount
        {
            get { return _rowsCount; }
        }

        /// <summary>
        /// Count of columns
        /// </summary>
        public ulong ColumnsCount
        {
            get { return _columnsCount; }
        }

        /// <summary>
        /// Constructor of a square matrix
        /// </summary>
        /// <param name="size">Count of rows and columns</param>
        public Matrix(ulong size): this(size, size)
        {}

        /// <summary>
        /// Constructor of a matrix
        /// </summary>
        /// <param name="rowsCount">Count of rows</param>
        /// <param name="columnsCount">Count of columns</param>
        public Matrix(ulong rowsCount, ulong columnsCount)
        {
            if (rowsCount == 0 || columnsCount==0)
                throw new Exception("Matrix must be positive size");

            _rowsCount = rowsCount;
            _columnsCount = columnsCount;
            _data = new double[_rowsCount, _columnsCount];
        }

        /// <summary>
        /// Constructor of a matrix
        /// </summary>
        /// <param name="data">Two-dimensional Array</param>
        public Matrix(double[,] data)
        {
            if (data==null)
                throw new Exception("Array null");

            if ((ulong)data.GetLength(0) == 0 || (ulong)data.GetLength(1) == 0)
                throw new Exception("Matrix must be positive size");

            _data = data;
            _rowsCount = (ulong)data.GetLength(0);
            _columnsCount = (ulong)data.GetLength(1);
        }

        /// <summary>
        /// Indexator of matrix
        /// </summary>
        /// <param name="rowIndex">Index of row</param>
        /// <param name="columnIndex">Index of column</param>
        /// <returns>Value element</returns>
        public double this[ulong rowIndex, ulong columnIndex]
        {
            get
            {
                return _data[rowIndex, columnIndex];
            }
            set
            {
                _data[rowIndex, columnIndex] = value;
            }
        }

        #region additional operations

        /// <summary>
        /// Transpose of matrix
        /// </summary>
        /// <param name="matrix">Matrix</param>
        /// <returns>Transpose matrix</returns>
        public static Matrix Transpose(Matrix matrix)
        {
            var transposeMatrix = new Matrix(matrix.ColumnsCount, matrix.RowsCount);
            for (ulong i = 0; i < transposeMatrix.RowsCount; i++)
                for (ulong j = 0; j < transposeMatrix.ColumnsCount; j++)
                    transposeMatrix[i, j] = matrix[j, i];
            return transposeMatrix;
        }

        /// <summary>
        /// Transpose of matrix
        /// </summary>
        /// <param name="matrix">Matrix</param>
        /// <returns>Transpose matrix</returns>
        public static Matrix T(Matrix matrix)
        {
            return Transpose(matrix);
        }

        /// <summary>
        /// Transpose of matrix
        /// </summary>
        /// <returns>Transpose matrix</returns>
        public void Transpose()
        {
            var transposeMatrix = Transpose(this);
            _data = transposeMatrix.ToArray();
            _rowsCount = transposeMatrix.RowsCount;
            _columnsCount = transposeMatrix.ColumnsCount;
        }

        /// <summary>
        /// Transpose of matrix
        /// </summary>
        /// <returns>Transpose matrix</returns>
        public void T()
        {
            Transpose();
        }

        /// <summary>
        /// Absolute values of elemnts matrix
        /// </summary>
        /// <param name="matrix">Matrix</param>
        /// <returns>Absolute matrix</returns>
        public static Matrix Abs(Matrix matrix)
        {
            var absMatrix = new Matrix(matrix.RowsCount, matrix.ColumnsCount);
            for (ulong i = 0; i < absMatrix.RowsCount; i++)
                for (ulong j = 0; j < absMatrix.ColumnsCount; j++)
                    absMatrix[i, j] = Math.Abs(matrix[i, j]);
            return absMatrix;
        }

        /// <summary>
        /// Absolute values of elements matrix
        /// </summary>
        /// <returns>Absolute matrix</returns>
        public void Abs()
        {
            _data = Abs(this).ToArray();
        }

        /// <summary>
        /// Invertible matrix
        /// </summary>
        public void Invertible()
        {
            Matrix invertibleMatrix = Invertible(this);
            _data = invertibleMatrix.ToArray();
            _rowsCount = invertibleMatrix.RowsCount;
            _columnsCount = invertibleMatrix.ColumnsCount;
        }

        /// <summary>
        /// Invertible matrix
        /// </summary>
        /// <param name="matrix">Matrix</param>
        /// <returns>Invertible matrix</returns>
        public static Matrix Invertible(Matrix matrix)
        {
            Matrix invertibleMatrix = matrix.Clone();

            if (!invertibleMatrix.IsSquare())
                throw new Exception("Matrix not square");

            Matrix I = Identity(invertibleMatrix.RowsCount);

            if (invertibleMatrix.MoveIfNeed(0, 0, I))
                throw new Exception("zero row");

            double element = invertibleMatrix[0, 0];
            invertibleMatrix.RowDivision(0, element);
            I.RowDivision(0, element);
            for (ulong i = 1; i < invertibleMatrix.RowsCount; i++)
            {
                for (ulong q = 0; q < i; q++)
                {
                    element = invertibleMatrix[i, q];
                    invertibleMatrix.RowsSubtraction(i, q, element);
                    I.RowsSubtraction(i, q, element);
                }
                if (invertibleMatrix[i, i] != 0)
                {
                    element = invertibleMatrix[i, i];
                    invertibleMatrix.RowDivision(i, element);
                    I.RowDivision(i, element);
                }
                else
                {
                    if (invertibleMatrix.MoveIfNeed(i, i, I))
                        throw new Exception("zero row");
                }
            }


                for (ulong i = invertibleMatrix.RowsCount-1; i >0; i--)
                    for (ulong j = i-1; j >=0; j--)
                    {
                        element = invertibleMatrix[j, i];
                        invertibleMatrix.RowsSubtraction(j, i, element);
                        I.RowsSubtraction(j, i, element);
                        if (j == 0) break;
                    }

           
                //for (int p = ro - 1; p > 0; p--)
                //{
                //    for (q = p - 1; q >= 0; q--)
                //    {
        
            return I;
        }

        /// <summary>
        /// Subtraction rows with factor
        /// </summary>
        /// <param name="rowSourceIndex">Index row source</param>
        /// <param name="rowDestIndex">Index row destination</param>
        /// <param name="lambda">factor</param>
        private void RowsSubtraction(ulong rowSourceIndex, ulong rowDestIndex, double lambda)
        {
            for (ulong j = 0; j < ColumnsCount; j++)
                this[rowSourceIndex, j] = this[rowSourceIndex, j] - (lambda * this[rowDestIndex, j]);
        }

        private bool MoveIfNeed(ulong row, ulong column, Matrix I)
        {
            if (this[row, column] == 0)
            {
                for (ulong i = row + 1; i < RowsCount; i++)
                {
                    if (this[i, column] != 0)
                    {
                        RowsTransposition(row, i);
                        I.RowsTransposition(row, i);
                        return true;
                    }
                }
            }
            return false;
        }
        private bool MoveIfNeed(ulong row, ulong column)
        {
            if (this[row, column] == 0)
            {
                for (ulong i = row + 1; i < RowsCount; i++)
                {
                    if (this[i, column] != 0)
                    {
                        RowsTransposition(row, i);
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Multiplication rows
        /// </summary>
        /// <param name="rowIndex">Index row source</param>
        /// <param name="lambda">Multiplier</param>
        public void RowMultiplication(ulong rowIndex, double lambda)
        {
            for (ulong j = 0; j < ColumnsCount; j++)
                this[rowIndex, j] = this[rowIndex, j] * lambda;
        }

        /// <summary>
        /// Division rows
        /// </summary>
        /// <param name="row">Index row source</param>
        /// <param name="lambda">Divider</param>
        public void RowDivision(ulong row, double lambda)
        {
            RowMultiplication(row, 1 / lambda);
        }

        /// <summary>
        /// Subtraction rows
        /// </summary>
        /// <param name="rowSourceIndex">Index row source</param>
        /// <param name="rowDestIndex">Index row destination</param>
        public void RowsSubtraction(ulong rowSourceIndex, ulong rowDestIndex)
        {
            for (ulong j = 0; j < ColumnsCount; j++)
                this[rowSourceIndex, j] = this[rowSourceIndex, j] - this[rowDestIndex, j];
        }

        /// <summary>
        /// Addition rows
        /// </summary>
        /// <param name="rowSourceIndex">Index row source</param>
        /// <param name="rowDestIndex">Index row destination</param>
        public void RowsAddition(ulong rowSourceIndex, ulong rowDestIndex)
        {
            for (ulong j = 0; j < ColumnsCount; j++)
                this[rowSourceIndex, j] = this[rowSourceIndex, j] + this[rowDestIndex, j];
        }

        /// <summary>
        /// Transposition rows
        /// </summary>
        /// <param name="rowSourceIndex">Index row source</param>
        /// <param name="rowDestIndex">Index row destination</param>
        public void RowsTransposition(ulong rowSourceIndex, ulong rowDestIndex)
        {
            if (rowSourceIndex >= RowsCount || rowDestIndex >= RowsCount)
                throw new Exception("Index row out of range");

            for (ulong j = 0; j < ColumnsCount; j++)
            {
                double temp = this[rowSourceIndex, j];
                this[rowSourceIndex, j] = this[rowDestIndex, j];
                this[rowDestIndex, j] = temp;
            }
        }

        /// <summary>
        /// Determinant of matrix
        /// </summary>
        /// <param name="matrix">Matrix</param>
        /// <returns>Value of Determinant</returns>
        public static double Determinant(Matrix matrix)
        { 
            if (!matrix.IsSquare())
                throw new Exception("Matrix not square");

            if (matrix.RowsCount==1)
                return matrix[0,0];

            if (matrix.RowsCount == 2)
                return (matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]);

            if (matrix.RowsCount == 3)
                return (matrix[0, 0] * matrix[1, 1] * matrix[2, 2] - matrix[0, 0] * matrix[1, 2] * matrix[2, 1] - matrix[0, 1] * matrix[1, 0] * matrix[2, 2]
                    + matrix[0, 1] * matrix[1, 2] * matrix[2, 0] + matrix[0, 2] * matrix[1, 0] * matrix[2, 1]
                     - matrix[0, 2] * matrix[1, 1] * matrix[2, 0]);

            ulong i = 0;

            double sum = 0;
            for (ulong j = 0; j < matrix.RowsCount; j++)
            { 
                double a = matrix[i, j];
                sum+=Math.Pow(-1.0, (i + 1) + (j + 1)) * a * matrix.Minor(i,j);
            }

            return sum;
        }

        /// <summary>
        /// Determinant of matrix
        /// </summary>
        /// <param name="matrix">Matrix</param>
        /// <returns>Value of Determinant</returns>
        public static double Det(Matrix matrix)
        {
            return Determinant(matrix);
        }

        /// <summary>
        /// Determinant of matrix
        /// </summary>
        /// <returns>Value of Determinant</returns>
        public double Determinant()
        {
            return Determinant(this);
        }

        /// <summary>
        /// Determinant of matrix
        /// </summary>
        /// <returns>Value of Determinant</returns>
        public double Det()
        {
            return Det(this);
        }

        /// <summary>
        /// Minor of matrix
        /// </summary>
        /// <param name="rowIndex">Index row element</param>
        /// <param name="columnIndex">Index column element</param>
        /// <returns>Value of minor</returns>
        public double Minor(ulong rowIndex,ulong columnIndex)
        {
            return Minor(this, rowIndex, columnIndex);
        }

        /// <summary>
        /// Minor of matrix
        /// </summary>
        /// <param name="matrix">Matrix</param> 
        /// <param name="rowIndex">Index row element</param>
        /// <param name="columnIndex">Index column element</param>
        /// <returns>Value of minor</returns>
        public static double Minor(Matrix matrix, ulong rowIndex, ulong columnIndex)
        {
            if (!matrix.IsSquare())
                throw new Exception("Matrix not square");
            if (rowIndex >= matrix.RowsCount || columnIndex >= matrix.ColumnsCount)
                throw new Exception("Error index matrix");

            var newmatrix = new Matrix(matrix.RowsCount - 1, matrix.ColumnsCount - 1);

            for (ulong i = 0; i < matrix.RowsCount; i++)
                for (ulong j = 0; j < matrix.ColumnsCount; j++)
                {
                    if (i == rowIndex || j == columnIndex)
                        continue;
                    if (i < rowIndex && j < columnIndex)
                        newmatrix[i, j] = matrix[i, j];
                    else if (i < rowIndex && j > columnIndex)
                        newmatrix[i, j-1] = matrix[i, j];
                    else if (i > rowIndex && j < columnIndex)
                        newmatrix[i-1, j] = matrix[i,j];
                    if (i > rowIndex && j > columnIndex)
                        newmatrix[i - 1, j-1] = matrix[i, j];
                }

            return newmatrix.Determinant();
        }

        /// <summary>
        /// Rank of matrix
        /// </summary>
        /// <returns>Value of rank</returns>
        public ulong Rank()
        {
            return Rank(this);
        }

        /// <summary>
        /// Rank of matrix
        /// </summary>
        /// <param name="matrix">Matrix</param>
        /// <returns>Value of rank</returns>
        public static ulong Rank(Matrix matrix)
        {
            if (matrix.IsZero())
                return 0;

            Matrix I = Identity(matrix.RowsCount);

            if (!matrix.MoveIfNeed(0, 0))
                matrix.RowDivision(0, matrix[0, 0]);

            for (ulong i = 1; i < matrix.RowsCount; i++)
            {
                
                for (ulong q = 0; q < i; q++)
                {
                    matrix.RowsSubtraction(i, q, matrix[i, q]);
                }

                if (i >= matrix.ColumnsCount)
                    continue;

                if (matrix[i, i] != 0)
                {
                    matrix.RowDivision(i, matrix[i, i]);
                }
                else
                {
                    matrix.MoveIfNeed(i, i);
                }
            }

               for (ulong i = matrix.RowsCount-1; i >0; i--)
               {
                   if (i >= matrix.ColumnsCount)
                       continue;
                   for (ulong j = i - 1; j >= 0; j--)
                   {
                       if (j >= matrix.RowsCount)
                           continue;
                       double element = matrix[j, i];
                       matrix.RowsSubtraction(j, i, element);
                       if (j == 0) break;
                   }
               }

            ulong rank = 0;
             for (ulong i = 0; i < matrix.RowsCount; i++)
             {

                 for (ulong j = 0; j < matrix.ColumnsCount; j++)
                 {
                     if (matrix[i, j] != 0)
                     {
                         rank++;
                         break;
                     }
                 }
             }
            return rank;

        }

        /// <summary>
        /// Trace of matrix
        /// </summary>
        /// <returns>Trace of matrix</returns>
        public double Trace()
        {
            return Trace(this);
        }

        /// <summary>
        /// Trace of matrix
        /// </summary>
        /// <param name="matrix">Matrix</param>
        /// <returns>Trace of matrix</returns>
        public static double Trace(Matrix matrix)
        {
            if (!matrix.IsSquare())
                throw new Exception("No square matrix");
            double sum = 0;
            for (ulong i = 0; i < matrix.RowsCount; i++)
                sum += matrix[i, i];
            return sum;
        }

        #endregion

        #region TypeMatrix

        /// <summary>
        /// If element matrix put in superdiagonal
        /// </summary>
        /// <param name="rowIndex">Index row element</param>
        /// <param name="columnIndex">Index column element</param>
        /// <returns>True/False</returns>
        public bool IsElementOnSuperDiagonal(ulong rowIndex, ulong columnIndex)
        {
            if ((rowIndex >= RowsCount) || (columnIndex >= ColumnsCount))
                throw new Exception("Index out of range");
            return (( rowIndex+1) == columnIndex);
        }

        /// <summary>
        /// If element matrix put in subdiagonal
        /// </summary>
        /// <param name="rowIndex">Index row element</param>
        /// <param name="columnIndex">Index column element</param>
        /// <returns>True/False</returns>
        public bool IsElementOnSubDiagonal(ulong rowIndex, ulong columnIndex)
        {
            if ((rowIndex >= RowsCount) || (columnIndex >= ColumnsCount))
                throw new Exception("Index out of range");
            return (rowIndex == (columnIndex+1));
        }

        /// <summary>
        /// If element matrix put in anti-diagonal
        /// </summary>
        /// <param name="rowIndex">Index row element</param>
        /// <param name="columnIndex">Index column element</param>
        /// <returns>True/False</returns>
        public bool IsElementOnAntiDiagonal(ulong rowIndex, ulong columnIndex)
        {
            if ((rowIndex >= RowsCount) || (columnIndex >= ColumnsCount))
                throw new Exception("Index out of range");
            return ((RowsCount - 1 - rowIndex) == columnIndex);
        }

        /// <summary>
        /// If element matrix put in main diagonal
        /// </summary>
        /// <param name="rowIndex">Index row element</param>
        /// <param name="columnIndex">Index column element</param>
        /// <returns>True/False</returns>
        public bool IsElementOnMainDiagonal(ulong rowIndex, ulong columnIndex)
        {
            if ((rowIndex >= RowsCount) || (columnIndex >= ColumnsCount))
                throw new Exception("Index out of range");
            return (rowIndex == columnIndex);
        }

        /// <summary>
        /// Is a symmetric matrix
        /// </summary>
        /// <returns>True/False</returns>
        public bool IsSymmetric()
        { 
            if(!IsSquare())
                return false;
             for (ulong i = 0; i < RowsCount; i++)
                for (ulong j = 0; j < ColumnsCount; j++)
                {
                    if (this[i, j] != this[j, i])
                        return false;
                }
             return true;
        }

        /// <summary>
        /// Is a square matrix
        /// </summary>
        /// <returns>True/False</returns>
        public bool IsSquare()
        {
            return (_rowsCount == _columnsCount);
        }

        /// <summary>
        /// Is a diagonal matrix
        /// </summary>
        /// <returns>True/False</returns>
        public bool IsDiagonal()
        {
            for (ulong i = 0; i < RowsCount; i++)
                for (ulong j = 0; j < ColumnsCount; j++)
                    if (i != j && this[i, j] != 0)
                        return false;
            return true;
        }

        /// <summary>
        /// Is a Bidiagonal matrix
        /// </summary>
        /// <returns>True/False</returns>
        public bool IsBiDiagonal()
        {
            return IsUpperBiDiagonal() || IsLowerBiDiagonal();
        }

        /// <summary>
        /// Is a Upper Bidiagonal matrix
        /// </summary>
        /// <returns>True/False</returns>
        public bool IsUpperBiDiagonal()
        {
            for (ulong i = 0; i < RowsCount; i++)
                for (ulong j = 0; j < ColumnsCount; j++)
                    if (i != j && this[i, j] != 0)
                    {
                        if (i!=(j-1))
                            return false;
                    }
            return true;
        }

        /// <summary>
        /// Is a Lower Bidiagonal matrix
        /// </summary>
        /// <returns>True/False</returns>
        public bool IsLowerBiDiagonal()
        {
            for (ulong i = 0; i < this.RowsCount; i++)
                for (ulong j = 0; j < this.ColumnsCount; j++)
                    if (i != j && this[i, j] != 0)
                    {
                        if ((i - 1) != j)
                            return false;
                    }
            return true;
        }

        /// <summary>
        /// Is a diagonally dominant matrix
        /// </summary>
        /// <returns>True/False</returns>
        public bool IsDiagonallyDominant()
        {
            for (ulong i = 0; i < this.RowsCount; i++)
            {
                double sum=0;
                for (ulong j = 0; j < this.ColumnsCount; j++)
                    if (i!=j)
                        sum += Math.Abs(this[i, j]);
                if (this[i, i] < sum)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Is a strict diagonally dominant matrix
        /// </summary>
        /// <returns>True/False</returns>
        public bool IsStrictDiagonallyDominant()
        {
            for (ulong i = 0; i < RowsCount; i++)
            {
                double sum = 0;
                for (ulong j = 0; j < ColumnsCount; j++)
                    if (i != j)
                        sum += Math.Abs(this[i, j]);
                if (this[i, i] <= sum)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Is a anti-diagonal matrix
        /// </summary>
        /// <returns>True/False</returns>
        public bool IsAntiDiagonal()
        {
            
            for (ulong i = RowsCount-1; i>=0; i--)
            {
                
                for (ulong j = 0; j < this.ColumnsCount; j++)
                    if (!IsElementOnAntiDiagonal(i, j) && this[i, j] != 0)
                        return false;
                if (i == 0) break;
            }
            return true;
        }

        /// <summary>
        /// Is a zero matrix
        /// </summary>
        /// <returns>True/False</returns>
        public bool IsZero()
        {
            for (ulong i = 0; i < RowsCount; i++)
                for (ulong j = 0; j < ColumnsCount; j++)
                    if (this[i, j] != 0)
                        return false;
            return true;
        }

        /// <summary>
        /// Get identity matrix
        /// </summary>
        /// <param name="size">Size matrix</param>
        /// <returns>Identity matrix</returns>
        public static Matrix Identity(ulong size)
        {
            var identity = new Matrix(size, size);
            for (ulong i = 0; i < identity.RowsCount; i++)
                for (ulong j = 0; j < identity.ColumnsCount; j++)
                {
                    if (identity.IsElementOnMainDiagonal(i, j))
                        identity[i, j] = 1;
                    else
                        identity[i, j] = 0;
                }
            return identity;
        }

        /// <summary>
        /// Get identity matrix
        /// </summary>
        /// <param name="size">Size matrix</param>
        /// <returns>Identity matrix</returns>
        public static Matrix Eye(ulong size)
        {
            return Identity(size);
        }

        /// <summary>
        /// Get zero matrix
        /// </summary>
        /// <param name="rowsCount">Count of rows</param>
        /// <param name="columnsCount">Count of columns</param>
        /// <returns>Zero matrix</returns>
        public static Matrix Zero(ulong rowsCount, ulong columnsCount)
        {
            var zero = new Matrix(rowsCount, columnsCount);
            for (ulong i = 0; i < zero.RowsCount; i++)
                for (ulong j = 0; j < zero.ColumnsCount; j++)
                    zero[i, j] = 0;
            return zero;
        }

        /// <summary>
        /// Get zero matrix
        /// </summary>
        /// <param name="size">Size matrix</param>
        /// <returns>Zero matrix</returns>
        public static Matrix Zero(ulong size)
        {
            return Zero(size, size);
        }

        /// <summary>
        /// Get scalar matrix
        /// </summary>
        /// <param name="size">Size matrix</param>
        /// <param name="lambda">Scalar multiple</param>
        /// <returns>Scalar matrix</returns>
        public static Matrix Scalar(ulong size,double lambda)
        {
            return Eye(size) * lambda;
        }

        /// <summary>
        /// Exchange matrix
        /// </summary>
        /// <param name="size">Size matrix</param>
        /// <returns>Exchange matrix</returns>
        public static Matrix Exchange(ulong size)
        {
            var exchange = new Matrix(size, size);
            for (ulong i = 0; i < exchange.RowsCount; i++)
                for (ulong j = 0; j < exchange.ColumnsCount; j++)
                {
                    if (exchange.IsElementOnAntiDiagonal(i, j))
                        exchange[i, j] = 1;
                    else
                        exchange[i, j] = 0;
                }
            return exchange;
        }

        /// <summary>
        /// Hilbert matrix
        /// </summary>
        /// <param name="size">Size matrix</param>
        /// <returns>Hilbert matrix</returns>
        public static Matrix Hilbert(ulong size)
        {
            var matrix = new Matrix(size, size);
            for (ulong i = 0; i < matrix.RowsCount; i++)
                for (ulong j = 0; j < matrix.ColumnsCount; j++)
                    matrix[i, j] = HilbertElement(i,j);
            return matrix;
        }

        /// <summary>
        /// Calculate Hilbert Element
        /// </summary>
        /// <param name="rowIndex">Index row element</param>
        /// <param name="columnIndex">Index column element</param>
        /// <returns>Hilbert Element</returns>
        private static double HilbertElement(ulong rowIndex, ulong columnIndex)
        {
            rowIndex++;
            columnIndex++;
            return 1.0 / (rowIndex + columnIndex-1);
        }

        /// <summary>
        /// Lehmer matrix
        /// </summary>
        /// <param name="size">Size matrix</param>
        /// <returns>Lehmer matrix</returns>
        public static Matrix Lehmer(ulong size)
        {
            var matrix = new Matrix(size, size);
            for (ulong i = 0; i < matrix.RowsCount; i++)
                for (ulong j = 0; j < matrix.ColumnsCount; j++)
                    matrix[i, j] =LehmerElement(i, j);
            return matrix;
        }

        /// <summary>
        /// Calculate Lehmer Element
        /// </summary>
        /// <param name="rowIndex">Index row element</param>
        /// <param name="columnIndex">Index column element</param>
        /// <returns>Lehmer Element</returns>
        private static double LehmerElement(ulong rowIndex, ulong columnIndex)
        {
            rowIndex++;
            columnIndex++;
            return Math.Min(rowIndex, columnIndex) / (double)Math.Max(rowIndex, columnIndex);
        }

        /// <summary>
        /// Pascal matrix
        /// </summary>
        /// <param name="size">Size matrix</param>
        /// <returns>Pascal matrix</returns>
        public static Matrix Pascal(ulong size)
        {
            var matrix = new Matrix(size, size);
            for (ulong i = 0; i < matrix.RowsCount; i++)
                for (ulong j = 0; j < matrix.ColumnsCount; j++)
                    matrix[i, j] = PascalElement(i, j);
            return matrix;
        }

        /// <summary>
        /// Calculate Pascal Element
        /// </summary>
        /// <param name="rowIndex">Index row element</param>
        /// <param name="columnIndex">Index column element</param>
        /// <returns>Pascal Element</returns>
        private static double PascalElement(ulong rowIndex, ulong columnIndex)
        {
            rowIndex++;
            rowIndex++;
            ulong n = rowIndex + columnIndex - 2;
            ulong r = rowIndex -1;
            return Factorial(n) / (double)(Factorial(r) * Factorial(n-r));
        }

        /// <summary>
        /// Calculate factorial
        /// </summary>
        /// <param name="number">Number</param>
        /// <returns>Factorial</returns>
        private static ulong Factorial(ulong number)
        {
            if (number==1)
                return 1;
            return number*Factorial(number-1);
        }

        /// <summary>
        /// Redheffer matrix
        /// </summary>
        /// <param name="size">Size matrix</param>
        /// <returns>Redheffer matrix</returns>
        public static Matrix Redheffer(ulong size)
        {
            var matrix = new Matrix(size, size);
            for (ulong i = 0; i < matrix.RowsCount; i++)
                for (ulong j = 0; j < matrix.ColumnsCount; j++)
                    matrix[i, j] = RedhefferElement(i, j);
            return matrix;
        }

        /// <summary>
        /// Calculate Redheffer Element
        /// </summary>
        /// <param name="rowIndex">Index row element</param>
        /// <param name="columnIndex">Index column element</param>
        /// <returns>Redheffer Element</returns>
        private static double RedhefferElement(ulong rowIndex, ulong columnIndex)
        {
            rowIndex++;
            columnIndex++;

            if (columnIndex == 1) return 1;

            long residuals = 0;
            Math.DivRem((long)rowIndex, (long)columnIndex, out residuals);

            if (residuals == 0) return 1;

            return 0;
        }

        /// <summary>
        /// Upper shift matrix
        /// </summary>
        /// <param name="size">Size matrix</param>
        /// <returns>Upper shift matrix</returns>
        public static Matrix UpperShift(ulong size)
        {
            var matrix = new Matrix(size, size);
            for (ulong i = 0; i < matrix.RowsCount; i++)
                for (ulong j = 0; j < matrix.ColumnsCount; j++)
                {
                    if (matrix.IsElementOnSuperDiagonal(i,j))
                        matrix[i, j] = 1;
                    else
                        matrix[i, j] = 0;

                }
            return matrix;
        }

        /// <summary>
        /// Lower shift matrix
        /// </summary>
        /// <param name="size">Size matrix</param>
        /// <returns>Lower shift matrix</returns>
        public static Matrix LowerShift(ulong size)
        {
            var matrix = new Matrix(size, size);
            for (ulong i = 0; i < matrix.RowsCount; i++)
                for (ulong j = 0; j < matrix.ColumnsCount; j++)
                {
                    if (matrix.IsElementOnSubDiagonal(i, j))
                        matrix[i, j] = 1;
                    else
                        matrix[i, j] = 0;

                }
            return matrix;
        }

        /// <summary>
        /// Get ones matrix
        /// </summary>
        /// <param name="rowsCount">Count of rows</param>
        /// <param name="columnsCount">Count of columns</param>
        /// <returns>Ones matrix</returns>
        public static Matrix Ones(ulong rowsCount, ulong columnsCount)
        {
            var matrix = new Matrix(rowsCount, columnsCount);
            for (ulong i = 0; i < matrix.RowsCount; i++)
                for (ulong j = 0; j < matrix.ColumnsCount; j++)
                    matrix[i, j] = 1;
            return matrix;
        }

        #endregion

        #region helper functions

        /// <summary>
        /// Matrix To Two-dimensional Array
        /// </summary>
        /// <returns>Two-dimensional Array</returns>
        public double[,] ToArray()
        {
            return _data;
        }

        /// <summary>
        /// Copy of matrix
        /// </summary>
        /// <returns>Copy matrix</returns>
        public Matrix Clone()
        {
            return (Matrix)MemberwiseClone();
        }

        #endregion

        #region Operators

        public static bool operator ==(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1 == null && matrix2 == null)
                return true;
            if (matrix1 == null || matrix2 == null)
                return false;

            var rowsCount1 = matrix1.RowsCount;

            var rowsCount2 = matrix2.RowsCount;
            var columnsCount1 = matrix1.ColumnsCount; var columnsCount2 = matrix2.ColumnsCount;

            if ((rowsCount1 != rowsCount2) || (columnsCount1 != columnsCount2))
            {
                return false;
            }
            for (ulong i = 0; i < rowsCount1; i++)
            {
                for (ulong j = 0; j < columnsCount1; j++)
                {
                    if (matrix1[i, j] != matrix2[i, j])
                        return false;
                }
            }

            return true;
        }
        public static bool operator !=(Matrix matrix1, Matrix matrix2)
        {
            return !(matrix1 == matrix2);
        }
        public static Matrix operator +(Matrix matrix, double a)
        {
            var newMatrix = new Matrix(matrix.RowsCount, matrix.ColumnsCount);
            for (ulong i = 0; i < matrix.RowsCount; i++)
                for (ulong j = 0; j < matrix.ColumnsCount; j++)
                    newMatrix[i, j] = matrix[i, j] + a;

            return newMatrix;
        }
        public static Matrix operator +(Matrix matrix, int a)
        {
            return matrix + Convert.ToDouble(a);
        }
        public static Matrix operator +(Matrix matrix, uint a)
        {
            return matrix + Convert.ToDouble(a);
        }
        public static Matrix operator +(Matrix matrix, long a)
        {
            return matrix + Convert.ToDouble(a);
        }
        public static Matrix operator +(Matrix matrix, ulong a)
        {
            return matrix + Convert.ToDouble(a);
        }
        public static Matrix operator +(Matrix matrix, float a)
        {
            return matrix + Convert.ToDouble(a);
        }
        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            ulong rowsCount1 = matrix1.RowsCount; ulong rowsCount2 = matrix2.RowsCount;
            ulong columnsCount1 = matrix1.ColumnsCount; ulong columnsCount2 = matrix2.ColumnsCount;
            if ((rowsCount1 != rowsCount2) || (columnsCount1 != columnsCount2))
                throw new Exception("Matrix dimensions donot agree");

            var newMatrix = new Matrix(rowsCount1, columnsCount1);

            for (ulong i = 0; i < rowsCount1; i++)
                for (ulong j = 0; j < columnsCount1; j++)
                    newMatrix[i, j] = matrix1[i, j] + matrix2[i, j];

            return newMatrix;
        }
        public static Matrix operator -(Matrix matrix, double a)
        {
            return matrix + (-a);
        }
        public static Matrix operator -(Matrix matrix, int a)
        {
            return matrix - Convert.ToDouble(a);
        }
        public static Matrix operator -(Matrix matrix, uint a)
        {
            return matrix - Convert.ToDouble(a);
        }
        public static Matrix operator -(Matrix matrix, long a)
        {
            return matrix - Convert.ToDouble(a);
        }
        public static Matrix operator -(Matrix matrix, ulong a)
        {
            return matrix - Convert.ToDouble(a);
        }
        public static Matrix operator -(Matrix matrix, float a)
        {
            return matrix - Convert.ToDouble(a);
        }
        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            ulong rowsCount1 = matrix1.RowsCount; ulong rowsCount2 = matrix2.RowsCount;
            ulong columnsCount1 = matrix1.ColumnsCount; ulong columnsCount2 = matrix2.ColumnsCount;
            if ((rowsCount1 != rowsCount2) || (columnsCount1 != columnsCount2))
                throw new Exception("Matrix dimensions donot agree");

            var newMatrix = new Matrix(rowsCount1, columnsCount1);

            for (ulong i = 0; i < rowsCount1; i++)
                for (ulong j = 0; j < columnsCount1; j++)
                    newMatrix[i, j] = matrix1[i, j] - matrix2[i, j];

            return newMatrix;
        }
        public static Matrix operator *(Matrix matrix, double a)
        {
            var newMatrix = new Matrix(matrix.RowsCount, matrix.ColumnsCount);

            for (ulong i = 0; i < matrix.RowsCount; i++)
                for (ulong j = 0; j < matrix.ColumnsCount; j++)
                    newMatrix[i, j] = matrix[i, j] * a;

            return newMatrix;
        }
        public static Matrix operator *(Matrix matrix, int a)
        {
            return matrix * Convert.ToDouble(a);
        }
        public static Matrix operator *(Matrix matrix, uint a)
        {
            return matrix * Convert.ToDouble(a);
        }
        public static Matrix operator *(Matrix matrix, long a)
        {
            return matrix * Convert.ToDouble(a);
        }
        public static Matrix operator *(Matrix matrix, ulong a)
        {
            return matrix * Convert.ToDouble(a);
        }
        public static Matrix operator *(Matrix matrix, float a)
        {
            return matrix * Convert.ToDouble(a);
        }
        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            ulong rowsCount1 = matrix1.RowsCount; ulong rowsCount2 = matrix2.RowsCount;
            ulong columnsCount1 = matrix1.ColumnsCount; ulong columnsCount2 = matrix2.ColumnsCount;
            if ((rowsCount1 != rowsCount2) || (columnsCount1 != columnsCount2))
                throw new Exception("Matrix dimensions donot agree");

            var newMatrix = new Matrix(rowsCount1, columnsCount1);

            for (ulong i = 0; i < matrix1.RowsCount; i++)
                for (ulong j = 0; j < matrix2.ColumnsCount; j++)
                    for (ulong k = 0; k < matrix2.RowsCount; k++)
                        newMatrix[i, j] = newMatrix[i, j] + (matrix1[i, k] * matrix2[k, j]);
            return newMatrix;
        }
        public static Matrix operator /(Matrix matrix, double a)
        {
            var newMatrix = new Matrix(matrix.RowsCount, matrix.ColumnsCount);

            for (ulong i = 0; i < matrix.RowsCount; i++)
                for (ulong j = 0; j < matrix.ColumnsCount; j++)
                    newMatrix[i, j] = matrix[i, j] / a;

            return newMatrix;
        }
        public static Matrix operator /(Matrix matrix, int a)
        {
            return matrix / Convert.ToDouble(a);
        }
        public static Matrix operator /(Matrix matrix, uint a)
        {
            return matrix / Convert.ToDouble(a);
        }
        public static Matrix operator /(Matrix matrix, long a)
        {
            return matrix / Convert.ToDouble(a);
        }
        public static Matrix operator /(Matrix matrix, ulong a)
        {
            return matrix / Convert.ToDouble(a);
        }
        public static Matrix operator /(Matrix matrix, float a)
        {
            return matrix / Convert.ToDouble(a);
        }

        #endregion

        #region norm

        /// <summary>
        /// Norming matrix
        /// </summary>
        /// <param name="typeNorm">Tpe Matrix Norm</param>
        /// <param name="p">P-degree for P-norm. By default p=1.</param>
        public void Norming(TypeMatrixNorm typeNorm, ulong p = 1)
        {
           Matrix matrix= Norming(this, typeNorm, p);
           _data = matrix.ToArray();
           _rowsCount = matrix.RowsCount;
           _columnsCount = matrix.ColumnsCount;
        }

        /// <summary>
        /// Norming matrix
        /// </summary>
        /// <param name="matrix">Type Matrix Norm</param>
        /// <param name="typeNorm">Tpe Matrix Norm</param>
        /// <param name="p">P-degree for P-norm. By default p=1.</param>
        /// <returns>Norming matrix</returns>
        public static Matrix Norming(Matrix matrix, TypeMatrixNorm typeNorm, ulong p = 1)
        {
            double norm = Norm(matrix, typeNorm, p);
            return (matrix / norm);
        }
        /// <summary>
        /// Matrix Norm
        /// </summary>
        /// <param name="typeNorm">Type Matrix Norm</param>
        /// <param name="p">P-degree for P-norm. By default p=1.</param>
        /// <returns>Norm</returns>
        public double Norm(TypeMatrixNorm typeNorm, ulong p = 1)
        {
            return Norm(this, typeNorm, p);
        }

        /// <summary>
        /// Matrix Norm
        /// </summary>
        /// <param name="matrix">Matrix</param>
        /// <param name="typeNorm">Type Matrix Norm</param>
        /// <param name="p">P-degree for P-norm. By default p=1.</param>
        /// <returns>Norm</returns>
        public static double Norm(Matrix matrix, TypeMatrixNorm typeNorm, ulong p=1)
        {
            double norm = 0, sum = 0, max = 0;
            switch (typeNorm)
            {
                case TypeMatrixNorm.Frobenius:
                    sum = 0;
                    for (ulong i = 0; i < matrix.RowsCount; i++)
                        for (ulong j = 0; j < matrix.ColumnsCount; j++)
                            sum += (matrix[i, j] * matrix[i, j]);
                    norm = Math.Sqrt(sum);
                    break;
                case TypeMatrixNorm.M:
                    max = 0;
                    for (ulong i = 0; i < matrix.RowsCount; i++)
                    {
                        sum = 0;
                        for (ulong j = 0; j < matrix.ColumnsCount; j++)
                            sum += Math.Abs(matrix[i, j]);
                        max = (sum > max) ? sum : max;
                    }
                    norm = max;
                    break;
                case TypeMatrixNorm.L:
                    max = 0;
                    for (ulong j = 0; j < matrix.ColumnsCount; j++)
                    {
                        sum = 0;
                        for (ulong i = 0; i < matrix.RowsCount; i++)
                            sum += Math.Abs(matrix[i, j]);
                        max = (sum > max) ? sum : max;
                    }
                    norm = max;
                    break;
                case TypeMatrixNorm.Max:
                    max = 0;
                    for (ulong j = 0; j < matrix.ColumnsCount; j++)
                        for (ulong i = 0; i < matrix.RowsCount; i++)
                            max = (Math.Abs(matrix[i, j]) > max) ? Math.Abs(matrix[i, j]) : max;
                    norm = max;
                    break;
                case TypeMatrixNorm.P:
                     sum = 0;
                    for (ulong i = 0; i < matrix.RowsCount; i++)
                        for (ulong j = 0; j < matrix.ColumnsCount; j++)
                            sum += (Math.Pow(matrix[i, j],p));
                    norm = Math.Pow(sum,1.0/p);
                    break;
            }
            return norm;
        }

        #endregion

        #region Члены IComparable

        /// <summary>
        /// Get Hash Code Matrix
        /// </summary>
        /// <returns>Hash Code</returns>
        public override int GetHashCode()//возможно нужно изменить
        {
            int sum = 1;
            for (ulong i = 0; i < RowsCount; i++)
            {
                for (ulong j = 0; j < ColumnsCount; j++)
                {
                    sum *= _data[i, j].GetHashCode();
                }
            }
            return sum;
        }

      

        public int CompareTo(object obj)
        {
            if ((!(obj is Matrix))||(obj==null))
            {
                throw new ArgumentException("Object is not a Matrix");
            }

            if (this.Equals((obj as Matrix)))
                return 0;
            else
                return -1;
        }

        public override bool Equals(object obj)
        {
            if ((!(obj is Matrix)) || (obj == null))
            {
                throw new ArgumentException("Object is not a Matrix");
            }
            return this.Equals((obj as Matrix));
        }

        #endregion

        #region Члены IEquatable<Matrix>

        public bool Equals(Matrix other)
        {
            return this == other;
        }

        #endregion

        #region Члены IEnumerable

        public IEnumerator GetEnumerator()
        {
            return new MatrixEnumerator(this);
        }

        //public IEnumerator GetEnumeratorColumns()
        //{
        //    return new ColumnsEnumerator(this);
        //}

        //public IEnumerator GetEnumeratorRows()
        //{
        //    return new RowsEnumerator(this);
        //}
        #endregion
    }
}
