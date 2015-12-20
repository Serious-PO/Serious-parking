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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_operator));
            this.label_name = new System.Windows.Forms.Label();
            this.label_money = new System.Windows.Forms.Label();
            this.button_apply_balance = new System.Windows.Forms.Button();
            this.button_add_user = new System.Windows.Forms.Button();
            this.button_change_price = new System.Windows.Forms.Button();
            this.textBox_carNumber3 = new System.Windows.Forms.TextBox();
            this.textBox_carNumber2 = new System.Windows.Forms.TextBox();
            this.textBox_carNumber1 = new System.Windows.Forms.TextBox();
            this.textBox_money = new System.Windows.Forms.TextBox();
            this.button_user_info = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(128, 120);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(132, 13);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "Введите номер машины:";
            this.label_name.Click += new System.EventHandler(this.label_name_Click);
            // 
            // label_money
            // 
            this.label_money.AutoSize = true;
            this.label_money.Location = new System.Drawing.Point(112, 172);
            this.label_money.Name = "label_money";
            this.label_money.Size = new System.Drawing.Size(148, 13);
            this.label_money.TabIndex = 3;
            this.label_money.Text = "Введите сумму для оплаты:";
            this.label_money.Click += new System.EventHandler(this.label_money_Click);
            // 
            // button_apply_balance
            // 
            this.button_apply_balance.Location = new System.Drawing.Point(286, 255);
            this.button_apply_balance.Name = "button_apply_balance";
            this.button_apply_balance.Size = new System.Drawing.Size(148, 35);
            this.button_apply_balance.TabIndex = 5;
            this.button_apply_balance.Text = "Пополнить счет";
            this.button_apply_balance.UseVisualStyleBackColor = true;
            this.button_apply_balance.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_add_user
            // 
            this.button_add_user.Location = new System.Drawing.Point(541, 370);
            this.button_add_user.Name = "button_add_user";
            this.button_add_user.Size = new System.Drawing.Size(148, 35);
            this.button_add_user.TabIndex = 6;
            this.button_add_user.Text = "Добавить нового пользователя";
            this.button_add_user.UseVisualStyleBackColor = true;
            this.button_add_user.Click += new System.EventHandler(this.button_add_user_Click);
            // 
            // button_change_price
            // 
            this.button_change_price.Location = new System.Drawing.Point(27, 370);
            this.button_change_price.Name = "button_change_price";
            this.button_change_price.Size = new System.Drawing.Size(148, 35);
            this.button_change_price.TabIndex = 7;
            this.button_change_price.Text = "Изменить стоимость минуты на стоянке";
            this.button_change_price.UseVisualStyleBackColor = true;
            this.button_change_price.Click += new System.EventHandler(this.button_change_price_Click);
            // 
            // textBox_carNumber3
            // 
            this.textBox_carNumber3.Location = new System.Drawing.Point(386, 120);
            this.textBox_carNumber3.Name = "textBox_carNumber3";
            this.textBox_carNumber3.Size = new System.Drawing.Size(47, 20);
            this.textBox_carNumber3.TabIndex = 3;
            this.textBox_carNumber3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_carNumber3_KeyPress);
            // 
            // textBox_carNumber2
            // 
            this.textBox_carNumber2.Location = new System.Drawing.Point(324, 120);
            this.textBox_carNumber2.Name = "textBox_carNumber2";
            this.textBox_carNumber2.Size = new System.Drawing.Size(56, 20);
            this.textBox_carNumber2.TabIndex = 2;
            this.textBox_carNumber2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_carNumber2_KeyPress);
            // 
            // textBox_carNumber1
            // 
            this.textBox_carNumber1.Location = new System.Drawing.Point(285, 120);
            this.textBox_carNumber1.Name = "textBox_carNumber1";
            this.textBox_carNumber1.Size = new System.Drawing.Size(33, 20);
            this.textBox_carNumber1.TabIndex = 1;
            this.textBox_carNumber1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_carNumber1_KeyPress);
            // 
            // textBox_money
            // 
            this.textBox_money.Location = new System.Drawing.Point(286, 169);
            this.textBox_money.Name = "textBox_money";
            this.textBox_money.Size = new System.Drawing.Size(148, 20);
            this.textBox_money.TabIndex = 4;
            this.textBox_money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_money_KeyPress);
            // 
            // button_user_info
            // 
            this.button_user_info.Location = new System.Drawing.Point(285, 370);
            this.button_user_info.Name = "button_user_info";
            this.button_user_info.Size = new System.Drawing.Size(148, 35);
            this.button_user_info.TabIndex = 8;
            this.button_user_info.Text = "Действия пользователя";
            this.button_user_info.UseVisualStyleBackColor = true;
            this.button_user_info.Click += new System.EventHandler(this.button_user_info_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(608, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Группировка окон";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Стоимость стоянки за минуту: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "руб.";
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(173, 14);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(13, 13);
            this.label_price.TabIndex = 12;
            this.label_price.Text = "5";
            // 
            // Form_operator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 447);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_user_info);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_operator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно для оператора";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_operator_FormClosing);
            this.Load += new System.EventHandler(this.Form_operator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_money;
        public System.Windows.Forms.Button button_apply_balance;
        private System.Windows.Forms.Button button_add_user;
        private System.Windows.Forms.Button button_change_price;
        public System.Windows.Forms.TextBox textBox_carNumber3;
        public System.Windows.Forms.TextBox textBox_carNumber2;
        public System.Windows.Forms.TextBox textBox_carNumber1;
        public System.Windows.Forms.TextBox textBox_money;
        private System.Windows.Forms.Button button_user_info;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label_price;
    }
}

