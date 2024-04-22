using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_
{
    public partial class frmMain : Form
    {
        Random r = new Random();
        int secretNum;
        public frmMain()
        {
            InitializeComponent();
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (secretNum == 1)
            {
                MessageBox.Show("Correct");
            }
            else
            {
                MessageBox.Show("Wrong");
            }
            Button btn = (Button)sender;
            btn.Enabled = false;

            startOver();
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (secretNum == 1)
            {
                MessageBox.Show("Correct");
            }
            else
            {
                MessageBox.Show("Wrong");
            }
            Button btn = (Button)sender;
            btn.Enabled = false;

            startOver();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            secretNum = r.Next(1, 4);
        }
        private void startOver()
        {
            var result = MessageBox.Show("Start Over?", "End of Game", MessageBoxButtons.YesNo);
            secretNum = r.Next(1, 4);
            if (result == DialogResult.Yes)
            {
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
            }
            else
            {
                Application.Exit();
            }

        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (secretNum == 1)
            {
                MessageBox.Show("Correct");
            }
            else
            {
                MessageBox.Show("Wrong");
            }
            Button btn = (Button)sender;
            btn.Enabled = false;

            startOver();
        }
    }
}
