using System;
using System.Windows.Forms;

namespace lb5_luz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. создание массива из 5 элементов и заполнение его из полей ввода
                int[] numbers = new int[5];
                numbers[0] = int.Parse(txt1.Text);
                numbers[1] = int.Parse(txt2.Text);
                numbers[2] = int.Parse(txt3.Text);
                numbers[3] = int.Parse(txt4.Text);
                numbers[4] = int.Parse(txt5.Text);

                // 2. вывод исходного массива
                lblOriginal.Text = "Исходный: " + string.Join(", ", numbers);

                // 3. РЕВЕРС "НА МЕСТЕ" 
                for (int i = 0; i < numbers.Length / 2; i++)
                {
                    // сохранение значения текущего элемента во временную переменную
                    int temp = numbers[i];

                    // вычисление индекса парного элемента с конца
                    int j = numbers.Length - 1 - i;

                    // меняем их местами
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }

                // 4. вывод измененного массива
                lblResult.Text = "Результат: " + string.Join(", ", numbers);
            }
            catch
            {
                MessageBox.Show("Пожалуйста, заполните все 5 полей целыми числами!");
            }
        }

        // Общий обработчик для всех текстовых полей
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Если нажата стрелка ВНИЗ
            if (e.KeyCode == Keys.Down)
            {
                // Переместить фокус на следующий элемент в порядке табуляции
                this.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true; // Сказать системе, что мы сами обработали нажатие
            }
            // Если нажата стрелка ВВЕРХ
            else if (e.KeyCode == Keys.Up)
            {
                // Переместить фокус на предыдущий элемент
                this.SelectNextControl((Control)sender, false, true, true, true);
                e.Handled = true;
            }
        }

    }
}
