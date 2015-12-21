namespace Terminal
{
    partial class Form_final
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_final));
            this.label_final = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.label_getmoney = new System.Windows.Forms.Label();
            this.label_balance = new System.Windows.Forms.Label();
            this.pictureBox_error = new System.Windows.Forms.PictureBox();
            this.label_error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_error)).BeginInit();
            this.SuspendLayout();
            // 
            // label_final
            // 
            this.label_final.AutoSize = true;
            this.label_final.Location = new System.Drawing.Point(178, 22);
            this.label_final.Name = "label_final";
            this.label_final.Size = new System.Drawing.Size(99, 13);
            this.label_final.TabIndex = 0;
            this.label_final.Text = "Счастливого пути!";
            this.label_final.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(98, 101);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(40, 13);
            this.label_time.TabIndex = 1;
            this.label_time.Text = "Время";
            // 
            // label_getmoney
            // 
            this.label_getmoney.AutoSize = true;
            this.label_getmoney.Location = new System.Drawing.Point(98, 135);
            this.label_getmoney.Name = "label_getmoney";
            this.label_getmoney.Size = new System.Drawing.Size(50, 13);
            this.label_getmoney.TabIndex = 2;
            this.label_getmoney.Text = "Списано";
            // 
            // label_balance
            // 
            this.label_balance.AutoSize = true;
            this.label_balance.Location = new System.Drawing.Point(98, 172);
            this.label_balance.Name = "label_balance";
            this.label_balance.Size = new System.Drawing.Size(44, 13);
            this.label_balance.TabIndex = 3;
            this.label_balance.Text = "Баланс";
            // 
            // pictureBox_error
            // 
            this.pictureBox_error.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_error.Image")));
            this.pictureBox_error.Location = new System.Drawing.Point(185, -1);
            this.pictureBox_error.Name = "pictureBox_error";
            this.pictureBox_error.Size = new System.Drawing.Size(194, 196);
            this.pictureBox_error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_error.TabIndex = 4;
            this.pictureBox_error.TabStop = false;
            this.pictureBox_error.Visible = false;
            // 
            // label_error
            // 
            this.label_error.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_error.AutoSize = true;
            this.label_error.Location = new System.Drawing.Point(93, 215);
            this.label_error.Margin = new System.Windows.Forms.Padding(0);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(29, 13);
            this.label_error.TabIndex = 5;
            this.label_error.Text = "Имя";
            this.label_error.Visible = false;
            // 
            // Form_final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 278);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.pictureBox_error);
            this.Controls.Add(this.label_balance);
            this.Controls.Add(this.label_getmoney);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_final);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(574, 309);
            this.MinimizeBox = false;
            this.Name = "Form_final";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Терминал на выезде";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_final_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_final_Closed);
            this.Load += new System.EventHandler(this.Form_final_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form_final_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_final;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_getmoney;
        private System.Windows.Forms.Label label_balance;
        private System.Windows.Forms.PictureBox pictureBox_error;
        private System.Windows.Forms.Label label_error;
    }
}