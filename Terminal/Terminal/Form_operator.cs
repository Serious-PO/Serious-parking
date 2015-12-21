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
    public partial class Form_operator : Form
    {
        public Point screen = new Point();
        private bool tryNumb;
        private bool tryBlnc;
        public bool move_form;
        Form_add_user form_add_user;
        Form_change_price form_change_price;
        private Test test;
        Form_close formC;
        Form_car_number form2;
        Form_user_info form_info;
        Form_open form_open;
        Form_final form_final;
        Log L;
        DataSet1TableAdapters.PriceTableAdapter price;
        private int num_row;
        DataSet1TableAdapters.UserQuerry1TableAdapter user;
        DataSet1TableAdapters.UserInfoTableAdapter userInfo;
        User Price;
        public Form_operator()
        {
            price = new DataSet1TableAdapters.PriceTableAdapter();
            screen.X=Screen.PrimaryScreen.Bounds.Width;
            screen.Y = Screen.PrimaryScreen.Bounds.Height;
            user = new DataSet1TableAdapters.UserQuerry1TableAdapter();
            userInfo = new DataSet1TableAdapters.UserInfoTableAdapter();
            InitializeComponent();
            Opacity = 0;
            Timer timer = new Timer();
            Price = new User();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.08d) >= 1) timer.Stop();
            });
            timer.Interval = 5;
            timer.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String carNumber = textBox_carNumber1.Text + textBox_carNumber2.Text + textBox_carNumber3.Text;
                   tryBox();

                       if ((tryBlnc == true) && (tryNumb == true))
                       {
                           DialogResult vibor2 = MessageBox.Show("Вы действительно хотите пополнить баланс?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                           if (vibor2 == DialogResult.Yes)
                           {
                               userInfo.newInfo(userInfo.GetData().Rows.Count + 1, "Пополнение", carNumber, 
                                   double.Parse(user.GetData().Rows[num_row]["Balance"].ToString()),
                                   double.Parse(textBox_money.Text.ToString()), "0", (double.Parse(user.GetData().Rows[num_row]["Balance"].ToString()) +
                               double.Parse(textBox_money.Text.ToString())), DateTime.Now);


                               user.updateBalance((double.Parse(user.GetData().Rows[num_row]["Balance"].ToString()) +
                               double.Parse(textBox_money.Text.ToString())), carNumber);
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
                   
        }

        private void textBox_money_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                    e.Handled = true;
            
        }


        private void button_add_user_Click(object sender, EventArgs e)
        {
            form_add_user = new Form_add_user();
            form_add_user.Show();
        }

        private void button_change_price_Click(object sender, EventArgs e)
        {
            form_change_price = new Form_change_price(this);
            form_change_price.Show();
        }

        private void Form_operator_Load(object sender, EventArgs e)
        {
            test = new Test(this);
            this.Location = new Point((screen.X / 2) - (this.Width / 2), (screen.Y / 2) - (this.Height / 2) - 150);
            
            form2 = new Form_car_number(this);
            form2.Show();
            formC = new Form_close(this);
            formC.Show();
            L = new Log(this);
            L.Show();
            textBox_price.Text = price.GetData().Rows[0]["price"].ToString();
            Price.changePrice(double.Parse(textBox_price.Text));
        }

        private void tryBox()
        {
            String tryNum;
            num_row = -1;
            double new_blnc=0;
            try
            {
                new_blnc = Double.Parse(textBox_money.Text);
                if (new_blnc > 0)
                {
                    tryBlnc = true;
                }
                if (new_blnc<0)
                {
                    tryBlnc = false;
                    MessageBox.Show("Баланс не может быть отрицательным");
                }
                if (new_blnc == 0)
                {
                    tryBlnc = false;
                    MessageBox.Show("Невозможно пополнить баланс на 0 руб");
                }
            }
            catch
            {
                tryBlnc = false;
                MessageBox.Show("Заполните поле оплаты");
            }


            tryNum = textBox_carNumber1.Text;
            if ((tryNum.Length > 1) || (tryNum.Length < 1))
            {
                tryNumb = false;
                MessageBox.Show("Неверный формат номера автомобиля");
            }
            else
            {
                tryNum = textBox_carNumber2.Text;
                if ((tryNum.Length > 3) || (tryNum.Length < 3))
                {
                    tryNumb = false;
                    MessageBox.Show("Неверный формат номера автомобиля");
                }
                else
                {
                    tryNum = textBox_carNumber3.Text;
                    if ((tryNum.Length > 2) || (tryNum.Length < 2))
                    {
                        tryNumb = false;
                        MessageBox.Show("Неверный формат номера автомобиля");
                        
                    }
                    else
                        tryNumb = true;
                }
            }
            if ((tryBlnc == true) && (tryNumb == true))
            {
                    for (int i = 0; i < user.GetData().Rows.Count; i++)
                    {
                        if ((user.GetData().Rows[i]["CarNumber"].ToString() == (textBox_carNumber1.Text + textBox_carNumber2.Text + textBox_carNumber3.Text)))
                        {
                            num_row = i;
                            double blnc = double.Parse(user.GetData().Rows[i]["Balance"].ToString());
                            double diff_blnc = 1000000 - blnc;
                            if ((new_blnc + blnc) > 1000000)
                            {
                                tryBlnc = false;
                                if (diff_blnc > 0)
                                {
                                    MessageBox.Show("Баланс не может быть больше 1.000.000 руб \n\nТекущий баланс: " + blnc + " руб \n\nВозможно пополнение на " + diff_blnc + " руб");
                                }
                                else
                                {
                                    MessageBox.Show("Баланс не может быть больше 1.000.000 руб \n\nТекущий баланс: " + blnc + " руб");
                                }
                            }
                            else
                            {
                                tryBlnc = true;
                            }
                            break;
                        }
                    }
                    if (num_row < 0)
                    {
                        tryBlnc = false;
                        MessageBox.Show("Такого пользователя не существует.");
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

        private void Form_operator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Выйти из программы?", "Выход",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;  
        }

        private void label_name_Click(object sender, EventArgs e)
        {
            form2 = new Form_car_number(this);
            form2.Show();

        }
        private void label_money_Click(object sender, EventArgs e)
        {

            formC = new Form_close(this);
            formC.Show();
        }

        public void logChang(string number, string operation)
        {
            L.logChange(number, operation);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (move_form == false)
            {
                move_form = true;
                button2.Text = "отключить";
                form2.WindowState = FormWindowState.Normal;
                formC.WindowState = FormWindowState.Normal;
                L.WindowState = FormWindowState.Normal;
                form_open.WindowState = FormWindowState.Normal;
                form_final.WindowState = FormWindowState.Normal;
                form2.Location = new Point((this.Location.X) + (this.Width), (this.Location.Y) );
                formC.Location = new Point((this.Location.X) + (this.Width), (this.Location.Y) + (this.Height) - formC.Height );
                L.Location = new Point(this.Location.X - L.Width, this.Location.Y );
                form_open.Location = new Point((this.Location.X) - (L.Width), (this.Location.Y) + (L.Height));
                form_final.Location = new Point((this.Location.X)+(this.Width)-(form2.Width)+45, (this.Location.Y)+(this.Height) );
            }
            else
            {
                button2.Text = "включить";
                form2.Location = new Point((this.Location.X) + (this.Width) + 10, (this.Location.Y) );
                formC.Location = new Point((this.Location.X) + (this.Width) + 10, (this.Location.Y) + (this.Height) - formC.Height );
                L.Location = new Point(this.Location.X - L.Width - 5, this.Location.Y );
                form_open.Location = new Point((this.Location.X) - (L.Width)-5, (this.Location.Y) + (L.Height)+10);
                form_final.Location = new Point((this.Location.X) + (this.Width) - (form2.Width) + 56, (this.Location.Y) + (this.Height)+10);
                move_form = false;
            }
        }

        private void button_user_info_Click(object sender, EventArgs e)
        {
            form_info = new Form_user_info();
            form_info.Show();
        }

        private void Form_operator_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Form_operator_CursorChanged(object sender, EventArgs e)
        {

        }

        private void Form_operator_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (move_form == true)
            {
                form2.Location = new Point((this.Location.X) + (this.Width), (this.Location.Y) );
                formC.Location = new Point((this.Location.X) + (this.Width), (this.Location.Y) + (this.Height) - formC.Height );
                L.Location = new Point(this.Location.X - L.Width, this.Location.Y );
                form_open.Location = new Point((this.Location.X) - (L.Width), (this.Location.Y) + (L.Height));
                form_final.Location = new Point((this.Location.X) + (this.Width) - (form2.Width) + 45, (this.Location.Y) + (this.Height));
            }
        }

        private void Form_operator_LocationChanged(object sender, EventArgs e)
        {
            if (move_form == true)
            {
                form2.Location = new Point((this.Location.X) + (this.Width), (this.Location.Y) );
                formC.Location = new Point((this.Location.X) + (this.Width), (this.Location.Y) + (this.Height) - formC.Height );
                L.Location = new Point(this.Location.X - L.Width, this.Location.Y );
                form_open.Location = new Point((this.Location.X) - (L.Width), (this.Location.Y) + (L.Height));
                form_final.Location = new Point((this.Location.X) + (this.Width) - (form2.Width) + 45, (this.Location.Y) + (this.Height));
            }
        }
        public void add_open(Form_open form_open_real)
        {
            form_open = form_open_real;
        }
        public void add_final(Form_final form_final_real)
        {
            form_final = form_final_real;
        }

        private void textBox_carNumber1_TextChanged(object sender, EventArgs e)
        {
            if (textBox_carNumber1.Text.Length >= 1)
            {
                textBox_carNumber2.Focus();
            }
        }

        private void textBox_carNumber2_TextChanged(object sender, EventArgs e)
        {
            if (textBox_carNumber2.Text.Length >= 3)
            {
                textBox_carNumber3.Focus();
            }
        }

        private void textBox_carNumber3_TextChanged(object sender, EventArgs e)
        {
            if (textBox_carNumber3.Text.Length >= 2)
            {
                textBox_money.Focus();
            }
        }
   
    }
}
