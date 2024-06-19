using System;
using System.Windows.Forms;

namespace MyCheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PB1.Visible = false;
        }

        private void chkSel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSel.Checked == true)
            {
                picImg.Image = MyCheckBox.Properties.Resources._1aawd;
                PB1.Visible = false;
            }
            else if (chkSel.Checked == false)
            {
                picImg.Image = null;
                PB1.Visible = true;
            }
        }
    }
}
