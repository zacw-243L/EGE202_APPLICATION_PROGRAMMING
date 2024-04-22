using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNum.Text = "0";
            txtResults.Text = "0";
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            int num, results;
            num = int.Parse(txtNum.Text);
            results = num * num;
            txtResults.Text = results.ToString();
        }
    }
}
