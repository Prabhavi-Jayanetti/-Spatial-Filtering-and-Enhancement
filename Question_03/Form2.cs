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
    public partial class Form2 : Form
    {
        preprocessing p = new preprocessing();

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
   
            pictureBox1.ImageLocation = "3a (1).png";
            pictureBox3.ImageLocation = "3a (2).png";
            pictureBox4.ImageLocation = "3a (3).png";
            pictureBox5.ImageLocation = "3a (4).png";
            pictureBox6.ImageLocation = "3a (5).png";
            pictureBox7.ImageLocation = "3a (6).png";
            pictureBox8.ImageLocation = "3a (7).png";
            pictureBox9.ImageLocation = "3a (8).png";
            pictureBox10.ImageLocation = "3a (9).png";
            pictureBox2.ImageLocation = "3a (10).png";

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.ArithmeticMeanFilter();
            pictureBox11.ImageLocation = "Output.png";
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
