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
        Form_operator frm1;
        public Form_final(Form_close f,Form_operator f1)
        {
            user = new DataSet1TableAdapters.UserQuerry1TableAdapter();
            InitializeComponent();
            frm = f;
            frm1 = f1;
            userInfo = new DataSet1TableAdapters.UserInfoTableAdapter();
            label_final.ForeColor = Color.Green;
            label_final.Font = new Font("label_final", 40);

            label_time.ForeColor = Color.Green;
            label_time.Font = new Font("label_time", 30);

            label_getmoney.ForeColor = Color.Green;
            label_getmoney.Font = new Font("label_getmoney", 30);

            label_balance.ForeColor = Color.Green;
            label_balance.Font = new Font("label_balance", 30);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form_final_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < user.GetData().Rows.Count; i++)
            {
                if (frm.number() == user.GetData().Rows[i]["CarNumber"].ToString())
                {
                    User first = new User(user.GetData().Rows[i]["FirstName"].ToString(),
                       user.GetData().Rows[i]["LastName"].ToString(),
                       DateTime.Parse(user.GetData().Rows[i]["BirthDay"].ToString()),
                       Int32.Parse(user.GetData().Rows[i]["Balance"].ToString()),
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

        private void Form_final_Closed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Form_final_DoubleClick(object sender, EventArgs e)
        {

        }

        private void Form_final_MouseClick(object sender, MouseEventArgs e)
        {

        }

    }
}
