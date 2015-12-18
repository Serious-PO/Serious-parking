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
        Form_operator form_operator;
        public Log(Form_operator frm_operator)
        {
            InitializeComponent();
            form_operator = frm_operator;
            user = new DataSet1TableAdapters.UserDataTableAdapter();
            Opacity = 0;
            Timer timer = new Timer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.08d) >= 1) timer.Stop();
            });
            timer.Interval = 5;
            timer.Start();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void logChange(string number, string operation)
        {
            user.dataChanges(user.GetData().Rows.Count + 1, operation, number, DateTime.Now);
            if (operation == "Въезд")
            {
                textBox1.SelectionColor = Color.Black;
                textBox1.AppendText(DateTime.Now.ToString() + " ");
                textBox1.SelectionColor = Color.Green;
                textBox1.AppendText(operation);
                textBox1.SelectionColor = Color.Black;
                textBox1.AppendText(" " + number + Environment.NewLine);
                textBox1.AppendText("-----------------------------------------------------------");
            }
            else
            {
                textBox1.SelectionColor = Color.Black;
                textBox1.AppendText(DateTime.Now.ToString() + " ");
                textBox1.SelectionColor = Color.Red;
                textBox1.AppendText(operation);
                textBox1.SelectionColor = Color.Black;
                textBox1.AppendText(" " + number + Environment.NewLine);
                textBox1.AppendText("-----------------------------------------------------------");
            }
        }
        private void Log_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Location = new Point(form_operator.Location.X-this.Width-5, form_operator.Location.Y);
        }

        private void Log_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
  
}
