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
        DataSet1TableAdapters.UserQuerryTableAdapter user;
        Form_final form_final;
        Form1 frm;
        public Form_close(Form1 f)
        {
            user = new Terminal.DataSet1TableAdapters.UserQuerryTableAdapter();
            frm = f;
            InitializeComponent();
            
        }

        private void button_close_Click(object sender, EventArgs e)
        {
           
                user.updateTimeQuit(DateTime.Now, textBox1.Text.ToString());
                form_final = new Form_final(this,frm);
                form_final.Show();
                this.Close();
            
        }
        public string number()
        {
            return textBox1.Text;
        }
        private void Form_close_Closed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
