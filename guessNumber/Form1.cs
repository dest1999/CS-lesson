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
        int userAnswer, numberIs;

        private void btnUserAnswer_Click(object sender, EventArgs e)
        {
            userAnswer = int.Parse(tbUserAnswer.Text);
            if (userAnswer == numberIs)
            {
                MessageBox.Show("Вы угадали");
            }
            else if (userAnswer < numberIs)
            {
                MessageBox.Show("Слишком маленькое");
            }
            else if (userAnswer > numberIs)
            {
                MessageBox.Show("Слишком большое");
            }
        }

        public Form1()
        {
            InitializeComponent();
            numberIs = rnd.Next(1, 101);
        }

        /*
        private void tbUserAnswer_TextChanged(object sender, EventArgs e)
        {

        }*/
    }
}
