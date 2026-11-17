namespace Lab1
{
    public partial class ChooseForm : Form
    {
        public LoginForm LoginOwner { get; set; }

        public ChooseForm()
        {
            InitializeComponent();
        }

        private void btnBicycle_Click(object sender, EventArgs e)
        {
            Hide();
            var f = new BicycleForm();
            f.ShowDialog();
            if (f.LoggedOut) LogoutToLogin(); else Show();
        }

        private void btnMushroom_Click(object sender, EventArgs e)
        {
            Hide();
            var f = new MushroomForm();
            f.ShowDialog();
            if (f.LoggedOut) LogoutToLogin(); else Show();
        }

        private void LogoutToLogin()
        {
            LoginOwner?.Show();
            Close();
        }

        // Closing with the X (while login is hidden) exits the app
        private void ChooseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (LoginOwner != null && !LoginOwner.Visible) Application.Exit();
        }
    }
}
