using System.Windows.Forms;

namespace WinFormsAndConsole
{
   public partial class FormOne : Form
   {
      public FormOne()
      {
         InitializeComponent();
      }

      private void btnCalculate_Click(object sender, System.EventArgs e)
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
   }
}