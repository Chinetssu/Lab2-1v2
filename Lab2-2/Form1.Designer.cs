
namespace Lab2_2
{
    partial class Form1
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
            this.InputField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cleanButton = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelResSign = new System.Windows.Forms.Label();
            this.buttonRes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputField
            // 
            this.InputField.Location = new System.Drawing.Point(168, 5);
            this.InputField.Name = "InputField";
            this.InputField.Size = new System.Drawing.Size(268, 27);
            this.InputField.TabIndex = 0;
            this.InputField.TextChanged += new System.EventHandler(this.InputCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите выражение";
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(12, 45);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(165, 29);
            this.cleanButton.TabIndex = 2;
            this.cleanButton.Text = "Очистить поле ввода";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.CleanField);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(359, 33);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(17, 20);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "0";
            // 
            // labelResSign
            // 
            this.labelResSign.AutoSize = true;
            this.labelResSign.Location = new System.Drawing.Point(334, 33);
            this.labelResSign.Name = "labelResSign";
            this.labelResSign.Size = new System.Drawing.Size(19, 20);
            this.labelResSign.TabIndex = 5;
            this.labelResSign.Text = "=";
            // 
            // buttonRes
            // 
            this.buttonRes.Location = new System.Drawing.Point(334, 56);
            this.buttonRes.Name = "buttonRes";
            this.buttonRes.Size = new System.Drawing.Size(102, 29);
            this.buttonRes.TabIndex = 6;
            this.buttonRes.Text = "Результат";
            this.buttonRes.UseVisualStyleBackColor = true;
            this.buttonRes.Click += new System.EventHandler(this.buttonRes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 93);
            this.Controls.Add(this.buttonRes);
            this.Controls.Add(this.labelResSign);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputField);
            this.Name = "Form1";
            this.Text = "Вычисление выражения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Clean;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelResSign;
        private System.Windows.Forms.Button buttonRes;
    }
}

