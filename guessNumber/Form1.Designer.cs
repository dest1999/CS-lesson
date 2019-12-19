namespace guessNumber
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbUserAnswer = new System.Windows.Forms.TextBox();
            this.btnUserAnswer = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            this.lblCounts = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // tbUserAnswer
            // 
            this.tbUserAnswer.Location = new System.Drawing.Point(12, 66);
            this.tbUserAnswer.Name = "tbUserAnswer";
            this.tbUserAnswer.Size = new System.Drawing.Size(100, 20);
            this.tbUserAnswer.TabIndex = 0;
            this.tbUserAnswer.Click += new System.EventHandler(this.tbUserAnswer_Click);
            // 
            // btnUserAnswer
            // 
            this.btnUserAnswer.Location = new System.Drawing.Point(118, 64);
            this.btnUserAnswer.Name = "btnUserAnswer";
            this.btnUserAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnUserAnswer.TabIndex = 1;
            this.btnUserAnswer.Text = "Проверить";
            this.btnUserAnswer.UseVisualStyleBackColor = true;
            this.btnUserAnswer.Click += new System.EventHandler(this.btnUserAnswer_Click);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(12, 9);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(151, 13);
            this.lblHint.TabIndex = 2;
            this.lblHint.Text = "Отгадайте число от 1 до 100";
            // 
            // lblCounts
            // 
            this.lblCounts.AutoSize = true;
            this.lblCounts.Location = new System.Drawing.Point(12, 32);
            this.lblCounts.Name = "lblCounts";
            this.lblCounts.Size = new System.Drawing.Size(35, 13);
            this.lblCounts.TabIndex = 3;
            this.lblCounts.Text = "label1";
            this.lblCounts.MouseHover += new System.EventHandler(this.lblCounts_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 97);
            this.Controls.Add(this.lblCounts);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.btnUserAnswer);
            this.Controls.Add(this.tbUserAnswer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра \"Угадай число\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserAnswer;
        private System.Windows.Forms.Button btnUserAnswer;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Label lblCounts;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

