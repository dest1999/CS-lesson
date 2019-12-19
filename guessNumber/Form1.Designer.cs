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
            this.tbUserAnswer = new System.Windows.Forms.TextBox();
            this.btnUserAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUserAnswer
            // 
            this.tbUserAnswer.Location = new System.Drawing.Point(12, 12);
            this.tbUserAnswer.Name = "tbUserAnswer";
            this.tbUserAnswer.Size = new System.Drawing.Size(100, 20);
            this.tbUserAnswer.TabIndex = 0;
            // 
            // btnUserAnswer
            // 
            this.btnUserAnswer.Location = new System.Drawing.Point(118, 10);
            this.btnUserAnswer.Name = "btnUserAnswer";
            this.btnUserAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnUserAnswer.TabIndex = 1;
            this.btnUserAnswer.Text = "Проверить";
            this.btnUserAnswer.UseVisualStyleBackColor = true;
            this.btnUserAnswer.Click += new System.EventHandler(this.btnUserAnswer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 94);
            this.Controls.Add(this.btnUserAnswer);
            this.Controls.Add(this.tbUserAnswer);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра \"Угадай число\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserAnswer;
        private System.Windows.Forms.Button btnUserAnswer;
    }
}

