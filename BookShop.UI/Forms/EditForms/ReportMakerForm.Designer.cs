
namespace BookShop.UI.Forms.EditForms
{
    partial class ReportMakerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton3 = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnSaveReport = new MetroFramework.Controls.MetroButton();
            this.cmbStart = new MetroFramework.Controls.MetroCheckBox();
            this.cmbEnd = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtFolderPath = new MetroFramework.Controls.MetroTextBox();
            this.btnSelectFolder = new MetroFramework.Controls.MetroButton();
            this.dtpStart = new MetroFramework.Controls.MetroDateTime();
            this.dtpEnd = new MetroFramework.Controls.MetroDateTime();
            this.SuspendLayout();
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Checked = true;
            this.metroRadioButton1.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.metroRadioButton1.Location = new System.Drawing.Point(209, 100);
            this.metroRadioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(159, 25);
            this.metroRadioButton1.TabIndex = 0;
            this.metroRadioButton1.TabStop = true;
            this.metroRadioButton1.Tag = "1";
            this.metroRadioButton1.Text = "Рейтинг послуг";
            this.metroRadioButton1.UseSelectable = true;
            this.metroRadioButton1.Click += new System.EventHandler(this.RButton_click);
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.metroRadioButton2.Location = new System.Drawing.Point(483, 100);
            this.metroRadioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(169, 25);
            this.metroRadioButton2.TabIndex = 1;
            this.metroRadioButton2.Tag = "2";
            this.metroRadioButton2.Text = "Рейтинг клієнтів";
            this.metroRadioButton2.UseSelectable = true;
            this.metroRadioButton2.Click += new System.EventHandler(this.RButton_click);
            // 
            // metroRadioButton3
            // 
            this.metroRadioButton3.AutoSize = true;
            this.metroRadioButton3.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.metroRadioButton3.Location = new System.Drawing.Point(764, 100);
            this.metroRadioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.metroRadioButton3.Name = "metroRadioButton3";
            this.metroRadioButton3.Size = new System.Drawing.Size(162, 25);
            this.metroRadioButton3.TabIndex = 2;
            this.metroRadioButton3.Tag = "3";
            this.metroRadioButton3.Text = "Всі замовлення";
            this.metroRadioButton3.UseSelectable = true;
            this.metroRadioButton3.Click += new System.EventHandler(this.RButton_click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(31, 100);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 25);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Тип звіту:";
            // 
            // btnSaveReport
            // 
            this.btnSaveReport.Enabled = false;
            this.btnSaveReport.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSaveReport.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSaveReport.Location = new System.Drawing.Point(717, 246);
            this.btnSaveReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveReport.Name = "btnSaveReport";
            this.btnSaveReport.Size = new System.Drawing.Size(245, 76);
            this.btnSaveReport.TabIndex = 12;
            this.btnSaveReport.Text = "Зберегти";
            this.btnSaveReport.UseSelectable = true;
            this.btnSaveReport.Click += new System.EventHandler(this.btnSaveReport_Click);
            // 
            // cmbStart
            // 
            this.cmbStart.AutoSize = true;
            this.cmbStart.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.cmbStart.Location = new System.Drawing.Point(152, 246);
            this.cmbStart.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStart.Name = "cmbStart";
            this.cmbStart.Size = new System.Drawing.Size(99, 25);
            this.cmbStart.TabIndex = 13;
            this.cmbStart.Text = "Дата від";
            this.cmbStart.UseSelectable = true;
            this.cmbStart.CheckedChanged += new System.EventHandler(this.cmbStart_CheckedChanged);
            // 
            // cmbEnd
            // 
            this.cmbEnd.AutoSize = true;
            this.cmbEnd.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.cmbEnd.Location = new System.Drawing.Point(152, 289);
            this.cmbEnd.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEnd.Name = "cmbEnd";
            this.cmbEnd.Size = new System.Drawing.Size(95, 25);
            this.cmbEnd.TabIndex = 14;
            this.cmbEnd.Text = "Дата до";
            this.cmbEnd.UseSelectable = true;
            this.cmbEnd.CheckedChanged += new System.EventHandler(this.cmbEnd_CheckedChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(80, 154);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 25);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Папка:";
            // 
            // txtFolderPath
            // 
            // 
            // 
            // 
            this.txtFolderPath.CustomButton.Image = null;
            this.txtFolderPath.CustomButton.Location = new System.Drawing.Point(595, 1);
            this.txtFolderPath.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtFolderPath.CustomButton.Name = "";
            this.txtFolderPath.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtFolderPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFolderPath.CustomButton.TabIndex = 1;
            this.txtFolderPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFolderPath.CustomButton.UseSelectable = true;
            this.txtFolderPath.CustomButton.Visible = false;
            this.txtFolderPath.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFolderPath.Lines = new string[0];
            this.txtFolderPath.Location = new System.Drawing.Point(173, 154);
            this.txtFolderPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtFolderPath.MaxLength = 32767;
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.PasswordChar = '\0';
            this.txtFolderPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFolderPath.SelectedText = "";
            this.txtFolderPath.SelectionLength = 0;
            this.txtFolderPath.SelectionStart = 0;
            this.txtFolderPath.ShortcutsEnabled = true;
            this.txtFolderPath.Size = new System.Drawing.Size(625, 31);
            this.txtFolderPath.TabIndex = 16;
            this.txtFolderPath.UseSelectable = true;
            this.txtFolderPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFolderPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFolderPath.TextChanged += new System.EventHandler(this.txtFolderPath_TextChanged);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSelectFolder.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSelectFolder.Location = new System.Drawing.Point(808, 154);
            this.btnSelectFolder.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(155, 31);
            this.btnSelectFolder.TabIndex = 17;
            this.btnSelectFolder.Text = "Вибрати";
            this.btnSelectFolder.UseSelectable = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.Enabled = false;
            this.dtpStart.Location = new System.Drawing.Point(276, 244);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStart.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(265, 30);
            this.dtpStart.TabIndex = 18;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Enabled = false;
            this.dtpEnd.Location = new System.Drawing.Point(276, 287);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEnd.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(265, 30);
            this.dtpEnd.TabIndex = 19;
            // 
            // ReportMakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 351);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cmbEnd);
            this.Controls.Add(this.cmbStart);
            this.Controls.Add(this.btnSaveReport);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroRadioButton1);
            this.Controls.Add(this.metroRadioButton3);
            this.Controls.Add(this.metroRadioButton2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ReportMakerForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Text = "Формування звіту";
            this.Load += new System.EventHandler(this.ReportMakerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnSaveReport;
        private MetroFramework.Controls.MetroCheckBox cmbStart;
        private MetroFramework.Controls.MetroCheckBox cmbEnd;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtFolderPath;
        private MetroFramework.Controls.MetroButton btnSelectFolder;
        private MetroFramework.Controls.MetroDateTime dtpStart;
        private MetroFramework.Controls.MetroDateTime dtpEnd;
    }
}