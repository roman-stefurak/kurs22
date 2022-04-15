using BookShop.Core.Other;
using BookShop.Core.Services;
using BookShop.UI.Forms;
using BookShop.UI.Forms.EditForms;
using BookShop.UI.Utility;
using MetroFramework;
using MetroFramework.Forms;
using System;

namespace BookShop.UI
{
    public partial class AuthForm : MetroForm
    {
        private const string EMPTY_FIELDS = "Заповніть всі поля";
        private const string WRONG_DATA = "Неправильний логін абр пароль";

        private readonly AuthService _authService;

        public AuthForm()
        {
            InitializeComponent();

            _authService = new AuthService(Settings.Context);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Helpers.IsAnyEmpty(string.IsNullOrEmpty, txtLogin.Text.Trim(), txtPassword.Text.Trim()))
            {
                lblStatus.Text = EMPTY_FIELDS;
                return;
            }

            try
            {
                if (_authService.LogIn(txtLogin.Text.Trim(), Helpers.CreateHash(txtPassword.Text.Trim()), out User user))
                {
                    Settings.CurrentUser = user;
                    this.Visible = false;

                    txtLogin.Text = string.Empty;
                    txtPassword.Text = string.Empty;

                    new MainForm().ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    lblStatus.Text = WRONG_DATA;
                }
            }
            catch (Exception exc)
            {
                MetroMessageBox.Show(this, exc.Message, "Помилка", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}
