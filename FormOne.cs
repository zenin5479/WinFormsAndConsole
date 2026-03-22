using System;
using System.Globalization;
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
         // Поддерживает производительность при добавлении позиций в ListBox по одной,
         // запрещая рисование в элементе управления вплоть до вызова метода EndUpdate().
         //ListBoxBalances.BeginUpdate();
         //ListBoxBalances.EndUpdate();

         // Проверка ввода
         if (!double.TryParse(txtInput.Text, out double inputValue))
         {
            MessageBox.Show("Пожалуйста, введите корректное число!", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }

         // Приостанавливаем обновление компоновки для TextBox
         txtInput.SuspendLayout();

         // Выполняем расчёт с использованием консоли
         // Выполняем множество операций, которые обычно вызывают перерисовку
         CalculateConsole(inputValue);

         // Возобновляем работу и принудительно применяем все изменения
         txtInput.ResumeLayout();

         // Опционально: принудительно вызываем немедленную перерисовку
         txtInput.PerformLayout();
      }

      private void CalculateConsole(double input)
      {
         // Выделяем консоль
         AllocConsole();

         // Счётчик итераций
         // Используем long, чтобы избежать переполнения int
         long iteration = 0;
         double result = 0;

         // Бесконечный цикл
         while (iteration < 1000)
         {
            try
            {
               iteration++;
               result = input * iteration;
               Console.WriteLine("Итерация: {0}, Результат: {1};", iteration, result);

            }
            catch (Exception ex)
            {
               Console.WriteLine("Ошибка: {0}", ex.Message);
            }
         }

         txtResult.Text = result.ToString(CultureInfo.InvariantCulture);
         // Освобождаем консоль
         //FreeConsole();
      }
   }
}