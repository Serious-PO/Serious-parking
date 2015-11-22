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
    public partial class Form_change_price : Form
    {
        private Test test;
        private bool tryPrice;
        public Form_change_price()
        {
            InitializeComponent();
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox_change_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                    e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tryBox();
            if ((textBox_password.Text.ToString() == "123456") && (tryPrice == true))
            {
                User user = new User();
                user.changePrice(double.Parse(textBox_price.Text.ToString()));
                MessageBox.Show("Стоимость изменена!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный пароль!");
            }
        }
        private void tryBox()
        {
            try
            {
                double price;
                price = Double.Parse(textBox_price.Text);
                tryPrice = true;
                if (price < 0)
                {
                    MessageBox.Show("Оплата не может быть отрицательной!");
                    tryPrice = false;
                }
            }
            catch
            {
                tryPrice = false;
                MessageBox.Show("Поле оплаты не может быть пустым!");
            }
        }

        private void Form_change_price_Load(object sender, EventArgs e)
        {
            test = new Test(this);
        }

    }
}
