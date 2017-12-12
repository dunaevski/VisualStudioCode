using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Заполнение листбокса случайными числами
            Random random = new Random();
            for (int i = 0; i < 10; i++)
                listBox1.Items.Add(random.Next(100, 300).ToString());
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = listBox1.SelectedIndex + " " + listBox1.SelectedItem;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
               // listBox1.Items.Add(textBox1.Text); // Вставить в конец
                // listBox1.Items.Insert(5, textBox1.Text);
                // Вставка до выдфеленного обьекта, проверка что в лстбокс выделенно
                if (listBox1.SelectedIndex==-1)
                {
                    MessageBox.Show("Не выделен ни один обьект");
                    listBox1.Focus();
                }
                else
                {
                    listBox1.Items.Insert(listBox1.SelectedIndex, textBox1.Text);
                    textBox1.Text = " ";
                    textBox1.Focus();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "";
            foreach (var VARIABLE in listBox1.SelectedIndices)
                str += "Интдекс " + VARIABLE + " \r\n";
            foreach (var VARIABLE in listBox1.SelectedItems)
                str += "Элемент " + VARIABLE + "\r\n";
            textBox2.Text = str;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = comboBox1.Text;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox3.Text = DateTime.Now.ToLongTimeString();
            
        }
    }
}
