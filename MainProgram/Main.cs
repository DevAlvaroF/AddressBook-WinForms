namespace MainProgram
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            // MAximize
            this.WindowState = FormWindowState.Maximized;
        }

        private void businessMenuItem_Click(object sender, EventArgs e)
        {


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

        private void Main_Load(object sender, EventArgs e)
        {
            // Create Contacts Form
            ContactView contactView = new ContactView(bindingSource1);
            // Add Main Form as Parent
            contactView.MdiParent = this;
            //contactView.StartPosition = FormStartPosition.CenterParent;
            //contactView.WindowState = FormWindowState.Minimized;
            //contactView.Dock = DockStyle.Fill;
            //contactView.Dock = DockStyle.Right;
            contactView.Show();
            contactView.WindowState = FormWindowState.Maximized;
        }

        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create Contacts Form
            Contacts frm = new Contacts(bindingSource1);

            // Add Main Form as Parent and change size to half of parent (this)
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Normal;
            frm.Show();

            LayoutMdi(MdiLayout.TileVertical);

        }
    }
}