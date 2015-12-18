namespace Terminal
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
            this.label_car_num = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_refresh = new System.Windows.Forms.Button();
            this.comboBox_num = new System.Windows.Forms.ComboBox();
            this.userQuerry1TableAdapter = new Terminal.DataSet1TableAdapters.UserQuerry1TableAdapter();
            this.userQuerry1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Terminal.DataSet1();
            this.label_check = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userQuerry1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_car
            // 
            this.button_car.Location = new System.Drawing.Point(110, 126);
            this.button_car.Name = "button_car";
            this.button_car.Size = new System.Drawing.Size(83, 33);
            this.button_car.TabIndex = 2;
            this.button_car.Text = "Применить";
            this.button_car.UseVisualStyleBackColor = true;
            this.button_car.Click += new System.EventHandler(this.button_car_Click);
            // 
            // label_car_num
            // 
            this.label_car_num.AutoSize = true;
            this.label_car_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label_car_num.Location = new System.Drawing.Point(36, 34);
            this.label_car_num.Name = "label_car_num";
            this.label_car_num.Size = new System.Drawing.Size(73, 15);
            this.label_car_num.TabIndex = 3;
            this.label_car_num.Text = "Состояние:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Номер автомобиля:";
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.SystemColors.Control;
            this.button_refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_refresh.BackgroundImage")));
            this.button_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_refresh.CausesValidation = false;
            this.button_refresh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_refresh.FlatAppearance.BorderSize = 0;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_refresh.ForeColor = System.Drawing.SystemColors.Control;
            this.button_refresh.Location = new System.Drawing.Point(270, 65);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(22, 22);
            this.button_refresh.TabIndex = 8;
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // comboBox_num
            // 
            this.comboBox_num.FormattingEnabled = true;
            this.comboBox_num.Location = new System.Drawing.Point(145, 65);
            this.comboBox_num.Name = "comboBox_num";
            this.comboBox_num.Size = new System.Drawing.Size(119, 21);
            this.comboBox_num.TabIndex = 7;
            this.comboBox_num.SelectedIndexChanged += new System.EventHandler(this.comboBox_num_SelectedIndexChanged);
            // 
            // userQuerry1TableAdapter
            // 
            this.userQuerry1TableAdapter.ClearBeforeFill = true;
            // 
            // userQuerry1BindingSource
            // 
            this.userQuerry1BindingSource.DataMember = "UserQuerry1";
            this.userQuerry1BindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_check
            // 
            this.label_check.AutoSize = true;
            this.label_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_check.Location = new System.Drawing.Point(115, 34);
            this.label_check.Name = "label_check";
            this.label_check.Size = new System.Drawing.Size(0, 15);
            this.label_check.TabIndex = 9;
            // 
            // Form_car_number
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 199);
            this.Controls.Add(this.label_check);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.comboBox_num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_car_num);
            this.Controls.Add(this.button_car);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_car_number";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Въезд";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_car_number_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_car_number_FormClosed);
            this.Load += new System.EventHandler(this.Form_car_number_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userQuerry1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_car;
        private System.Windows.Forms.Label label_car_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.ComboBox comboBox_num;
        private DataSet1TableAdapters.UserQuerry1TableAdapter userQuerry1TableAdapter;
        private System.Windows.Forms.BindingSource userQuerry1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.Label label_check;
    }
}