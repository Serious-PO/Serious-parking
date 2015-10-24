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
    public partial class Form_car_number : Form
    {

        Form_open form_open = new Form_open();
        Form_Error form_error = new Form_Error();
        public Form_car_number()
        {
            InitializeComponent();

        }

        private void button_car_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString() == "A732PE")
            {
                form_open.Show();
                this.Hide();
            }
            else
            {
                form_error.Show();
                this.Hide();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form_car_number_FormClosed(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Exit();
        }

        private void Form_car_number_Load(object sender, EventArgs e)
        {

        }

        private void Form_car_number_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
