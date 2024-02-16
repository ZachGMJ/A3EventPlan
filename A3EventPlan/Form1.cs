namespace A3EventPlan
{
    public partial class frmBurgers : Form
    {
        public frmBurgers()
        {
            InitializeComponent();
        }

        //Button for prime beef burger picture
        private void btnPrime_Click(object sender, EventArgs e)
        {
            picVeggie.Visible = false;
            picPrime.Visible = true;
        }
        //Button for veggie burger picture
        private void btnVeggie_Click(object sender, EventArgs e)
        {
            picPrime.Visible = false;
            picVeggie.Visible = true;
        }
        //select meal button action
        private void btnSelectMeal_Click(object sender, EventArgs e)
        {
            btnPrime.Enabled = false;
            btnVeggie.Enabled = false;
            label2.Visible = true;
        }
        //Exit button action
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
