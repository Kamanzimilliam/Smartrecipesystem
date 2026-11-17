namespace Lab1
{
    partial class MushroomForm
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
            lblInfo = new Label();
            lblCount = new Label();
            lblQuestion = new Label();
            btnYes = new Button();
            btnNo = new Button();
            btnStart = new Button();
            btnBack = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // lblInfo
            lblInfo.Location = new Point(20, 15);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(360, 40);
            lblInfo.Text = "Think of one of: Agaric jaunissant, Amanite tue-mouche, Cepe de bordeaux, Coprin chevelu, Girolle, Pied bleu.";
            // lblCount
            lblCount.AutoSize = true;
            lblCount.Location = new Point(20, 65);
            lblCount.Name = "lblCount";
            lblCount.Text = "Question 1 of at most 3";
            // lblQuestion
            lblQuestion.Font = new Font("Segoe UI", 11F);
            lblQuestion.Location = new Point(20, 90);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(360, 40);
            lblQuestion.Text = "Question";
            // btnYes
            btnYes.Location = new Point(20, 140);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(90, 32);
            btnYes.TabIndex = 0;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += btnYes_Click;
            // btnNo
            btnNo.Location = new Point(120, 140);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(90, 32);
            btnNo.TabIndex = 1;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += btnNo_Click;
            // btnStart
            btnStart.Location = new Point(250, 140);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(110, 32);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start again";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // btnBack
            btnBack.Location = new Point(20, 200);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 30);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // btnLogout
            btnLogout.Location = new Point(280, 200);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 30);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // MushroomForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 250);
            Controls.Add(lblInfo);
            Controls.Add(lblCount);
            Controls.Add(lblQuestion);
            Controls.Add(btnYes);
            Controls.Add(btnNo);
            Controls.Add(btnStart);
            Controls.Add(btnBack);
            Controls.Add(btnLogout);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MushroomForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mushroom";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label lblInfo;
        private Label lblCount;
        private Label lblQuestion;
        private Button btnYes;
        private Button btnNo;
        private Button btnStart;
        private Button btnBack;
        private Button btnLogout;
    }
}
