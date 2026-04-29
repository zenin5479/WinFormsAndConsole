namespace WinFormsAndConsole
{
   partial class FormOne
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         lblResult = new System.Windows.Forms.Label();
         btnCalculate = new System.Windows.Forms.Button();
         txtResult = new System.Windows.Forms.TextBox();
         txtInput = new System.Windows.Forms.TextBox();
         SuspendLayout();
         // 
         // lblResult
         // 
         lblResult.AutoSize = true;
         lblResult.Location = new System.Drawing.Point(12, 86);
         lblResult.Name = "lblResult";
         lblResult.Size = new System.Drawing.Size(63, 15);
         lblResult.TabIndex = 7;
         lblResult.Text = "Результат:";
         // 
         // btnCalculate
         // 
         btnCalculate.Location = new System.Drawing.Point(21, 60);
         btnCalculate.Name = "btnCalculate";
         btnCalculate.Size = new System.Drawing.Size(100, 23);
         btnCalculate.TabIndex = 6;
         btnCalculate.Text = "Рассчитать";
         btnCalculate.UseVisualStyleBackColor = true;
         btnCalculate.Click += btnCalculate_Click;
         // 
         // txtResult
         // 
         txtResult.Location = new System.Drawing.Point(12, 113);
         txtResult.Name = "txtResult";
         txtResult.Size = new System.Drawing.Size(250, 23);
         txtResult.TabIndex = 5;
         // 
         // txtInput
         // 
         txtInput.Location = new System.Drawing.Point(12, 12);
         txtInput.Multiline = true;
         txtInput.Name = "txtInput";
         txtInput.PlaceholderText = "Введите число...";
         txtInput.Size = new System.Drawing.Size(250, 23);
         txtInput.TabIndex = 4;
         // 
         // FormOne
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(284, 141);
         Controls.Add(lblResult);
         Controls.Add(btnCalculate);
         Controls.Add(txtResult);
         Controls.Add(txtInput);
         MaximizeBox = false;
         MinimizeBox = false;
         Name = "FormOne";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "WinForms с консольными расчётами";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.Label lblResult;
      private System.Windows.Forms.Button btnCalculate;
      private System.Windows.Forms.TextBox txtResult;
      private System.Windows.Forms.TextBox txtInput;
   }
}