using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HDBPredict
{
    public partial class LoginForm : Form
    {
        Dictionary<string, string> id_pwd;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            id_pwd = new Dictionary<string, string>();
            id_pwd.Add("admin", "p@ssw0rd");
            id_pwd.Add("ege202", "");

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id, pwd;

            id = txtUser.Text;
            pwd = txtPwd.Text;
            if (id_pwd.ContainsKey(id))
            {
                if (id_pwd[id] == pwd)
                {
                    this.Hide();
                    Form1 frm = new Form1();
                    frm.Closed += (s, args) => this.Close();
                    frm.Show();
                }
                else
                    MessageBox.Show("Wrong User ID or Password");
            }
            else
                MessageBox.Show("Wrong User ID or Password");
        }
    }
}