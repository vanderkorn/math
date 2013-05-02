// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IArithmetic.cs" company="VanDerKorn">
//   Copyright (c) VanDerKorn (vanderkorn@gmail.com). All rights reserved.
// </copyright>
// <summary>
//   The Arithmetic interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Vanderkorn.Matrixes
{
    /// <summary>
    /// The Arithmetic interface.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public interface IArithmetic<T>
    {
        T Sqrt();
        T Abs();
        T Pow(double y);

        //public virtual static bool operator ==(IArithmetic value1, IArithmetic value2)
        //{

        //}

        //public virtual static bool operator !=(IArithmetic value1, IArithmetic value2)
        //{
        //    return !(value1 == value2);
        //}


        //public static bool operator !=(Matrix<TV> matrix1, Matrix<TV> matrix2)
        //{
        //    return !(matrix1 == matrix2);
        //}
        //public static Matrix<TV> operator +(Matrix<TV> matrix, TV a)
        //{
        //    var newMatrix = new Matrix(matrix.RowsCount, matrix.ColumnsCount);
        //    for (ulong i = 0; i < matrix.RowsCount; i++)
        //        for (ulong j = 0; j < matrix.ColumnsCount; j++)
        //            newMatrix[i, j] = matrix[i, j] + a;

        //    return newMatrix;
        //}
        //public static Matrix<TV> operator +(Matrix<TV> matrix, int a)
        //{
        //    return matrix + Convert.ToDouble(a);
        //}
        //public static Matrix<TV> operator +(Matrix<TV> matrix, uint a)
        //{
        //    return matrix + Convert.ToDouble(a);
        //}
        //public static Matrix<TV> operator +(Matrix<TV> matrix, long a)
        //{
        //    return matrix + Convert.ToDouble(a);
        //}
        //public static Matrix<TV> operator +(Matrix<TV> matrix, ulong a)
        //{
        //    return matrix + Convert.ToDouble(a);
        //}
        //public static Matrix<TV> operator +(Matrix<TV> matrix, float a)
        //{
        //    return matrix + Convert.ToDouble(a);
        //}
        //public static Matrix operator +(Matrix<TV> matrix1, Matrix<TV> matrix2)
        //{
        //    ulong rowsCount1 = matrix1.RowsCount; ulong rowsCount2 = matrix2.RowsCount;
        //    ulong columnsCount1 = matrix1.ColumnsCount; ulong columnsCount2 = matrix2.ColumnsCount;
        //    if ((rowsCount1 != rowsCount2) || (columnsCount1 != columnsCount2))
        //        throw new Exception("Matrix dimensions donot agree");

        //    var newMatrix = new Matrix<TV>(rowsCount1, columnsCount1);

        //    for (ulong i = 0; i < rowsCount1; i++)
        //        for (ulong j = 0; j < columnsCount1; j++)
        //            newMatrix[i, j] = matrix1[i, j] + matrix2[i, j];

        //    return newMatrix;
        //}
        //public static Matrix<TV> operator -(Matrix<TV> matrix, TV a)
        //{
        //    return matrix + (-a);
        //}
        //public static Matrix<TV> operator -(Matrix<TV> matrix, int a)
        //{
        //    return matrix - Convert.ToDouble(a);
        //}
        //public static Matrix<TV> operator -(Matrix<TV> matrix, uint a)
        //{
        //    return matrix - Convert.ToDouble(a);
        //}
        //public static Matrix<TV> operator -(Matrix<TV> matrix, long a)
        //{
        //    return matrix - Convert.ToDouble(a);
        //}
        //public static Matrix<TV> operator -(Matrix<TV> matrix, ulong a)
        //{
        //    return matrix - Convert.ToDouble(a);
        //}
        //public static Matrix<TV> operator -(Matrix<TV> matrix, float a)
        //{
        //    return matrix - Convert.ToDouble(a);
        //}
        //public static Matrix<TV> operator -(Matrix<TV> matrix1, Matrix<TV> matrix2)
        //{
        //    ulong rowsCount1 = matrix1.RowsCount; ulong rowsCount2 = matrix2.RowsCount;
        //    ulong columnsCount1 = matrix1.ColumnsCount; ulong columnsCount2 = matrix2.ColumnsCount;
        //    if ((rowsCount1 != rowsCount2) || (columnsCount1 != columnsCount2))
        //        throw new Exception("Matrix dimensions donot agree");

        //    var newMatrix = new Matrix<TV>(rowsCount1, columnsCount1);

        //    for (ulong i = 0; i < rowsCount1; i++)
        //        for (ulong j = 0; j < columnsCount1; j++)
        //            newMatrix[i, j] = matrix1[i, j] - matrix2[i, j];

        //    return newMatrix;
        //}
        //public static Matrix<TV> operator *(Matrix<TV> matrix, TV a)
        //{
        //    var newMatrix = new Matrix<TV>(matrix.RowsCount, matrix.ColumnsCount);

        //    for (ulong i = 0; i < matrix.RowsCount; i++)
        //        for (ulong j = 0; j < matrix.ColumnsCount; j++)
        //            newMatrix[i, j] = matrix[i, j] * a;

        //    return newMatrix;
        //}
        //public static Matrix<TV> operator *(Matrix<TV> matrix, int a)
        //{
        //    return matrix * Convert.ToDouble(a);
        //}
        //public static Matrix<TV> operator *(Matrix<TV> matrix, uint a)
        //{
        //    return matrix * Convert.ToDouble(a);
        //}
        //public static Matrix<TV> operator *(Matrix<TV> matrix, long a)
        //{
        //    return matrix * Convert.ToDouble(a);
        //}
        //public static Matrix<TV> operator *(Matrix<TV> matrix, ulong a)
        //{
        //    return matrix * Convert.ToDouble(a);
        //}
        //public static Matrix<TV> operator *(Matrix<TV> matrix, float a)
        //{
        //    return matrix * Convert.ToDouble(a);
        //}
        //public static Matrix<TV> operator *(Matrix<TV> matrix1, Matrix<TV> matrix2)
        //{
        //    ulong rowsCount1 = matrix1.RowsCount; ulong rowsCount2 = matrix2.RowsCount;
        //    ulong columnsCount1 = matrix1.ColumnsCount; ulong columnsCount2 = matrix2.ColumnsCount;
        //    if ((rowsCount1 != rowsCount2) || (columnsCount1 != columnsCount2))
        //        throw new Exception("Matrix dimensions donot agree");

        //    var newMatrix = new Matrix<TV>(rowsCount1, columnsCount1);

        //    for (ulong i = 0; i < matrix1.RowsCount; i++)
        //        for (ulong j = 0; j < matrix2.ColumnsCount; j++)
        //            for (ulong k = 0; k < matrix2.RowsCount; k++)
        //                newMatrix[i, j] = newMatrix[i, j] + (matrix1[i, k] * matrix2[k, j]);
        //    return newMatrix;
        //}
        //public static Matrix<TV> operator /(Matrix<TV> matrix, TV a)
        //{
        //    var newMatrix = new Matrix<TV>(matrix.RowsCount, matrix.ColumnsCount);

        //    for (ulong i = 0; i < matrix.RowsCount; i++)
        //        for (ulong j = 0; j < matrix.ColumnsCount; j++)
        //            newMatrix[i, j] = matrix[i, j] / a;

        //    return newMatrix;
        //}
        //public static Matrix<TV> operator /(Matrix<TV> matrix, int a)
        //{
        //    return matrix / Convert.ToDouble(a);
        //}
        //public static Matrix<TV> operator /(Matrix<TV> matrix, uint a)
        //{
        //    return matrix / Convert.ToDouble(a);
        //}
        //public static Matrix<TV> operator /(Matrix<TV> matrix, long a)
        //{
        //    return matrix / Convert.ToDouble(a);
        //}
        //public static Matrix<TV> operator /(Matrix<TV> matrix, ulong a)
        //{
        //    return matrix / Convert.ToDouble(a);
        //}
        //public static Matrix<TV> operator /(Matrix<TV> matrix, float a)
        //{
        //    return matrix / Convert.ToDouble(a);
        //}
    }
}
