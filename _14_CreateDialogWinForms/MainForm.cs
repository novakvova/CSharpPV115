using _14_CreateDialogWinForms.Data;

namespace _14_CreateDialogWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            try
            {
                AppFormData mydata = new AppFormData();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShowLoginForm_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void btnShowRegisterForm_Click(object sender, EventArgs e)
        {
            RegisterForm dlg = new RegisterForm();
            dlg.ShowDialog();
        }
    }
}