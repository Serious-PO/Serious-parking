namespace Terminal
{
    partial class Form_operator
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
            this.label_name = new System.Windows.Forms.Label();
            this.label_money = new System.Windows.Forms.Label();
            this.button_apply_balance = new System.Windows.Forms.Button();
            this.button_add_user = new System.Windows.Forms.Button();
            this.button_change_price = new System.Windows.Forms.Button();
            this.textBox_carNumber3 = new System.Windows.Forms.TextBox();
            this.textBox_carNumber2 = new System.Windows.Forms.TextBox();
            this.textBox_carNumber1 = new System.Windows.Forms.TextBox();
            this.textBox_money = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(104, 120);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(132, 13);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "Введите номер машины:";
            // 
            // label_money
            // 
            this.label_money.AutoSize = true;
            this.label_money.Location = new System.Drawing.Point(88, 172);
            this.label_money.Name = "label_money";
            this.label_money.Size = new System.Drawing.Size(148, 13);
            this.label_money.TabIndex = 3;
            this.label_money.Text = "Введите сумму для оплаты:";
            this.label_money.Click += new System.EventHandler(this.label_money_Click);
            // 
            // button_apply_balance
            // 
            this.button_apply_balance.Location = new System.Drawing.Point(262, 255);
            this.button_apply_balance.Name = "button_apply_balance";
            this.button_apply_balance.Size = new System.Drawing.Size(148, 35);
            this.button_apply_balance.TabIndex = 4;
            this.button_apply_balance.Text = "Пополнить счет";
            this.button_apply_balance.UseVisualStyleBackColor = true;
            this.button_apply_balance.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_add_user
            // 
            this.button_add_user.Location = new System.Drawing.Point(538, 370);
            this.button_add_user.Name = "button_add_user";
            this.button_add_user.Size = new System.Drawing.Size(148, 35);
            this.button_add_user.TabIndex = 5;
            this.button_add_user.Text = "Добавить нового пользователя";
            this.button_add_user.UseVisualStyleBackColor = true;
            this.button_add_user.Click += new System.EventHandler(this.button_add_user_Click);
            // 
            // button_change_price
            // 
            this.button_change_price.Location = new System.Drawing.Point(27, 370);
            this.button_change_price.Name = "button_change_price";
            this.button_change_price.Size = new System.Drawing.Size(148, 35);
            this.button_change_price.TabIndex = 6;
            this.button_change_price.Text = "Изменить стоимость минуты на стоянке";
            this.button_change_price.UseVisualStyleBackColor = true;
            this.button_change_price.Click += new System.EventHandler(this.button_change_price_Click);
            // 
            // textBox_carNumber3
            // 
            this.textBox_carNumber3.Location = new System.Drawing.Point(375, 120);
            this.textBox_carNumber3.Name = "textBox_carNumber3";
            this.textBox_carNumber3.Size = new System.Drawing.Size(34, 20);
            this.textBox_carNumber3.TabIndex = 19;
            this.textBox_carNumber3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_carNumber3_KeyPress);
            // 
            // textBox_carNumber2
            // 
            this.textBox_carNumber2.Location = new System.Drawing.Point(313, 120);
            this.textBox_carNumber2.Name = "textBox_carNumber2";
            this.textBox_carNumber2.Size = new System.Drawing.Size(56, 20);
            this.textBox_carNumber2.TabIndex = 18;
            this.textBox_carNumber2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_carNumber2_KeyPress);
            // 
            // textBox_carNumber1
            // 
            this.textBox_carNumber1.Location = new System.Drawing.Point(261, 120);
            this.textBox_carNumber1.Name = "textBox_carNumber1";
            this.textBox_carNumber1.Size = new System.Drawing.Size(46, 20);
            this.textBox_carNumber1.TabIndex = 17;
            this.textBox_carNumber1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_carNumber1_KeyPress);
            // 
            // textBox_money
            // 
            this.textBox_money.Location = new System.Drawing.Point(262, 169);
            this.textBox_money.Name = "textBox_money";
            this.textBox_money.Size = new System.Drawing.Size(148, 20);
            this.textBox_money.TabIndex = 1;
            this.textBox_money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_money_KeyPress);
            // 
            // Form_operator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 451);
            this.Controls.Add(this.textBox_carNumber3);
            this.Controls.Add(this.textBox_carNumber2);
            this.Controls.Add(this.textBox_carNumber1);
            this.Controls.Add(this.button_change_price);
            this.Controls.Add(this.button_add_user);
            this.Controls.Add(this.button_apply_balance);
            this.Controls.Add(this.label_money);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_money);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_operator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно для оператора";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_operator_FormClosed);
            this.Load += new System.EventHandler(this.Form_operator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_money;
        private System.Windows.Forms.Button button_apply_balance;
        private System.Windows.Forms.Button button_add_user;
        private System.Windows.Forms.Button button_change_price;
        private System.Windows.Forms.TextBox textBox_carNumber3;
        private System.Windows.Forms.TextBox textBox_carNumber2;
        private System.Windows.Forms.TextBox textBox_carNumber1;
        private System.Windows.Forms.TextBox textBox_money;
    }
}

