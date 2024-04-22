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

namespace mPlayer
{
    public partial class Form1 : Form
    {
        List<KeyValuePair<string, string>> stations = new List<KeyValuePair<string, string>>();
        string[] paths, filenames;
        public Form1()
        {
            InitializeComponent();
        }

        private void rMedia_CheckedChanged(object sender, EventArgs e)
        {
            this.Size = new Size(800, 440);
            btnAdd.Enabled = true; 
            lbMedia.DataSource = null; 
            lbMedia.Items.Clear();
        }

        private void rRadio_CheckedChanged(object sender, EventArgs e)
        {
            this.Size = new Size(220, 440);

            btnAdd.Enabled = false;
            stations.Clear();
            stations.Add(new KeyValuePair<string, string>("Class 95", @"https://19183.live.streamtheworld.com/CLASS95_SC"));
            stations.Add(new KeyValuePair<string, string>("Yes 933", @"https://19183.live.streamtheworld.com/YES933_SC"));
            stations.Add(new KeyValuePair<string, string>("Gold 905", @"https://19183.live.streamtheworld.com/GOLD905_SC"));
            stations.Add(new KeyValuePair<string, string>("Symphony 924", @"https://19183.live.streamtheworld.com/SYMPHONY924_SC"));
            lbMedia.DataSource = stations; 
            lbMedia.DisplayMember = "Key"; 
            lbMedia.ValueMember = "Value";
        }

        private void lbMedia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbMedia.SelectedIndex == -1)
                return;
            if (rRadio.Checked)
                wmpPlayer.URL = ((KeyValuePair<string, string>)lbMedia.SelectedItem).Value;
            else
                wmpPlayer.URL = paths[lbMedia.SelectedIndex];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filenames = ofd.SafeFileNames;
                paths = ofd.FileNames;
                for (int i = 0; i < filenames.Length; i++)
                {
                    lbMedia.Items.Add(filenames[i]);
                }
            }
        }
    }
}
