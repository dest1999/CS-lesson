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
 * а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
 * б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.
 * Игрок должен получить это число за минимальное количество ходов.
 * в) *Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте обобщенный класс Stack.
 * Вся логика игры должна быть реализована в классе с удвоителем. 
 * 
 * coded by Олег Саврик
 */

namespace WF_Udvoitel
{
    public partial class Form1 : Form
    {
        //Stack<> commands = new Stack<>;
        Random rnd = new Random();
        int i = 1, clicksCounter = 0, targetNumber;
        string[] constToLabels = { "Число: ", "Ваше число: ", "Увеличения: " };
        public Form1()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Clear";
            lblNumber.Text = constToLabels[1] + i.ToString();
            targetNumber = rnd.Next(15, 101);
            lblTargetNumber.Text = constToLabels[0] + targetNumber.ToString();
            MessageBox.Show("Вы должный получить число " + targetNumber.ToString());
            lblCount.Text = constToLabels[2] + clicksCounter.ToString();
        }

        private void btnPlus1_Click(object sender, EventArgs e)
        {
            lblCount.Text = constToLabels[2] + (++clicksCounter).ToString();
            lblNumber.Text = constToLabels[1] + (++i).ToString();
            if (i == targetNumber) youWinner(this, e);
        }

        private void btnMultiple2_Click(object sender, EventArgs e)
        {
            lblCount.Text = constToLabels[2] + (++clicksCounter).ToString();
            lblNumber.Text = constToLabels[1] + (i *= 2).ToString();
            if (i == targetNumber) youWinner(this, e);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clicksCounter = 0;
            lblCount.Text = constToLabels[2] + clicksCounter.ToString();
            i = 1;
            lblNumber.Text = constToLabels[1] + i.ToString();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            btnReset_Click(this, e);
            targetNumber = rnd.Next(15, 101);
            lblTargetNumber.Text = constToLabels[0] + targetNumber.ToString();
            MessageBox.Show("Вы должный получить число " + targetNumber.ToString());
        }

        private void youWinner(object sender, EventArgs e)
        {
            MessageBox.Show("Выигрыш!!!\nНачинаем заново");
            btnNewGame_Click(this, e);
        }

    }
}
