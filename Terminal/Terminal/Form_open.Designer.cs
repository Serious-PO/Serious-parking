namespace Terminal
{
    partial class Form_open
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_open));
            this.pictureBox_open = new System.Windows.Forms.PictureBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_balance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_open)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_open
            // 
            this.pictureBox_open.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_open.Image")));
            this.pictureBox_open.Location = new System.Drawing.Point(418, 12);
            this.pictureBox_open.Name = "pictureBox_open";
            this.pictureBox_open.Size = new System.Drawing.Size(474, 367);
            this.pictureBox_open.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_open.TabIndex = 0;
            this.pictureBox_open.TabStop = false;
            this.pictureBox_open.Click += new System.EventHandler(this.pictureBox_open_Click);
            // 
            // label_name
            // 
            this.label_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(267, 438);
            this.label_name.Margin = new System.Windows.Forms.Padding(0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(0, 13);
            this.label_name.TabIndex = 1;
            this.label_name.Click += new System.EventHandler(this.label_name_Click);
            // 
            // label_balance
            // 
            this.label_balance.AutoSize = true;
            this.label_balance.Location = new System.Drawing.Point(267, 511);
            this.label_balance.Name = "label_balance";
            this.label_balance.Size = new System.Drawing.Size(0, 13);
            this.label_balance.TabIndex = 2;
            // 
            // Form_open
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 691);
            this.Controls.Add(this.label_balance);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.pictureBox_open);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_open";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_open_Closed);
            this.Load += new System.EventHandler(this.Form_open_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_open)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_open;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_balance;
    }
}