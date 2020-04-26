using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivityLogger
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = "demo";
            string password = "password";
            if (txtUsername.Text == "" || txtUserpassword.Text == "")
            {
                MessageBox.Show("ERROR01: Check your username and/or password !");

            }
            else if (txtUsername.Text == username && txtUserpassword.Text == password)
            {
                this.Hide();
                Form f = new ActivityLogger();
                f.Show();

            }
            else if(txtUsername.Text != username || txtUserpassword.Text != password)
            {
                MessageBox.Show("ERROR02: There's no account with the values provided !");
            }
        }
    }
}
