namespace Lab1
{
    partial class BicycleForm
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
            lblStart = new Label();
            lblEnd = new Label();
            lblTotal = new Label();
            txtStart = new TextBox();
            txtEnd = new TextBox();
            txtTotal = new TextBox();
            btnCalc = new Button();
            btnBack = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // lblStart
            lblStart.AutoSize = true;
            lblStart.Location = new Point(20, 25);
            lblStart.Name = "lblStart";
            lblStart.Text = "Start time (hour, 0-23):";
            // lblEnd
            lblEnd.AutoSize = true;
            lblEnd.Location = new Point(20, 65);
            lblEnd.Name = "lblEnd";
            lblEnd.Text = "End time (hour, 1-24):";
            // lblTotal
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(20, 160);
            lblTotal.Name = "lblTotal";
            lblTotal.Text = "Total amount (RWF):";
            // txtStart
            txtStart.Location = new Point(210, 22);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(110, 23);
            txtStart.TabIndex = 0;
            // txtEnd
            txtEnd.Location = new Point(210, 62);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(110, 23);
            txtEnd.TabIndex = 1;
            // txtTotal
            txtTotal.Location = new Point(210, 157);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(110, 23);
            txtTotal.TabStop = false;
            // btnCalc
            btnCalc.Location = new Point(20, 105);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(110, 32);
            btnCalc.TabIndex = 2;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // btnBack
            btnBack.Location = new Point(20, 215);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 30);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // btnLogout
            btnLogout.Location = new Point(230, 215);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 30);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // BicycleForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 270);
            Controls.Add(lblStart);
            Controls.Add(lblEnd);
            Controls.Add(lblTotal);
            Controls.Add(txtStart);
            Controls.Add(txtEnd);
            Controls.Add(txtTotal);
            Controls.Add(btnCalc);
            Controls.Add(btnBack);
            Controls.Add(btnLogout);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "BicycleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bicycle Rental";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label lblStart;
        private Label lblEnd;
        private Label lblTotal;
        private TextBox txtStart;
        private TextBox txtEnd;
        private TextBox txtTotal;
        private Button btnCalc;
        private Button btnBack;
        private Button btnLogout;
    }
}
