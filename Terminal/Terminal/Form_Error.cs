using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Terminal
{
    public partial class Form_Error : Form
    {       
        Form_car_number frm;
        public Form_Error(Form_car_number f)
        {
            InitializeComponent();
            frm = f;
            label_no.ForeColor = Color.Red;
            label_no.Font = new Font("label_no", 30);
        }

        private void label_no_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frm.Show();
            this.Close();
        }

        private void Form_Error_Closed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
