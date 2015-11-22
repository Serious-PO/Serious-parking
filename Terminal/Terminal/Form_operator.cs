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
    public partial class Form_operator : Form
    {
        private bool tryNumb;
        private bool tryBlnc;
        Form_add_user form_add_user;
        Form_change_price form_change_price;

        DataSet1TableAdapters.UserQuerryTableAdapter user;
        public Form_operator()
        {
            user = new DataSet1TableAdapters.UserQuerryTableAdapter();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tryBox();
            String carNumber=textBox_carNumber1.Text+textBox_carNumber2.Text+textBox_carNumber3.Text;
            if((tryBlnc==true)&&(tryNumb==true))
                for (int i = 0; i < user.GetData().Rows.Count; i++)
                {
                    if ((carNumber == user.GetData().Rows[i]["CarNumber"].ToString()) && (Double.Parse(textBox_money.Text.ToString()) > 0))
                    {
                        user.updateBalance((double.Parse(user.GetData().Rows[i]["Balance"].ToString())+
                            double.Parse(textBox_money.Text.ToString())), carNumber);
                        DialogResult vibor2 = MessageBox.Show("Вы действительно хотите пополнить баланс?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (vibor2 == DialogResult.Yes)
                        {
                            MessageBox.Show("Баланс пополнен!");
                            textBox_carNumber1.Text = "";
                            textBox_carNumber2.Text = "";
                            textBox_carNumber3.Text = "";
                            textBox_money.Text = "";
                        }
                        if (vibor2 == DialogResult.No)
                        {

                        }

                    }
                    else
                    {
                        if(i==(user.GetData().Rows.Count-1))
                        MessageBox.Show("Такого пользователя не существует!");
                    }
                }
            
        }

        private void textBox_money_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                    e.Handled = true;
            
        }

        private void label_money_Click(object sender, EventArgs e)
        {

        }

        private void button_add_user_Click(object sender, EventArgs e)
        {
            form_add_user = new Form_add_user();
            form_add_user.Show();
        }

        private void button_change_price_Click(object sender, EventArgs e)
        {
            form_change_price = new Form_change_price();
            form_change_price.Show();
        }

        private void Form_operator_Load(object sender, EventArgs e)
        {

        }

        private void tryBox()
        {
            String tryNum;
            try
            {
                double blnc;
                blnc = Double.Parse(textBox_money.Text);
                if (blnc > 0)
                    tryBlnc = true;
                else
                {
                    tryBlnc = false;
                    MessageBox.Show("Баланс не может быть отрицательным!");
                }
            }
            catch
            {
                tryBlnc = false;
                MessageBox.Show("Заполните поле оплаты!");
            }


            tryNum = textBox_carNumber1.Text;
            if ((tryNum.Length > 2) || (tryNum.Length < 2))
            {
                tryNumb = false;
                MessageBox.Show("Неверный формат номера автомобиля!");
            }
            else
            {
                tryNum = textBox_carNumber2.Text;
                if ((tryNum.Length > 3) || (tryNum.Length < 3))
                {
                    tryNumb = false;
                    MessageBox.Show("Неверный формат номера автомобиля!");
                }
                else
                {
                    tryNum = textBox_carNumber3.Text;
                    if ((tryNum.Length > 1) || (tryNum.Length < 1))
                    {
                        tryNumb = false;
                        MessageBox.Show("Неверный формат номера автомобиля!");
                    }
                    else
                        tryNumb = true;
                }
            }
        }

        private void textBox_carNumber1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char tryKey = e.KeyChar;
            if (((tryKey < 'А') || (tryKey > 'Я')) && tryKey != '\b')
                e.Handled = true;
        }

        private void textBox_carNumber2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void textBox_carNumber3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char tryKey = e.KeyChar;
            if (((tryKey < 'А') || (tryKey > 'Я')) && tryKey != '\b')
                e.Handled = true;
        }

        private void Form_operator_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
