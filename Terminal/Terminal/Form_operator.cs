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
        private Test test;
        Form_close formC;
        Form_car_number form2;
        private int num_row;
        DataSet1TableAdapters.UserQuerry1TableAdapter user;
        public Form_operator()
        {
            form2 = new Form_car_number(this);
            form2.Show();
            formC = new Form_close(this);
            formC.Show();
            user = new DataSet1TableAdapters.UserQuerry1TableAdapter();
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String carNumber = textBox_carNumber1.Text + textBox_carNumber2.Text + textBox_carNumber3.Text;
                for (int i = 0; i < user.GetData().Rows.Count; i++)
                {
                   num_row = i;
                   tryBox();
                   if ((tryBlnc == true) && (tryNumb == true))
                    {
                    if ((user.GetData().Rows[i]["CarNumber"].ToString() == carNumber) && (Double.Parse(textBox_money.Text.ToString()) > 0))
                    {
                            DialogResult vibor2 = MessageBox.Show("Вы действительно хотите пополнить баланс?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (vibor2 == DialogResult.Yes)
                            {
                                user.updateBalance((double.Parse(user.GetData().Rows[i]["Balance"].ToString()) +
                                double.Parse(textBox_money.Text.ToString())), carNumber);
                                MessageBox.Show("Баланс пополнен!");
                                textBox_carNumber1.Text = "";
                                textBox_carNumber2.Text = "";
                                textBox_carNumber3.Text = "";
                                textBox_money.Text = "";
                                break;
                            }
                            if (vibor2 == DialogResult.No)
                            {
                                break;
                            }

                        }
                        else
                        {
                            if (i == (user.GetData().Rows.Count - 1))
                                MessageBox.Show("Такого пользователя не существует!");
                        }
                    }
                   else
                   {
                       if (i == (user.GetData().Rows.Count - 1))
                           MessageBox.Show("Такого пользователя не существует!");
                       break;
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
            test = new Test(this);
        }

        private void tryBox()
        {
            String tryNum;
            try
            {
                double new_blnc;
                new_blnc = Double.Parse(textBox_money.Text);
                if (new_blnc > 0)
                    tryBlnc = true;
                if (new_blnc<0)
                {
                    tryBlnc = false;
                    MessageBox.Show("Баланс не может быть отрицательным!");
                }
                for (int i = 0; i < user.GetData().Rows.Count; i++)
                 {
                        if ((user.GetData().Rows[i]["CarNumber"].ToString() == (textBox_carNumber1.Text + textBox_carNumber2.Text + textBox_carNumber3.Text)))
                        {
                            double blnc = double.Parse(user.GetData().Rows[i]["Balance"].ToString());
                            double diff_blnc = 1000000 - blnc;
                            if ((new_blnc + blnc) > 1000000)
                            {
                                tryBlnc = false;
                                MessageBox.Show("Баланс не может быть больше 1.000.000 руб!");
                                if (diff_blnc > 0)
                                {
                                 MessageBox.Show("Текущий баланс: " + blnc + " руб \n Возможно пополнение на " + diff_blnc + " руб!");
                                }
                            else
                            {
                                MessageBox.Show("Текущий баланс: " + blnc + " руб");
                            }
                        }
                    }
                    
                }
            }
            catch
            {
                tryBlnc = false;
                MessageBox.Show("Заполните поле оплаты!");
            }


            tryNum = textBox_carNumber1.Text;
            if ((tryNum.Length > 1) || (tryNum.Length < 1))
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
                    if ((tryNum.Length > 2) || (tryNum.Length < 2))
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
            if ( ((tryKey == 'А')
                | (tryKey == 'В')
                | (tryKey == 'Е')
                | (tryKey == 'К')
                | (tryKey == 'М')
                | (tryKey == 'Н')
                | (tryKey == 'О')
                | (tryKey == 'Р')
                | (tryKey == 'С')
                | (tryKey == 'Т')
                | (tryKey == 'У')
                | (tryKey == 'Х')
                ) | tryKey == '\b') return;
            else
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
            if ( ((tryKey == 'А')
                | (tryKey == 'В')
                | (tryKey == 'Е')
                | (tryKey == 'К')
                | (tryKey == 'М')
                | (tryKey == 'Н')
                | (tryKey == 'О')
                | (tryKey == 'Р')
                | (tryKey == 'С')
                | (tryKey == 'Т')
                | (tryKey == 'У')
                | (tryKey == 'Х')
                ) | tryKey == '\b') return;
            else
                e.Handled = true;
        }

        private void Form_operator_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
