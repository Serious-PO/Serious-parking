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
    public partial class Form_close : Form
    {
        Form_final form_final = new Form_final();
        public Form_close()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            form_final.Show();
            this.Hide();
          /*  if (textBox1.Text.ToString() == "A732PE")
            {
                form_open.Show();
                this.Hide();
            }
            else
            {
                form_error.Show();
                this.Hide();
            }*/
        }

        private void Form_close_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
