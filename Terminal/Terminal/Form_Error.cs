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
        Form_close form_close = new Form_close();
        public Form_Error()
        {
            InitializeComponent();
            label_no.ForeColor = Color.Red;
            label_no.Font = new Font("label_no", 30);
        }

        private void label_no_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            form_close.Show();
            this.Hide();
        }

        private void Form_Error_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
