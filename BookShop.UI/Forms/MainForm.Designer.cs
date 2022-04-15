namespace BookShop.UI.Forms
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblEmployee = new MetroFramework.Controls.MetroLabel();
            this.tglShowMenu = new MetroFramework.Controls.MetroToggle();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShowGames = new MetroFramework.Controls.MetroButton();
            this.btnShowGenres = new MetroFramework.Controls.MetroButton();
            this.btnShowEmployees = new MetroFramework.Controls.MetroButton();
            this.btnShowCustomers = new MetroFramework.Controls.MetroButton();
            this.btnShowOrders = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShowHelp = new MetroFramework.Controls.MetroButton();
            this.btnChangeUser = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.flpShowsMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.dtgOrders = new MetroFramework.Controls.MetroGrid();
            this.OderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderItemsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateClosed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpItems = new System.Windows.Forms.TableLayoutPanel();
            this.lblPositions = new MetroFramework.Controls.MetroLabel();
            this.dtgItems = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblCurrentTime = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.oderButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.lblCount = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnMakeReport = new MetroFramework.Controls.MetroButton();
            this.btnDownloadReport = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flpShowsMenu.SuspendLayout();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrders)).BeginInit();
            this.tlpItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItems)).BeginInit();
            this.oderButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblEmployee.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEmployee.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblEmployee.Location = new System.Drawing.Point(1213, 74);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(415, 25);
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "Адміністратор: Стефурак Роман Миколайович";
            // 
            // tglShowMenu
            // 
            this.tglShowMenu.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tglShowMenu.Checked = true;
            this.tglShowMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tglShowMenu.DisplayStatus = false;
            this.tglShowMenu.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.tglShowMenu.Location = new System.Drawing.Point(125, 119);
            this.tglShowMenu.Margin = new System.Windows.Forms.Padding(4);
            this.tglShowMenu.Name = "tglShowMenu";
            this.tglShowMenu.Size = new System.Drawing.Size(83, 27);
            this.tglShowMenu.TabIndex = 2;
            this.tglShowMenu.Text = "On";
            this.tglShowMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tglShowMenu.UseSelectable = true;
            this.tglShowMenu.CheckedChanged += new System.EventHandler(this.tglShowMenu_CheckedChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(31, 116);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 25);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "МЕНЮ";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.btnShowGames);
            this.flowLayoutPanel1.Controls.Add(this.btnShowGenres);
            this.flowLayoutPanel1.Controls.Add(this.btnShowEmployees);
            this.flowLayoutPanel1.Controls.Add(this.btnShowCustomers);
            this.flowLayoutPanel1.Controls.Add(this.btnShowOrders);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(169, 287);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // btnShowGames
            // 
            this.btnShowGames.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnShowGames.Location = new System.Drawing.Point(4, 4);
            this.btnShowGames.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowGames.Name = "btnShowGames";
            this.btnShowGames.Size = new System.Drawing.Size(159, 49);
            this.btnShowGames.TabIndex = 8;
            this.btnShowGames.Text = "Книги";
            this.btnShowGames.UseSelectable = true;
            this.btnShowGames.Click += new System.EventHandler(this.btnShowGames_Click);
            // 
            // btnShowGenres
            // 
            this.btnShowGenres.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnShowGenres.Location = new System.Drawing.Point(4, 61);
            this.btnShowGenres.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowGenres.Name = "btnShowGenres";
            this.btnShowGenres.Size = new System.Drawing.Size(159, 49);
            this.btnShowGenres.TabIndex = 9;
            this.btnShowGenres.Text = "Жанри";
            this.btnShowGenres.UseSelectable = true;
            this.btnShowGenres.Click += new System.EventHandler(this.btnShowGenres_Click);
            // 
            // btnShowEmployees
            // 
            this.btnShowEmployees.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnShowEmployees.Location = new System.Drawing.Point(4, 118);
            this.btnShowEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowEmployees.Name = "btnShowEmployees";
            this.btnShowEmployees.Size = new System.Drawing.Size(159, 49);
            this.btnShowEmployees.TabIndex = 10;
            this.btnShowEmployees.Text = "Співробітники";
            this.btnShowEmployees.UseSelectable = true;
            this.btnShowEmployees.Click += new System.EventHandler(this.btnShowEmployees_Click);
            // 
            // btnShowCustomers
            // 
            this.btnShowCustomers.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnShowCustomers.Location = new System.Drawing.Point(4, 175);
            this.btnShowCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowCustomers.Name = "btnShowCustomers";
            this.btnShowCustomers.Size = new System.Drawing.Size(159, 49);
            this.btnShowCustomers.TabIndex = 12;
            this.btnShowCustomers.Text = "Клієнти";
            this.btnShowCustomers.UseSelectable = true;
            this.btnShowCustomers.Click += new System.EventHandler(this.btnShowCustomers_Click);
            // 
            // btnShowOrders
            // 
            this.btnShowOrders.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnShowOrders.Location = new System.Drawing.Point(4, 232);
            this.btnShowOrders.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowOrders.Name = "btnShowOrders";
            this.btnShowOrders.Size = new System.Drawing.Size(159, 49);
            this.btnShowOrders.TabIndex = 11;
            this.btnShowOrders.Text = "Всі замовлення";
            this.btnShowOrders.UseSelectable = true;
            this.btnShowOrders.Click += new System.EventHandler(this.btnShowOrders_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.btnShowHelp);
            this.flowLayoutPanel2.Controls.Add(this.btnChangeUser);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 320);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 25);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(169, 116);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // btnShowHelp
            // 
            this.btnShowHelp.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnShowHelp.Location = new System.Drawing.Point(4, 4);
            this.btnShowHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowHelp.Name = "btnShowHelp";
            this.btnShowHelp.Size = new System.Drawing.Size(159, 49);
            this.btnShowHelp.TabIndex = 8;
            this.btnShowHelp.Text = "Довідка";
            this.btnShowHelp.UseSelectable = true;
            this.btnShowHelp.Click += new System.EventHandler(this.btnShowHelp_Click);
            // 
            // btnChangeUser
            // 
            this.btnChangeUser.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnChangeUser.Location = new System.Drawing.Point(4, 61);
            this.btnChangeUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeUser.Name = "btnChangeUser";
            this.btnChangeUser.Size = new System.Drawing.Size(159, 49);
            this.btnChangeUser.TabIndex = 9;
            this.btnChangeUser.Text = "Змінити користувача";
            this.btnChangeUser.UseSelectable = true;
            this.btnChangeUser.Click += new System.EventHandler(this.btnChangeUser_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Controls.Add(this.btnExit);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(181, 4);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(169, 59);
            this.flowLayoutPanel3.TabIndex = 13;
            // 
            // btnExit
            // 
            this.btnExit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnExit.Location = new System.Drawing.Point(4, 4);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(159, 49);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // flpShowsMenu
            // 
            this.flpShowsMenu.AutoSize = true;
            this.flpShowsMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpShowsMenu.Controls.Add(this.flowLayoutPanel1);
            this.flpShowsMenu.Controls.Add(this.flowLayoutPanel2);
            this.flpShowsMenu.Controls.Add(this.flowLayoutPanel3);
            this.flpShowsMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpShowsMenu.Location = new System.Drawing.Point(4, 4);
            this.flpShowsMenu.Margin = new System.Windows.Forms.Padding(4);
            this.flpShowsMenu.Name = "flpShowsMenu";
            this.tlpMain.SetRowSpan(this.flpShowsMenu, 2);
            this.flpShowsMenu.Size = new System.Drawing.Size(177, 461);
            this.flpShowsMenu.TabIndex = 2;
            // 
            // tlpMain
            // 
            this.tlpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.Controls.Add(this.flpShowsMenu, 0, 0);
            this.tlpMain.Controls.Add(this.dtgOrders, 1, 0);
            this.tlpMain.Controls.Add(this.tlpItems, 1, 1);
            this.tlpMain.Location = new System.Drawing.Point(27, 154);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(4);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(1601, 533);
            this.tlpMain.TabIndex = 3;
            // 
            // dtgOrders
            // 
            this.dtgOrders.AllowUserToAddRows = false;
            this.dtgOrders.AllowUserToResizeRows = false;
            this.dtgOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OderID,
            this.OrderEmployee,
            this.Customer,
            this.OrderItemsCount,
            this.OrderDate,
            this.DateClosed,
            this.OrderPrice,
            this.OrderState});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgOrders.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgOrders.EnableHeadersVisualStyles = false;
            this.dtgOrders.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgOrders.Location = new System.Drawing.Point(225, 4);
            this.dtgOrders.Margin = new System.Windows.Forms.Padding(40, 4, 4, 4);
            this.dtgOrders.MultiSelect = false;
            this.dtgOrders.Name = "dtgOrders";
            this.dtgOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgOrders.RowHeadersWidth = 51;
            this.dtgOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgOrders.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgOrders.Size = new System.Drawing.Size(1372, 297);
            this.dtgOrders.TabIndex = 3;
            this.dtgOrders.SelectionChanged += new System.EventHandler(this.dtgOrders_SelectionChanged);
            // 
            // OderID
            // 
            this.OderID.Frozen = true;
            this.OderID.HeaderText = "#";
            this.OderID.MinimumWidth = 6;
            this.OderID.Name = "OderID";
            this.OderID.ReadOnly = true;
            this.OderID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.OderID.Width = 30;
            // 
            // OrderEmployee
            // 
            this.OrderEmployee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderEmployee.HeaderText = "Продавець";
            this.OrderEmployee.MinimumWidth = 6;
            this.OrderEmployee.Name = "OrderEmployee";
            this.OrderEmployee.ReadOnly = true;
            // 
            // Customer
            // 
            this.Customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Customer.HeaderText = "Покупець";
            this.Customer.MinimumWidth = 6;
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            // 
            // OrderItemsCount
            // 
            this.OrderItemsCount.HeaderText = "К-сть позицій";
            this.OrderItemsCount.MinimumWidth = 6;
            this.OrderItemsCount.Name = "OrderItemsCount";
            this.OrderItemsCount.ReadOnly = true;
            this.OrderItemsCount.Width = 125;
            // 
            // OrderDate
            // 
            this.OrderDate.HeaderText = "Дата створення";
            this.OrderDate.MinimumWidth = 6;
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            this.OrderDate.Width = 125;
            // 
            // DateClosed
            // 
            this.DateClosed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateClosed.HeaderText = "Дата закриття";
            this.DateClosed.MinimumWidth = 6;
            this.DateClosed.Name = "DateClosed";
            this.DateClosed.ReadOnly = true;
            // 
            // OrderPrice
            // 
            this.OrderPrice.HeaderText = "Разом";
            this.OrderPrice.MinimumWidth = 6;
            this.OrderPrice.Name = "OrderPrice";
            this.OrderPrice.ReadOnly = true;
            this.OrderPrice.Width = 120;
            // 
            // OrderState
            // 
            this.OrderState.HeaderText = "Стан";
            this.OrderState.MinimumWidth = 6;
            this.OrderState.Name = "OrderState";
            this.OrderState.ReadOnly = true;
            this.OrderState.Width = 160;
            // 
            // tlpItems
            // 
            this.tlpItems.ColumnCount = 1;
            this.tlpItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpItems.Controls.Add(this.lblPositions, 0, 0);
            this.tlpItems.Controls.Add(this.dtgItems, 0, 1);
            this.tlpItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpItems.Location = new System.Drawing.Point(189, 309);
            this.tlpItems.Margin = new System.Windows.Forms.Padding(4);
            this.tlpItems.Name = "tlpItems";
            this.tlpItems.RowCount = 2;
            this.tlpItems.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItems.Size = new System.Drawing.Size(1408, 220);
            this.tlpItems.TabIndex = 20;
            // 
            // lblPositions
            // 
            this.lblPositions.AutoSize = true;
            this.lblPositions.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPositions.Location = new System.Drawing.Point(40, 0);
            this.lblPositions.Margin = new System.Windows.Forms.Padding(40, 0, 4, 0);
            this.lblPositions.Name = "lblPositions";
            this.lblPositions.Size = new System.Drawing.Size(74, 25);
            this.lblPositions.TabIndex = 14;
            this.lblPositions.Text = "Позиції";
            // 
            // dtgItems
            // 
            this.dtgItems.AllowUserToAddRows = false;
            this.dtgItems.AllowUserToDeleteRows = false;
            this.dtgItems.AllowUserToResizeRows = false;
            this.dtgItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgItems.ColumnHeadersHeight = 30;
            this.dtgItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.PriceDate});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgItems.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgItems.EnableHeadersVisualStyles = false;
            this.dtgItems.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgItems.Location = new System.Drawing.Point(40, 34);
            this.dtgItems.Margin = new System.Windows.Forms.Padding(40, 4, 4, 4);
            this.dtgItems.MultiSelect = false;
            this.dtgItems.Name = "dtgItems";
            this.dtgItems.ReadOnly = true;
            this.dtgItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgItems.RowHeadersWidth = 51;
            this.dtgItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgItems.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgItems.Size = new System.Drawing.Size(1364, 182);
            this.dtgItems.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 20;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Найменування";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // PriceDate
            // 
            this.PriceDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PriceDate.HeaderText = "Ціна";
            this.PriceDate.MinimumWidth = 6;
            this.PriceDate.Name = "PriceDate";
            this.PriceDate.ReadOnly = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(252, 116);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 25);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "ПРОДАЖІ";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCurrentTime.Location = new System.Drawing.Point(27, 729);
            this.lblCurrentTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(128, 25);
            this.lblCurrentTime.TabIndex = 5;
            this.lblCurrentTime.Text = "Поточний час:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(1333, 116);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 25);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Детально";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroToggle1
            // 
            this.metroToggle1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroToggle1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroToggle1.Checked = true;
            this.metroToggle1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroToggle1.DisplayStatus = false;
            this.metroToggle1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroToggle1.Location = new System.Drawing.Point(1465, 119);
            this.metroToggle1.Margin = new System.Windows.Forms.Padding(4);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(163, 27);
            this.metroToggle1.TabIndex = 6;
            this.metroToggle1.Text = "On";
            this.metroToggle1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroToggle1.UseSelectable = true;
            this.metroToggle1.CheckedChanged += new System.EventHandler(this.metroToggle1_CheckedChanged);
            // 
            // oderButtons
            // 
            this.oderButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.oderButtons.AutoSize = true;
            this.oderButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.oderButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oderButtons.Controls.Add(this.btnAdd);
            this.oderButtons.Controls.Add(this.btnEdit);
            this.oderButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.oderButtons.Location = new System.Drawing.Point(1287, 700);
            this.oderButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 25);
            this.oderButtons.Name = "oderButtons";
            this.oderButtons.Size = new System.Drawing.Size(336, 59);
            this.oderButtons.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAdd.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnAdd.Location = new System.Drawing.Point(171, 4);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 49);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.brnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEdit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnEdit.Location = new System.Drawing.Point(4, 4);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(159, 49);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Редагувати";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblCount
            // 
            this.lblCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCount.AutoSize = true;
            this.lblCount.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCount.Location = new System.Drawing.Point(580, 116);
            this.lblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(22, 25);
            this.lblCount.TabIndex = 10;
            this.lblCount.Text = "0";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(479, 116);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(90, 25);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Кількість: ";
            // 
            // btnMakeReport
            // 
            this.btnMakeReport.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnMakeReport.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnMakeReport.Location = new System.Drawing.Point(744, 23);
            this.btnMakeReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakeReport.Name = "btnMakeReport";
            this.btnMakeReport.Size = new System.Drawing.Size(245, 49);
            this.btnMakeReport.TabIndex = 10;
            this.btnMakeReport.Text = "Сформувати звіт";
            this.btnMakeReport.UseSelectable = true;
            this.btnMakeReport.Click += new System.EventHandler(this.btnMakeReport_Click);
            // 
            // btnDownloadReport
            // 
            this.btnDownloadReport.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDownloadReport.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnDownloadReport.Location = new System.Drawing.Point(491, 23);
            this.btnDownloadReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnDownloadReport.Name = "btnDownloadReport";
            this.btnDownloadReport.Size = new System.Drawing.Size(245, 49);
            this.btnDownloadReport.TabIndex = 11;
            this.btnDownloadReport.Text = "Скачати договір";
            this.btnDownloadReport.UseSelectable = true;
            this.btnDownloadReport.Click += new System.EventHandler(this.btnDownloadReport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1655, 784);
            this.Controls.Add(this.btnDownloadReport);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btnMakeReport);
            this.Controls.Add(this.oderButtons);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroToggle1);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tglShowMenu);
            this.Controls.Add(this.lblEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1655, 729);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "BookShop | Головне вікно";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flpShowsMenu.ResumeLayout(false);
            this.flpShowsMenu.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrders)).EndInit();
            this.tlpItems.ResumeLayout(false);
            this.tlpItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItems)).EndInit();
            this.oderButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblEmployee;
        private MetroFramework.Controls.MetroToggle tglShowMenu;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroButton btnShowGames;
        private MetroFramework.Controls.MetroButton btnShowGenres;
        private MetroFramework.Controls.MetroButton btnShowEmployees;
        private MetroFramework.Controls.MetroButton btnShowOrders;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MetroFramework.Controls.MetroButton btnShowHelp;
        private MetroFramework.Controls.MetroButton btnChangeUser;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private MetroFramework.Controls.MetroButton btnExit;
        private System.Windows.Forms.FlowLayoutPanel flpShowsMenu;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private MetroFramework.Controls.MetroGrid dtgOrders;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblCurrentTime;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private System.Windows.Forms.TableLayoutPanel tlpItems;
        private MetroFramework.Controls.MetroLabel lblPositions;
        private MetroFramework.Controls.MetroGrid dtgItems;
        private System.Windows.Forms.FlowLayoutPanel oderButtons;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnShowCustomers;
        private MetroFramework.Controls.MetroLabel lblCount;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnMakeReport;
        private MetroFramework.Controls.MetroButton btnDownloadReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn OderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderItemsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateClosed;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderState;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceDate;
    }
}