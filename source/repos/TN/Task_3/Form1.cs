using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char) Keys.Enter) return;
            var num = textBox1.Text;
            var max = string.Concat(num.OrderByDescending(n => n));
            var min = string.Concat(num.OrderBy(n => n).ToArray());
            var sum = (long.Parse(max) + long.Parse(min)).ToString();
            var diff = (long.Parse(max) - long.Parse(min)).ToString(); 
            textBox2.Text = max;
            textBox3.Text = min;
            textBox4.Text = sum;
            textBox5.Text = diff;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
