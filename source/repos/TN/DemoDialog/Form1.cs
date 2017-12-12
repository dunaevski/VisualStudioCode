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
        private Bitmap Bitmap;  // переменная для картинки

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Файлы графики (*.bmp;*.jpg;*.png;*.gif)|*.bmp;*.jpg;*.png;*.gif|Все файлы(*.*)|*.*";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
