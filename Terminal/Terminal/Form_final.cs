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
    public partial class Form_final : Form
    {
        
        DataSet1TableAdapters.UserQuerry1TableAdapter user;
        Form_close frm;
        DataSet1TableAdapters.UserInfoTableAdapter userInfo;
        Form_operator form_operator;
        public Form_final(Form_close f, Form_operator form_operator_new)
        {
            user = new DataSet1TableAdapters.UserQuerry1TableAdapter();
            InitializeComponent();
            frm = f;
            form_operator = form_operator_new;
            form_operator.add_final(this);
            userInfo = new DataSet1TableAdapters.UserInfoTableAdapter();
            label_final.ForeColor = Color.Green;
            label_final.Font = new Font("label_final", 20);

            label_time.ForeColor = Color.Green;
            label_time.Font = new Font("label_time", 15);

            label_getmoney.ForeColor = Color.Green;
            label_getmoney.Font = new Font("label_getmoney", 15);

            label_balance.ForeColor = Color.Green;
            label_balance.Font = new Font("label_balance", 15);
            Opacity = 0;
            Timer timer = new Timer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.08d) >= 1) timer.Stop();
            });
            timer.Interval = 5;
            timer.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form_final_Load(object sender, EventArgs e)
        {
            this.Location = new Point(frm.Location.X - this.Width/2+20, frm.Location.Y+frm.Height+10);
            this.BackColor = Color.Black;
            label_error.Hide();
            label_balance.Hide();
            label_final.Hide();
            label_getmoney.Hide();
            label_time.Hide();
            pictureBox_error.Hide();
            for (int i = 0; i < user.GetData().Rows.Count; i++)
            {
                if (frm.number() == user.GetData().Rows[i]["CarNumber"].ToString())
                {
                    User first = new User(user.GetData().Rows[i]["FirstName"].ToString(),
                       user.GetData().Rows[i]["LastName"].ToString(),
                       DateTime.Parse(user.GetData().Rows[i]["BirthDay"].ToString()),
                       Double.Parse(user.GetData().Rows[i]["Balance"].ToString()),
                       user.GetData().Rows[i]["CarNumber"].ToString(),
                       user.GetData().Rows[i]["TelephoneNumber"].ToString(),
                       DateTime.Parse(user.GetData().Rows[i]["LastEnter"].ToString()),
                       DateTime.Parse(user.GetData().Rows[i]["LastQuit"].ToString()));
                    
                    label_time.Text = "Время вашего пребывания: " + first.getTime() + " мин";
                    label_getmoney.Text = "С Вашего счета списано: " + first.getChangesInBalance() + " руб.";

                    userInfo.newInfo(userInfo.GetData().Rows.Count+1,"Списание", frm.number(), double.Parse(user.GetData().Rows[i]["Balance"].ToString()),
                            first.getChangesInBalance(),first.getTime().ToString(),first.getBalance(),DateTime.Now);

                    user.updateBalance(first.getBalance(), frm.number());
                    label_balance.Text = "На Вашем счете осталось: " + user.GetData().Rows[i]["Balance"].ToString() + " руб.";
                    user.updateParking(false, frm.number());
                }
            }

           
        }
        public void activate_final()
        {
            label_error.Hide();
            pictureBox_error.Hide();
            this.BackColor = Color.White;
            label_balance.Show();
            label_final.Show();
            label_getmoney.Show();
            label_time.Show();
            for (int i = 0; i < user.GetData().Rows.Count; i++)
            {
                if (frm.number() == user.GetData().Rows[i]["CarNumber"].ToString())
                {
                    User first = new User(user.GetData().Rows[i]["FirstName"].ToString(),
                       user.GetData().Rows[i]["LastName"].ToString(),
                       DateTime.Parse(user.GetData().Rows[i]["BirthDay"].ToString()),
                       Double.Parse(user.GetData().Rows[i]["Balance"].ToString()),
                       user.GetData().Rows[i]["CarNumber"].ToString(),
                       user.GetData().Rows[i]["TelephoneNumber"].ToString(),
                       DateTime.Parse(user.GetData().Rows[i]["LastEnter"].ToString()),
                       DateTime.Parse(user.GetData().Rows[i]["LastQuit"].ToString()));

                    label_time.Text = "Время вашего пребывания: " + first.getTime() + " мин";
                    label_getmoney.Text = "С Вашего счета списано: " + first.getChangesInBalance() + " руб.";

                    userInfo.newInfo(userInfo.GetData().Rows.Count + 1, "Списание", frm.number(), double.Parse(user.GetData().Rows[i]["Balance"].ToString()),
                            first.getChangesInBalance(), first.getTime().ToString(), first.getBalance(), DateTime.Now);

                    user.updateBalance(first.getBalance(), frm.number());
                    label_balance.Text = "На Вашем счете осталось: " + user.GetData().Rows[i]["Balance"].ToString() + " руб.";
                    user.updateParking(false, frm.number());
                }
            }
            float time = 0;
            Timer timer = new Timer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((time += 1) >= 3600)
                {
                    this.BackColor = Color.Black;
                    label_error.Hide();
                    label_balance.Hide();
                    label_final.Hide();
                    label_getmoney.Hide();
                    label_time.Hide();
                    pictureBox_error.Hide();
                    timer.Stop();

                }
            });
            timer.Interval = 1;
            timer.Start();

        }
        public void final_error()
        {
            label_balance.Hide();
            label_final.Hide();
            label_getmoney.Hide();
            label_time.Hide();
            pictureBox_error.Show();
            this.BackColor = Color.White;
            label_error.Font = new Font("label_error", 15);
            label_error.ForeColor = Color.Red;
            label_error.Text = "Выезд запрещён, обратитесь к оператору!";
            label_error.Show();
            float time = 0;
            Timer timer = new Timer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((time += 1) >= 7200)
                {
                    this.BackColor = Color.Black;
                    label_error.Hide();
                    label_balance.Hide();
                    label_final.Hide();
                    label_getmoney.Hide();
                    label_time.Hide();
                    pictureBox_error.Hide();
                    timer.Stop();

                }
            });
            timer.Interval = 1;
            timer.Start();
        }
        private void Form_final_Closed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Form_final_DoubleClick(object sender, EventArgs e)
        {

        }

        private void Form_final_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form_final_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

    }
}
