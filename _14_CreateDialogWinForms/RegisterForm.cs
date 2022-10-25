using _14_CreateDialogWinForms.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_CreateDialogWinForms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //Filter
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show("Select file "+ofd.FileName);
                pbImage.Image = Image.FromFile(ofd.FileName);
            }

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            pbImage.Image = Image.FromFile("images/select.jpg");
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            AppFormData appFormData = new AppFormData();
            UserEntity user = new UserEntity
            {
                FirstName=txtName.Text,
                Image="Сало.jpg",
                LastName="Мельник",
                Phone="097 88 77 6666",
                Password="123456",
                Gender=Gender.Male
            };
            appFormData.Users.Add(user);
            appFormData.SaveChanges();
            this.Close();

        }
    }
}
