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
    public partial class Form_final : Form
    {
        public Form_final()
        {
            InitializeComponent();
            label_final.ForeColor = Color.Green;
            label_final.Font = new Font("label_final", 40);

            label_time.ForeColor = Color.Green;
            label_time.Font = new Font("label_time", 30);

            label_getmoney.ForeColor = Color.Green;
            label_getmoney.Font = new Font("label_getmoney", 30);

            label_balance.ForeColor = Color.Green;
            label_balance.Font = new Font("label_balance", 30);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_final_Load(object sender, EventArgs e)
        {

        }

        private void Form_final_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
