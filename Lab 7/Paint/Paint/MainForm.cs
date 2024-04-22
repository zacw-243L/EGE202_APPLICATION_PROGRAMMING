using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class MainForm : Form
    {
        Bitmap bm;

        Graphics g;
        Pen pen = new Pen(Color.Black, 5);
        SolidBrush brush = new SolidBrush(Color.Black);
        Point startP = new Point(0, 0);
        Point endP = new Point(0, 0);
        bool flagDraw = false;
        bool flagErase = false;
        bool flagText = false;
        string strText;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bm = new Bitmap(picBoxMain.Width, picBoxMain.Height);
            picBoxMain.Image = bm;
        }

        private void picBoxMain_MouseDown(object sender, MouseEventArgs e)
        {
            startP = e.Location;
            if (flagText == false)
            {
                if (e.Button == MouseButtons.Left)
                    flagDraw = true;
            }
            else
            {
                strText = txtBoxText.Text;
                g = Graphics.FromImage(bm);
                Font font = new Font("Arial", 12);
                brush = new SolidBrush(Color.Black);
                g.DrawString(strText, font, brush, startP.X, startP.Y);
                g.Dispose();
                picBoxMain.Invalidate();
            }
        }

        private void picBoxMain_MouseUp(object sender, MouseEventArgs e)
        {
            flagDraw = false;
        }

        private void picBoxMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (flagDraw == true)
            {
                endP = e.Location;
                g = Graphics.FromImage(bm);
                if (flagErase == false)
                    g.DrawLine(pen, startP, endP);
                else
                    g.FillRectangle(brush, endP.X, endP.Y, 20, 20);
                g.Dispose();
                picBoxMain.Invalidate();
            }
            startP = endP;
        }

        private void picBoxRed_Click(object sender, EventArgs e)
        {
            pen.Color = picBoxRed.BackColor;
            picBoxBrushColor.BackColor = pen.Color;
            picBoxBrushColor.Image = null;
            flagErase = false;
            flagText = false;
        }

        private void picBoxGreen_Click(object sender, EventArgs e)
        {
            pen.Color = picBoxGreen.BackColor;
            picBoxBrushColor.BackColor = pen.Color;
            picBoxBrushColor.Image = null;
            flagErase = false;
            flagText = false;
        }

        private void picBoxBlue_Click(object sender, EventArgs e)
        {
            pen.Color = picBoxBlue.BackColor;
            picBoxBrushColor.BackColor = pen.Color;
            picBoxBrushColor.Image = null;
            flagErase = false;
            flagText = false;
        }
        private void picBoxBlack_Click(object sender, EventArgs e)
        {
            pen.Color = picBoxBlack.BackColor;
            picBoxBrushColor.BackColor = pen.Color;
            picBoxBrushColor.Image = null;
            flagErase = false;
            flagText = false;
        }
        private void picBoxClear_Click(object sender, EventArgs e)
        {
            g = Graphics.FromImage(bm);
            Rectangle rect = picBoxMain.ClientRectangle;
            g.FillRectangle(new SolidBrush(Color.GhostWhite), rect);
            g.Dispose();
            picBoxMain.Invalidate();
        }

        private void picBoxErase_Click(object sender, EventArgs e)
        {
            brush = new SolidBrush(picBoxMain.BackColor);
            picBoxBrushColor.Image = Properties.Resources.erasor;
            flagErase = true;
            flagText = false;
        }

        private void picBoxText_Click(object sender, EventArgs e)
        {
            picBoxBrushColor.Image = Properties.Resources.text;
            flagDraw = false;
            flagText = true;
        }

        private void picBoxSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfdlg = new SaveFileDialog())
            {
                sfdlg.Title = "Save Dialog";
                sfdlg.Filter = "Bitmap Image (*.bmp)|*.bmp|PNG Image (*.png)|*.png|JPEG Image (*.jpg)|*.jpg|All files (*.*)|*.*";
                if (sfdlg.ShowDialog(this) == DialogResult.OK)
                {
                    using (Bitmap bmp = new Bitmap(picBoxMain.Width, picBoxMain.Height))
                    {
                        Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                        picBoxMain.DrawToBitmap(bmp, rect);

                        string extension = Path.GetExtension(sfdlg.FileName).ToLower();

                        // Save the image based on the selected file extension
                        ImageFormat imageFormat;
                        switch (extension)
                        {
                            case ".bmp":
                                imageFormat = ImageFormat.Bmp;
                                break;
                            case ".png":
                                imageFormat = ImageFormat.Png;
                                break;
                            case ".jpg":
                            case ".jpeg":
                                imageFormat = ImageFormat.Jpeg;
                                break;
                            default:
                                // If the selected extension is not supported, default to PNG
                                imageFormat = ImageFormat.Png;
                                break;
                        }

                        bmp.Save(sfdlg.FileName, imageFormat);
                        MessageBox.Show("File Saved Successfully");
                    }
                }
            }
        }
    }
}

