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
                using (MemoryStream ms = new MemoryStream())
                {
                    ms.Write(File.ReadAllBytes($"images/{user.Image}"));
                    object[] row = {user.Id, user.FirstName+" "+user.LastName, user.Phone,
                    user.Gender, Image.FromStream(ms) };
                    dgvUsers.Rows.Add(row);
                }
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
                    if (!string.IsNullOrEmpty(userDel.Image))
                    {
                        File.Delete($"images/{userDel.Image}");
                    }
                    _formData.Users.Remove(userDel);
                    _formData.SaveChanges();
                    UpdateUsersList();

                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
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
                    var user = _formData.Users.SingleOrDefault(x => x.Id == id);
                    EditUserForm editForm = new EditUserForm(_formData);
                    editForm.initTxtName = user.FirstName;
                    editForm.initTxtLastName = user.LastName;
                    editForm.initTxtPhone = user.Phone;
                    editForm.initTxtPassword = user.Password;
                    editForm.initSelectGender=user.Gender;
                    editForm.initImageUser = user.Image;
                    editForm.initUserId = user.Id;
                    editForm.ShowDialog();
                    UpdateUsersList();

                }
            }
           
            //MessageBox.Show("Edit item");
        }
    }
}