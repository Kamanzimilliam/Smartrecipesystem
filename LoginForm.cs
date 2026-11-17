namespace Lab1
{
    public partial class LoginForm : Form
    {
        // Demo credentials
        private const string ValidUser = "admin";
        private const string ValidPass = "1234";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == ValidUser && txtPass.Text == ValidPass)
            {
                txtPass.Clear();
                Hide();
                new ChooseForm { LoginOwner = this }.Show();   // next form
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
