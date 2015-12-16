namespace Terminal
{
    partial class Form_change_price
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
            this.label_price = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(12, 80);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(122, 13);
            this.label_price.TabIndex = 0;
            this.label_price.Text = "Новая цена за минуту:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(86, 39);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(48, 13);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "Пароль:";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(140, 36);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(143, 20);
            this.textBox_password.TabIndex = 1;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(140, 77);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(143, 20);
            this.textBox_price.TabIndex = 2;
            this.textBox_price.TextChanged += new System.EventHandler(this.textBox_price_TextChanged);
            this.textBox_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_change_price_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_change_price
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 215);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_price);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_change_price";
            this.Text = "Изменить цену";
            this.Load += new System.EventHandler(this.Form_change_price_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_password;
        public System.Windows.Forms.TextBox textBox_password;
        public System.Windows.Forms.TextBox textBox_price;
        public System.Windows.Forms.Button button1;
    }
}