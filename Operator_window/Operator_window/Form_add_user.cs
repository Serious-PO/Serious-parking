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
    public partial class Form_add_user : Form
    {
        public Form_add_user()
        {
            InitializeComponent();
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            if (textBox_number.Text.ToString() != "A732PE")
            {
                DialogResult vibor2 = MessageBox.Show("Вы действительно хотите добавить пользователя?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (vibor2 == DialogResult.Yes)
                {
                    MessageBox.Show("Пользователь добавлен!");
                    this.Close();
                    
                }
                if (vibor2 == DialogResult.No)
                {

                }
            }
            else
            {
                MessageBox.Show("Данный пользователь уже существует!");
            }
        }
    }
}
