﻿namespace Terminal
{
    partial class Form_add_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_add_user));
            this.textBox_last_name = new System.Windows.Forms.TextBox();
            this.textBox_first_name = new System.Windows.Forms.TextBox();
            this.button_apply = new System.Windows.Forms.Button();
            this.label_last_name = new System.Windows.Forms.Label();
            this.label_first_name = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label_number = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_telephone = new System.Windows.Forms.TextBox();
            this.textBox_year = new System.Windows.Forms.TextBox();
            this.textBox_month = new System.Windows.Forms.TextBox();
            this.textBox_day = new System.Windows.Forms.TextBox();
            this.textBox_carNumber1 = new System.Windows.Forms.TextBox();
            this.textBox_carNumber2 = new System.Windows.Forms.TextBox();
            this.textBox_carNumber3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_last_name
            // 
            this.textBox_last_name.ForeColor = System.Drawing.Color.Gray;
            this.textBox_last_name.Location = new System.Drawing.Point(259, 72);
            this.textBox_last_name.Name = "textBox_last_name";
            this.textBox_last_name.Size = new System.Drawing.Size(148, 20);
            this.textBox_last_name.TabIndex = 1;
            this.textBox_last_name.Text = "Иванов";
            this.textBox_last_name.Enter += new System.EventHandler(this.textBox_last_name_Enter);
            this.textBox_last_name.Leave += new System.EventHandler(this.textBox_last_name_Leave);
            // 
            // textBox_first_name
            // 
            this.textBox_first_name.ForeColor = System.Drawing.Color.Gray;
            this.textBox_first_name.Location = new System.Drawing.Point(259, 125);
            this.textBox_first_name.Name = "textBox_first_name";
            this.textBox_first_name.Size = new System.Drawing.Size(148, 20);
            this.textBox_first_name.TabIndex = 2;
            this.textBox_first_name.Text = "Иван";
            this.textBox_first_name.Enter += new System.EventHandler(this.textBox_first_name_Enter);
            this.textBox_first_name.Leave += new System.EventHandler(this.textBox_first_name_Leave);
            // 
            // button_apply
            // 
            this.button_apply.Location = new System.Drawing.Point(259, 322);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(148, 35);
            this.button_apply.TabIndex = 10;
            this.button_apply.Text = "Добавить пользователя";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // label_last_name
            // 
            this.label_last_name.AutoSize = true;
            this.label_last_name.Location = new System.Drawing.Point(168, 75);
            this.label_last_name.Name = "label_last_name";
            this.label_last_name.Size = new System.Drawing.Size(59, 13);
            this.label_last_name.TabIndex = 0;
            this.label_last_name.Text = "Фамилия:";
            // 
            // label_first_name
            // 
            this.label_first_name.AutoSize = true;
            this.label_first_name.Location = new System.Drawing.Point(195, 132);
            this.label_first_name.Name = "label_first_name";
            this.label_first_name.Size = new System.Drawing.Size(32, 13);
            this.label_first_name.TabIndex = 6;
            this.label_first_name.Text = "Имя:";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(138, 182);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(89, 13);
            this.label_date.TabIndex = 7;
            this.label_date.Text = "Дата рождения:";
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Location = new System.Drawing.Point(138, 231);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(89, 13);
            this.label_number.TabIndex = 8;
            this.label_number.Text = "Номер машины:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Номер телефона";
            // 
            // text_telephone
            // 
            this.text_telephone.ForeColor = System.Drawing.Color.Gray;
            this.text_telephone.Location = new System.Drawing.Point(259, 276);
            this.text_telephone.Name = "text_telephone";
            this.text_telephone.Size = new System.Drawing.Size(148, 20);
            this.text_telephone.TabIndex = 9;
            this.text_telephone.Text = "88005553535";
            this.text_telephone.TextChanged += new System.EventHandler(this.text_telephone_TextChanged);
            this.text_telephone.Enter += new System.EventHandler(this.text_telephone_Enter);
            this.text_telephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_telephone_press);
            this.text_telephone.Leave += new System.EventHandler(this.text_telephone_Leave);
            // 
            // textBox_year
            // 
            this.textBox_year.ForeColor = System.Drawing.Color.Gray;
            this.textBox_year.Location = new System.Drawing.Point(343, 182);
            this.textBox_year.Name = "textBox_year";
            this.textBox_year.Size = new System.Drawing.Size(64, 20);
            this.textBox_year.TabIndex = 5;
            this.textBox_year.Text = "1990";
            this.textBox_year.Enter += new System.EventHandler(this.textBox_year_Enter);
            this.textBox_year.Leave += new System.EventHandler(this.textBox_year_Leave);
            // 
            // textBox_month
            // 
            this.textBox_month.ForeColor = System.Drawing.Color.Gray;
            this.textBox_month.Location = new System.Drawing.Point(300, 182);
            this.textBox_month.Name = "textBox_month";
            this.textBox_month.Size = new System.Drawing.Size(37, 20);
            this.textBox_month.TabIndex = 4;
            this.textBox_month.Text = "01";
            this.textBox_month.Enter += new System.EventHandler(this.textBox_month_Enter);
            this.textBox_month.Leave += new System.EventHandler(this.textBox_month_Leave);
            // 
            // textBox_day
            // 
            this.textBox_day.ForeColor = System.Drawing.Color.Gray;
            this.textBox_day.Location = new System.Drawing.Point(259, 182);
            this.textBox_day.Name = "textBox_day";
            this.textBox_day.Size = new System.Drawing.Size(35, 20);
            this.textBox_day.TabIndex = 3;
            this.textBox_day.Text = "01";
            this.textBox_day.Enter += new System.EventHandler(this.textBox_day_Enter);
            this.textBox_day.Leave += new System.EventHandler(this.textBox_day_Leave);
            // 
            // textBox_carNumber1
            // 
            this.textBox_carNumber1.ForeColor = System.Drawing.Color.Gray;
            this.textBox_carNumber1.Location = new System.Drawing.Point(259, 231);
            this.textBox_carNumber1.Name = "textBox_carNumber1";
            this.textBox_carNumber1.Size = new System.Drawing.Size(24, 20);
            this.textBox_carNumber1.TabIndex = 6;
            this.textBox_carNumber1.Text = "А";
            this.textBox_carNumber1.TextChanged += new System.EventHandler(this.textBox_carNumber1_TextChanged);
            this.textBox_carNumber1.Enter += new System.EventHandler(this.textBox_carNumber1_Enter);
            this.textBox_carNumber1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_carNumber1_KeyPress);
            this.textBox_carNumber1.Leave += new System.EventHandler(this.textBox_carNumber1_Leave);
            // 
            // textBox_carNumber2
            // 
            this.textBox_carNumber2.ForeColor = System.Drawing.Color.Gray;
            this.textBox_carNumber2.Location = new System.Drawing.Point(289, 231);
            this.textBox_carNumber2.Name = "textBox_carNumber2";
            this.textBox_carNumber2.Size = new System.Drawing.Size(69, 20);
            this.textBox_carNumber2.TabIndex = 7;
            this.textBox_carNumber2.Text = "000";
            this.textBox_carNumber2.TextChanged += new System.EventHandler(this.textBox_carNumber2_TextChanged);
            this.textBox_carNumber2.Enter += new System.EventHandler(this.textBox_carNumber2_Enter);
            this.textBox_carNumber2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_carNumber2_KeyPress);
            this.textBox_carNumber2.Leave += new System.EventHandler(this.textBox_carNumber2_Leave);
            // 
            // textBox_carNumber3
            // 
            this.textBox_carNumber3.ForeColor = System.Drawing.Color.Gray;
            this.textBox_carNumber3.Location = new System.Drawing.Point(364, 231);
            this.textBox_carNumber3.Name = "textBox_carNumber3";
            this.textBox_carNumber3.Size = new System.Drawing.Size(43, 20);
            this.textBox_carNumber3.TabIndex = 8;
            this.textBox_carNumber3.Text = "АА";
            this.textBox_carNumber3.TextChanged += new System.EventHandler(this.textBox_carNumber3_TextChanged);
            this.textBox_carNumber3.Enter += new System.EventHandler(this.textBox_carNumber3_Enter);
            this.textBox_carNumber3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_carNumber3_KeyPress);
            this.textBox_carNumber3.Leave += new System.EventHandler(this.textBox_carNumber3_Leave);
            // 
            // Form_add_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 421);
            this.Controls.Add(this.textBox_carNumber3);
            this.Controls.Add(this.textBox_carNumber2);
            this.Controls.Add(this.textBox_carNumber1);
            this.Controls.Add(this.textBox_day);
            this.Controls.Add(this.textBox_month);
            this.Controls.Add(this.textBox_year);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_telephone);
            this.Controls.Add(this.label_number);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_first_name);
            this.Controls.Add(this.label_last_name);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.textBox_first_name);
            this.Controls.Add(this.textBox_last_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_add_user";
            this.Text = "Добавление нового пользователя";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_add_user_FormClosed);
            this.Load += new System.EventHandler(this.Form_add_user_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBox_last_name;
        public System.Windows.Forms.TextBox textBox_first_name;
        public System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Label label_last_name;
        private System.Windows.Forms.Label label_first_name;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox text_telephone;
        public System.Windows.Forms.TextBox textBox_year;
        public System.Windows.Forms.TextBox textBox_month;
        public System.Windows.Forms.TextBox textBox_day;
        public System.Windows.Forms.TextBox textBox_carNumber1;
        public System.Windows.Forms.TextBox textBox_carNumber2;
        public System.Windows.Forms.TextBox textBox_carNumber3;
    }
}