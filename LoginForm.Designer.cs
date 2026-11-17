namespace Lab1
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            lblUser = new Label();
            lblPass = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // lblUser
            lblUser.AutoSize = true;
            lblUser.Location = new Point(20, 30);
            lblUser.Name = "lblUser";
            lblUser.Text = "Username:";
            // lblPass
            lblPass.AutoSize = true;
            lblPass.Location = new Point(20, 70);
            lblPass.Name = "lblPass";
            lblPass.Text = "Password:";
            // txtUser
            txtUser.Location = new Point(110, 27);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(180, 23);
            txtUser.TabIndex = 0;
            // txtPass
            txtPass.Location = new Point(110, 67);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(180, 23);
            txtPass.TabIndex = 1;
            txtPass.UseSystemPasswordChar = true;
            // btnLogin
            btnLogin.Location = new Point(110, 115);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 32);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // LoginForm
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 200);
            Controls.Add(lblUser);
            Controls.Add(lblPass);
            Controls.Add(txtUser);
            Controls.Add(txtPass);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label lblUser;
        private Label lblPass;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnLogin;
    }
}
