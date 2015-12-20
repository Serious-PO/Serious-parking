namespace Terminal
{
    partial class Form_user_info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_num = new System.Windows.Forms.ComboBox();
            this.InfoArea = new System.Windows.Forms.RichTextBox();
            this.textBox_lastName = new System.Windows.Forms.TextBox();
            this.textBox_firstName = new System.Windows.Forms.TextBox();
            this.textBox_balance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_num
            // 
            this.comboBox_num.FormattingEnabled = true;
            this.comboBox_num.Location = new System.Drawing.Point(51, 50);
            this.comboBox_num.Name = "comboBox_num";
            this.comboBox_num.Size = new System.Drawing.Size(114, 21);
            this.comboBox_num.TabIndex = 0;
            this.comboBox_num.TextChanged += new System.EventHandler(this.comboBox_num_TextChanged);
            // 
            // InfoArea
            // 
            this.InfoArea.BackColor = System.Drawing.Color.White;
            this.InfoArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.InfoArea.Location = new System.Drawing.Point(51, 99);
            this.InfoArea.Name = "InfoArea";
            this.InfoArea.ReadOnly = true;
            this.InfoArea.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.InfoArea.Size = new System.Drawing.Size(569, 279);
            this.InfoArea.TabIndex = 4;
            this.InfoArea.Text = "";
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.BackColor = System.Drawing.Color.White;
            this.textBox_lastName.Location = new System.Drawing.Point(184, 51);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.ReadOnly = true;
            this.textBox_lastName.Size = new System.Drawing.Size(124, 20);
            this.textBox_lastName.TabIndex = 7;
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.BackColor = System.Drawing.Color.White;
            this.textBox_firstName.Location = new System.Drawing.Point(327, 50);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.ReadOnly = true;
            this.textBox_firstName.Size = new System.Drawing.Size(126, 20);
            this.textBox_firstName.TabIndex = 8;
            // 
            // textBox_balance
            // 
            this.textBox_balance.BackColor = System.Drawing.Color.White;
            this.textBox_balance.Location = new System.Drawing.Point(469, 50);
            this.textBox_balance.Name = "textBox_balance";
            this.textBox_balance.ReadOnly = true;
            this.textBox_balance.Size = new System.Drawing.Size(151, 20);
            this.textBox_balance.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Номер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Баланс";
            // 
            // Form_user_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 411);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_balance);
            this.Controls.Add(this.textBox_firstName);
            this.Controls.Add(this.textBox_lastName);
            this.Controls.Add(this.InfoArea);
            this.Controls.Add(this.comboBox_num);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(690, 452);
            this.Name = "Form_user_info";
            this.Text = "Действия пользователя";
            this.Load += new System.EventHandler(this.Form_user_info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_num;
        private System.Windows.Forms.RichTextBox InfoArea;
        private System.Windows.Forms.TextBox textBox_lastName;
        private System.Windows.Forms.TextBox textBox_firstName;
        private System.Windows.Forms.TextBox textBox_balance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}