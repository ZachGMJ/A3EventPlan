namespace A3EventPlan
{
    public partial class frmBurgers : Form
    {
        public frmBurgers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picPrime_Click(object sender, EventArgs e)
        {

        }

        private void btnPrime_Click(object sender, EventArgs e)
        {
            picVeggie.Visible = false;
            picPrime.Visible = true;
        }
        private void btnVeggie_Click(object sender, EventArgs e)
        {
            picPrime.Visible = false;
            picVeggie.Visible = true;
        }
        private void btnSelectMeal_Click(object sender, EventArgs e)
        {
            if(picVeggie.Visible)
            {
                btnPrime.Enabled = false;
                btnVeggie.Enabled = false;
                label2.Visible = true;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
           Close();
        }
    }
}
