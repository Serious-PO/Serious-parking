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
            this.SuspendLayout();
            // 
            // label_final
            // 
            this.label_final.AutoSize = true;
            this.label_final.Location = new System.Drawing.Point(442, 66);
            this.label_final.Name = "label_final";
            this.label_final.Size = new System.Drawing.Size(99, 13);
            this.label_final.TabIndex = 0;
            this.label_final.Text = "Счастливого пути!";
            this.label_final.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(156, 324);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(0, 13);
            this.label_time.TabIndex = 1;
            // 
            // label_getmoney
            // 
            this.label_getmoney.AutoSize = true;
            this.label_getmoney.Location = new System.Drawing.Point(156, 369);
            this.label_getmoney.Name = "label_getmoney";
            this.label_getmoney.Size = new System.Drawing.Size(0, 13);
            this.label_getmoney.TabIndex = 2;
            // 
            // label_balance
            // 
            this.label_balance.AutoSize = true;
            this.label_balance.Location = new System.Drawing.Point(156, 531);
            this.label_balance.Name = "label_balance";
            this.label_balance.Size = new System.Drawing.Size(0, 13);
            this.label_balance.TabIndex = 3;
            // 
            // Form_final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 691);
            this.Controls.Add(this.label_balance);
            this.Controls.Add(this.label_getmoney);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_final);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_final";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_final_Closed);
            this.Load += new System.EventHandler(this.Form_final_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form_final_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_final;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_getmoney;
        private System.Windows.Forms.Label label_balance;
    }
}