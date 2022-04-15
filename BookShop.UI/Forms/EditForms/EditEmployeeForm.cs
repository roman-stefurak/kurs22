using BookShop.Core.Models;
using BookShop.Core.Other;
using BookShop.UI.Utility;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;

namespace BookShop.UI.Forms.EditForms
{
    public partial class EditEmployeeForm : MetroForm
    {
        private readonly Employee _employee;

        public EditEmployeeForm(Employee employee)
        {
            InitializeComponent();

            _employee = employee;
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            dtpBirthday.MaxDate = DateTime.Now.AddYears(-18);

            txtSurname.Text = _employee.Surname;
            txtName.Text = _employee.Name;
            txtPatr.Text = _employee.Patronymic;
            if (DateTime.TryParse(_employee.Birthday, out DateTime dtp))
                dtpBirthday.Value = dtp;
            txtEmail.Text = _employee.Email;
            txtPhone.Text = _employee.Phone;

            try
            {
                if (_employee.Photo != null && _employee.Photo.Length != 0)
                    using (var ms = new MemoryStream(_employee.Photo))
                    {
                        picImage.Image = Image.FromStream(ms);
                    }
            }
            catch { }

            switch ((UserType)_employee.UserType)
            {
                case UserType.Admin: rbAdmin.Checked = true; break;
                case UserType.Employee: rbUser.Checked = true; break;
                default: break;
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            picImage.Image.Dispose();
            picImage.Image = null;
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                picImage.Image = Image.FromFile(openFD.FileName);
                _employee.Photo = File.ReadAllBytes(openFD.FileName);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Helpers.IsAnyEmpty(string.IsNullOrEmpty, txtLogin.Text, txtPassword.Text, txtSurname.Text, txtName.Text, txtPhone.Text) || (!rbAdmin.Checked && !rbUser.Checked))
            {
                MetroMessageBox.Show(this, "Заповніть обов'язкові поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
                return;
            }

            try
            {
                if (!string.IsNullOrEmpty(txtEmail.Text))
                    new MailAddress(txtEmail.Text);
            }
            catch
            {
                MetroMessageBox.Show(this, "Неправильно вказана пошта", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _employee.Login = txtLogin.Text.Trim();
            _employee.PasswordHash = Helpers.CreateHash(txtPassword.Text.Trim());

            _employee.Surname = txtSurname.Text.Trim();
            _employee.Name = txtName.Text.Trim();
            _employee.Patronymic = txtPatr.Text.Trim();
            _employee.Phone = txtPhone.Text.Trim();
            _employee.Email = txtEmail.Text.Trim();
            _employee.Birthday = dtpBirthday.Value.ToShortDateString();
            _employee.UserType = (long)(rbAdmin.Checked ? UserType.Admin : (rbUser.Checked ? UserType.Employee : UserType.None));
        }
    }
}