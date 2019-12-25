using System;
using System.Windows.Forms;

/*
 * Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDow
 * 
 * coded by Олег Саврик
 */

namespace linkElements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDown.Maximum = int.MaxValue;
            numericUpDown.Minimum = int.MinValue;
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            textBox.Text = numericUpDown.Value.ToString();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

            if (int.TryParse(textBox.Text, out int i))
            {
                numericUpDown.Value = i;
            }
        }
    }
}
