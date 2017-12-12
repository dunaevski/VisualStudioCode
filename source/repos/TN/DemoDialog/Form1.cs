using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDialog
{
    public partial class Form1 : Form
    {
        private Bitmap _bitmap;  // переменная для картинки

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Файлы графики (*.bmp;*.jpg;*.png;*.gif)|*.bmp;*.jpg;*.png;*.gif|Все файлы(*.*)|*.*";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    _bitmap=new Bitmap(openFileDialog1.FileName);
                    pictureBox1.Image = _bitmap;
                    pictureBox1.Invalidate();
                }
                catch (Exception exception)
                {
                    DialogResult result = MessageBox.Show("Невозможн открыть", "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    throw;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog()==DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }
    }
}
