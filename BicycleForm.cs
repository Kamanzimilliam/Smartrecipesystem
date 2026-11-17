namespace Lab1
{
    public partial class BicycleForm : Form
    {
        public bool LoggedOut { get; private set; }

        public BicycleForm()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // int.TryParse rejects decimal numbers and text
            if (!int.TryParse(txtStart.Text.Trim(), out int start) ||
                !int.TryParse(txtEnd.Text.Trim(), out int end))
            {
                ShowError("Please enter whole numbers only (no decimals).");
                return;
            }
            if (start < 0 || start > 23) { ShowError("Start time must be between 0 and 23."); return; }
            if (end < 1 || end > 24)     { ShowError("End time must be between 1 and 24."); return; }
            if (start >= end)            { ShowError("Start time must be less than end time."); return; }

            int total = 0;
            for (int hour = start; hour < end; hour++)   // each rented hour: hour -> hour+1
            {
                total += RateForHour(hour);
            }
            txtTotal.Text = total.ToString("N0");
        }

        private static int RateForHour(int h)
        {
            if (h < 7 || h >= 21) return 500;                    // 0-7 and 21-24
            if (h < 14 || (h >= 19 && h < 21)) return 1000;      // 7-14 and 19-21
            return 1500;                                          // 14-19
        }

        private void ShowError(string msg)
        {
            txtTotal.Clear();
            MessageBox.Show(msg, "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnBack_Click(object sender, EventArgs e) => Close();

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoggedOut = true;
            Close();
        }
    }
}
