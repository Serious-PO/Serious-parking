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
        DataSet1TableAdapters.UserQuerry1TableAdapter user;
        Form_Error form_error;
        Form_final form_final;
        Form_operator frm;
        public Form_close(Form_operator f)
        {
            user = new Terminal.DataSet1TableAdapters.UserQuerry1TableAdapter();
            frm = f;
            InitializeComponent();
            
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < user.GetData().Rows.Count; i++)
            {
                if (number() == user.GetData().Rows[i]["CarNumber"].ToString())
                {
                    if (user.GetData().Rows[i]["OnParking"].ToString() == true.ToString())
                    {
                        user.updateTimeQuit(DateTime.Now, textBox1.Text.ToString());
                        form_final = new Form_final(this, frm);
                        form_final.Show();
                    }
                    else
                    {
                        form_error = new Form_Error(this, "Въезд");
                        form_error.Show();
                    }
                }
            }
                
            
        }
        public string number()
        {
            return textBox1.Text;
        }
        private void Form_close_Closed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void Form_close_Load(object sender, EventArgs e)
        {
            
        }
    }
}
