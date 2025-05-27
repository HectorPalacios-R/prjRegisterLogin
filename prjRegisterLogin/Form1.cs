namespace prjRegisterLogin
{
    public partial class Form1 : Form
    {
        private Register loginFormInstance;
        public Form1(Register register)
        {
            InitializeComponent();
            this.loginFormInstance = register;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtPassword.Clear();
            this.txtUserName.Clear();
            this.txtUserName.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strUserName = this.txtUserName.Text.ToString().Trim();
            string strPassword = this.txtPassword.Text.ToString().Trim();
            User user = new User(strUserName, strPassword);
            if (UserDetails.IsUserValid(user))
            {
                MessageBox.Show("Login Succesful!");
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtUserName.Focus();
        }

        private void btnRegisterScreen_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register(this);
            registerForm.Show();
            this.Hide();//Hide the login form when opening the register form
        }
    }
}
