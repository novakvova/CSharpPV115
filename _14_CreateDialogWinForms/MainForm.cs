using _14_CreateDialogWinForms.Data;
using System.Windows.Forms;

namespace _14_CreateDialogWinForms
{
    public partial class MainForm : Form
    {
        private readonly AppFormData _formData;
        public MainForm()
        {
            InitializeComponent();
            try
            {
                _formData = new AppFormData();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void UpdateUsersList()
        {
            dgvUsers.Rows.Clear();
            var users = _formData.Users.ToList();
            foreach (var user in users)
            {
                object[] row = {user.Id, user.FirstName+" "+user.LastName, user.Phone,
                    user.Gender, Image.FromFile($"images/{user.Image}") };
                dgvUsers.Rows.Add(row);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello app");
            UpdateUsersList();
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
            UpdateUsersList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = dgvUsers.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                if (dgvUsers.AreAllCellsSelected(true))
                {
                    MessageBox.Show("All cells are selected", "Selected Cells");
                }
                else
                {
                    var selectRowIndex = dgvUsers.SelectedCells[0].RowIndex;
                    var id = int.Parse(dgvUsers.Rows[selectRowIndex].Cells[0].Value.ToString());
                    //MessageBox.Show(id.ToString());
                    var userDel = _formData.Users.SingleOrDefault(x => x.Id == id);
                    _formData.Users.Remove(userDel);
                    _formData.SaveChanges();
                    UpdateUsersList();

                }
            }
        }
    }
}