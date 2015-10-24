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
    public partial class Form_open : Form
    {
        Form_close form_close = new Form_close();
        public Form_open()
        {
            InitializeComponent();
            label_name.ForeColor = Color.Green;
            label_name.Font = new Font("label_name", 30);

      
        }

        private void label_name_Click(object sender, EventArgs e)
        {

        }

        private void Form_open_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_open_Click(object sender, EventArgs e)
        {
            form_close.Show();
            this.Hide();
        }

        private void Form_open_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
