// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Arithmetic.cs" company="VanDerKorn">
//   Copyright (c) VanDerKorn (vanderkorn@gmail.com). All rights reserved.
// </copyright>
// <summary>
//   The arithmetic.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Vanderkorn.Matrixes
{
    /// <summary>
    /// The arithmetic.
    /// </summary>
    public abstract class Arithmetic
    {
        #region Operators

        public static bool operator ==(Arithmetic val1, Arithmetic val2)
        {
            return (val1 == val2);
        }
        public static bool operator !=(Arithmetic val1, Arithmetic val2)
        {
            return !(val1 == val2);
        }
        public static Arithmetic operator +(Arithmetic val, double a)
        {
            return (dynamic)val+a;
        }
        public static Arithmetic operator +(Arithmetic val, int a)
        {
            return (dynamic)val + a;
        }
        public static Arithmetic operator +(Arithmetic val, uint a)
        {
            return (dynamic)val + a;
        }
        public static Arithmetic operator +(Arithmetic val, long a)
        {
            return (dynamic)val + a;
        }
        public static Arithmetic operator +(Arithmetic val, ulong a)
        {
            return (dynamic)val + a;
        }
        public static Arithmetic operator +(Arithmetic val, float a)
        {
            return (dynamic)val + a;
        }
        public static Arithmetic operator +(Arithmetic val1, Arithmetic val2)
        {
            return (dynamic)val1 + val2;
        }
        public static Arithmetic operator -(Arithmetic val, double a)
        {
            return (dynamic)val - a;
        }
        public static Arithmetic operator -(Arithmetic val, int a)
        {
            return (dynamic)val - a;
        }
        public static Arithmetic operator -(Arithmetic val, uint a)
        {
            return (dynamic)val - a;
        }
        public static Arithmetic operator -(Arithmetic val, long a)
        {
            return (dynamic)val - a;
        }
        public static Arithmetic operator -(Arithmetic val, ulong a)
        {
            return (dynamic)val - a;
        }
        public static Arithmetic operator -(Arithmetic val, float a)
        {
            return (dynamic)val - a;
        }
        public static Arithmetic operator -(Arithmetic val1, Arithmetic val2)
        {
            return (dynamic)val1 - val2;
        }
        public static Arithmetic operator *(Arithmetic val, double a)
        {
            return (dynamic)val * a;
        }
        public static Arithmetic operator *(Arithmetic val, int a)
        {
            return (dynamic)val * a;
        }
        public static Arithmetic operator *(Arithmetic val, uint a)
        {
            return (dynamic)val * a;
        }
        public static Arithmetic operator *(Arithmetic val, long a)
        {
            return (dynamic)val * a;
        }
        public static Arithmetic operator *(Arithmetic val, ulong a)
        {
            return (dynamic)val * a;
        }
        public static Arithmetic operator *(Arithmetic val, float a)
        {
            return (dynamic)val * a;
        }
        public static Arithmetic operator *(Arithmetic val1, Arithmetic val2)
        {
            return (dynamic)val1 * val2;
        }
        public static Arithmetic operator /(Arithmetic val1, Arithmetic val2)
        {
            return (dynamic)val1 / val2;
        }
        public static Arithmetic operator /(Arithmetic val, double a)
        {
            return (dynamic)val/a;
        }
        public static Arithmetic operator /(Arithmetic val, int a)
        {
            return (dynamic)val / a;
        }
        public static Arithmetic operator /(Arithmetic val, uint a)
        {
            return (dynamic)val / a;
        }
        public static Arithmetic operator /(Arithmetic val, long a)
        {
            return (dynamic)val / a;
        }
        public static Arithmetic operator /(Arithmetic val, ulong a)
        {
            return (dynamic)val / a;
        }
        public static Arithmetic operator /(Arithmetic val, float a)
        {
            return (dynamic)val / a;
        }

        #endregion

        #region Члены IArithmetic<Arithmetic>

        public abstract Arithmetic Sqrt();

        public abstract Arithmetic Abs();

        public abstract Arithmetic Pow(double y);

        #endregion
    }
}
