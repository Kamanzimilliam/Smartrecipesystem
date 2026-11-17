namespace Lab1
{
    public partial class MushroomForm : Form
    {
        public bool LoggedOut { get; private set; }

        private int step;
        private bool forest, convex;

        public MushroomForm()
        {
            InitializeComponent();
            Restart();
        }

        private void Restart()
        {
            step = 1;
            btnYes.Enabled = btnNo.Enabled = true;
            ShowQuestion();
        }

        private void ShowQuestion()
        {
            lblCount.Text = $"Question {step} of at most 3";
            if (step == 1) lblQuestion.Text = "Does your mushroom grow in a forest?";
            else if (step == 2) lblQuestion.Text = "Does your mushroom have a convex cup?";
            else lblQuestion.Text = convex ? "Does your mushroom have a ring?"
                                           : "Does your mushroom have gills?";
        }

        // Decision tree (max 3 questions):
        //  forest? no  -> convex? yes: Agaric jaunissant / no: Coprin chevelu
        //  forest? yes -> convex? yes -> ring?  yes: Amanite tue-mouche / no: Pied bleu
        //                         no  -> gills? yes: Girolle / no: Cepe de bordeaux
        private void Answer(bool yes)
        {
            string result = null;

            if (step == 1)
            {
                forest = yes;
                step = 2;
            }
            else if (step == 2)
            {
                convex = yes;
                if (!forest) result = convex ? "Agaric jaunissant" : "Coprin chevelu";
                else step = 3;
            }
            else
            {
                if (convex) result = yes ? "Amanite tue-mouche" : "Pied bleu";   // yes = has ring
                else result = yes ? "Girolle" : "Cepe de bordeaux";               // yes = has gills
            }

            if (result != null)
            {
                btnYes.Enabled = btnNo.Enabled = false;
                MessageBox.Show("Your mushroom is: " + result, "Mushroom name",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else ShowQuestion();
        }

        private void btnYes_Click(object sender, EventArgs e) => Answer(true);
        private void btnNo_Click(object sender, EventArgs e) => Answer(false);
        private void btnStart_Click(object sender, EventArgs e) => Restart();
        private void btnBack_Click(object sender, EventArgs e) => Close();

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoggedOut = true;
            Close();
        }
    }
}
