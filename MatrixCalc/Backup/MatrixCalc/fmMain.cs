using System;
using System.Windows.Forms;

namespace MatrixCalc
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        enum Operations { Sum, Multiplication, InverseMatrix } // возможные операции
        private const int ColumnWidth = 30; // ширина столбцов матриц

        private Matrix _bufferA; // буфер для матрица А
        private Matrix _bufferB; // буфер для матрицы В
        private Matrix _bufferResult; // буфер для матрицы результата

        // Работа с матрицей А
        #region -MatrixA-
        /// <summary>
        /// Установка размеров в марице А и вызов функции SetValues для установки размеров матрицы В
        /// </summary>
        private void SetMatrixA()
        {
            SetValues(); //Установка размеров
            dgvMatrixA.ColumnCount = Convert.ToInt32(nudMatrixAColCount.Value);
            dgvMatrixA.RowCount = Convert.ToInt32(nudMatrixARowCount.Value);
            for (int i = 0; i < dgvMatrixA.Columns.Count; ++i)
                dgvMatrixA.Columns[i].Width = ColumnWidth;  // все столбцы делаем шириной 30

            nudMatrixAColCount.Value = dgvMatrixA.ColumnCount; // количество добавленных столбцов
        }

        /// <summary>
        /// Установка размеров матрицы А после нажатия на кнопку ОК
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bOkA_Click(object sender, EventArgs e)
        {
            SetMatrixA(); // Установка размеров матрицы А
        }

        /// <summary>
        /// Нажатие на кнопку отчистить матрицу А
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbCeA_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvMatrixA.RowCount; ++i)
                for (int j = 0; j < dgvMatrixA.ColumnCount; ++j)
                    dgvMatrixA[j, i].Value = ""; // отчистка матрицы А
        }

        private void FromMToA(Matrix BufferFrom)
        {
            WriteDataToTable(dgvMatrixA, BufferFrom);
            nudMatrixARowCount.Text = BufferFrom.RowsCount.ToString();
            nudMatrixAColCount.Text = BufferFrom.ColumnsCount.ToString();
        }

        /// <summary>
        /// Сохранение данных матрицы А в буфере А
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbMA_Click(object sender, EventArgs e)
        {
            _bufferA = new Matrix(dgvMatrixA.RowCount, dgvMatrixA.ColumnCount);
            ReadDataFromTable(dgvMatrixA, _bufferA, "A"); // запись данных в буфер
        }

        /// <summary>
        /// Вставка данных из буфера А в матрицу А
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbMrAToA_ButtonClick(object sender, EventArgs e)
        {
            if (_bufferA == null) return;
            FromMToA(_bufferA);
        }

        /// <summary>
        /// Вставка данных из буфера В в матрицу А
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbMrBToA_Click(object sender, EventArgs e)
        {
            if (_bufferB == null) return;
            FromMToA(_bufferB);
        }

        /// <summary>
        /// Вставка данных из буфера результата в матрицу А
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbMrResultToA_Click(object sender, EventArgs e)
        {
            if (_bufferResult == null) return;
            FromMToA(_bufferResult);
        }
        #endregion //-MatrixA-

        //Работа с матрицей B
        #region -MatrixB-
        /// <summary>
        /// Установка размеров в марице В
        /// </summary>
        private void SetMatrixB()
        {
            dgvMatrixB.ColumnCount = Convert.ToInt32(nudMatrixBColCount.Value);
            dgvMatrixB.RowCount = Convert.ToInt32(nudMatrixBRowCount.Value);
            for (int i = 0; i < dgvMatrixB.Columns.Count; ++i)
                dgvMatrixB.Columns[i].Width = ColumnWidth;       // все столбцы делаем шириной 30
            nudMatrixBColCount.Value = dgvMatrixB.ColumnCount;// количество добавленных столбцов
        }

        /// <summary>
        /// //Установка размеров матрицы В после нажатия на кнопку ОК
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bOkB_Click(object sender, EventArgs e)
        {
            SetMatrixB(); // Установка размеров матрицы В
        }

        /// <summary>
        /// Нажатие на кнопку отчистить матрицу B
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbCeB_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvMatrixB.RowCount; ++i)
                for (int j = 0; j < dgvMatrixB.ColumnCount; ++j)
                    dgvMatrixB[j, i].Value = ""; // отчистка матрицы B
        }

        private void FromMToB(Matrix bufferFrom)
        {
            WriteDataToTable(dgvMatrixB, bufferFrom);
            nudMatrixBRowCount.Text = bufferFrom.RowsCount.ToString();
            nudMatrixBColCount.Text = bufferFrom.ColumnsCount.ToString();
        }

        /// <summary>
        /// Сохранение данных матрицы В в буфере В
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbMB_Click(object sender, EventArgs e)
        {
            _bufferB = new Matrix(dgvMatrixB.RowCount, dgvMatrixB.ColumnCount);
            ReadDataFromTable(dgvMatrixB, _bufferB, "B"); // запись данных в буфер
        }

        /// <summary>
        /// Вставка данных из буфера В в матрицу В
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbMrBToB_ButtonClick(object sender, EventArgs e)
        {
            if (_bufferB == null) return;
            FromMToB(_bufferB);
        }

        /// <summary>
        /// Вставка данных из буфера А в матрицу В
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbMrAToB_Click(object sender, EventArgs e)
        {
            if (_bufferA == null) return;
            FromMToB(_bufferA);
        }

        /// <summary>
        /// Вставка данных из буфера результата в матрицу В
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbMrResultToB_Click(object sender, EventArgs e)
        {
            if (_bufferResult == null) return;
            FromMToB(_bufferResult);
        }
        #endregion //-MatrixB-

        // Работа с матрицей Результата
        #region -MatrixResult-
        /// <summary>
        /// Нажатие на кнопку отчистить матрицу результата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbCeResult_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvMatrixResult.RowCount; ++i)
                for (int j = 0; j < dgvMatrixResult.ColumnCount; ++j)
                    dgvMatrixResult[j, i].Value = ""; //отчистка матрицы результата
        }

        private void FromMToResult(Matrix bufferFrom)
        {
            WriteDataToTable(dgvMatrixResult, bufferFrom);
            tbMatrixResultRowCount.Text = bufferFrom.RowsCount.ToString();
            tbMatrixResultColCount.Text = bufferFrom.ColumnsCount.ToString();
        }

        /// <summary>
        /// Сохранение данных матрицы результата в буфере результата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbMResult_Click(object sender, EventArgs e)
        {
            _bufferResult = new Matrix(dgvMatrixResult.RowCount, dgvMatrixResult.ColumnCount);
            ReadDataFromTable(dgvMatrixResult, _bufferResult, "Результат");
        }

        /// <summary>
        /// Вставка данных из буфера результата в матрицу результата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbMrResultToResult_ButtonClick(object sender, EventArgs e)
        {
            if (_bufferResult == null) return;
            FromMToResult(_bufferResult);
        }

        /// <summary>
        /// Вставка данных из буфера А в матрицу результата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbMrAToResult_Click(object sender, EventArgs e)
        {
            if (_bufferA == null) return;
            FromMToResult(_bufferA);
        }

        /// <summary>
        /// Вставка данных из буфера В в матрицу результата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbMrBToResult_Click(object sender, EventArgs e)
        {
            if (_bufferB == null) return;
            FromMToResult(_bufferB);

        }
        #endregion //-MatrixResult-

        //Чтение и запись данных в таблицы и массивы
        #region -Read and Write Data-
        /// <summary>
        /// Считывание данных из таблиц в массивы
        /// </summary>
        /// <param name="dgvMatrix">Таблица от куда считывать</param>
        /// <param name="matrix1">Массив куда считывать</param>
        /// <param name="matrixName">Название матрицы</param>
        private bool ReadDataFromTable(DataGridView dgvMatrix, Matrix matrix1, string matrixName)
        {
            try
            {
                for (int i = 0; i < matrix1.RowsCount; ++i)
                    for (int j = 0; j < matrix1.ColumnsCount; ++j)
                        matrix1[i, j] = Convert.ToDouble(dgvMatrix[j, i].Value.ToString());
                return true;
            }
            catch // если в данных есть ошибка, то
            {
                MessageBox.Show("В матрице " + matrixName + " ошибка данных. Возможно одно из чисел введенно не верно. " +
                        "Пожалуйста, проверьте данные и повторите попытку.", "Внимание", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                return false;
            }

        }

        /// <summary>
        /// Запись данных из массива в таблицу
        /// </summary>
        /// <param name="dgvMatrix">Таблица куда записывать</param>
        /// <param name="matrix1">Массив от куда записывать</param>
        private void WriteDataToTable(DataGridView dgvMatrix, Matrix matrix1)
        {
            if (matrix1 == null) return; // если массив неопределен, то выход
            dgvMatrix.RowCount = matrix1.RowsCount; // количество строк
            dgvMatrix.ColumnCount = matrix1.ColumnsCount; // количество столбцов

            for (int i = 0; i < matrix1.ColumnsCount; i++)
                dgvMatrix.Columns[i].Width = ColumnWidth; // ширина столбца
            
            for (int i = 0; i < matrix1.RowsCount; i++)
                for (int j = 0; j < matrix1.ColumnsCount; j++)
                    dgvMatrix[j, i].Value = matrix1[i, j]; //запись значений в таблицу
        }
        #endregion //-Read and Write Data-

        /// <summary>
        /// Нажатие на кнопку равно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bResult_Click(object sender, EventArgs e)
        {
            // создание массивов А и В
            Matrix matrixA = new Matrix(dgvMatrixA.RowCount, dgvMatrixA.ColumnCount);
            Matrix matrixB = new Matrix(dgvMatrixB.RowCount, dgvMatrixB.ColumnCount);

            // запись в массивы А и В данных из таблиц 
            if (ReadDataFromTable(dgvMatrixA, matrixA, "A") == false) return;

            try
            {
                switch ((Operations) cbOperation.SelectedIndex) // выбранное действие
                {
                    case Operations.Sum:
                        if (ReadDataFromTable(dgvMatrixB, matrixB, "B") == false) return;
                        WriteDataToTable(dgvMatrixResult, matrixA + matrixB); // запись результата в таблицу
                        break; //вычисление суммы
                    case Operations.Multiplication:
                        if (ReadDataFromTable(dgvMatrixB, matrixB, "B") == false) return;
                        WriteDataToTable(dgvMatrixResult, matrixA*matrixB); // запись результата в таблицу
                        break; //произведения
                    case Operations.InverseMatrix: // нахождение обратной матрицы
                       WriteDataToTable(dgvMatrixResult, matrixA.Inverse()); // запись результата в таблицу
                       break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvMatrixResult.Rows.Clear();
                dgvMatrixResult.Columns.Clear();
            }

            //запсиь размеров таблицы результата
            tbMatrixResultRowCount.Text = dgvMatrixResult.RowCount.ToString();
            tbMatrixResultColCount.Text = dgvMatrixResult.ColumnCount.ToString();
        }

        // изменение выбранной операции
        #region -Changing operation-
        /// <summary>
        /// Изменение выбранной операции
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudMatrixAColCount.Enabled = true;
            
            switch ((Operations)cbOperation.SelectedIndex) // выбранная операция
            {
                case Operations.Sum: // сумма
                    gbMatrixBAbout.Enabled = false; // изменение размеров матрицы В делаем невозможным
                    SetValues(); // установка размеров матриц
                    break;
                case Operations.Multiplication: // произведение
                    nudMatrixBRowCount.Enabled = false; // изменение количества строк матрицы В делаем невозможным
                    gbMatrixBAbout.Enabled = true;// можно менять количество столбцов 
                    dgvMatrixB.Enabled = true; // матрицу В делаем доступной
                    SetValues();// установка размеров матриц
                    break;
                case Operations.InverseMatrix: // обратная матрица
                    gbMatrixBAbout.Enabled = false; // изменение размеров матрицы В делаем недоступным
                    dgvMatrixB.Enabled = false; // матрицу В делаем недоступной
                    nudMatrixAColCount.Enabled = false; // изменение количества столбцов делаем недоступным
                    SetMatrixA();                      // т.к. матрица должна быть квадратной
                    break;
            }
        }

        /// <summary>
        /// Устанавливает значения количества строк в зависимости от выбранной операции
        /// </summary>
        private void SetValues()
        {
            switch ((Operations)cbOperation.SelectedIndex) // выбраная операция
            {
                case Operations.Sum: // сложение
                    nudMatrixBColCount.Value = nudMatrixAColCount.Value;
                    nudMatrixBRowCount.Value = nudMatrixARowCount.Value;
                    SetMatrixB(); // матрица В должна иметь такой же размер как матрица А
                    break;
                case Operations.Multiplication: // произведение
                    nudMatrixBRowCount.Value = nudMatrixAColCount.Value;
                    SetMatrixB(); // Длина столца матрицы В должна быть равна длине строки матрицы А
                    break;
                case Operations.InverseMatrix: //Нахождение обратной матрицы
                    nudMatrixAColCount.Value = nudMatrixARowCount.Value;// Матрица А должна быть квадратной
                    break;
            }

        }
        #endregion //-Changing operation-
    }
}
