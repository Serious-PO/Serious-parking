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
    public partial class Form1 : Form
    {
        
        Form_car_number form2;
        Form_operator frm;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            frm = new Form_operator();
            frm.Show();
        }
        private void pictureBox_car_Click(object sender, EventArgs e)
        {
            form2  = new Form_car_number(this);
            form2.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

}
