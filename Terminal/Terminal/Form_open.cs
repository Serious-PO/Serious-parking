using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using classUsers;

namespace Terminal
{
    public partial class Form_open : Form
    {
        DataSet1TableAdapters.UserQuerry1TableAdapter user;
        
        private Form_car_number frm;
        Form_operator frm1;
        public Form_open(Form_car_number f,Form_operator f1)
        {
            user = new Terminal.DataSet1TableAdapters.UserQuerry1TableAdapter();
            frm = f;
            frm1 = f1;
            InitializeComponent();
            label_name.ForeColor = Color.Green;
            label_name.Font = new Font("label_name", 30);
            label_balance.ForeColor = Color.Green;
            label_balance.Font = new Font("label_name", 30);
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
                    User first = new User();
                    label_name.Text = "Здравствуйте, " + user.GetData().Rows[i]["FirstName"].ToString()
                        + " " + user.GetData().Rows[i]["LastName"].ToString();
                    user.updateTimeEnter(DateTime.Now, frm.number());
                    label_balance.Text = "На вашем счете: " + user.GetData().Rows[i]["Balance"].ToString() + " \nМаксимальное время парковки: "
                        + (Int32.Parse(user.GetData().Rows[i]["Balance"].ToString())/(int)first.getPrice()).ToString() + " мин";
                    user.updateParking(true, frm.number());
                }
            }
            label_name.Location = new Point((640 - (label_name.Width / 2)), 438);
            label_balance.Location = new Point((640 - (label_balance.Width / 2)), 511);
        }

        private void pictureBox_open_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_open_Closed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
