namespace Terminal
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox_car = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_car
            // 
            this.pictureBox_car.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_car.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_car.Image")));
            this.pictureBox_car.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_car.Name = "pictureBox_car";
            this.pictureBox_car.Size = new System.Drawing.Size(1274, 691);
            this.pictureBox_car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_car.TabIndex = 0;
            this.pictureBox_car.TabStop = false;
            this.pictureBox_car.Click += new System.EventHandler(this.pictureBox_car_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 691);
            this.Controls.Add(this.pictureBox_car);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terminal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox_car;


    }
}

