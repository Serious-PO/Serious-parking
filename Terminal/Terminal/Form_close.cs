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
        private bool check;
        public Form_close(Form_operator f)
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

        private void button_close_Click(object sender, EventArgs e)
        {
            check = false;
            for (int i = 0; i < user.GetData().Rows.Count; i++)
            {
                if (number() == user.GetData().Rows[i]["CarNumber"].ToString())
                {
                    check = true;
                    if (user.GetData().Rows[i]["OnParking"].ToString() == true.ToString())
                    {
                        user.updateTimeQuit(DateTime.Now, comboBox_num.Text.ToString());
                        form_final = new Form_final(this, frm);
                        form_final.Show();
                        frm.logChang(number(), "Выезд");
                    }
                    else
                    {
                        form_error = new Form_Error(this, "Выезд");
                        form_error.Show();
                    }
                }

            }
            if (check == false)
            {
                form_error = new Form_Error(this, "Выезд");
                form_error.Show();
            }
            new_lable();
            
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
        private void Form_close_Closed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void Form_close_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.UserQuerry1' table. You can move, or remove it, as needed.
            user = new Terminal.DataSet1TableAdapters.UserQuerry1TableAdapter();
            update_box();
            new_lable();
            this.userQuerry1TableAdapter.Fill(this.dataSet1.UserQuerry1);
            this.Location = new Point((frm.Location.X) + (frm.Width)+10, (frm.Location.Y)+(frm.Height)-this.Height);

        }

        private void comboBox_num_SelectedIndexChanged(object sender, EventArgs e)
        {
            new_lable();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            update_box();
            new_lable();
        }

        private void Form_close_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
