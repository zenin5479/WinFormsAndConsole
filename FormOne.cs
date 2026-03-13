using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WinFormsAndConsole
{
   public partial class FormOne : Form
   {
      [DllImport("kernel32.dll")]
      private static extern bool AllocConsole();

      [DllImport("kernel32.dll")]
      private static extern bool FreeConsole();

      public FormOne()
      {
         InitializeComponent();
      }

      private void btnCalculate_Click(object sender, EventArgs e)
      {
         // Проверка ввода
         if (!double.TryParse(txtInput.Text, out double inputValue))
         {
            MessageBox.Show("Пожалуйста, введите корректное число!", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }

         // Выполняем расчёт с использованием консоли
         double result = CalculateWithConsole(inputValue);

         // Обновляем интерфейс с результатом
         txtResult.Text = result.ToString("F4");
      }

      private double CalculateWithConsole(double input)
      {
         // Выделяем консоль
         AllocConsole();
         // Бесконечный цикл в главном потоке
         while (true)
         {
            // Выполняем расчёт (квадрат числа)
            int i = 3;
            double result = input * i;

            // Формируем строку результата
            string resultText = string.Format("Число: {0}, Квадрат: {1}, Время: {2:HH:mm:ss}", input, result, DateTime.Now);

            // Выводим в консоль
            Console.WriteLine("Результат: {0}", resultText);
            i++;
            return result;
         }

         // Освобождаем консоль
         FreeConsole();
      }
   }
}