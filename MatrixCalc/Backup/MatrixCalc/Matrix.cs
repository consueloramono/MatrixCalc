/*--------------------------------------------------------------------------------
 Copyright, 2009
 
 Модуль Matrix предназначен для вычислений над матрицами. 
  Он включает такие функции как сложение матриц, умножение матриц и 
  нахождение обратной матрицы.
  
 Date: 29.03.09 
 -------------------------------------------------------------------------------*/


using System;

namespace MatrixCalc
{
    /// <summary>
    /// Класс предоставляет функции для работы с матрицами.
    /// </summary>
    class Matrix
    {
        private readonly double[,] _matrix;

        /// <summary>
        /// Конструктор для создания матрицы нужного размера
        /// </summary>
        /// <param name="rowsCount">Количество строк</param>
        /// <param name="columnsCount">Количество столбцов</param>
        public Matrix(int rowsCount, int columnsCount)
        {
            _matrix = new double[rowsCount, columnsCount];
        }

        /// <summary>
        /// Индексатор для доступа к элементам матрицы
        /// </summary>
        /// <param name="rowIndex">Индекс строки</param>
        /// <param name="columnIndex">Индекс столбца</param>
        /// <returns>элемент матрицы</returns>
        public double this[int rowIndex, int columnIndex]
        {
            get { return _matrix[rowIndex, columnIndex]; }
            set { _matrix[rowIndex, columnIndex] = value; }
        }

        /// <summary>
        /// Возвращает количество строк
        /// </summary>
        public int RowsCount
        {
            get { return _matrix.GetLength(0); }
        }

        /// <summary>
        /// Возвращает количество столбцов в матрице
        /// </summary>
        public int ColumnsCount
        {
            get { return _matrix.GetLength(1); }
        }

        /// <summary>
        /// Вычисление суммы двух матриц
        /// </summary>
        /// <param name="matrix1">Первая матрица</param>
        /// <param name="matrix2">Вторая матрица</param>
        /// <returns>Матрица результата сложения</returns>
        public static Matrix operator + (Matrix matrix1, Matrix matrix2)
        {
            if (matrix1 == null) throw new ArgumentNullException("matrix1");
            if (matrix2 == null) throw new ArgumentNullException("matrix2");
            if (matrix1.RowsCount != matrix2.RowsCount || matrix1.ColumnsCount != matrix2.ColumnsCount)
                throw new Exception("Матрицы для сложения должны иметь одинаковый размер");
            Matrix result = new Matrix(matrix1.RowsCount, matrix1.ColumnsCount);

            for (int i = 0; i < result.RowsCount; i++)
                for (int j = 0; j < result.ColumnsCount; j++)
                    result[i, j] = matrix1[i, j] + matrix2[i, j];

            return result;
        }

        /// <summary>
        /// Вычисление произведения двух матриц
        /// </summary>
        /// <param name="matrix1">Первая матрица</param>
        /// <param name="matrix2">Вторая матрица (на которую произходит умножение)</param>
        /// <returns>Матрица результата произведения</returns>
        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1 == null) throw new ArgumentNullException("matrix1");
            if (matrix2 == null) throw new ArgumentNullException("matrix2");
            if (matrix1.ColumnsCount != matrix2.RowsCount)
                throw new Exception("Длина строки первой матрицы должна быть равна длине столбца второй матрицы");
            Matrix result = new Matrix(matrix1.RowsCount, matrix2.ColumnsCount);

            for (int i = 0; i < result.RowsCount; i++)
                for (int j = 0; j < result.ColumnsCount; j++)
                {
                    double temp = 0;
                    for (int k = 0; k < matrix1.ColumnsCount; k++)
                        temp += matrix1[i, k] * matrix2[k, j];
                    result[i, j] = temp;
                }

            return result;
        }

        /// <summary>
        /// Нахождение единичной матрицы размера n x n
        /// </summary>
        /// <param name="n">Размер матрицы</param>
        /// <returns>Единичная матрица данного размера</returns>
        public Matrix IdentityMatrix(int n)
        {
            Matrix result = new Matrix(n,n);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++) 
                    result[i, j] = i == j ? 1 : 0; // если диагональный элемент, то 1, иначе 0
            return result;
        }

        /// <summary>
        /// Перестановка строк по заданным индексам
        /// </summary>
        /// <param name="rowIndex1">Первый индекс сткроки</param>
        /// <param name="rowIndex2">Второй индекс строки</param>
        public void SwapRows(int rowIndex1, int rowIndex2)
        {
            for (int i = 0; i < ColumnsCount; i++) // перебор всех столбцов и замена значений в них
            {
                double temp = _matrix[rowIndex1, i];
                _matrix[rowIndex1, i] = _matrix[rowIndex2, i];
                _matrix[rowIndex2, i] = temp;
            }
        }

        /// <summary>
        /// Приведение матрицы к LUP виду
        /// </summary>
        /// <param name="result">Результирующая матрица</param>
        /// <param name="p">Матрица перестановок</param>
        public void LUP(ref Matrix result, ref Matrix p)
        {
            if (result == null) throw new ArgumentNullException("result");
            if (p == null) throw new ArgumentNullException("p");
            int n = RowsCount; // n - размерность исходной матрицы

            result = this;

            //загружаем в матрицу p единичную матрицу
            p = IdentityMatrix(n);

            for (int i = 0; i < n; i++)
            {
                // поиск опорного элемента (максимального по модулю)
                double pivotValue = 0; // опорный элемент
                int pivot = -1;         // индекс опорного элемента
                for (int row = i; row < n; row++)
                {
                    if (Math.Abs(result[row, i]) > pivotValue)
                    {
                        pivotValue = Math.Abs(result[row, i]);
                        pivot = row;
                    }
                }
                if (pivotValue == 0)
                    throw new Exception("Матрица вырождена. " + "Обратная ей матрица не может быть найдена. "
                        + "Попробуйте ввести другие значения.");

                // меняем местами i-ю строку и строку с опорным элементом
                p.SwapRows(pivot, i);
                result.SwapRows(pivot, i);
                for (int j = i + 1; j < n; j++)
                {
                    result[j, i] /= result[i, i];
                    for (int k = i + 1; k < n; k++)
                        result[j, k] -= result[j, i] * result[i, k];
                }
            }
            // теперь матрица result = L + U - E
        }

        /// <summary>
        /// Нахождение обратной матрицы
        /// </summary>
        /// <returns>Обратная матрица</returns>
        public Matrix Inverse()
        {
            // n - размерность квадратной матрицы Matrix1
            int n = RowsCount;//  
            // при инициализации задается размерность nxn
            Matrix result = new Matrix(n, n);
            Matrix p = new Matrix(n, n); // матрица перестановок
            Matrix c = new Matrix(n, n); // матрица для LUP разложения
            // предполагается что в результате следующего вызова матрица C = L + U - E
            LUP(ref c, ref p);
            for (int k = n - 1; k >= 0; k--)
            {
                result[k, k] = 1;
                for (int j = n - 1; j > k; j--) 
                    result[k, k] -= c[k, j]*result[j, k];
                result[k, k] /= c[k, k];
                for (int i = k - 1; i >= 0; i--)
                {
                    for (int j = n - 1; j > i; j--)
                    {
                        result[i, k] -= c[i, j]*result[j, k];
                        result[k, i] -= c[j, i]*result[k, j];
                    }
                    result[i, k] /= c[i, i];
                }
            }
            return result * p; // обратная матрица
        }
    }
}
