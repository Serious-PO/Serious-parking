using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using classUsers;

namespace Terminal
{
    public partial class Form_change_price : Form
    {
        DataSet1TableAdapters.PriceTableAdapter price;
        private Test test;
        Form_operator form_operator;
        private bool tryPrice;
        public Form_change_price(Form_operator form)
        {
            form_operator = form;
            InitializeComponent();
            price = new DataSet1TableAdapters.PriceTableAdapter();
            Opacity = 0;
            Timer timer = new Timer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.08d) == 1) timer.Stop();
            });
            timer.Interval = 5;
            timer.Start();
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
                char tryKey = e.KeyChar;
               /* if ((e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar != 8))
                {
                    e.Handled = true;
                }*/
                if (((tryKey == '0')
                | (tryKey == '1')
                | (tryKey == '2')
                | (tryKey == '3')
                | (tryKey == '4')
                | (tryKey == '5')
                | (tryKey == '6')
                | (tryKey == '7')
                | (tryKey == '8')
                | (tryKey == '9')
                | (tryKey == ',')
                ) | tryKey == '\b') return;
                else
                    e.Handled = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tryBox();
            if ((textBox_password.Text.ToString() == "123456") && (tryPrice == true))
            {
                User user = new User();
                price.changePrice(double.Parse(textBox_price.Text), 1);
                form_operator.textBox_price.Text = price.GetData().Rows[0]["price"].ToString();
                user.changePrice(double.Parse(textBox_price.Text));
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
                    MessageBox.Show("Цена за минуту не может быть отрицательной!");
                    tryPrice = false;
                }
                if (price > 10000)
                {
                    MessageBox.Show("Цена за минуту не может быть больше 10000");
                    tryPrice = false;
                }
            }
            catch
            {
                tryPrice = false;
                MessageBox.Show("Цена за минуту не может быть пустым!");
            }
        }

        private void Form_change_price_Load(object sender, EventArgs e)
        {

            this.Location = new Point((form_operator.screen.X / 2) - (this.Width / 2), (form_operator.screen.Y / 2) - (this.Height / 2));
            test = new Test(this);
        }

    }
}
