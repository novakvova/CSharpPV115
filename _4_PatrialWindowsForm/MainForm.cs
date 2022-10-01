namespace _4_PatrialWindowsForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            txtName.Text = "";
            MessageBox.Show(name);
        }
    }
}