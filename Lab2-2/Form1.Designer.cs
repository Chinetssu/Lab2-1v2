
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
            this.groupCalc = new System.Windows.Forms.GroupBox();
            this.buttonCalcYeah = new System.Windows.Forms.Button();
            this.buttonCalcNah = new System.Windows.Forms.Button();
            this.groupCalc.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputField
            // 
            this.InputField.Location = new System.Drawing.Point(168, 5);
            this.InputField.Name = "InputField";
            this.InputField.Size = new System.Drawing.Size(551, 27);
            this.InputField.TabIndex = 0;
            this.InputField.TextChanged += new System.EventHandler(this.InputCheck);
            this.InputField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterCheck);
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
            this.cleanButton.Location = new System.Drawing.Point(554, 38);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(165, 29);
            this.cleanButton.TabIndex = 2;
            this.cleanButton.Text = "Очистить поле ввода";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.CleanField);
            // 
            // groupCalc
            // 
            this.groupCalc.Controls.Add(this.buttonCalcYeah);
            this.groupCalc.Controls.Add(this.buttonCalcNah);
            this.groupCalc.Location = new System.Drawing.Point(168, 149);
            this.groupCalc.Name = "groupCalc";
            this.groupCalc.Size = new System.Drawing.Size(414, 109);
            this.groupCalc.TabIndex = 3;
            this.groupCalc.TabStop = false;
            this.groupCalc.Text = "Хотите отключить уведомления о некорректном вводе?";
            // 
            // buttonCalcYeah
            // 
            this.buttonCalcYeah.Location = new System.Drawing.Point(25, 60);
            this.buttonCalcYeah.Name = "buttonCalcYeah";
            this.buttonCalcYeah.Size = new System.Drawing.Size(93, 29);
            this.buttonCalcYeah.TabIndex = 5;
            this.buttonCalcYeah.Text = "Да";
            this.buttonCalcYeah.UseVisualStyleBackColor = true;
            // 
            // buttonCalcNah
            // 
            this.buttonCalcNah.Location = new System.Drawing.Point(304, 60);
            this.buttonCalcNah.Name = "buttonCalcNah";
            this.buttonCalcNah.Size = new System.Drawing.Size(94, 29);
            this.buttonCalcNah.TabIndex = 4;
            this.buttonCalcNah.Text = "Нет";
            this.buttonCalcNah.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 410);
            this.Controls.Add(this.groupCalc);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputField);
            this.Name = "Form1";
            this.Text = "Вычисление выражения";
            this.groupCalc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Clean;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.GroupBox groupCalc;
        private System.Windows.Forms.Button buttonCalcYeah;
        private System.Windows.Forms.Button buttonCalcNah;
    }
}

