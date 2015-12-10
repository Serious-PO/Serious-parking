﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Terminal
{
    public partial class Form_close : Form
    {
        DataSet1TableAdapters.UserQuerry1TableAdapter user;
        Form_Error form_error;
        Form_final form_final;
        Form_operator frm;
        private bool check;
        public Form_close(Form_operator f)
        {
            user = new Terminal.DataSet1TableAdapters.UserQuerry1TableAdapter();
            frm = f;
            InitializeComponent();
            
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            check = false;
            for (int i = 0; i < user.GetData().Rows.Count; i++)
            {
                if (number() == user.GetData().Rows[i]["CarNumber"].ToString())
                {
                    check = true;
                    if (user.GetData().Rows[i]["OnParking"].ToString() == true.ToString())
                    {
                        user.updateTimeQuit(DateTime.Now, comboBox_num.Text.ToString());
                        form_final = new Form_final(this, frm);
                        form_final.Show();
                    }
                    else
                    {
                        form_error = new Form_Error(this, "Выезд");
                        form_error.Show();
                    }
                }

            }
            if (check == false)
            {
                form_error = new Form_Error(this, "Выезд");
                form_error.Show();
            }
            new_lable();
            
        }
        public string number()
        {
            return comboBox_num.Text;
        }
        public void new_lable()
        {
            for (int i = 0; i < user.GetData().Rows.Count; i++)
            {
                label_check.Text = "вне территории";
                if (number() == user.GetData().Rows[i]["CarNumber"].ToString())
                {
                    if (user.GetData().Rows[i]["OnParking"].ToString() == true.ToString())
                    {
                        label_check.Text = "на территории";
                        break;
                    }
                }

             }
        }
        private void Form_close_Closed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void Form_close_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.UserQuerry1' table. You can move, or remove it, as needed.
            this.userQuerry1TableAdapter.Fill(this.dataSet1.UserQuerry1);
            new_lable();

        }

        private void comboBox_num_SelectedIndexChanged(object sender, EventArgs e)
        {
            new_lable();
        }
    }
}
