﻿namespace Terminal
{
    partial class Form_car_number
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_car_number));
            this.button_car = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_car_num = new System.Windows.Forms.Label();
            this.visualStyler1 = new SkinSoft.VisualStyler.VisualStyler(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_car
            // 
            this.button_car.Location = new System.Drawing.Point(110, 100);
            this.button_car.Name = "button_car";
            this.button_car.Size = new System.Drawing.Size(83, 33);
            this.button_car.TabIndex = 2;
            this.button_car.Text = "Применить";
            this.button_car.UseVisualStyleBackColor = true;
            this.button_car.Click += new System.EventHandler(this.button_car_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_car_num
            // 
            this.label_car_num.AutoSize = true;
            this.label_car_num.Location = new System.Drawing.Point(99, 25);
            this.label_car_num.Name = "label_car_num";
            this.label_car_num.Size = new System.Drawing.Size(105, 13);
            this.label_car_num.TabIndex = 3;
            this.label_car_num.Text = "Номер автомобиля";
            // 
            // visualStyler1
            // 
            this.visualStyler1.HostForm = this;
            this.visualStyler1.License = ((SkinSoft.VisualStyler.Licensing.VisualStylerLicense)(resources.GetObject("visualStyler1.License")));
            this.visualStyler1.LoadVisualStyle(null, "OSX (Aqua).vssf");
            // 
            // Form_car_number
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 201);
            this.Controls.Add(this.label_car_num);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_car);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_car_number";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Въезд";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_car_number_Closed);
            this.Load += new System.EventHandler(this.Form_car_number_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_car;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_car_num;
        private SkinSoft.VisualStyler.VisualStyler visualStyler1;
    }
}