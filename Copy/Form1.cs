namespace Copy
{
    public partial class MainForm : Form
    {
        public Invoice invoiceManager;
        public MainForm()
        {
            InitializeComponent();
            invoiceManager = new Invoice();

            addInvoice.InvoiceManager = invoiceManager;
            manageInvoices.InvoiceManager = invoiceManager;

            addInvoice.Show();
            manageInvoices.Hide();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addInvoice1_Load(object sender, EventArgs e)
        {

        }

        private void manageInvoices_Load(object sender, EventArgs e)
        {

        }
        private void manageInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageInvoices.Show();
            addInvoice.Hide();
            manageInvoices.RefreshInvoiceList();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageInvoices.Hide();
            addInvoice.Show();
        }
    }
}
