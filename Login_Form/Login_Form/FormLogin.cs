using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username, passwd;
            username = txtUsername.Text;
            passwd = txtPassword.Text;

            if (username == "admin" && passwd == "12345")
            {
                FormKasir fk = new FormKasir();
                fk.Show();
            }
            else
            {
                MessageBox.Show("Username dan Password Anda Salah!!");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }
    }
}
