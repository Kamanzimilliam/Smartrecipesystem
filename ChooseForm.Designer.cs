namespace Lab1
{
    partial class ChooseForm
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
            lblChoose = new Label();
            btnBicycle = new Button();
            btnMushroom = new Button();
            SuspendLayout();
            // lblChoose
            lblChoose.AutoSize = true;
            lblChoose.Location = new Point(20, 20);
            lblChoose.Name = "lblChoose";
            lblChoose.Text = "Choose an option:";
            // btnBicycle
            btnBicycle.Location = new Point(30, 60);
            btnBicycle.Name = "btnBicycle";
            btnBicycle.Size = new Size(110, 40);
            btnBicycle.TabIndex = 0;
            btnBicycle.Text = "Bicycle";
            btnBicycle.UseVisualStyleBackColor = true;
            btnBicycle.Click += btnBicycle_Click;
            // btnMushroom
            btnMushroom.Location = new Point(170, 60);
            btnMushroom.Name = "btnMushroom";
            btnMushroom.Size = new Size(110, 40);
            btnMushroom.TabIndex = 1;
            btnMushroom.Text = "Mushroom";
            btnMushroom.UseVisualStyleBackColor = true;
            btnMushroom.Click += btnMushroom_Click;
            // ChooseForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 160);
            Controls.Add(lblChoose);
            Controls.Add(btnBicycle);
            Controls.Add(btnMushroom);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ChooseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Choose";
            FormClosed += ChooseForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label lblChoose;
        private Button btnBicycle;
        private Button btnMushroom;
    }
}
