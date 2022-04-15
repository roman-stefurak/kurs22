using BookShop.Core.Services;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.IO;
using System.Windows.Forms;

namespace BookShop.UI.Forms.EditForms
{
    public partial class ReportMakerForm : MetroForm
    {
        private readonly ReportService _service = new ReportService(Settings.Context);

        private ReportType _selectedReportType;
        private string _selectedPath;

        public ReportMakerForm()
        {
            InitializeComponent();
        }

        private void ReportMakerForm_Load(object sender, EventArgs e)
        {

        }

        private void RButton_click(object sender, EventArgs e)
        {
            _selectedReportType = (ReportType)Enum.Parse(typeof(ReportType), (sender as RadioButton).Tag.ToString());
        }

        private void cmbStart_CheckedChanged(object sender, EventArgs e)
        {
            dtpStart.Enabled = cmbStart.Checked;
        }

        private void cmbEnd_CheckedChanged(object sender, EventArgs e)
        {
            dtpEnd.Enabled = cmbEnd.Checked;
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _selectedPath = dialog.SelectedPath;
                txtFolderPath.Text = _selectedPath;
            }
        }

        private void btnSaveReport_Click(object sender, EventArgs e)
        {
            DateTime? start = default;
            DateTime? end = default;

            if (dtpStart.Enabled)
                start = dtpStart.Value;

            if (dtpEnd.Enabled)
                end = dtpEnd.Value;

            if (_service.CreateReport(_selectedReportType, _selectedPath, Settings.CurrentUser.Surname, start, end))
            {
                MetroMessageBox.Show(this, "Звіт успішно сформовано", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MetroMessageBox.Show(this, "Не вдалося сформувати звіт", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFolderPath_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Path.GetFullPath(txtFolderPath.Text);

                _selectedPath = txtFolderPath.Text;
                btnSaveReport.Enabled = true;
            }
            catch
            {
                _selectedPath = string.Empty;
                btnSaveReport.Enabled = false;
            }
        }
    }
}