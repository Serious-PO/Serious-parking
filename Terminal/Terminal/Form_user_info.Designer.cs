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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox_num
            // 
            this.comboBox_num.FormattingEnabled = true;
            this.comboBox_num.Location = new System.Drawing.Point(51, 50);
            this.comboBox_num.Name = "comboBox_num";
            this.comboBox_num.Size = new System.Drawing.Size(88, 21);
            this.comboBox_num.TabIndex = 0;
            this.comboBox_num.TextChanged += new System.EventHandler(this.comboBox_num_TextChanged);
            // 
            // InfoArea
            // 
            this.InfoArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.InfoArea.Location = new System.Drawing.Point(51, 99);
            this.InfoArea.Name = "InfoArea";
            this.InfoArea.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.InfoArea.Size = new System.Drawing.Size(569, 279);
            this.InfoArea.TabIndex = 4;
            this.InfoArea.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(297, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(64, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(380, 50);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(79, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(469, 50);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(151, 20);
            this.textBox4.TabIndex = 10;
            // 
            // Form_user_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 419);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.InfoArea);
            this.Controls.Add(this.comboBox_num);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}