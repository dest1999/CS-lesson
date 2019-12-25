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
 * а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок (не создана база данных,
 * обращение к несуществующему вопросу, открытие слишком большого файла и т.д.)
 * б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие
 * «косметические» улучшения на свое усмотрение
 * в) Добавить в приложение меню «О программе» с информацией о программе (автор, версия, авторские права и др.).
 * г)* Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных (элемент SaveFileDialog)
 * 
 * coded by Олег Саврик
 */
namespace BelieveOrNotBelieve
{
    public partial class Form1 : Form
    {

        TrueFalse database;

        public Form1()
        {
            InitializeComponent();
        }

        private string ExtractFileName(string fileName)
        {
            string[] tmpStr = fileName.Split('\\');
            return tmpStr[(tmpStr.Length) - 1];
        }

        #region FileMenu

        private void miNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(sfd.FileName);
                database.Add("", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
                this.Text = ExtractFileName(sfd.FileName);
            }
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            if (database != null) 
            {
                database.Save();
                miUnsave.Visible = false;
            }
            else MessageBox.Show("БД не создана", "Инфо");
        }

        private void miSaveAs_Click(object sender, EventArgs e)
        {
            if(database != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    database.Save(sfd.FileName);
                    database.FileName = sfd.FileName;
                    database.Load();
                    this.Text = ExtractFileName(sfd.FileName);
                }
            }
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
                this.Text = ExtractFileName(ofd.FileName);
            }
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор программы: Олег\nВерсия: позавчера\nАвторские права? Не, неслышал", "О...");
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void miUnsave_Click(object sender, EventArgs e)
        {
            miSave_Click(this, e);
        }





        #endregion

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            if (database == null)
            {
                nudNumber.Value = 0;
            }
            else
            {
                tboxQuestion.Text = database[(int)nudNumber.Value - 1].text;
                cboxTrue.Checked = database[(int)nudNumber.Value - 1].trueFalse;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую БД", "Инфо");
            }
            else
            {
                database.Add((database.Count + 1).ToString(), true);
                nudNumber.Maximum = database.Count;
                nudNumber.Value = database.Count;
                miUnsave.Visible = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую БД", "Инфо");
                return;
            }
            if (nudNumber.Maximum == 1)
            {
                MessageBox.Show("Это единственная запись в БД", "Инфо");
            }
            else
            {
                database.Remove((int)(nudNumber.Value - 1));
                nudNumber.Maximum--;
                tboxQuestion.Text = database[(int)nudNumber.Value - 1].text;
                cboxTrue.Checked = database[(int)nudNumber.Value - 1].trueFalse;
                if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
                miUnsave.Visible = true;
            }

        }

        private void btnSaveQuestion_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую БД", "Инфо");
            }
            else
            {
                database[(int)nudNumber.Value - 1].text = tboxQuestion.Text;
                database[(int)nudNumber.Value - 1].trueFalse = cboxTrue.Checked;
                miUnsave.Visible = true;
            }
        }

    }
}
