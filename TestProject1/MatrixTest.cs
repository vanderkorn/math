using Vanderkorn.Matrixes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
namespace TestProject1
{
    
    
    /// <summary>
    ///Это класс теста для MatrixTest, в котором должны
    ///находиться все модульные тесты MatrixTest
    ///</summary>
    [TestClass()]
    public class MatrixTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Дополнительные атрибуты теста
        // 
        //При написании тестов можно использовать следующие дополнительные атрибуты:
        //
        //ClassInitialize используется для выполнения кода до запуска первого теста в классе
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //TestInitialize используется для выполнения кода перед запуском каждого теста
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //TestCleanup используется для выполнения кода после завершения каждого теста
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        private static Matrix matrixTest1;

        /// <summary>
        ///Тест для Конструктор Matrix
        ///</summary>
        [ClassInitialize()]
        public static void MatrixConstructorTest4(TestContext _testContextInstance)
        {

            //testContextInstance = _testContextInstance;
             matrixTest1 = new Matrix(3, 4);


             matrixTest1[0, 0] = 1.0;
             matrixTest1[0, 1] = 2.0;
             matrixTest1[0, 2] = 0.0;
             matrixTest1[0, 3] = 0.0;

             matrixTest1[1, 0] = 4.0;
             matrixTest1[1, 1] = 6.0;
             matrixTest1[1, 2] = 0.0;
             matrixTest1[1, 3] = 0.0;

             matrixTest1[2, 0] = 7.0;
             matrixTest1[2, 1] = 3.0;
             matrixTest1[2, 2] = 0.0;
             matrixTest1[2, 3] = 0.0;

        }



