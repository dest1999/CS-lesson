using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100,
 * а человек пытается его угадать за минимальное число попыток. Компьютер говорит, больше или меньше загаданное число введенного.
 * a) Для ввода данных от человека используется элемент TextBox;
 * б) **Реализовать отдельную форму c TextBox для ввода числа.
 * 
 * coded by Олег Саврик
 */

namespace guessNumber
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int userAnswer, numberIs, i = 0;

        public Form1()
        {
            InitializeComponent();
            numberIs = rnd.Next(1, 101);
            lblCounts.Text = "";
        }

        private void lblCounts_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show(numberIs.ToString(), this);
        }

        private void btnUserAnswer_Click(object sender, EventArgs e)
        {
            lblCounts.Text = "Количество попыток угадать: " + (++i).ToString();
            userAnswer = int.Parse(tbUserAnswer.Text);
            if (userAnswer == numberIs)
            {
                lblHint.Text = "Да, этим числом было " + numberIs.ToString();
                MessageBox.Show("Вы угадали");
                btnUserAnswer.Enabled = false;
            }
            else if (userAnswer < numberIs)
            {
                lblHint.Text = "Слишком маленькое число";
            }
            else if (userAnswer > numberIs)
            {
                lblHint.Text = "Слишком большое число";
            }
        }

        private void tbUserAnswer_Click(object sender, EventArgs e)
        {
            tbUserAnswer.Text = "";
        }
    }
}
