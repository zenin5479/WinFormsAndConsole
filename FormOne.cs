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
         //double result = CalculateWithConsole(inputValue);
         int result = CalculateConsole(inputValue);

         // Обновляем интерфейс с результатом
         txtResult.Text = result.ToString("F4");
      }

      private int CalculateConsole(double input)
      {
         // Выделяем консоль
         AllocConsole();

         // Счётчик итераций
         int iterationCount = 0; 

         while (true) // Бесконечный цикл
         {
            iterationCount++; // Увеличиваем счётчик на каждой итерации

            Console.WriteLine("Итерация №{0}", iterationCount);

            // Здесь можно разместить любую логику, выполняемую на каждой итерации
            return iterationCount;
         }
      }

      private double CalculateWithConsole(double input)
      {
         // Выделяем консоль
         AllocConsole();

         // Счётчик итераций
         int iterationCount = 0;

         // Бесконечный цикл
         while (true)
         {
            double result;
            try
            {
               // Увеличиваем счётчик на каждой итерации
               iterationCount++;
               Console.Clear();
               // Здесь можно разместить любую логику, выполняемую на каждой итерации
               Console.WriteLine("=== КОНСОЛЬ РАСЧЁТОВ ===");
               Console.WriteLine("Получено значение: {0}", input);
               Console.WriteLine("Выполняем вычисления...");

               // Пример расчёта: вычисляем квадратный корень и возводим в куб
               double sqrt = Math.Sqrt(input);
               result = Math.Pow(sqrt, 3);
               Console.WriteLine("Корень квадратный из {0} = {1:F4}", input, sqrt);
               Console.WriteLine("(Корень квадратный из {0} в кубе = {1:F4}", input, result);

               Console.WriteLine("Расчёт завершён!");
               Console.WriteLine("Итерация №{0}", iterationCount);
               Console.WriteLine();
               //Console.Write("Нажмите любую клавишу для продолжения...");
               //Console.ReadKey();
            }
            catch (Exception ex)
            {
               Console.WriteLine("Ошибка: {0}", ex.Message);
               result = double.NaN;
            }
            finally
            {
               // Освобождаем консоль
               //FreeConsole();
            }

            return result;
         }
      }
   }
}