namespace lb5_luz
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
            this.label11 = new System.Windows.Forms.Label();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btnReverse = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.8F);
            this.label11.Location = new System.Drawing.Point(31, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 21);
            this.label11.TabIndex = 28;
            this.label11.Text = "Введите числа:";
            // 
            // txt5
            // 
            this.txt5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt5.Font = new System.Drawing.Font("Century Gothic", 9.8F);
            this.txt5.Location = new System.Drawing.Point(35, 206);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(279, 28);
            this.txt5.TabIndex = 27;
            this.txt5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // txt4
            // 
            this.txt4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt4.Font = new System.Drawing.Font("Century Gothic", 9.8F);
            this.txt4.Location = new System.Drawing.Point(35, 172);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(279, 28);
            this.txt4.TabIndex = 26;
            this.txt4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // txt3
            // 
            this.txt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt3.Font = new System.Drawing.Font("Century Gothic", 9.8F);
            this.txt3.Location = new System.Drawing.Point(35, 138);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(279, 28);
            this.txt3.TabIndex = 25;
            this.txt3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // txt2
            // 
            this.txt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt2.Font = new System.Drawing.Font("Century Gothic", 9.8F);
            this.txt2.Location = new System.Drawing.Point(35, 104);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(279, 28);
            this.txt2.TabIndex = 24;
            this.txt2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // txt1
            // 
            this.txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt1.Font = new System.Drawing.Font("Century Gothic", 9.8F);
            this.txt1.Location = new System.Drawing.Point(35, 70);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(279, 28);
            this.txt1.TabIndex = 23;
            this.txt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // btnReverse
            // 
            this.btnReverse.BackColor = System.Drawing.Color.White;
            this.btnReverse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReverse.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.btnReverse.Location = new System.Drawing.Point(35, 240);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(279, 35);
            this.btnReverse.TabIndex = 29;
            this.btnReverse.Text = "Развернуть массив";
            this.btnReverse.UseVisualStyleBackColor = false;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Century Gothic", 8.8F);
            this.lblResult.Location = new System.Drawing.Point(31, 320);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(83, 20);
            this.lblResult.TabIndex = 31;
            this.lblResult.Text = "Результат:";
            // 
            // lblOriginal
            // 
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.BackColor = System.Drawing.Color.Transparent;
            this.lblOriginal.Font = new System.Drawing.Font("Century Gothic", 8.8F);
            this.lblOriginal.Location = new System.Drawing.Point(31, 288);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(88, 20);
            this.lblOriginal.TabIndex = 30;
            this.lblOriginal.Text = "Исходный:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnReverse;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lb5_luz.Properties.Resources.es;
            this.ClientSize = new System.Drawing.Size(356, 409);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblOriginal);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblOriginal;
    }
}

