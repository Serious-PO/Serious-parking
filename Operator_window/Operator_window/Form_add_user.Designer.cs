namespace Operator_window
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
            this.textBox_last_name = new System.Windows.Forms.TextBox();
            this.textBox_first_name = new System.Windows.Forms.TextBox();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.button_apply = new System.Windows.Forms.Button();
            this.label_last_name = new System.Windows.Forms.Label();
            this.label_first_name = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label_number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_last_name
            // 
            this.textBox_last_name.Location = new System.Drawing.Point(259, 72);
            this.textBox_last_name.Name = "textBox_last_name";
            this.textBox_last_name.Size = new System.Drawing.Size(148, 20);
            this.textBox_last_name.TabIndex = 0;
            // 
            // textBox_first_name
            // 
            this.textBox_first_name.Location = new System.Drawing.Point(259, 125);
            this.textBox_first_name.Name = "textBox_first_name";
            this.textBox_first_name.Size = new System.Drawing.Size(148, 20);
            this.textBox_first_name.TabIndex = 1;
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(259, 175);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(148, 20);
            this.textBox_date.TabIndex = 2;
            // 
            // textBox_number
            // 
            this.textBox_number.Location = new System.Drawing.Point(259, 224);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(148, 20);
            this.textBox_number.TabIndex = 3;
            // 
            // button_apply
            // 
            this.button_apply.Location = new System.Drawing.Point(259, 284);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(148, 35);
            this.button_apply.TabIndex = 4;
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
            this.label_last_name.TabIndex = 5;
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
            // Form_add_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 421);
            this.Controls.Add(this.label_number);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_first_name);
            this.Controls.Add(this.label_last_name);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.textBox_number);
            this.Controls.Add(this.textBox_date);
            this.Controls.Add(this.textBox_first_name);
            this.Controls.Add(this.textBox_last_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_add_user";
            this.Text = "Добавление нового пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_last_name;
        private System.Windows.Forms.TextBox textBox_first_name;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Label label_last_name;
        private System.Windows.Forms.Label label_first_name;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_number;
    }
}