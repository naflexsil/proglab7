using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace proglab7 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }



        private void сгенерироватьButton_Click(object sender, EventArgs e) {
            int n;
            if (!int.TryParse(textSIZE.Text, out n)) {
                MessageBox.Show("ты что-то странное вводишь");
                return;
            }
            if (dataGridView.ColumnCount != n + 1) {
                dataGridView.Columns.Clear();
                dataGridView.ColumnCount = n + 1; // доп. столбец для B.
                // заголовки столбцов для X и B.
                for (int i = 0; i < n; ++i) {
                    dataGridView.Columns[i].HeaderText = $"X{i + 1}";
                }
                dataGridView.Columns[n].HeaderText = "B";
            }
            if (dataGridView.RowCount != n) {
                dataGridView.Rows.Clear();
                dataGridView.RowCount = n;
            }
            var RandomNumber = new Random();
            // заполнение  А рандом числами, если ячейка пуста
            for (int i = 0; i < n; ++i) {
                for (int j = 0; j < n; ++j) {
                    if (dataGridView.Rows[i].Cells[j].Value == null || string.IsNullOrWhiteSpace(dataGridView.Rows[i].Cells[j].Value.ToString())) {
                        double number = RandomNumber.Next(-100, 101); // Случайные числа от -100 до 100
                        dataGridView.Rows[i].Cells[j].Value = number;
                    }
                }
                // заполнение B рандом числами, если ячейка пуста
                int bColumnIndex = n; // Индекс столбца B.
                if (dataGridView.Rows[i].Cells[bColumnIndex].Value == null || string.IsNullOrWhiteSpace(dataGridView.Rows[i].Cells[bColumnIndex].Value.ToString())) {
                    double num = RandomNumber.Next(-100, 101); // Случайные числа от -100 до 100.
                    dataGridView.Rows[i].Cells[bColumnIndex].Value = num;
                }
            }
        }





        private double[] SolveByGauss(double[,] matrixA, double[] vectorB) {
            int n = vectorB.Length;
            for (int i = 0; i < n; ++i) {
                // Поиск макс-го эл-та в текущем столбце
                double maxEl = Math.Abs(matrixA[i, i]);
                int maxRow = i;
                for (int k = i + 1; k < n; ++k) {
                    if (Math.Abs(matrixA[k, i]) > maxEl) {
                        maxEl = Math.Abs(matrixA[k, i]);
                        maxRow = k;
                    }
                }
                // Перестановка строк
                for (int k = i; k < n; ++k) {
                    double tmp = matrixA[maxRow, k];
                    matrixA[maxRow, k] = matrixA[i, k];
                    matrixA[i, k] = tmp;
                }
                double tmpB = vectorB[maxRow];
                vectorB[maxRow] = vectorB[i];
                vectorB[i] = tmpB;
                // Обнуление элементов ниже диагонали
                for (int k = i + 1; k < n; ++k) {
                    double c = -matrixA[k, i] / matrixA[i, i];
                    for (int j = i; j < n; ++j) {
                        if (i == j) {
                            matrixA[k, j] = 0;
                        }
                        else {
                            matrixA[k, j] += c * matrixA[i, j];
                        }
                    }
                    vectorB[k] += c * vectorB[i];
                }
            }
            // Решение Ax=b для верхнетреугольной матрицы A
            double[] x = new double[n];
            for (int i = n - 1; i >= 0; --i) {
                x[i] = vectorB[i] / matrixA[i, i];
                for (int k = i - 1; k >= 0; --k) {
                    vectorB[k] -= matrixA[k, i] * x[i];
                }
            }
            return x;
        }






        private double[] SolveByCramer(double[,] matrixA, double[] vectorB) {
            int n = matrixA.GetLength(0);
            double detA = CalculateDeterminant(matrixA);
            if (Math.Abs(detA) < 1e-14) { // Проверка на нулевой определитель
            
                throw new InvalidOperationException("определитель (детерминант) = нулю. Си-ма ур-й имеет бесконечно много решений или не имеет вовсе");
            }
            double[] x = new double[n];
            for (int i = 0; i < n; ++i) {
                double[,] tempMatrix = (double[,])matrixA.Clone();
                for (int j = 0; j < n; ++j) {
                    tempMatrix[j, i] = vectorB[j];
                }
                x[i] = CalculateDeterminant(tempMatrix) / detA;
            }
            return x;
        }


        private double CalculateDeterminant(double[,] matrix) {
            int n = matrix.GetLength(0);
            double det = 1;
            double[,] tempMatrix = (double[,])matrix.Clone();
            for (int i = 0; i < n; ++i) {
                // Поиск макс-го эл-та в текущем столбце
                double maxEl = tempMatrix[i, i];
                int maxRow = i;
                for (int k = i + 1; k < n; ++k) {
                    if (tempMatrix[k, i] > maxEl) {
                        maxEl = tempMatrix[k, i];
                        maxRow = k;
                    }
                }
                // Проверка на ноль
                if (maxEl == 0) {
                    return 0; // Определитель равен нулю
                }
                // Перестановка строк
                for (int k = i; k < n; ++k) {
                    double tmp = tempMatrix[maxRow, k];
                    tempMatrix[maxRow, k] = tempMatrix[i, k];
                    tempMatrix[i, k] = tmp;
                }
                if (i != maxRow) {
                    det *= -1; // Перестановка строк меняет знак определителя
                }
                // Обнуление эле-в ниже диагонали
                for (int k = i + 1; k < n; ++k) {
                    double c = -tempMatrix[k, i] / tempMatrix[i, i];
                    for (int j = i; j < n; ++j) {
                        if (i == j) {
                            tempMatrix[k, j] = 0;
                        }
                        else {
                            tempMatrix[k, j] += c * tempMatrix[i, j];
                        }
                    }
                }
                // Умножаем det на элементы диагонали
                det *= tempMatrix[i, i];
            }
            return det;
        }





        private double[] SolveByJordanGauss(double[,] matrixA, double[] vectorB) {
            int n = vectorB.Length;
            for (int i = 0; i < n; ++i) {
                // Нормализация строки i
                double diag = matrixA[i, i];
                for (int j = 0; j < n; ++j) {
                    matrixA[i, j] /= diag;
                }
                vectorB[i] /= diag;
                // Обнуление элементов в столбце i
                for (int k = 0; k < n; ++k) {
                    if (k != i) {
                        double factor = matrixA[k, i];
                        for (int j = 0; j < n; ++j) {
                            matrixA[k, j] -= factor * matrixA[i, j];
                        }
                        vectorB[k] -= factor * vectorB[i];
                    }
                }
            }
            // Вектор решений
            double[] x = new double[n];
            for (int i = 0; i < n; ++i) {
                x[i] = vectorB[i];
            }
            return x;
        }





        private void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e) {
            int n = dataGridView.RowCount;
            double[,] matrixA = new double[n, n];
            double[] vectorB = new double[n];
            for (int i = 0; i < n; ++i) {
                for (int j = 0; j < n; ++j) {
                    matrixA[i, j] = Convert.ToDouble(dataGridView.Rows[i].Cells[j].Value);
                }
                vectorB[i] = Convert.ToDouble(dataGridView.Rows[i].Cells[n].Value);
            }
            Stopwatch stopwatch = new Stopwatch();
            try {
                if (checkBoxCramer.Checked) {
                    stopwatch.Start();
                    double[] resultCramer = SolveByCramer(matrixA, vectorB);
                    stopwatch.Stop();
                    ShowResult(resultCramer, resCramer);
                    timeCramer.Text = $"{stopwatch.Elapsed.TotalMilliseconds} мс";
                    stopwatch.Reset();
                }
                if (checkBoxGauss.Checked) {
                    stopwatch.Start();
                    double[] resultGauss = SolveByGauss(matrixA, vectorB);
                    stopwatch.Stop();
                    ShowResult(resultGauss, resGauss);
                    timeGauss.Text = $"{stopwatch.Elapsed.TotalMilliseconds} мс";
                    stopwatch.Reset();
                }
                if (checkBoxJordanGauss.Checked) {
                    stopwatch.Start();
                    double[] resultJordanGauss = SolveByJordanGauss(matrixA, vectorB);
                    stopwatch.Stop();
                    ShowResult(resultJordanGauss, resJordanGauss);
                    timeJordanGauss.Text = $"{stopwatch.Elapsed.TotalMilliseconds} мс";
                    stopwatch.Reset();
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }



        private void ShowResult(double[] result, System.Windows.Forms.TextBox resultTextBox) {
            resultTextBox.Clear();
            for (int i = 0; i < result.Length; i++) {
                resultTextBox.AppendText($"x{i + 1} = {result[i]:0.00};   ");
            }
        }



        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e) {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
        }



        private void загрузитьИзExcelToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xls;*.xlsx;*.xlsm",
                Title = "Выберите файл Excel"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    var excelApp = new Microsoft.Office.Interop.Excel.Application();
                    var workbook = excelApp.Workbooks.Open(filePath);
                    var worksheet = workbook.Sheets[1] as Microsoft.Office.Interop.Excel.Worksheet;
                    var range = worksheet.UsedRange;
                    int rows = range.Rows.Count;
                    int cols = range.Columns.Count;
                    dataGridView.Columns.Clear();
                    dataGridView.Rows.Clear();

                    // Создаем столбцы в DataGridView для X1, X2, ..., X(n-1)
                    for (int c = 1; c < cols; c++)
                    { // начинаем с 1, чтобы включить первый столбец B в Excel
                        dataGridView.Columns.Add("column" + c, "X" + c);
                    }
                    // Последний столбец будет B, он соответствует последнему столбцу E в Excel
                    dataGridView.Columns.Add("columnB", "B");

                    // Загружаем данные из Excel в DataGridView
                    for (int r = 1; r <= rows; r++)
                    {
                        DataGridViewRow newRow = new DataGridViewRow();
                        newRow.CreateCells(dataGridView);

                        // Заполнить столбцы X1, X2, ..., X(n-1)
                        for (int c = 1; c < cols; c++)
                        { // включаем первый столбец B в Excel
                            newRow.Cells[c - 1].Value = (range.Cells[r, c] as Microsoft.Office.Interop.Excel.Range).Value2?.ToString() ?? "";
                        }

                        // Заполнить столбец B значениями из последнего столбца Excel
                        newRow.Cells[cols - 1].Value = (range.Cells[r, cols] as Microsoft.Office.Interop.Excel.Range).Value2?.ToString() ?? "";

                        dataGridView.Rows.Add(newRow);
                    }

                    workbook.Close(false);
                    excelApp.Quit();

                    Marshal.ReleaseComObject(workbook);
                    Marshal.ReleaseComObject(excelApp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при чтении файла Excel: " + ex.Message);
                }
            }
        }
    }
}
