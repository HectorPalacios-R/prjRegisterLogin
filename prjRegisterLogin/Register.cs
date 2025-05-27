using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjRegisterLogin
{
    public partial class Register : Form
    {
        private Form1 loginFormInstance;
        public Register(Form1 form1)
        {
            InitializeComponent();
            this.loginFormInstance = form1;
        }

        private void btnLoginScreen_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);
            form1.Show();
            this.Hide();//Hide the register form when opening the register form
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string strUserName = this.txtUserName.Text.ToString().Trim();
            string strPassword = this.txtPassword.Text.ToString().Trim();
            User user = new User(strUserName, strPassword);
            if (UserDetails.GetUsers().Any(u => u.Username == strUserName))
            {
                MessageBox.Show("Username already exists. Please login or try another username");
            }
            else
            {
                UserDetails.AddUser(user);
                MessageBox.Show("Registration successful");
            }

        }

        private void Register_Load(object sender, EventArgs e)
        {
            this.txtUserName.Focus();
        }
    }
}
