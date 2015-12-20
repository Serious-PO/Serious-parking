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
    public partial class Form_user_info : Form
    {
        string date;
        DataSet1TableAdapters.UserQuerry1TableAdapter user;
        DataSet1TableAdapters.UserInfoTableAdapter userInfo;
        Form_operator form_operator;
        public Form_user_info()
        {
            InitializeComponent();
            user = new DataSet1TableAdapters.UserQuerry1TableAdapter();
            userInfo = new DataSet1TableAdapters.UserInfoTableAdapter();
            form_operator = new Form_operator();
        }

        private void Form_user_info_Load(object sender, EventArgs e)
        {
            this.Location = new Point((form_operator.screen.X / 2) - (this.Width / 2), (form_operator.screen.Y / 2) - (this.Height / 2));
            for (int i = 0; i < user.GetData().Rows.Count; i++)
            {
                comboBox_num.Items.Add(user.GetData().Rows[i]["CarNumber"].ToString());
            }
        }

        private void comboBox_num_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < user.GetData().Rows.Count; i++)
                if (user.GetData().Rows[i]["CarNumber"].ToString() == comboBox_num.Text)
                {
                    textBox_firstName.Text = user.GetData().Rows[i]["FirstName"].ToString();
                    textBox_lastName.Text = user.GetData().Rows[i]["LastName"].ToString();
                    textBox_balance.Text = user.GetData().Rows[i]["Balance"].ToString();
                    break;
                }
            InfoArea.Text = "";
            InfoArea.AppendText("Операция" + "\t" +
                       "Номер" + "\t" +
                       "Было денег" + "    " +
                       "Списано" + "    " +
                       "Стало денег" + "    " +
                       "Время парковки" + "        " +
                       "Дата" + "\n" + "\t\t\t\t    " +
                       "/Пополнено" + "\n\n");
            for (int i = 0; i < userInfo.GetData().Rows.Count; i++)
            {
                if (comboBox_num.Text == userInfo.GetData().Rows[i]["CarNumber"].ToString())
                {
                        date = userInfo.GetData().Rows[i]["Date"].ToString();
                        if (userInfo.GetData().Rows[i]["Operation"].ToString() == "Пополнение")
                            InfoArea.SelectionColor = Color.Green;
                        else
                            InfoArea.SelectionColor = Color.Red;
                        InfoArea.AppendText(userInfo.GetData().Rows[i]["Operation"].ToString() + "\t");
                        InfoArea.AppendText(userInfo.GetData().Rows[i]["CarNumber"].ToString() + "\t" +
                            "  " +
                            userInfo.GetData().Rows[i]["Balance"].ToString() + "\t\t" +
                            userInfo.GetData().Rows[i]["Money"].ToString() + "\t" +
                            userInfo.GetData().Rows[i]["NewBalance"].ToString() + "\t\t" +
                            userInfo.GetData().Rows[i]["ParkingTime"].ToString() + " мин." + "\t" +
                            date + "\n");
                        InfoArea.SelectionColor = Color.Black;
                        InfoArea.AppendText("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
                    
                }
                
            }
            
        }


        
    }
}
