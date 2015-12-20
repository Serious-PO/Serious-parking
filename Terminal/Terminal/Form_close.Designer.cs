namespace Terminal
{
    partial class Form_close
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_close));
            this.button_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_num = new System.Windows.Forms.ComboBox();
            this.label_check = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_refresh = new System.Windows.Forms.Button();
            this.userQuerry1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Terminal.DataSet1();
            this.userQuerry1TableAdapter = new Terminal.DataSet1TableAdapters.UserQuerry1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.userQuerry1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_close
            // 
            this.button_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_close.Location = new System.Drawing.Point(110, 126);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(83, 33);
            this.button_close.TabIndex = 0;
            this.button_close.Text = "Применить";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер автомобиля:";
            // 
            // comboBox_num
            // 
            this.comboBox_num.FormattingEnabled = true;
            this.comboBox_num.Location = new System.Drawing.Point(145, 65);
            this.comboBox_num.Name = "comboBox_num";
            this.comboBox_num.Size = new System.Drawing.Size(119, 21);
            this.comboBox_num.TabIndex = 3;
            this.comboBox_num.SelectedIndexChanged += new System.EventHandler(this.comboBox_num_SelectedIndexChanged);
            // 
            // label_check
            // 
            this.label_check.AutoSize = true;
            this.label_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_check.Location = new System.Drawing.Point(115, 34);
            this.label_check.Name = "label_check";
            this.label_check.Size = new System.Drawing.Size(0, 15);
            this.label_check.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(36, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Состояние:";
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.SystemColors.Control;
            this.button_refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_refresh.BackgroundImage")));
            this.button_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_refresh.CausesValidation = false;
            this.button_refresh.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_refresh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_refresh.FlatAppearance.BorderSize = 0;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_refresh.ForeColor = System.Drawing.SystemColors.Control;
            this.button_refresh.Location = new System.Drawing.Point(270, 65);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(22, 22);
            this.button_refresh.TabIndex = 6;
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
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
            // userQuerry1TableAdapter
            // 
            this.userQuerry1TableAdapter.ClearBeforeFill = true;
            // 
            // Form_close
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 201);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_check);
            this.Controls.Add(this.comboBox_num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(310, 232);
            this.Name = "Form_close";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выезд";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_close_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_close_Closed);
            this.Load += new System.EventHandler(this.Form_close_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userQuerry1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_num;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource userQuerry1BindingSource;
        private DataSet1TableAdapters.UserQuerry1TableAdapter userQuerry1TableAdapter;
        private System.Windows.Forms.Label label_check;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_close;
    }
}