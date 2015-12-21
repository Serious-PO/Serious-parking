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
        private Form_operator form_operator;
        private Form_user_info form_user_info;
        public Form_open(Form_car_number f, Form_operator form_operator_new)
        {
            user = new Terminal.DataSet1TableAdapters.UserQuerry1TableAdapter();
            frm = f;
            form_operator = form_operator_new;
            form_operator.add_open(this);
            form_user_info = new Form_user_info();
            InitializeComponent();
            label_name.ForeColor = Color.Green;
            label_name.Font = new Font("label_name", 15);
            label_balance.ForeColor = Color.Green;
            label_balance.Font = new Font("label_name", 15);
            Opacity = 0;
            Timer timer = new Timer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.08d) >= 1) timer.Stop();
            });
            timer.Interval = 5;
            timer.Start();
        }

        private void label_name_Click(object sender, EventArgs e)
        {

        }

        private void Form_open_Load(object sender, EventArgs e)
        {
            this.Location = new Point(frm.Location.X - form_operator.Width-235, frm.Location.Y + form_operator.Height+10);
            this.BackColor = Color.Black;
            label_balance.Hide();
            label_name.Hide();
            pictureBox_open.Hide();
            for (int i = 0; i < user.GetData().Rows.Count; i++)
            {
                
                if (user.GetData().Rows[i]["CarNumber"].ToString() == frm.number())
                {
                    User first = new User();
                    label_name.Text = "Здравствуйте, " + user.GetData().Rows[i]["FirstName"].ToString()
                        + " " + user.GetData().Rows[i]["LastName"].ToString();
                    user.updateTimeEnter(DateTime.Now, frm.number());
                    label_balance.Text = "На вашем счете: " + user.GetData().Rows[i]["Balance"].ToString() + " руб." + " \nМаксимальное время парковки: "
                        + ((int)(Double.Parse(user.GetData().Rows[i]["Balance"].ToString())/(double)first.getPrice())).ToString() + " мин";
                    user.updateParking(true, frm.number());
                }
            }
        }
        public void activate_open()
        {
            pictureBox_error.Hide();
            this.BackColor = Color.White;
            label_name.ForeColor = Color.Green;
            label_balance.Show();
            label_name.Show();
            pictureBox_open.Show();
            for (int i = 0; i < user.GetData().Rows.Count; i++)
            {

                if (user.GetData().Rows[i]["CarNumber"].ToString() == frm.number())
                {
                    User first = new User();
                    label_name.Text = "Здравствуйте, " + user.GetData().Rows[i]["FirstName"].ToString()
                        + " " + user.GetData().Rows[i]["LastName"].ToString();
                    user.updateTimeEnter(DateTime.Now, frm.number());
                    label_balance.Text = "На вашем счете: " + user.GetData().Rows[i]["Balance"].ToString()+ " руб " + " \nМаксимальное время парковки: "
                        + ((int)(((int)(Double.Parse(user.GetData().Rows[i]["Balance"].ToString()) / (double)first.getPrice())) / 60)).ToString() + " час(ов) " + ((int)(((int)(Double.Parse(user.GetData().Rows[i]["Balance"].ToString()) / (double)first.getPrice())) % 60)).ToString() + " минут(ы) ";
                    user.updateParking(true, frm.number());
                }
            }
            float time = 0;
            Timer timer = new Timer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((time +=1) >= 7200)
                {
                    this.BackColor = Color.Black;
                    label_balance.Hide();
                    label_name.Hide();
                    pictureBox_open.Hide();
                    timer.Stop();
 
                }
            });
            timer.Interval = 1;
            timer.Start();
 
        }
        public void open_error()
        {
            label_balance.Hide();
            pictureBox_open.Hide();
            this.BackColor = Color.White;
            label_name.Show();
            label_name.ForeColor = Color.Red;
            label_name.Text = "Въезд запрещён, обратитесь к оператору!";
            pictureBox_error.Show();
            float time = 0;
            Timer timer = new Timer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((time += 1) >= 3600)
                {
                    this.BackColor = Color.Black;
                    label_balance.Hide();
                    label_name.Hide();
                    pictureBox_open.Hide();
                    pictureBox_error.Hide();
                    timer.Stop();

                }
            });
            timer.Interval = 1;
            timer.Start();
        }
        private void pictureBox_open_Click(object sender, EventArgs e)
        {
        }

        private void Form_open_Closed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Form_open_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
