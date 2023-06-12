using System;

namespace MatrixCalc
{
    class Matrix
    {
        private readonly double[,] _matrix;

        public Matrix(int rowsCount, int columnsCount)
        {
            _matrix = new double[rowsCount, columnsCount];
        }

        public double this[int rowIndex, int columnIndex]
        {
            get { return _matrix[rowIndex, columnIndex]; }
            set { _matrix[rowIndex, columnIndex] = value; }
        }

        public int RowsCount
        {
            get { return _matrix.GetLength(0); }
        }

        public int ColumnsCount
        {
            get { return _matrix.GetLength(1); }
        }


        public static Matrix operator + (Matrix matrix1, Matrix matrix2)
        {
            if (matrix1 == null) throw new ArgumentNullException("matrix1");
            if (matrix2 == null) throw new ArgumentNullException("matrix2");
            if (matrix1.RowsCount != matrix2.RowsCount || matrix1.ColumnsCount != matrix2.ColumnsCount)
                throw new Exception("Матриці для додавання повинні мати однаковий розмір");
            Matrix result = new Matrix(matrix1.RowsCount, matrix1.ColumnsCount);

            for (int i = 0; i < result.RowsCount; i++)
                for (int j = 0; j < result.ColumnsCount; j++)
                    result[i, j] = matrix1[i, j] + matrix2[i, j];

            return result;
        }

        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1 == null) throw new ArgumentNullException("matrix1");
            if (matrix2 == null) throw new ArgumentNullException("matrix2");
            if (matrix1.ColumnsCount != matrix2.RowsCount)
                throw new Exception("Довжина рядка першої матриці повинна дорівнювати довжині стовпця другої матриці");
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

        public Matrix IdentityMatrix(int n)
        {
            Matrix result = new Matrix(n,n);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++) 
                    result[i, j] = i == j ? 1 : 0; // якщо діагональний елемент, то 1, в іншому випадку 0
            return result;
        }

        public void SwapRows(int rowIndex1, int rowIndex2)
        {
            for (int i = 0; i < ColumnsCount; i++) // перебір всіх стовпців і заміна їх значень
            {
                double temp = _matrix[rowIndex1, i];
                _matrix[rowIndex1, i] = _matrix[rowIndex2, i];
                _matrix[rowIndex2, i] = temp;
            }
        }

        public void LUP(ref Matrix result, ref Matrix p)
        {
            if (result == null) throw new ArgumentNullException("result");
            if (p == null) throw new ArgumentNullException("p");
            int n = RowsCount; // n - розмір матриці

            result = this;

            //загружаєм в матрицю p одиничну матрицю
            p = IdentityMatrix(n);

            for (int i = 0; i < n; i++)
            {
                // пошук опорного елемента (максимального за модулем)
                double pivotValue = 0; // опорний елемент
                int pivot = -1;         // індекс опорного елемента
                for (int row = i; row < n; row++)
                {
                    if (Math.Abs(result[row, i]) > pivotValue)
                    {
                        pivotValue = Math.Abs(result[row, i]);
                        pivot = row;
                    }
                }
                if (pivotValue == 0)
                    throw new Exception("Матриця вироджена. " + "Обернена матриця не може бути знайдена. "
                        + "Спробуйте ввести інші значення.");

                // міняємо місцями і-ий рядок та рядок з опорним елементом
                p.SwapRows(pivot, i);
                result.SwapRows(pivot, i);
                for (int j = i + 1; j < n; j++)
                {
                    result[j, i] /= result[i, i];
                    for (int k = i + 1; k < n; k++)
                        result[j, k] -= result[j, i] * result[i, k];
                }
            }
            // тепер матриця result = L + U - E
        }

        public Matrix Inverse()
        {
            // n - розмірність квадратної матриці Matrix1
            int n = RowsCount;//  
            // при ініціалізації задається розмірність nxn
            Matrix result = new Matrix(n, n);
            Matrix p = new Matrix(n, n); // матриця перестановок
            Matrix c = new Matrix(n, n); // матриця для LUP розкладу
            // передбачається, що в результаті наступного виклику матриця C = L + U - E
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
            return result * p; // обернена матриця
        }
    }
}
