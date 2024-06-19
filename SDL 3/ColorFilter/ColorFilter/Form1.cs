using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorFilter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            picImage.Load("campus.bmp");
        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            Bitmap oImage = (Bitmap)picImage.Image;
            if (oImage == null)
                return;
            int pixelcol;
            for (int i = 0; i < oImage.Width; i++)
                for (int j = 0; j < oImage.Height; j++)
                {
                    pixelcol = oImage.GetPixel(i, j).ToArgb();
                    oImage.SetPixel(i, j, Color.FromArgb(pixelcol & 0x00FF0000));
                }
            picImage.Refresh();
        }

        private void btnGreyScale_Click(object sender, EventArgs e)
        {
            Bitmap oImage;
            oImage = (Bitmap)picImage.Image;
            if (oImage == null)
                return;
            Color col;
            int red;
            int green;
            int blue;
            int gray;
            for (int i = 0; i < oImage.Width; i++)
                for (int j = 0; j < oImage.Height; j++)
                {
                    col = oImage.GetPixel(i, j);
                    red = col.R;
                    green = col.G;
                    blue = col.B;
                    gray = (red + green + blue) / 3;
                    oImage.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            picImage.Refresh();
        }
    }
}
