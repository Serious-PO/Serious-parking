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
    public partial class Form_add_user : Form
    {
        private Test test;
        public bool testLeft=false;
        private bool tryDate = false;
        private bool tryNumb = true;
        private bool tryPhoneNum = false;
        private bool tryAdd = true;
        private int n;
        bool isNumeric = true;
        DataSet1TableAdapters.UserQuerry1TableAdapter user;
        DataSet1 dataNew;
        Form_operator form_opreator;
        public Form_add_user()
        {
            form_opreator = new Form_operator();
            user = new DataSet1TableAdapters.UserQuerry1TableAdapter();
            dataNew = new DataSet1();
            InitializeComponent();
            Opacity = 0;
            Timer timer = new Timer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.08d) == 1) timer.Stop();
            });
            timer.Interval = 5;
            timer.Start();
            
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            
            tryBox();
                
            if ((tryDate == true)&&(tryNumb==true)&&(tryPhoneNum==true)&&(tryAdd==true))
            {
                if (testLeft == false)
                {
                    DialogResult vibor2 = MessageBox.Show("Вы действительно хотите добавить пользователя?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (vibor2 == DialogResult.Yes)
                    {
                        String datTime;
                        DateTime inBox = new DateTime();
                        inBox.AddHours(0);
                        inBox.AddMinutes(0);
                        inBox.AddSeconds(0);
                        datTime = textBox_day.Text + "." + textBox_month.Text + "." + textBox_year.Text;
                        inBox = DateTime.Parse(datTime);
                        MessageBox.Show("Пользователь добавлен!");
                        user.addNewClient(textBox_first_name.Text.ToString(), textBox_last_name.Text.ToString(),
                            inBox, 100,
                        (textBox_carNumber1.Text + textBox_carNumber2.Text + textBox_carNumber3.Text), text_telephone.Text.ToString(), false);
                        user.Update(dataNew);
                        dataNew.AcceptChanges();


                    }
                    if (vibor2 == DialogResult.No)
                    {

                    }
                }
                else
                {
                    String datTime;
                    DateTime inBox = new DateTime();
                    inBox.AddHours(0);
                    inBox.AddMinutes(0);
                    inBox.AddSeconds(0);
                    datTime = textBox_day.Text + "." + textBox_month.Text + "." + textBox_year.Text;
                    inBox = DateTime.Parse(datTime);
                    MessageBox.Show("Пользователь добавлен!");
                    user.addNewClient(textBox_first_name.Text.ToString(), textBox_last_name.Text.ToString(),
                        inBox, 100,
                    (textBox_carNumber1.Text + textBox_carNumber2.Text + textBox_carNumber3.Text), text_telephone.Text.ToString(), false);

                }
            }
            else
                if(tryDate==false)
                MessageBox.Show("Неверный формат даты!");
            testLeft = false;
            tryAdd = true;
        }



        private void text_telephone_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void text_telephone_press(object sender, KeyPressEventArgs e)
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
        private void textBox_carNumber2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
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
       
        
        private void tryBox()
        {
            String tryNum;
            
            try
            {
                tryDate = false;
                int day;
                int month;
                int year;
                day = Int32.Parse(textBox_day.Text);
                month = Int32.Parse(textBox_month.Text);
                year = Int32.Parse(textBox_year.Text);
                if (((day >= 0) && (day <= 31)) && ((month >= 0) && (month <= 12)) && ((year >= 1915) && (year <= 3000)))
                    tryDate = true;
            }
            catch
            {
                MessageBox.Show("Неверный формат даты!");
            }


            tryNum = textBox_carNumber1.Text;
            if (tryNum.Length!=1)
            {
                tryNumb = false;
                MessageBox.Show("Неверный формат номера автомобиля!");
            }
            else
            {
                tryNum = textBox_carNumber2.Text;
                if (tryNum.Length!=3)
                {
                    tryNumb = false;
                    MessageBox.Show("Неверный формат номера автомобиля!");
                }
                else
                {
                    tryNum = textBox_carNumber3.Text;
                    if (tryNum.Length!=2)
                    {
                        tryNumb = false;
                        MessageBox.Show("Неверный формат номера автомобиля!");
                    }
                    else
                        tryNumb = true;
                }
            }

            tryNum = text_telephone.Text;
            if (tryNum.Length == 11)
                tryPhoneNum = true;
            else
            {
                   
                    if (tryNum.Length > 11)
                        MessageBox.Show("Введено слишком много цифр в номер телефона!");
                    else
                        MessageBox.Show("Введено слишком мало цифр в номер телефона!");
                    tryPhoneNum = false;
            }
           for(int i=0;i<user.GetData().Rows.Count;i++)
             {
                 if (user.GetData().Rows[i]["CarNumber"].ToString() == (textBox_carNumber1.Text + textBox_carNumber2.Text + textBox_carNumber3.Text))
                 {
     
                     MessageBox.Show("Такой номер уже существует в БД!");
                     tryAdd = false;
                     break;
                 }
             }

        }

        private void Form_add_user_Load(object sender, EventArgs e)
        {
            this.Location = new Point((form_opreator.screen.X / 2) - (this.Width / 2), (form_opreator.screen.Y / 2) - (this.Height / 2)-20);
             test = new Test(this);
             textBox_first_name.Text = "Имя";
             textBox_first_name.ForeColor = Color.Gray;
             textBox_last_name.Text = "Фамилия";
             textBox_last_name.ForeColor = Color.Gray;
             textBox_day.Text = "01";
             textBox_day.ForeColor = Color.Gray;
             textBox_month.Text = "01";
             textBox_month.ForeColor = Color.Gray;
             textBox_year.Text = "1995";
             textBox_year.ForeColor = Color.Gray;
             textBox_carNumber1.Text = "А";
             textBox_carNumber1.ForeColor = Color.Gray;
             textBox_carNumber2.Text = "537";
             textBox_carNumber2.ForeColor = Color.Gray;
             textBox_carNumber3.Text = "CT";
             textBox_carNumber3.ForeColor = Color.Gray;
             text_telephone.Text = "89254594586";
             text_telephone.ForeColor = Color.Gray;
        }


        private void Form_add_user_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void textBox_carNumber2_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox_first_name_Enter(object sender, EventArgs e)
        {
            textBox_first_name.Text = null;
            textBox_first_name.ForeColor = Color.Black;
        }

        private void textBox_last_name_Enter(object sender, EventArgs e)
        {
            //textBox_last_name.Text = null;
            //textBox_last_name.ForeColor = Color.Black;
        }

        private void textBox_day_Enter(object sender, EventArgs e)
        {
            textBox_day.Text = null;
            textBox_day.ForeColor = Color.Black;
        }

        private void textBox_month_Enter(object sender, EventArgs e)
        {
            textBox_month.Text=null;
            textBox_month.ForeColor = Color.Black;
        }

        private void textBox_year_Enter(object sender, EventArgs e)
        {
            textBox_year.Text = null;
            textBox_year.ForeColor = Color.Black;
        }

        private void textBox_carNumber1_Enter(object sender, EventArgs e)
        {
            textBox_carNumber1.Text = null;
            textBox_carNumber1.ForeColor = Color.Black;
        }

        private void textBox_carNumber2_Enter(object sender, EventArgs e)
        {
            textBox_carNumber2.Text = null;
            textBox_carNumber2.ForeColor = Color.Black;
        }

        private void textBox_carNumber3_Enter(object sender, EventArgs e)
        {
            textBox_carNumber3.Text = null;
            textBox_carNumber3.ForeColor = Color.Black;
        }

        private void text_telephone_Enter(object sender, EventArgs e)
        {
            text_telephone.Text = null;
            text_telephone.ForeColor = Color.Black;
        }

        private void textBox_last_name_MouseEnter(object sender, EventArgs e)
        {
            textBox_last_name.Text = null;
            textBox_last_name.ForeColor = Color.Black;
        }

    }
}
