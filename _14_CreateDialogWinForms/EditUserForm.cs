using _14_CreateDialogWinForms.Data;
using _14_CreateDialogWinForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _14_CreateDialogWinForms
{
    public partial class EditUserForm : Form
    {
        private readonly AppFormData _formData;
        public int initUserId { get; set; }
        public string initTxtName 
        { 
            set { txtName.Text = value; } 
        }
        public string initTxtLastName
        {
            set { txtLastName.Text = value; }
        }
        public string initTxtPhone
        {
            set { txtPhone.Text = value; }
        }
        public string initTxtPassword
        {
            set { txtPassword.Text = value; }
        }
        //ctrl+K+F

        public Gender initSelectGender
        {
            set
            {
                if (value == Gender.Male)
                {
                    cbGender.SelectedIndex = 0;
                }
                else
                {
                    cbGender.SelectedIndex = 1;
                }
            }
        }
        private string imageSelect = string.Empty;
        public EditUserForm(AppFormData formData)
        {
            InitializeComponent();

            MyComboBoxItem male = new MyComboBoxItem();
            male.Name = "Чоловік";
            male.Id = (int)Gender.Male;
            cbGender.Items.Add(male);
            MyComboBoxItem female = new MyComboBoxItem();
            female.Name = "Жінка";
            female.Id = (int)Gender.Female;
            cbGender.Items.Add(female);
            cbGender.SelectedIndex = 0;
            _formData = formData;
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
                imageSelect= ofd.FileName;
            }

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            pbImage.Image = Image.FromFile("images/select.jpg");
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cbGender.SelectedIndex.ToString());
            if(cbGender.SelectedIndex<0)
            {
                MessageBox.Show("Визначтеся із стать");
                return;
            }
            //if(string.IsNullOrEmpty(imageSelect))
            //{
            //    MessageBox.Show("Оберіть фото");
            //    return;
            //}
            var select = cbGender.SelectedItem as MyComboBoxItem;
            
            var user = _formData.Users.SingleOrDefault(x => x.Id == initUserId);
            if (user != null)
            {
                user.FirstName = txtName.Text;
                user.LastName = txtLastName.Text;
                user.Phone = txtPhone.Text;
                user.Password = txtPassword.Text;
                user.Gender = (Gender)select.Id;

                _formData.SaveChanges();
            }
            this.Close();

        }
    }
}
