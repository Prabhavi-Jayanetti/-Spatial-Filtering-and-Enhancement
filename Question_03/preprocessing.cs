using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace Question_03
{
    class preprocessing
    {

        IplImage srcImage, SaltPepper, srcImage2;
        IplImage src, dst;
        IplImage oRed, oGreen, oBlue;
        IplImage dRed, dGreen, dBlue;

       public void LoadOriginalImage(string fname)
       {
            srcImage = Cv.LoadImage("3b.png", LoadMode.Color);
            Cv.SaveImage("3bSave.png", srcImage);
            srcImage2 = Cv.LoadImage("3c.png", LoadMode.Color);
            Cv.SaveImage("3cSave.png", srcImage2);
       }

        public void SaltPepperFilter()
        {
            SaltPepper = Cv.CreateImage(srcImage.Size, BitDepth.U8, 3);
            Cv.Smooth(srcImage, SaltPepper, SmoothType.Median, 3, 3);
            Cv.SaveImage("3bSaltPepper.png", SaltPepper);
            Cv.Smooth(srcImage2, SaltPepper, SmoothType.Median, 3, 3);
            Cv.SaveImage("3cSaltPepper.png", SaltPepper);
        }

    

        /////// PART A/////

        public void ArithmeticMeanFilter()
        {

            for (int i = 1; i < 11; i++)
            {
                String Image = "3a" + " " + "(" + i.ToString() + ")" + ".png";

                src = Cv.LoadImage(Image, LoadMode.Color);

                oRed = Cv.CreateImage(src.Size, BitDepth.U8, 1);
                oGreen = Cv.CreateImage(src.Size, BitDepth.U8, 1);
                oBlue = Cv.CreateImage(src.Size, BitDepth.U8, 1);

                dRed = Cv.CreateImage(src.Size, BitDepth.U8, 1);
                dGreen = Cv.CreateImage(src.Size, BitDepth.U8, 1);
                 dBlue = Cv.CreateImage(src.Size, BitDepth.U8, 1);

                dst = Cv.CreateImage(src.Size, BitDepth.U8, 3);

                Cv.Split(src, oRed, oGreen, oBlue, null);

                for (int x = 1; x < src.Height - 1; x++)
                {
                    for (int y = 1; y < src.Width - 1; y++)
                    {
                        double getRed = 1;
                        double getGreen = 1;
                        double getBlue = 1;
                        double c = 105.886;

                        getRed += Cv.GetReal2D(oRed, x - 1, y - 1);
                        getRed += Cv.GetReal2D(oRed, x - 1, y);
                        getRed += Cv.GetReal2D(oRed, x - 1, y * 1);
                        getRed += Cv.GetReal2D(oRed, x, y - 1);
                        getRed += Cv.GetReal2D(oRed, x, y);
                        getRed += Cv.GetReal2D(oRed, x, y + 1);
                        getRed += Cv.GetReal2D(oRed, x + 1, y - 1);
                        getRed += Cv.GetReal2D(oRed, x + 1, y);
                        getRed += Cv.GetReal2D(oRed, x + 1, y + 1);

                        getGreen += Cv.GetReal2D(oGreen, x - 1, y - 1);
                        getGreen += Cv.GetReal2D(oGreen, x - 1, y);
                        getGreen += Cv.GetReal2D(oGreen, x - 1, y + 1);
                        getGreen += Cv.GetReal2D(oGreen, x, y - 1);
                        getGreen += Cv.GetReal2D(oGreen, x, y);
                        getGreen += Cv.GetReal2D(oGreen, x, y + 1);
                        getGreen += Cv.GetReal2D(oGreen, x + 1, y - 1);
                        getGreen += Cv.GetReal2D(oGreen, x + 1, y);
                        getGreen += Cv.GetReal2D(oGreen, x + 1, y + 1);

                        getBlue += Cv.GetReal2D(oBlue, x - 1, y - 1);
                        getBlue += Cv.GetReal2D(oBlue, x - 1, y);
                        getBlue += Cv.GetReal2D(oBlue, x - 1, y + 1);
                        getBlue += Cv.GetReal2D(oBlue, x, y - 1);
                        getBlue += Cv.GetReal2D(oBlue, x, y);
                        getBlue += Cv.GetReal2D(oBlue, x, y + 1);
                        getBlue += Cv.GetReal2D(oBlue, x + 1, y - 1);
                        getBlue += Cv.GetReal2D(oBlue, x + 1, y);
                        getBlue += Cv.GetReal2D(oBlue, x + 1, y + 1);

                        getRed = (double)getRed / 9.0;
                        getGreen = (double)getGreen / 9.0;
                        getBlue = (double)getBlue / 9.0;

                        double setRed = c * Math.Log(1 + getRed);
                        double setGreen = c * Math.Log(1 + getGreen);
                        double setBlue = c * Math.Log(1 + getBlue);

                        Cv.SetReal2D(dRed, x, y, getRed);
                        Cv.SetReal2D(dGreen, x, y, getGreen);
                        Cv.SetReal2D(dBlue, x, y, getBlue);
                    }
                }

                Cv.Merge(dRed, dGreen, dBlue, null, dst);
                Cv.SaveImage("Output.png", dst);
            }
        }
    }
}