        /// <summary>
        ///Тест для Abs
        ///</summary>
        [TestMethod()]
        public void AbsTest()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            target.Abs();
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для Abs
        ///</summary>
        [TestMethod()]
        public void AbsTest1()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = Matrix.Abs(matrix);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Clone
        ///</summary>
        [TestMethod()]
        public void CloneTest()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = target.Clone();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Det
        ///</summary>
        [TestMethod()]
        public void DetTest()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            double expected = 0F; // TODO: инициализация подходящего значения
            double actual;
            actual = Matrix.Det(matrix);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Det
        ///</summary>
        [TestMethod()]
        public void DetTest1()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            double expected = 0F; // TODO: инициализация подходящего значения
            double actual;
            actual = target.Det();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Determinant
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(Exception), "Matrix not square")]
        public void DeterminantTest()
        {
       
            double expected = 0F; // TODO: инициализация подходящего значения
            double actual;
            actual = Matrix.Determinant(matrixTest1);
            Assert.AreEqual(expected, null);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Determinant
        ///</summary>
        [TestMethod()]
        public void DeterminantTest1()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            double expected = 0F; // TODO: инициализация подходящего значения
            double actual;
            actual = target.Determinant();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Equals
        ///</summary>
        [TestMethod()]
        public void EqualsTest()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            object obj = null; // TODO: инициализация подходящего значения
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = target.Equals(obj);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Exchange
        ///</summary>
        [TestMethod()]
        public void ExchangeTest()
        {
            ulong size = 0; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = Matrix.Exchange(size);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Eye
        ///</summary>
        [TestMethod()]
        public void EyeTest()
        {
            ulong size = 0; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = Matrix.Eye(size);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Factorial
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Vanderkorn.dll")]
        public void FactorialTest()
        {
            ulong number = 0; // TODO: инициализация подходящего значения
            ulong expected = 0; // TODO: инициализация подходящего значения
            ulong actual;
            actual = Matrix_Accessor.Factorial(number);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для GetHashCode
        ///</summary>
        [TestMethod()]
        public void GetHashCodeTest()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            int expected = 0; // TODO: инициализация подходящего значения
            int actual;
            actual = target.GetHashCode();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Hilbert
        ///</summary>
        [TestMethod()]
        public void HilbertTest()
        {
            ulong size = 0; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = Matrix.Hilbert(size);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для HilbertElement
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Vanderkorn.dll")]
        public void HilbertElementTest()
        {
            ulong rowIndex = 0; // TODO: инициализация подходящего значения
            ulong columnIndex = 0; // TODO: инициализация подходящего значения
            double expected = 0F; // TODO: инициализация подходящего значения
            double actual;
            actual = Matrix_Accessor.HilbertElement(rowIndex, columnIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Identity
        ///</summary>
        [TestMethod()]
        public void IdentityTest()
        {
            ulong size = 0; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = Matrix.Identity(size);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Invertible
        ///</summary>
        [TestMethod()]
        public void InvertibleTest()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            target.Invertible();
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для Invertible
        ///</summary>
        [TestMethod()]
        public void InvertibleTest1()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = Matrix.Invertible(matrix);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для IsAntiDiagonal
        ///</summary>
        [TestMethod()]
        public void IsAntiDiagonalTest()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = target.IsAntiDiagonal();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для IsBiDiagonal
        ///</summary>
        [TestMethod()]
        public void IsBiDiagonalTest()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = target.IsBiDiagonal();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для IsDiagonal
        ///</summary>
        [TestMethod()]
        public void IsDiagonalTest()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = target.IsDiagonal();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для IsDiagonallyDominant
        ///</summary>
        [TestMethod()]
        public void IsDiagonallyDominantTest()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = target.IsDiagonallyDominant();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для IsElementOnAntiDiagonal
        ///</summary>
        [TestMethod()]
        public void IsElementOnAntiDiagonalTest()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            ulong rowIndex = 0; // TODO: инициализация подходящего значения
            ulong columnIndex = 0; // TODO: инициализация подходящего значения
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = target.IsElementOnAntiDiagonal(rowIndex, columnIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для IsElementOnMainDiagonal
        ///</summary>
        [TestMethod()]
        public void IsElementOnMainDiagonalTest()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            ulong rowIndex = 0; // TODO: инициализация подходящего значения
            ulong columnIndex = 0; // TODO: инициализация подходящего значения
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = target.IsElementOnMainDiagonal(rowIndex, columnIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для IsElementOnSubDiagonal
        ///</summary>
        [TestMethod()]
        public void IsElementOnSubDiagonalTest()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            ulong rowIndex = 0; // TODO: инициализация подходящего значения
            ulong columnIndex = 0; // TODO: инициализация подходящего значения
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = target.IsElementOnSubDiagonal(rowIndex, columnIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для IsElementOnSuperDiagonal
        ///</summary>
        [TestMethod()]
        public void IsElementOnSuperDiagonalTest()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            ulong rowIndex = 0; // TODO: инициализация подходящего значения
            ulong columnIndex = 0; // TODO: инициализация подходящего значения
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = target.IsElementOnSuperDiagonal(rowIndex, columnIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для IsLowerBiDiagonal
        ///</summary>
        [TestMethod()]
        public void IsLowerBiDiagonalTest()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = target.IsLowerBiDiagonal();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для IsSquare
        ///</summary>
        [TestMethod()]
        public void IsSquareTest()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = target.IsSquare();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для IsStrictDiagonallyDominant
        ///</summary>
        [TestMethod()]
        public void IsStrictDiagonallyDominantTest()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = target.IsStrictDiagonallyDominant();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для IsSymmetric
        ///</summary>
        [TestMethod()]
        public void IsSymmetricTest()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = target.IsSymmetric();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для IsUpperBiDiagonal
        ///</summary>
        [TestMethod()]
        public void IsUpperBiDiagonalTest()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = target.IsUpperBiDiagonal();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для IsZero
        ///</summary>
        [TestMethod()]
        public void IsZeroTest()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = target.IsZero();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Lehmer
        ///</summary>
        [TestMethod()]
        public void LehmerTest()
        {
            ulong size = 0; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = Matrix.Lehmer(size);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для LehmerElement
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Vanderkorn.dll")]
        public void LehmerElementTest()
        {
            ulong rowIndex = 0; // TODO: инициализация подходящего значения
            ulong columnIndex = 0; // TODO: инициализация подходящего значения
            double expected = 0F; // TODO: инициализация подходящего значения
            double actual;
            actual = Matrix_Accessor.LehmerElement(rowIndex, columnIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для LowerShift
        ///</summary>
        [TestMethod()]
        public void LowerShiftTest()
        {
            ulong size = 0; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = Matrix.LowerShift(size);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Minor
        ///</summary>
        [TestMethod()]
        public void MinorTest()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            ulong rowIndex = 0; // TODO: инициализация подходящего значения
            ulong columnIndex = 0; // TODO: инициализация подходящего значения
            double expected = 0F; // TODO: инициализация подходящего значения
            double actual;
            actual = target.Minor(rowIndex, columnIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Minor
        ///</summary>
        [TestMethod()]
        public void MinorTest1()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            ulong rowIndex = 0; // TODO: инициализация подходящего значения
            ulong columnIndex = 0; // TODO: инициализация подходящего значения
            double expected = 0F; // TODO: инициализация подходящего значения
            double actual;
            actual = Matrix.Minor(matrix, rowIndex, columnIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для MoveIfNeed
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Vanderkorn.dll")]
        public void MoveIfNeedTest()
        {
            PrivateObject param0 = null; // TODO: инициализация подходящего значения
            Matrix_Accessor target = new Matrix_Accessor(param0); // TODO: инициализация подходящего значения
            ulong row = 0; // TODO: инициализация подходящего значения
            ulong column = 0; // TODO: инициализация подходящего значения
            Matrix I = null; // TODO: инициализация подходящего значения
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = target.MoveIfNeed(row, column, I);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для MoveIfNeed
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Vanderkorn.dll")]
        public void MoveIfNeedTest1()
        {
            PrivateObject param0 = null; // TODO: инициализация подходящего значения
            Matrix_Accessor target = new Matrix_Accessor(param0); // TODO: инициализация подходящего значения
            ulong row = 0; // TODO: инициализация подходящего значения
            ulong column = 0; // TODO: инициализация подходящего значения
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = target.MoveIfNeed(row, column);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Norm
        ///</summary>
        [TestMethod()]
        public void NormTest()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            TypeMatrixNorm typeNorm = new TypeMatrixNorm(); // TODO: инициализация подходящего значения
            ulong p = 0; // TODO: инициализация подходящего значения
            double expected = 0F; // TODO: инициализация подходящего значения
            double actual;
            actual = target.Norm(typeNorm, p);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Norm
        ///</summary>
        [TestMethod()]
        public void NormTest1()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            TypeMatrixNorm typeNorm = new TypeMatrixNorm(); // TODO: инициализация подходящего значения
            ulong p = 0; // TODO: инициализация подходящего значения
            double expected = 0F; // TODO: инициализация подходящего значения
            double actual;
            actual = Matrix.Norm(matrix, typeNorm, p);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Norming
        ///</summary>
        [TestMethod()]
        public void NormingTest()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            TypeMatrixNorm typeNorm = new TypeMatrixNorm(); // TODO: инициализация подходящего значения
            ulong p = 0; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = Matrix.Norming(matrix, typeNorm, p);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Norming
        ///</summary>
        [TestMethod()]
        public void NormingTest1()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            TypeMatrixNorm typeNorm = new TypeMatrixNorm(); // TODO: инициализация подходящего значения
            ulong p = 0; // TODO: инициализация подходящего значения
            target.Norming(typeNorm, p);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для Ones
        ///</summary>
        [TestMethod()]
        public void OnesTest()
        {
            ulong rowsCount = 0; // TODO: инициализация подходящего значения
            ulong columnsCount = 0; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = Matrix.Ones(rowsCount, columnsCount);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Pascal
        ///</summary>
        [TestMethod()]
        public void PascalTest()
        {
            ulong size = 0; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = Matrix.Pascal(size);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для PascalElement
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Vanderkorn.dll")]
        public void PascalElementTest()
        {
            ulong rowIndex = 0; // TODO: инициализация подходящего значения
            ulong columnIndex = 0; // TODO: инициализация подходящего значения
            double expected = 0F; // TODO: инициализация подходящего значения
            double actual;
            actual = Matrix_Accessor.PascalElement(rowIndex, columnIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Rank
        ///</summary>
        [TestMethod()]
        public void RankTest()
        {
            ulong expected = 2; // TODO: инициализация подходящего значения
            ulong actual;
            actual = matrixTest1.Rank();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Тест для Rank
        ///</summary>
        [TestMethod()]
        public void RankTest1()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            ulong expected = 0; // TODO: инициализация подходящего значения
            ulong actual;
            actual = Matrix.Rank(matrix);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Redheffer
        ///</summary>
        [TestMethod()]
        public void RedhefferTest()
        {
            ulong size = 0; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = Matrix.Redheffer(size);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для RedhefferElement
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Vanderkorn.dll")]
        public void RedhefferElementTest()
        {
            ulong rowIndex = 0; // TODO: инициализация подходящего значения
            ulong columnIndex = 0; // TODO: инициализация подходящего значения
            double expected = 0F; // TODO: инициализация подходящего значения
            double actual;
            actual = Matrix_Accessor.RedhefferElement(rowIndex, columnIndex);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для RowDivision
        ///</summary>
        [TestMethod()]
        public void RowDivisionTest()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            ulong row = 0; // TODO: инициализация подходящего значения
            double lambda = 0F; // TODO: инициализация подходящего значения
            target.RowDivision(row, lambda);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для RowMultiplication
        ///</summary>
        [TestMethod()]
        public void RowMultiplicationTest()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            ulong rowIndex = 0; // TODO: инициализация подходящего значения
            double lambda = 0F; // TODO: инициализация подходящего значения
            target.RowMultiplication(rowIndex, lambda);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для RowsAddition
        ///</summary>
        [TestMethod()]
        public void RowsAdditionTest()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            ulong rowSourceIndex = 0; // TODO: инициализация подходящего значения
            ulong rowDestIndex = 0; // TODO: инициализация подходящего значения
            target.RowsAddition(rowSourceIndex, rowDestIndex);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для RowsSubtraction
        ///</summary>
        [TestMethod()]
        public void RowsSubtractionTest()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            ulong rowSourceIndex = 0; // TODO: инициализация подходящего значения
            ulong rowDestIndex = 0; // TODO: инициализация подходящего значения
            target.RowsSubtraction(rowSourceIndex, rowDestIndex);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для RowsSubtraction
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Vanderkorn.dll")]
        public void RowsSubtractionTest1()
        {
            PrivateObject param0 = null; // TODO: инициализация подходящего значения
            Matrix_Accessor target = new Matrix_Accessor(param0); // TODO: инициализация подходящего значения
            ulong rowSourceIndex = 0; // TODO: инициализация подходящего значения
            ulong rowDestIndex = 0; // TODO: инициализация подходящего значения
            double lambda = 0F; // TODO: инициализация подходящего значения
            target.RowsSubtraction(rowSourceIndex, rowDestIndex, lambda);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для RowsTransposition
        ///</summary>
        [TestMethod()]
        public void RowsTranspositionTest()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            ulong rowSourceIndex = 0; // TODO: инициализация подходящего значения
            ulong rowDestIndex = 0; // TODO: инициализация подходящего значения
            target.RowsTransposition(rowSourceIndex, rowDestIndex);
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для Scalar
        ///</summary>
        [TestMethod()]
        public void ScalarTest()
        {
            ulong size = 0; // TODO: инициализация подходящего значения
            double lambda = 0F; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = Matrix.Scalar(size, lambda);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для T
        ///</summary>
        [TestMethod()]
        public void TTest()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = Matrix.T(matrix);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для T
        ///</summary>
        [TestMethod()]
        public void TTest1()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            target.T();
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для ToArray
        ///</summary>
        [TestMethod()]
        public void ToArrayTest()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            double[,] expected = null; // TODO: инициализация подходящего значения
            double[,] actual;
            actual = target.ToArray();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Trace
        ///</summary>
        [TestMethod()]
        public void TraceTest()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            double expected = 0F; // TODO: инициализация подходящего значения
            double actual;
            actual = Matrix.Trace(matrix);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Trace
        ///</summary>
        [TestMethod()]
        public void TraceTest1()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            double expected = 0F; // TODO: инициализация подходящего значения
            double actual;
            actual = target.Trace();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Transpose
        ///</summary>
        [TestMethod()]
        public void TransposeTest()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            target.Transpose();
            Assert.Inconclusive("Невозможно проверить метод, не возвращающий значение.");
        }

        /// <summary>
        ///Тест для Transpose
        ///</summary>
        [TestMethod()]
        public void TransposeTest1()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = Matrix.Transpose(matrix);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для UpperShift
        ///</summary>
        [TestMethod()]
        public void UpperShiftTest()
        {
            ulong size = 0; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = Matrix.UpperShift(size);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Zero
        ///</summary>
        [TestMethod()]
        public void ZeroTest()
        {
            ulong size = 0; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = Matrix.Zero(size);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Zero
        ///</summary>
        [TestMethod()]
        public void ZeroTest1()
        {
            ulong rowsCount = 0; // TODO: инициализация подходящего значения
            ulong columnsCount = 0; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = Matrix.Zero(rowsCount, columnsCount);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для op_Addition
        ///</summary>
        [TestMethod()]
        public void op_AdditionTest()
        {
            Matrix matrix1 = null; // TODO: инициализация подходящего значения
            Matrix matrix2 = null; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = (matrix1 + matrix2);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для op_Addition
        ///</summary>
        [TestMethod()]
        public void op_AdditionTest1()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            double a = 0F; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = (matrix + a);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для op_Addition
        ///</summary>
        [TestMethod()]
        public void op_AdditionTest2()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            long a = 0; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = (matrix + a);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для op_Addition
        ///</summary>
        [TestMethod()]
        public void op_AdditionTest3()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            uint a = 0; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = (matrix + a);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для op_Addition
        ///</summary>
        [TestMethod()]
        public void op_AdditionTest4()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            int a = 0; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = (matrix + a);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для op_Addition
        ///</summary>
        [TestMethod()]
        public void op_AdditionTest5()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            float a = 0F; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = (matrix + a);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для op_Addition
        ///</summary>
        [TestMethod()]
        public void op_AdditionTest6()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            ulong a = 0; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = (matrix + a);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для op_Division
        ///</summary>
        [TestMethod()]
        public void op_DivisionTest()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            long a = 0; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = (matrix / a);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для op_Division
        ///</summary>
        [TestMethod()]
        public void op_DivisionTest1()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            uint a = 0; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = (matrix / a);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для op_Division
        ///</summary>
        [TestMethod()]
        public void op_DivisionTest2()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            double a = 0F; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = (matrix / a);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для op_Division
        ///</summary>
        [TestMethod()]
        public void op_DivisionTest3()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            int a = 0; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = (matrix / a);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для op_Division
        ///</summary>
        [TestMethod()]
        public void op_DivisionTest4()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            float a = 0F; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = (matrix / a);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для op_Division
        ///</summary>
        [TestMethod()]
        public void op_DivisionTest5()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            ulong a = 0; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = (matrix / a);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для op_Equality
        ///</summary>
        [TestMethod()]
        public void op_EqualityTest()
        {
            Matrix matrix1 = null; // TODO: инициализация подходящего значения
            Matrix matrix2 = null; // TODO: инициализация подходящего значения
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = (matrix1 == matrix2);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для op_Inequality
        ///</summary>
        [TestMethod()]
        public void op_InequalityTest()
        {
            Matrix matrix1 = null; // TODO: инициализация подходящего значения
            Matrix matrix2 = null; // TODO: инициализация подходящего значения
            bool expected = false; // TODO: инициализация подходящего значения
            bool actual;
            actual = (matrix1 != matrix2);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для op_Multiply
        ///</summary>
        [TestMethod()]
        public void op_MultiplyTest()
        {
            Matrix matrix1 = null; // TODO: инициализация подходящего значения
            Matrix matrix2 = null; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = (matrix1 * matrix2);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для op_Multiply
        ///</summary>
        [TestMethod()]
        public void op_MultiplyTest1()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            uint a = 0; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = (matrix * a);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для op_Multiply
        ///</summary>
        [TestMethod()]
        public void op_MultiplyTest2()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            int a = 0; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = (matrix * a);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для op_Multiply
        ///</summary>
        [TestMethod()]
        public void op_MultiplyTest3()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            double a = 0F; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = (matrix * a);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для op_Multiply
        ///</summary>
        [TestMethod()]
        public void op_MultiplyTest4()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            float a = 0F; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = (matrix * a);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для op_Multiply
        ///</summary>
        [TestMethod()]
        public void op_MultiplyTest5()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            ulong a = 0; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = (matrix * a);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для op_Multiply
        ///</summary>
        [TestMethod()]
        public void op_MultiplyTest6()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            long a = 0; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = (matrix * a);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для op_Subtraction
        ///</summary>
        [TestMethod()]
        public void op_SubtractionTest()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            uint a = 0; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = (matrix - a);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для op_Subtraction
        ///</summary>
        [TestMethod()]
        public void op_SubtractionTest1()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            int a = 0; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = (matrix - a);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для op_Subtraction
        ///</summary>
        [TestMethod()]
        public void op_SubtractionTest2()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            double a = 0F; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = (matrix - a);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для op_Subtraction
        ///</summary>
        [TestMethod()]
        public void op_SubtractionTest3()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            long a = 0; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = (matrix - a);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для op_Subtraction
        ///</summary>
        [TestMethod()]
        public void op_SubtractionTest4()
        {
            Matrix matrix1 = null; // TODO: инициализация подходящего значения
            Matrix matrix2 = null; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = (matrix1 - matrix2);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для op_Subtraction
        ///</summary>
        [TestMethod()]
        public void op_SubtractionTest5()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            float a = 0F; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = (matrix - a);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для op_Subtraction
        ///</summary>
        [TestMethod()]
        public void op_SubtractionTest6()
        {
            Matrix matrix = null; // TODO: инициализация подходящего значения
            ulong a = 0; // TODO: инициализация подходящего значения
            Matrix expected = null; // TODO: инициализация подходящего значения
            Matrix actual;
            actual = (matrix - a);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для ColumnsCount
        ///</summary>
        [TestMethod()]
        public void ColumnsCountTest()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            ulong actual;
            actual = target.ColumnsCount;
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для Item
        ///</summary>
        [TestMethod()]
        public void ItemTest()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            ulong rowIndex = 0; // TODO: инициализация подходящего значения
            ulong columnIndex = 0; // TODO: инициализация подходящего значения
            double expected = 0F; // TODO: инициализация подходящего значения
            double actual;
            target[rowIndex, columnIndex] = expected;
            actual = target[rowIndex, columnIndex];
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }

        /// <summary>
        ///Тест для RowsCount
        ///</summary>
        [TestMethod()]
        public void RowsCountTest()
        {
            double[,] data = null; // TODO: инициализация подходящего значения
            Matrix target = new Matrix(data); // TODO: инициализация подходящего значения
            ulong actual;
            actual = target.RowsCount;
            Assert.Inconclusive("Проверьте правильность этого метода теста.");
        }
    }
}
