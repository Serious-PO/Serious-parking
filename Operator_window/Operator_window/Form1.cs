using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Operator_window
{
    public partial class Form_operator : Form
    {
        Form_add_user form_add_user = new Form_add_user();
        public Form_operator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox_number_car.Text.ToString() == "A732PE") && (Convert.ToInt32(textBox_money.Text.ToString()) > 0))
            {
                DialogResult vibor2 = MessageBox.Show("Вы действительно хотите пополнить баланс?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
                if (vibor2 == DialogResult.Yes) 
                {       
                    MessageBox.Show("Баланс пополнен!");
                    textBox_number_car.Text = "";
                    textBox_money.Text = "";
                } 
                if (vibor2 == DialogResult.No) 
                {      
                   
                }

            }
            else
            {
                MessageBox.Show("Введенные данные некорректны!");
            }
            
        }

        private void textBox_money_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                    e.Handled = true;
            }
        }

        private void label_money_Click(object sender, EventArgs e)
        {

        }

        private void button_add_user_Click(object sender, EventArgs e)
        {
            form_add_user.Show();
        }
    }
}
