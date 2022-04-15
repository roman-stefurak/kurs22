using BookShop.Core.Other;
using BookShop.Core.Services;
using BookShop.UI.Forms.EditForms;
using BookShop.UI.Properties;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BookShop.UI.Forms
{
    public partial class MainForm : MetroForm
    {
        private const string ORDER_EDITING = "Редагується";
        private const string ORDER_CLOSED = "Закритий";

        private readonly EmployeesService _empService = new EmployeesService(Settings.Context);

        private Record[] _items;

        private System.Timers.Timer _timer;

        public MainForm()
        {
            InitializeComponent();

            Application.ApplicationExit += Application_ApplicationExit;
            this.FormClosing += MainForm_FormClosing;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _timer?.Stop();
            _timer?.Dispose();
        }

        private void tglShowMenu_CheckedChanged(object sender, System.EventArgs e)
        {
            if (flpShowsMenu.Visible)
            {
                flpShowsMenu.Visible = false;
                dtgOrders.Margin = new Padding(0);

                lblPositions.Margin = new Padding(0);
                dtgItems.Margin = new Padding(0);
            }
            else
            {
                flpShowsMenu.Visible = true;
                dtgOrders.Margin = new Padding(30, 0, 0, 0);

                lblPositions.Margin = new Padding(30, 0, 0, 0);
                dtgItems.Margin = new Padding(30, 0, 0, 0);
            }
        }


        private void UpdateOrdersDtg()
        {
            dtgOrders.Rows.Clear();
            _items = _empService.GetOrders(Settings.CurrentUser.ID);

            if (_items != null)
            {
                foreach (var order in _items)
                {
                    dtgOrders.Rows.Add(order.ID, order.EmployeeFullName, order.CustomerFullName,
                                       order.Items.Count, order.DateCreated, order.DateClosed, order.Items.Sum(x => x.Price).ToString("N2") + " грн.",
                                       order.State == RecordState.Editing ? ORDER_EDITING : ORDER_CLOSED);
                }
            }
        }

        private void dtgOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgOrders.SelectedRows.Count != 0)
            {
                dtgItems.Rows.Clear();

                var recordID = Convert.ToInt32(dtgOrders.SelectedRows[0].Cells[0].FormattedValue);
                var record = _items.First(x => x.ID == recordID);

                btnEdit.Enabled = record.State != RecordState.Closed ? true : false;

                foreach (var item in record.Items)
                {
                    dtgItems.Rows.Add(item.ID, item.Name, item.Price.ToString("N2") + " грн.");
                }
            }
            else if (dtgOrders.Rows.Count == 0)
            {
                btnEdit.Enabled = false;
                dtgItems.Rows.Clear();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _timer = new System.Timers.Timer();
            _timer.Elapsed += (s, _) => lblCurrentTime.Invoke(new Action(() =>
            {
                try
                {
                    lblCurrentTime.Text = $"Поточний час: {DateTime.Now.ToLongTimeString()}";
                }
                catch { }
            }));
            _timer.Interval = 1_000;
            _timer.Start();

            lblEmployee.Text = Settings.CurrentUser.UserType == UserType.Admin ? "Адміністратор: " : "Співробітник: ";
            lblEmployee.Text += string.Join(" ", Settings.CurrentUser.Surname, Settings.CurrentUser.Name, Settings.CurrentUser.Patronymic);

            if (Settings.CurrentUser.UserType == UserType.Employee)
                oderButtons.Enabled = false;

            UpdateOrdersDtg();
            UpdateCounter();
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (tlpItems.Visible)
            {
                tlpItems.Visible = false;

                tlpItems.SetRowSpan(dtgOrders, 2);
            }
            else
            {
                tlpItems.Visible = true;

                tlpItems.SetRowSpan(dtgOrders, 1);
            }
        }

        private void btnShowGames_Click(object sender, EventArgs e)
        {
            new ProductsForm().ShowDialog();
        }

        private void btnShowGenres_Click(object sender, EventArgs e)
        {
            new GenresForm().ShowDialog();
        }

        private void btnShowEmployees_Click(object sender, EventArgs e)
        {
            new EmployeesForm().ShowDialog();
        }

        private void btnShowOrders_Click(object sender, EventArgs e)
        {
            new OrdersForm().ShowDialog();
        }

        private void btnShowHelp_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Ця програма надає користувачеві можливість організувати зберігання інформації про" +
                " облік підприємства \n\n © Roman Stefurak", "Довідка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool isChangingUser;
        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            isChangingUser = true;
            this.Close();
        }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            _timer?.Stop();
            _timer?.Dispose();
        }

        private void UpdateCounter()
        {
            lblCount.Text = dtgOrders.Rows.Count.ToString();
        }

        private void brnAdd_Click(object sender, EventArgs e)
        {
            var record = new Record();

            var result = new EditOrderForm(record).ShowDialog();

            if (result == DialogResult.OK)
            {
                record.EmployeeID = Settings.CurrentUser.ID;

                _empService.AddOrder(Settings.CurrentUser.ID, record);

                MetroMessageBox.Show(this, "Замовлення успішно додано", "Довідка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateOrdersDtg();
                UpdateCounter();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var record = _items.FirstOrDefault(x => x.ID == Convert.ToInt32(dtgOrders.SelectedRows[0].Cells[0].FormattedValue));

            if (record != null)
            {
                var result = new EditOrderForm(record).ShowDialog();

                if (result == DialogResult.OK)
                {
                    record.EmployeeID = Settings.CurrentUser.ID;

                    _empService.Update(Settings.CurrentUser.ID, record);

                    MetroMessageBox.Show(this, "Замовлення успішно змінено", "Довідка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateOrdersDtg();
                }
            }
        }

        private void btnShowCustomers_Click(object sender, EventArgs e)
        {
            new CustomersForm().ShowDialog();
        }

        private void btnDownloadReport_Click(object sender, EventArgs e)
        {
            var fileDialog = new SaveFileDialog();
            fileDialog.DefaultExt = "pdf";
            fileDialog.FileName = "Договір";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(fileDialog.FileName, Resources.dogovor_usluga_reklama);
                MetroMessageBox.Show(this, $"Договір знаходиться у папці:\n{fileDialog.FileName}", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMakeReport_Click(object sender, EventArgs e)
        {
            new ReportMakerForm().ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isChangingUser)
                Environment.Exit(0);
        }
    }
}