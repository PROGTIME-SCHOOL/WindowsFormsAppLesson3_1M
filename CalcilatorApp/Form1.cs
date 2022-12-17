using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcilatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            // input (get data from form)
            int num1 = 0;
            int.TryParse(textBoxNum1.Text, out num1);

            int num2 = 0;
            int.TryParse(textBoxNum2.Text, out num2);

            // action
            int res = num1 + num2;

            // output (put data to form)
            labelResult.Text = res.ToString();
            labelResultInfo.Text = num1.ToString() + " + " + num2.ToString() +
                " = " + res.ToString();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            // input (get data from form)
            int num1 = int.Parse(textBoxNum1.Text);
            int num2 = int.Parse(textBoxNum2.Text);

            // action
            int res = num1 - num2;

            // output (put data to form)
            labelResult.Text = res.ToString();
            labelResultInfo.Text = num1.ToString() + " - " + num2.ToString() +
                " = " + res.ToString();
        }
    }
}
