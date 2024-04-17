using System;
using System.Windows.Forms;

namespace ScrollbarCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void scrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                int n = scrollBar1.Value;
                int resultLoop = CalculateSumLoop(n);
                int resultFormula = CalculateSumFormula(n);
                textBox1.Text = $"Сумма (цикл): {resultLoop}\r\nСумма (формула): {resultFormula}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private int CalculateSumLoop(int n)
        {
            // Проверка на валидность
            if (n <= 0)
            {
                throw new ArgumentException("n должно быть положительным числом");
            }

            // Вычисление суммы в цикле
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += (2 * i - 1) * (2 * i - 1) * (2 * i - 1);
            }
            return sum;
        }

        private int CalculateSumFormula(int n)
        {
            // Проверка на валидность
            if (n <= 0)
            {
                throw new ArgumentException("n должно быть положительным числом");
            }

            // Вычисление суммы по формуле
            int sum = n * n * (2 * n * n - 1);
            return sum;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Select(0, 0);
            textBox1.SelectionStart = 0;
            textBox1.ScrollToCaret();
        }
    }
}
