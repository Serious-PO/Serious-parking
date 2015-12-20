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
        public Form_user_info()
        {
            InitializeComponent();
            user = new DataSet1TableAdapters.UserQuerry1TableAdapter();
            userInfo = new DataSet1TableAdapters.UserInfoTableAdapter();
        }

        private void Form_user_info_Load(object sender, EventArgs e)
        {
            InfoArea.AppendText("Операция" + "\t" +
                       "Номер" + "\t" +
                       "Было денег" + "    " +
                       "Списано" + "    " +
                       "Время парковки" + "    " +
                       "Стало денег" + "        " +
                       "Дата" + "\n" + "\t\t\t\t    "+
                       "/Пополнено"+"\n\n");
            for (int i = 0; i < user.GetData().Rows.Count; i++)
            {
                comboBox_num.Items.Add(user.GetData().Rows[i]["CarNumber"].ToString());
            }
        }

        private void comboBox_num_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < userInfo.GetData().Rows.Count; i++)
            {
                if (comboBox_num.Text == userInfo.GetData().Rows[i]["CarNumber"].ToString())
                {
                    date = userInfo.GetData().Rows[i]["Date"].ToString();
                    if(userInfo.GetData().Rows[i]["Operation"].ToString() == "Пополнение")
                        InfoArea.SelectionColor = Color.Green;
                    else
                        InfoArea.SelectionColor = Color.Red;
                    InfoArea.AppendText(userInfo.GetData().Rows[i]["Operation"].ToString()+"\t");
                    //InfoArea.SelectionColor = Color.Black; 
                    InfoArea.AppendText(userInfo.GetData().Rows[i]["CarNumber"].ToString()+"\t       "+
                        userInfo.GetData().Rows[i]["Balance"].ToString() + "\t            " +
                        userInfo.GetData().Rows[i]["Money"].ToString() + "    \t    " +
                        userInfo.GetData().Rows[i]["ParkingTime"].ToString() + "\t\t " +
                        userInfo.GetData().Rows[i]["NewBalance"].ToString() + "\t    " +
                        date.Remove(11)+"\n");
                    
                }
                
            }
        }


        
    }
}
