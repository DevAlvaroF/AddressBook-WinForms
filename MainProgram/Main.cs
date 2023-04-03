namespace MainProgram
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void businessMenuItem_Click(object sender, EventArgs e)
        {
            // Create Contacts Form
            Contacts frm = new Contacts();

            // Add Main Form as Parent
            frm.MdiParent = this;
            frm.Show();
        }

        private void cascadeMenuItem_Click(object sender, EventArgs e)
        {
            // Define the MDI Layout of this window
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Define the MDI Layout of this window
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalMenuItem_Click(object sender, EventArgs e)
        {
            // Define the MDI Layout of this window
            LayoutMdi(MdiLayout.TileHorizontal);
        }
    }
}