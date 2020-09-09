using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_03
{
    public partial class Form3 : Form
    {
        preprocessing p = new preprocessing();
        OpenFileDialog ofd = new OpenFileDialog();

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            p.LoadOriginalImage(ofd.FileName);
            pictureBox1.ImageLocation = "3bSave.png";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.ImageLocation = "3cSave.png";
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.SaltPepperFilter();
            pictureBox2.ImageLocation = "3bSaltPepper.png";
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.ImageLocation = "3cSaltPepper.png";
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
