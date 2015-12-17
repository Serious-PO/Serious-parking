namespace Operator_window
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
            this.textBox_number_car = new System.Windows.Forms.TextBox();
            this.textBox_money = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_money = new System.Windows.Forms.Label();
            this.button_apply_balance = new System.Windows.Forms.Button();
            this.button_add_user = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_number_car
            // 
            this.textBox_number_car.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_number_car.Location = new System.Drawing.Point(262, 117);
            this.textBox_number_car.Name = "textBox_number_car";
            this.textBox_number_car.Size = new System.Drawing.Size(148, 20);
            this.textBox_number_car.TabIndex = 0;
            // 
            // textBox_money
            // 
            this.textBox_money.Location = new System.Drawing.Point(262, 169);
            this.textBox_money.Name = "textBox_money";
            this.textBox_money.Size = new System.Drawing.Size(148, 20);
            this.textBox_money.TabIndex = 1;
            this.textBox_money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_money_KeyPress);
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
            this.button_add_user.Location = new System.Drawing.Point(45, 373);
            this.button_add_user.Name = "button_add_user";
            this.button_add_user.Size = new System.Drawing.Size(148, 35);
            this.button_add_user.TabIndex = 5;
            this.button_add_user.Text = "Добавить нового пользователя";
            this.button_add_user.UseVisualStyleBackColor = true;
            this.button_add_user.Click += new System.EventHandler(this.button_add_user_Click);
            // 
            // Form_operator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 451);
            this.Controls.Add(this.button_add_user);
            this.Controls.Add(this.button_apply_balance);
            this.Controls.Add(this.label_money);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_money);
            this.Controls.Add(this.textBox_number_car);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_operator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно для оператора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_number_car;
        private System.Windows.Forms.TextBox textBox_money;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_money;
        private System.Windows.Forms.Button button_apply_balance;
        private System.Windows.Forms.Button button_add_user;
    }
}

