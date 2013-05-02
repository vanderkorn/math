// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MatrixEnumerator.cs" company="VanDerKorn">
//   Copyright (c) VanDerKorn (vanderkorn@gmail.com). All rights reserved.
// </copyright>
// <summary>
//   Defines the MatrixEnumerator type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Vanderkorn.Matrixes
{
    using System;
    using System.Collections;

    public class MatrixEnumerator : IEnumerator
    {
        Matrix _matrix;
        long position = -1;

        public MatrixEnumerator(Matrix matrix)
        {
            _matrix = matrix;
        }

        public bool MoveNext()
        {
            position++;
            return (position < (int)(_matrix.RowsCount * _matrix.ColumnsCount));
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public double Current
        {
            get
            {
                try
                {
                    var column= 0L;
                    var row = Math.DivRem(position, (long)_matrix.RowsCount, out column);

                    return _matrix[(ulong)row, (ulong)column];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }


}
