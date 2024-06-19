using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteApp
{
    public partial class Form1 : Form
    {
        DataTable tbl;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbl = new DataTable("Notes");
            tbl.Columns.Add("Title", typeof(String));
            tbl.Columns.Add("Message", typeof(String));
            if (File.Exists(@"MyData.xml"))
            {
                tbl.ReadXml(@"MyData.xml");
            }
            dgvMesg.DataSource = tbl;
            dgvMesg.Columns["Message"].Visible = false;
            dgvMesg.Columns["Title"].Width = dgvMesg.ClientRectangle.Width - 4;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((txtTitle.Text != String.Empty) && (txtMesg.Text != String.Empty))
                tbl.Rows.Add(txtTitle.Text, txtMesg.Text);
            else
                MessageBox.Show("Title and Message cannot be empty");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtMesg.Clear(); 
            txtTitle.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dgvMesg.CurrentCell.RowIndex; if (index > -1)
            {
                tbl.Rows[index].Delete();
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int index = dgvMesg.CurrentCell.RowIndex;
            if (index > -1)
            {
                txtTitle.Text = tbl.Rows[index].ItemArray[0].ToString(); 
                txtMesg.Text = tbl.Rows[index].ItemArray[1].ToString();
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            tbl.WriteXml(@"MyData.xml");
        }
    }
}
