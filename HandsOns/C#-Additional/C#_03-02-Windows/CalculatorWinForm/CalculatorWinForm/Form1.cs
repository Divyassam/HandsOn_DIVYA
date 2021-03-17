using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result="";
            if(!Regex.Match(textBox1.Text,"[0-9]*").Success || !Regex.Match(textBox1.Text, "[0-9]*").Success)
            {
                result = "Please enter valid input for the operands";
            }
            else if (radioButton1.Checked )
            {
                result = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString();
            }
            else if (radioButton2.Checked)
            {
                result = (Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)).ToString();
            }
            else if (radioButton3.Checked)
            {
                result = (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)).ToString();
            }
            else if (radioButton4.Checked)
            {
                result = (Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text)).ToString();
            }
            MessageBox.Show(result);
        }
    }
}
