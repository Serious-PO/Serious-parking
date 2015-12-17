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
    public partial class Log : Form
    {
        string carNumber;
        DataSet1TableAdapters.UserDataTableAdapter user;
        public Log()
        {
            InitializeComponent();
            user = new DataSet1TableAdapters.UserDataTableAdapter();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void logChange(string number, string operation)
        {
            user.dataChanges(user.GetData().Rows.Count + 1, operation, number, DateTime.Now);
            textBox1.Text = textBox1.Text + "\n" + operation + " " + number + " " + DateTime.Now.ToString()+"\n";
        }
    }
}
