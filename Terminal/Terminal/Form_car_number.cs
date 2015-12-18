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
        Form_close form_close;
        Form_operator frm;
        private bool check;
        public Form_car_number(Form_operator f)
        {
            frm = f;
            InitializeComponent();
            Opacity = 0;
            Timer timer = new Timer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.08d) >= 1) timer.Stop();
            });
            timer.Interval = 5;
            timer.Start();
            
            
            
        }

        private void button_car_Click(object sender, EventArgs e)
        {
            check = false;
            for (int i = 0; i < user.GetData().Rows.Count; i++)
            {
                if ((number() == user.GetData().Rows[i]["CarNumber"].ToString()))
                {
                    check = true;
                    if ((double.Parse(user.GetData().Rows[i]["Balance"].ToString()) > 0) && (user.GetData().Rows[i]["OnParking"].ToString() == false.ToString()))
                    {
                        user.updateTimeEnter(DateTime.Now, comboBox_num.Text.ToString());
                        form_open = new Form_open(this, frm);
                        form_open.Show();
                        frm.logChang(number(), "Въезд");
                    }
                    else
                    {
                        form_error = new Form_Error(this, "Въезд");
                        form_error.Show();
                    }
                }
            }
            if (check == false)
            {
                form_error = new Form_Error(this, "Въезд");
                form_error.Show();
                new_lable();
            }
        }

        public string number()
        {
            return comboBox_num.Text;
        }
        public void update_box()
        {
            comboBox_num.Items.Clear();
            for (int i = 0; i < user.GetData().Rows.Count; i++)
            {
                comboBox_num.Items.Add(user.GetData().Rows[i]["CarNumber"].ToString());
            }
        }
        public void new_lable()
        {
            for (int i = 0; i < user.GetData().Rows.Count; i++)
            {
                label_check.Text = "вне территории";
                if (number() == user.GetData().Rows[i]["CarNumber"].ToString())
                {
                    if (user.GetData().Rows[i]["OnParking"].ToString() == true.ToString())
                    {
                        label_check.Text = "на территории";
                        break;
                    }
                }

            }
        }
        private void Form_car_number_FormClosed(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void Form_car_number_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            user = new Terminal.DataSet1TableAdapters.UserQuerry1TableAdapter();
            update_box();
            new_lable();
            this.userQuerry1TableAdapter.Fill(this.dataSet1.UserQuerry1);
            this.Location = new Point((frm.Location.X)+(frm.Width)+10, (frm.Location.Y));
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            new_lable();
            update_box();
        }

        private void comboBox_num_SelectedIndexChanged(object sender, EventArgs e)
        {
            new_lable();
        }

        private void Form_car_number_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void Form_car_number_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

    }
}
