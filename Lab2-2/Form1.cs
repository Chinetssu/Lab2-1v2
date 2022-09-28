using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Calculate()
        {
            if (InputField.Text[0] == '+')
            {
                InputField.Text = InputField.Text[1..];
            }
            if (InputField.Text.Length > 1)
            {
                if ((InputField.Text[InputField.Text.Length - 1] == '+' || InputField.Text[InputField.Text.Length - 1] == '-') && (InputField.Text[InputField.Text.Length - 2] == '+' || InputField.Text[InputField.Text.Length - 2] == '-'))
                {
                    char sign = InputField.Text[InputField.Text.Length - 1];
                    InputField.Text = InputField.Text.TrimEnd('-', '+');
                    InputField.Text += sign;
                    InputField.SelectionStart = InputField.Text.Length;
                }
            }
            int res = 0, num = 0, minus = 1;
            for (int i = 0; i < InputField.Text.Length; i++)
            {

                if (InputField.Text[i] == '-')
                {
                    res += num * minus;
                    num = 0;
                    minus = -1;
                }
                if (InputField.Text[i] == '+')
                {
                    res += num * minus;
                    num = 0;
                    minus = 1;
                }
                if (InputField.Text[i] >= '0' && InputField.Text[i] <= '9')
                {
                    num = num * 10 + InputField.Text[i] - '0';
                }
            }
            res += num * minus;
            labelResult.Text = res.ToString();
        }
        private void EnterCheck(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Calculate();
            }
        }

        private void InputCheck(object sender, EventArgs e)
        {
            int length = InputField.Text.Length;
            if (length > 0)
            {
                char sym = InputField.Text[length - 1];
                if (!(sym >= '0' && sym <= '9') && !(sym == '-' || sym == '+'))
                {
                    if (length == 1)
                    {
                        InputField.Text = "";
                        MessageBox.Show("Введён недопустимый символ!");
                    }
                    else
                    {
                        InputField.Text = InputField.Text.Substring(0, length - 1);
                        MessageBox.Show("Введён недопустимый символ!");
                        InputField.SelectionStart = InputField.Text.Length;
                    }
                }
                else
                {
                    Calculate();
                }
            }
            else
            {
                labelResult.Text = "0";
            }
        }

        private void CleanField(object sender, EventArgs e)
        {
            InputField.Text = "";
            labelResult.Text = "0";
            InputField.Focus();
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Результат равен: "+ labelResult.Text);
        }
    }
}
