namespace BookShop.UI.Forms.EditForms
{
    partial class EditProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProductForm));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtTitle = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtDesc = new MetroFramework.Controls.MetroTextBox();
            this.btnSubmit = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnRemoveImage = new MetroFramework.Controls.MetroButton();
            this.btnLoadImage = new MetroFramework.Controls.MetroButton();
            this.dtpCreated = new MetroFramework.Controls.MetroDateTime();
            this.dtpProductCreated = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.dtgPrices = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsExist = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddPrice = new MetroFramework.Controls.MetroButton();
            this.txtNewPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.btnAddNewGenre = new MetroFramework.Controls.MetroButton();
            this.btnRemoveGanre = new MetroFramework.Controls.MetroButton();
            this.picGame = new System.Windows.Forms.PictureBox();
            this.lstExistedGenres = new MetroFramework.Controls.MetroListView();
            this.lstGameGenres = new MetroFramework.Controls.MetroListView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrices)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGame)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(432, 80);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(132, 25);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Найменування";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.Location = new System.Drawing.Point(601, 80);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(20, 25);
            this.metroLabel10.TabIndex = 26;
            this.metroLabel10.Text = "*";
            // 
            // txtTitle
            // 
            // 
            // 
            // 
            this.txtTitle.CustomButton.Image = null;
            this.txtTitle.CustomButton.Location = new System.Drawing.Point(625, 2);
            this.txtTitle.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.CustomButton.Name = "";
            this.txtTitle.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTitle.CustomButton.TabIndex = 1;
            this.txtTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTitle.CustomButton.UseSelectable = true;
            this.txtTitle.CustomButton.Visible = false;
            this.txtTitle.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTitle.Lines = new string[0];
            this.txtTitle.Location = new System.Drawing.Point(432, 114);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.MaxLength = 60;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitle.SelectedText = "";
            this.txtTitle.SelectionLength = 0;
            this.txtTitle.SelectionStart = 0;
            this.txtTitle.ShortcutsEnabled = true;
            this.txtTitle.Size = new System.Drawing.Size(657, 34);
            this.txtTitle.TabIndex = 25;
            this.txtTitle.UseSelectable = true;
            this.txtTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(432, 159);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 25);
            this.metroLabel2.TabIndex = 27;
            this.metroLabel2.Text = "Опис";
            // 
            // txtDesc
            // 
            // 
            // 
            // 
            this.txtDesc.CustomButton.Image = null;
            this.txtDesc.CustomButton.Location = new System.Drawing.Point(433, 1);
            this.txtDesc.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesc.CustomButton.Name = "";
            this.txtDesc.CustomButton.Size = new System.Drawing.Size(223, 223);
            this.txtDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDesc.CustomButton.TabIndex = 1;
            this.txtDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDesc.CustomButton.UseSelectable = true;
            this.txtDesc.CustomButton.Visible = false;
            this.txtDesc.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDesc.Lines = new string[0];
            this.txtDesc.Location = new System.Drawing.Point(432, 193);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesc.MaxLength = 256;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDesc.SelectedText = "";
            this.txtDesc.SelectionLength = 0;
            this.txtDesc.SelectionStart = 0;
            this.txtDesc.ShortcutsEnabled = true;
            this.txtDesc.Size = new System.Drawing.Size(657, 225);
            this.txtDesc.TabIndex = 28;
            this.txtDesc.UseSelectable = true;
            this.txtDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSubmit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSubmit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSubmit.Location = new System.Drawing.Point(201, 4);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(253, 33);
            this.btnSubmit.TabIndex = 33;
            this.btnSubmit.Text = "Підтвердити";
            this.btnSubmit.UseSelectable = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCancel.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnCancel.Location = new System.Drawing.Point(4, 4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(189, 33);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Відміна";
            this.btnCancel.UseSelectable = true;
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnRemoveImage.Location = new System.Drawing.Point(31, 385);
            this.btnRemoveImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(139, 33);
            this.btnRemoveImage.TabIndex = 31;
            this.btnRemoveImage.Text = "Видалити";
            this.btnRemoveImage.UseSelectable = true;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnLoadImage.Location = new System.Drawing.Point(177, 385);
            this.btnLoadImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(232, 33);
            this.btnLoadImage.TabIndex = 30;
            this.btnLoadImage.Text = "Загрузити з ...";
            this.btnLoadImage.UseSelectable = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // dtpCreated
            // 
            this.dtpCreated.Location = new System.Drawing.Point(1103, 485);
            this.dtpCreated.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCreated.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtpCreated.Name = "dtpCreated";
            this.dtpCreated.Size = new System.Drawing.Size(459, 30);
            this.dtpCreated.TabIndex = 34;
            // 
            // dtpProductCreated
            // 
            this.dtpProductCreated.Location = new System.Drawing.Point(1103, 559);
            this.dtpProductCreated.Margin = new System.Windows.Forms.Padding(4);
            this.dtpProductCreated.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtpProductCreated.Name = "dtpProductCreated";
            this.dtpProductCreated.Size = new System.Drawing.Size(459, 30);
            this.dtpProductCreated.TabIndex = 35;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(1097, 446);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(142, 25);
            this.metroLabel4.TabIndex = 36;
            this.metroLabel4.Text = "Дата додавання";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(1097, 524);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(90, 25);
            this.metroLabel5.TabIndex = 37;
            this.metroLabel5.Text = "Написана";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(1213, 524);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(20, 25);
            this.metroLabel6.TabIndex = 38;
            this.metroLabel6.Text = "*";
            // 
            // dtgPrices
            // 
            this.dtgPrices.AllowUserToAddRows = false;
            this.dtgPrices.AllowUserToDeleteRows = false;
            this.dtgPrices.AllowUserToResizeRows = false;
            this.dtgPrices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgPrices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgPrices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgPrices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPrices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPrices.ColumnHeadersHeight = 30;
            this.dtgPrices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.PriceDate,
            this.IsExist});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPrices.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgPrices.EnableHeadersVisualStyles = false;
            this.dtgPrices.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgPrices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgPrices.Location = new System.Drawing.Point(1097, 153);
            this.dtgPrices.Margin = new System.Windows.Forms.Padding(4);
            this.dtgPrices.MultiSelect = false;
            this.dtgPrices.Name = "dtgPrices";
            this.dtgPrices.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPrices.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgPrices.RowHeadersWidth = 51;
            this.dtgPrices.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgPrices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPrices.Size = new System.Drawing.Size(465, 266);
            this.dtgPrices.TabIndex = 39;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DividerWidth = 1;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 15;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Ціна";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // PriceDate
            // 
            this.PriceDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PriceDate.HeaderText = "Дата";
            this.PriceDate.MinimumWidth = 6;
            this.PriceDate.Name = "PriceDate";
            this.PriceDate.ReadOnly = true;
            // 
            // IsExist
            // 
            this.IsExist.HeaderText = "В наявності";
            this.IsExist.MinimumWidth = 6;
            this.IsExist.Name = "IsExist";
            this.IsExist.Width = 125;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(1097, 74);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(149, 25);
            this.metroLabel3.TabIndex = 40;
            this.metroLabel3.Text = "Історія змін ціни:";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnSubmit);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1103, 604);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(460, 43);
            this.flowLayoutPanel1.TabIndex = 41;
            // 
            // btnAddPrice
            // 
            this.btnAddPrice.Location = new System.Drawing.Point(1097, 112);
            this.btnAddPrice.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPrice.Name = "btnAddPrice";
            this.btnAddPrice.Size = new System.Drawing.Size(465, 33);
            this.btnAddPrice.TabIndex = 42;
            this.btnAddPrice.Text = "Додати";
            this.btnAddPrice.UseSelectable = true;
            this.btnAddPrice.Click += new System.EventHandler(this.btnAddPrice_Click);
            // 
            // txtNewPrice
            // 
            // 
            // 
            // 
            this.txtNewPrice.CustomButton.Image = null;
            this.txtNewPrice.CustomButton.Location = new System.Drawing.Point(154, 2);
            this.txtNewPrice.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPrice.CustomButton.Name = "";
            this.txtNewPrice.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtNewPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewPrice.CustomButton.TabIndex = 1;
            this.txtNewPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewPrice.CustomButton.UseSelectable = true;
            this.txtNewPrice.CustomButton.Visible = false;
            this.txtNewPrice.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNewPrice.Lines = new string[0];
            this.txtNewPrice.Location = new System.Drawing.Point(1383, 76);
            this.txtNewPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPrice.MaxLength = 32767;
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.PasswordChar = '\0';
            this.txtNewPrice.PromptText = "Нова ціна";
            this.txtNewPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewPrice.SelectedText = "";
            this.txtNewPrice.SelectionLength = 0;
            this.txtNewPrice.SelectionStart = 0;
            this.txtNewPrice.ShortcutsEnabled = true;
            this.txtNewPrice.Size = new System.Drawing.Size(180, 28);
            this.txtNewPrice.TabIndex = 43;
            this.txtNewPrice.UseSelectable = true;
            this.txtNewPrice.WaterMark = "Нова ціна";
            this.txtNewPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(31, 450);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(96, 25);
            this.metroLabel7.TabIndex = 46;
            this.metroLabel7.Text = "Всі жанри:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(596, 450);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(131, 25);
            this.metroLabel8.TabIndex = 47;
            this.metroLabel8.Text = "Додані жанри:";
            // 
            // btnAddNewGenre
            // 
            this.btnAddNewGenre.BackgroundImage = global::BookShop.UI.Properties.Resources.right;
            this.btnAddNewGenre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddNewGenre.Enabled = false;
            this.btnAddNewGenre.Location = new System.Drawing.Point(539, 485);
            this.btnAddNewGenre.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewGenre.Name = "btnAddNewGenre";
            this.btnAddNewGenre.Size = new System.Drawing.Size(49, 78);
            this.btnAddNewGenre.TabIndex = 50;
            this.btnAddNewGenre.UseSelectable = true;
            this.btnAddNewGenre.Click += new System.EventHandler(this.btnAddNewGenre_Click);
            // 
            // btnRemoveGanre
            // 
            this.btnRemoveGanre.BackgroundImage = global::BookShop.UI.Properties.Resources.left;
            this.btnRemoveGanre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRemoveGanre.Enabled = false;
            this.btnRemoveGanre.Location = new System.Drawing.Point(539, 570);
            this.btnRemoveGanre.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveGanre.Name = "btnRemoveGanre";
            this.btnRemoveGanre.Size = new System.Drawing.Size(49, 78);
            this.btnRemoveGanre.TabIndex = 51;
            this.btnRemoveGanre.UseSelectable = true;
            this.btnRemoveGanre.Click += new System.EventHandler(this.btnRemoveGanre_Click);
            // 
            // picGame
            // 
            this.picGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGame.Location = new System.Drawing.Point(31, 78);
            this.picGame.Margin = new System.Windows.Forms.Padding(4);
            this.picGame.Name = "picGame";
            this.picGame.Size = new System.Drawing.Size(378, 297);
            this.picGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGame.TabIndex = 0;
            this.picGame.TabStop = false;
            // 
            // lstExistedGenres
            // 
            this.lstExistedGenres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstExistedGenres.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lstExistedGenres.FullRowSelect = true;
            this.lstExistedGenres.Location = new System.Drawing.Point(31, 485);
            this.lstExistedGenres.Margin = new System.Windows.Forms.Padding(4);
            this.lstExistedGenres.MultiSelect = false;
            this.lstExistedGenres.Name = "lstExistedGenres";
            this.lstExistedGenres.OwnerDraw = true;
            this.lstExistedGenres.ShowGroups = false;
            this.lstExistedGenres.Size = new System.Drawing.Size(499, 162);
            this.lstExistedGenres.TabIndex = 52;
            this.lstExistedGenres.UseCompatibleStateImageBehavior = false;
            this.lstExistedGenres.UseSelectable = true;
            this.lstExistedGenres.View = System.Windows.Forms.View.SmallIcon;
            this.lstExistedGenres.SelectedIndexChanged += new System.EventHandler(this.lstExistedGenres_SelectedIndexChanged);
            // 
            // lstGameGenres
            // 
            this.lstGameGenres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstGameGenres.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lstGameGenres.FullRowSelect = true;
            this.lstGameGenres.Location = new System.Drawing.Point(596, 485);
            this.lstGameGenres.Margin = new System.Windows.Forms.Padding(4);
            this.lstGameGenres.MultiSelect = false;
            this.lstGameGenres.Name = "lstGameGenres";
            this.lstGameGenres.OwnerDraw = true;
            this.lstGameGenres.ShowGroups = false;
            this.lstGameGenres.Size = new System.Drawing.Size(499, 162);
            this.lstGameGenres.TabIndex = 53;
            this.lstGameGenres.UseCompatibleStateImageBehavior = false;
            this.lstGameGenres.UseSelectable = true;
            this.lstGameGenres.View = System.Windows.Forms.View.SmallIcon;
            this.lstGameGenres.SelectedIndexChanged += new System.EventHandler(this.lstGameGenres_SelectedIndexChanged);
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1593, 682);
            this.Controls.Add(this.lstGameGenres);
            this.Controls.Add(this.lstExistedGenres);
            this.Controls.Add(this.btnRemoveGanre);
            this.Controls.Add(this.btnAddNewGenre);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtNewPrice);
            this.Controls.Add(this.btnAddPrice);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.dtgPrices);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.dtpProductCreated);
            this.Controls.Add(this.dtpCreated);
            this.Controls.Add(this.btnRemoveImage);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.picGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditProductForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Text = "Редагування книги";
            this.Load += new System.EventHandler(this.EditProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrices)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGame;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtTitle;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtDesc;
        private MetroFramework.Controls.MetroButton btnSubmit;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnRemoveImage;
        private MetroFramework.Controls.MetroButton btnLoadImage;
        private MetroFramework.Controls.MetroDateTime dtpCreated;
        private MetroFramework.Controls.MetroDateTime dtpProductCreated;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroGrid dtgPrices;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroButton btnAddPrice;
        private MetroFramework.Controls.MetroTextBox txtNewPrice;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton btnAddNewGenre;
        private MetroFramework.Controls.MetroButton btnRemoveGanre;
        private MetroFramework.Controls.MetroListView lstExistedGenres;
        private MetroFramework.Controls.MetroListView lstGameGenres;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsExist;
    }
}