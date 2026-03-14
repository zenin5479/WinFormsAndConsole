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
         double result;

         // Выделяем консоль
         AllocConsole();

         while (true)
         {
            try
            {
               Console.Clear();
               Console.WriteLine("=== КОНСОЛЬ РАСЧЁТОВ ===");
               Console.WriteLine("Получено значение: {0}", input);
               Console.WriteLine("Выполняем вычисления...");

               // Пример расчёта: вычисляем квадратный корень и возводим в куб
               double sqrt = Math.Sqrt(input);
               result = Math.Pow(sqrt, 3);

               Console.WriteLine("Корень квадратный из {0} = {1:F4}", input, sqrt);
               Console.WriteLine("(Корень квадратный из {0} в кубе = {1:F4}", input, result);
               Console.WriteLine("Расчёт завершён!");
               //Console.Write("Нажмите любую клавишу для продолжения...");
               //Console.ReadKey();
            }
            catch (Exception ex)
            {
               Console.WriteLine("Ошибка: {0}", ex.Message);
            }
         }


         try
         {

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

      public void Start()
      {

         Console.WriteLine("Синхронный Json сервер");

         while (true)
         {
            try
            {

            }
            catch (Exception ex)
            {
               Console.WriteLine("Ошибка: {0}", ex.Message);
            }
         }
      }

   }
}