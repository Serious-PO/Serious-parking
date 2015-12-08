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
        DataSet1TableAdapters.UserQuerryTableAdapter user;
        private Form_close form_close; 
        private Form_car_number frm;
        Form1 frm1;
        public Form_open(Form_car_number f,Form1 f1)
        {
            user = new Terminal.DataSet1TableAdapters.UserQuerryTableAdapter();
            frm = f;
            frm1 = f1;
            InitializeComponent();
            label_name.ForeColor = Color.Green;
            label_name.Font = new Font("label_name", 30);
        }

        private void label_name_Click(object sender, EventArgs e)
        {

        }

        private void Form_open_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < user.GetData().Rows.Count; i++)
            {

                if (user.GetData().Rows[i]["CarNumber"].ToString() == frm.number())
                {
                    label_name.Text = "Здравствуйте, " + user.GetData().Rows[i]["FirstName"].ToString()
                        + " " + user.GetData().Rows[i]["LastName"].ToString();
                }
            }
            label_name.Location = new Point((640 - (label_name.Width / 2)), 503);
        }

        private void pictureBox_open_Click(object sender, EventArgs e)
        {
            form_close = new Form_close(frm1);
            form_close.Show();
            this.Close();
        }

        private void Form_open_Closed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
