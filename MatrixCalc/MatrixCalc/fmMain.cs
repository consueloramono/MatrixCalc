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

        enum Operations { Sum, Multiplication, InverseMatrix } // можливі операції
        private const int ColumnWidth = 30; // ширина стовпців матриць

        private Matrix _bufferA; // буфер для матриці А
        private Matrix _bufferB; // буфер для матриці В
        private Matrix _bufferResult; // буфер для матриці результату

        // Робота з матрицею А
        #region -MatrixA-
        private void SetMatrixA()
        {
            SetValues(); // Встановлення розмірів
            dgvMatrixA.ColumnCount = Convert.ToInt32(nudMatrixAColCount.Value);
            dgvMatrixA.RowCount = Convert.ToInt32(nudMatrixARowCount.Value);
            for (int i = 0; i < dgvMatrixA.Columns.Count; ++i)
                dgvMatrixA.Columns[i].Width = ColumnWidth;  // всі стовпці робимо шириною 30

            nudMatrixAColCount.Value = dgvMatrixA.ColumnCount; // кількість доданих стовпців
        }

        private void bOkA_Click(object sender, EventArgs e)
        {
            SetMatrixA(); // Встановлення розмірів матриці А
        }

        private void tsbCeA_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvMatrixA.RowCount; ++i)
                for (int j = 0; j < dgvMatrixA.ColumnCount; ++j)
                    dgvMatrixA[j, i].Value = ""; // очищення матриці А
        }

        private void FromMToA(Matrix BufferFrom)
        {
            WriteDataToTable(dgvMatrixA, BufferFrom);
            nudMatrixARowCount.Text = BufferFrom.RowsCount.ToString();
            nudMatrixAColCount.Text = BufferFrom.ColumnsCount.ToString();
        }

        private void tsbMrAToA_ButtonClick(object sender, EventArgs e)
        {
            if (_bufferA == null) return;
            FromMToA(_bufferA);
        }

        private void tsbMrBToA_Click(object sender, EventArgs e)
        {
            if (_bufferB == null) return;
            FromMToA(_bufferB);
        }

        private void tsbMrResultToA_Click(object sender, EventArgs e)
        {
            if (_bufferResult == null) return;
            FromMToA(_bufferResult);
        }
        #endregion //-MatrixA-

        // Робота з матрицею B
        #region -MatrixB-
        private void SetMatrixB()
        {
            dgvMatrixB.ColumnCount = Convert.ToInt32(nudMatrixBColCount.Value);
            dgvMatrixB.RowCount = Convert.ToInt32(nudMatrixBRowCount.Value);
            for (int i = 0; i < dgvMatrixB.Columns.Count; ++i)
                dgvMatrixB.Columns[i].Width = ColumnWidth;       // всі стовпці робимо шириною 30
            nudMatrixBColCount.Value = dgvMatrixB.ColumnCount; // кількість доданих стовпців
        }

        private void bOkB_Click(object sender, EventArgs e)
        {
            SetMatrixB(); // Встановлення розмірів матриці В
        }

        private void tsbCeB_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvMatrixB.RowCount; ++i)
                for (int j = 0; j < dgvMatrixB.ColumnCount; ++j)
                    dgvMatrixB[j, i].Value = ""; // очищення матриці В
        }

        private void FromMToB(Matrix bufferFrom)
        {
            WriteDataToTable(dgvMatrixB, bufferFrom);
            nudMatrixBRowCount.Text = bufferFrom.RowsCount.ToString();
            nudMatrixBColCount.Text = bufferFrom.ColumnsCount.ToString();
        }

        private void tsbMB_Click(object sender, EventArgs e)
        {
            _bufferB = new Matrix(dgvMatrixB.RowCount, dgvMatrixB.ColumnCount);
            ReadDataFromTable(dgvMatrixB, _bufferB, "B"); // запис даних в буфер
        }

        private void tsbMrBToB_ButtonClick(object sender, EventArgs e)
        {
            if (_bufferB == null) return;
            FromMToB(_bufferB);
        }

        private void tsbMrAToB_Click(object sender, EventArgs e)
        {
            if (_bufferA == null) return;
            FromMToB(_bufferA);
        }

        private void tsbMrResultToB_Click(object sender, EventArgs e)
        {
            if (_bufferResult == null) return;
            FromMToB(_bufferResult);
        }
        #endregion //-MatrixB-

        // Робота з матрицею Результата
        #region -MatrixResult-
        private void tsbCeResult_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvMatrixResult.RowCount; ++i)
                for (int j = 0; j < dgvMatrixResult.ColumnCount; ++j)
                    dgvMatrixResult[j, i].Value = ""; // очищення матриці результату
        }

        private void FromMToResult(Matrix bufferFrom)
        {
            WriteDataToTable(dgvMatrixResult, bufferFrom);
            tbMatrixResultRowCount.Text = bufferFrom.RowsCount.ToString();
            tbMatrixResultColCount.Text = bufferFrom.ColumnsCount.ToString();
        }

        private void tsbMResult_Click(object sender, EventArgs e)
        {
            _bufferResult = new Matrix(dgvMatrixResult.RowCount, dgvMatrixResult.ColumnCount);
            ReadDataFromTable(dgvMatrixResult, _bufferResult, "Результат");
        }

        private void tsbMrResultToResult_ButtonClick(object sender, EventArgs e)
        {
            if (_bufferResult == null) return;
            FromMToResult(_bufferResult);
        }

        private void tsbMrAToResult_Click(object sender, EventArgs e)
        {
            if (_bufferA == null) return;
            FromMToResult(_bufferA);
        }

        private void tsbMrBToResult_Click(object sender, EventArgs e)
        {
            if (_bufferB == null) return;
            FromMToResult(_bufferB);
        }
        #endregion //-MatrixResult-

        //Читання та запис даних у таблиці та масиви
        #region -Читання та запис даних-
        private bool ReadDataFromTable(DataGridView dgvMatrix, Matrix matrix1, string matrixName)
        {
            try
            {
                for (int i = 0; i < matrix1.RowsCount; ++i)
                    for (int j = 0; j < matrix1.ColumnsCount; ++j)
                        matrix1[i, j] = Convert.ToDouble(dgvMatrix[j, i].Value.ToString());
                return true;
            }
            catch // якщо є помилка у даних, то
            {
                MessageBox.Show("У матриці " + matrixName + " помилка даних. Можливо, одне з чисел введено неправильно. " +
                        "Будь ласка, перевірте дані та спробуйте знову.", "Увага", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                return false;
            }

        }

        private void WriteDataToTable(DataGridView dgvMatrix, Matrix matrix1)
        {
            if (matrix1 == null) return; // якщо масив не визначений, то вихід
            dgvMatrix.RowCount = matrix1.RowsCount; // кількість рядків
            dgvMatrix.ColumnCount = matrix1.ColumnsCount; // кількість стовпців

            for (int i = 0; i < matrix1.ColumnsCount; i++)
                dgvMatrix.Columns[i].Width = ColumnWidth; // ширина стовпця

            for (int i = 0; i < matrix1.RowsCount; i++)
                for (int j = 0; j < matrix1.ColumnsCount; j++)
                    dgvMatrix[j, i].Value = matrix1[i, j]; //запис значень у таблицю
        }
        #endregion //-Читання та запис даних-

        private void bResult_Click(object sender, EventArgs e)
        {
            // створення масивів А і В
            Matrix matrixA = new Matrix(dgvMatrixA.RowCount, dgvMatrixA.ColumnCount);
            Matrix matrixB = new Matrix(dgvMatrixB.RowCount, dgvMatrixB.ColumnCount);

            // запис в масиви А і В даних з таблиць
            if (ReadDataFromTable(dgvMatrixA, matrixA, "A") == false) return;

            try
            {
                switch ((Operations)cbOperation.SelectedIndex) // обрана дія
                {
                    case Operations.Sum:
                        if (ReadDataFromTable(dgvMatrixB, matrixB, "B") == false) return;
                        WriteDataToTable(dgvMatrixResult, matrixA + matrixB); // запис результату у таблицю
                        break; //обчислення суми
                    case Operations.Multiplication:
                        if (ReadDataFromTable(dgvMatrixB, matrixB, "B") == false) return;
                        WriteDataToTable(dgvMatrixResult, matrixA * matrixB); // запис результату у таблицю
                        break; //перемноження
                    case Operations.InverseMatrix: // знаходження оберненої матриці
                        WriteDataToTable(dgvMatrixResult, matrixA.Inverse()); // запис результату у таблицю
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvMatrixResult.Rows.Clear();
                dgvMatrixResult.Columns.Clear();
            }

            //запис розмірів таблиці результату
            tbMatrixResultRowCount.Text = dgvMatrixResult.RowCount.ToString();
            tbMatrixResultColCount.Text = dgvMatrixResult.ColumnCount.ToString();
        }

        // зміна обраної операції
        #region -Зміна операції-
        private void cbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudMatrixAColCount.Enabled = true;

            switch ((Operations)cbOperation.SelectedIndex) // обрана операція
            {
                case Operations.Sum: // сума
                    gbMatrixBAbout.Enabled = false; // зміна розмірів матриці В недоступна
                    SetValues(); // встановлення розмірів матриць
                    break;
                case Operations.Multiplication: // добуток
                    nudMatrixBRowCount.Enabled = false; // зміна кількості рядків матриці В недоступна
                    gbMatrixBAbout.Enabled = true;// можна змінювати кількість стовпців 
                    dgvMatrixB.Enabled = true; // матрицю В робимо доступною
                    SetValues();// встановлення розмірів матриць
                    break;
                case Operations.InverseMatrix: // обернена матриця
                    gbMatrixBAbout.Enabled = false; // зміна розмірів матриці В недоступна
                    dgvMatrixB.Enabled = false; // матрицю В робимо недоступною
                    nudMatrixAColCount.Enabled = false; // зміна кількості стовпців робимо недоступною
                    SetMatrixA();                      // оскільки матриця має бути квадратною
                    break;
            }
        }

        private void SetValues()
        {
            switch ((Operations)cbOperation.SelectedIndex) // обрана операція
            {
                case Operations.Sum: // додавання
                    nudMatrixBColCount.Value = nudMatrixAColCount.Value;
                    nudMatrixBRowCount.Value = nudMatrixARowCount.Value;
                    SetMatrixB(); // матриця В повинна мати такий же розмір, як матриця А
                    break;
                case Operations.Multiplication: // добуток
                    nudMatrixBRowCount.Value = nudMatrixAColCount.Value;
                    SetMatrixB(); // Довжина стовпця матриці В повинна дорівнювати довжині рядка матриці А
                    break;
                case Operations.InverseMatrix: //Знаходження оберненої матриці
                    nudMatrixAColCount.Value = nudMatrixARowCount.Value;// Матриця А повинна бути квадратною
                    break;
            }

        }
        #endregion //-Зміна операції-
    }
}
