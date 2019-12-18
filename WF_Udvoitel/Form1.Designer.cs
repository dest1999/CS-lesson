namespace WF_Udvoitel
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
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblTargetNumber = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCommand1
            // 
            this.btnCommand1.Location = new System.Drawing.Point(163, 61);
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.Size = new System.Drawing.Size(75, 23);
            this.btnCommand1.TabIndex = 0;
            this.btnCommand1.Text = "+1";
            this.btnCommand1.UseVisualStyleBackColor = true;
            this.btnCommand1.Click += new System.EventHandler(this.btnPlus1_Click);
            // 
            // btnCommand2
            // 
            this.btnCommand2.Location = new System.Drawing.Point(163, 90);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(75, 23);
            this.btnCommand2.TabIndex = 1;
            this.btnCommand2.Text = "x2";
            this.btnCommand2.UseVisualStyleBackColor = true;
            this.btnCommand2.Click += new System.EventHandler(this.btnMultiple2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(163, 119);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "rst";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(12, 66);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(64, 13);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "userNumber";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(163, 32);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 4;
            this.btnNewGame.Text = "New game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblTargetNumber
            // 
            this.lblTargetNumber.AutoSize = true;
            this.lblTargetNumber.Location = new System.Drawing.Point(12, 37);
            this.lblTargetNumber.Name = "lblTargetNumber";
            this.lblTargetNumber.Size = new System.Drawing.Size(71, 13);
            this.lblTargetNumber.TabIndex = 5;
            this.lblTargetNumber.Text = "targetNumber";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(12, 95);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(34, 13);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "count";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 154);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblTargetNumber);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCommand2);
            this.Controls.Add(this.btnCommand1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удвоитель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCommand1;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblTargetNumber;
        private System.Windows.Forms.Label lblCount;
    }
}

