using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_Core
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToInt32(textBox1.Text);
            var num2 = Convert.ToInt32(textBox2.Text);
            labelres.Text = (num1+num2).ToString();
        }
    }
}
