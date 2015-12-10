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

        DataSet1TableAdapters.UserQuerry1TableAdapter user;
        Form_open form_open;
        Form_Error form_error;
        Form_operator frm;
        public Form_car_number(Form_operator f)
        {
            user = new Terminal.DataSet1TableAdapters.UserQuerry1TableAdapter();
            frm = f;
            InitializeComponent();
            
            
            
        }

        private void button_car_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < user.GetData().Rows.Count; i++)
            {
                if ((textBox1.Text.ToString() == user.GetData().Rows[i]["CarNumber"].ToString()))
                {
                    if(user.GetData().Rows[i]["Balance"]!=null)
                    if (double.Parse(user.GetData().Rows[i]["Balance"].ToString()) > 0)
                    {
                        form_open = new Form_open(this, frm);
                        form_open.Show();
                        
                        user.updateTimeEnter(DateTime.Now, textBox1.Text.ToString());
                        break;
                    }
                }
                if (i == (user.GetData().Rows.Count - 1))
                {
                    form_error = new Form_Error(this, "Въезд");
                    form_error.Show();
                    
                }
            }
        }

        public string number()
        {
            return textBox1.Text;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form_car_number_FormClosed(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void Form_car_number_Load(object sender, EventArgs e)
        {

        }

        private void Form_car_number_Closed(object sender, FormClosedEventArgs e)
        {
            
        }

    }
}
