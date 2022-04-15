using BookShop.Core.Other;
using BookShop.Core.Services;
using MetroFramework;
using MetroFramework.Forms;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BookShop.UI.Forms.EditForms
{
    public partial class EditOrderForm : MetroForm
    {
        public class Status
        {
            public RecordState State { get; set; }
            public override string ToString()
            {
                switch (State)
                {
                    case RecordState.Closed: return "Закрито";
                    case RecordState.Editing: return "Редагується";
                    default: return string.Empty;
                }
            }
        }

        private readonly ProductsService _productsService = new ProductsService(Settings.Context);
        private readonly CustomersService _customersService = new CustomersService(Settings.Context);
        private readonly Record _record;

        public EditOrderForm(Record record)
        {
            InitializeComponent();

            _record = record;
        }

        private void EditOrderForm_Load(object sender, EventArgs e)
        {
            cbStatus.Items.AddRange(new Status[] {
                                        new Status() { State = RecordState.Editing },
                                        new Status() { State = RecordState.Closed } });

            cbStatus.SelectedIndex = _record.State == RecordState.Editing ? 0 : 1;

            cbClients.Items.AddRange(_customersService.GetCustomers());

            foreach(var item in  cbClients.Items)
                if ((item as CustomerDto).ID == _record.CustomerID)
                {
                    cbClients.SelectedItem = item;
                    break;
                }      

            var games = _productsService.GetAll(x => x.ProductPriceHistory.Any(z => z.IsDeleted == 0));
            games.ToList().ForEach(pr =>
            {
                dtgGames.Rows.Add(
                        pr.Id,
                        pr.Title,
                        pr.ProductDateCreated,
                        pr.ProductPriceHistory.LastOrDefault(x => x.IsDeleted == 0).Price.ToString("N2") + " грн."
                    );

                dtgGames.Rows[dtgGames.RowCount - 1].Tag = pr.ProductPriceHistory.LastOrDefault(x => x.IsDeleted == 0).Id;
            });

            foreach (var game in games)
            {
                foreach (var prHistory in game.ProductPriceHistory)
                {
                    if (_record.Items.Exists(x => x.ProductID == prHistory.Id))
                    {
                        dtgBasket.Rows.Add(
                            prHistory.Id,
                            prHistory.Product.Title,
                            prHistory.Product.ProductDateCreated,
                            prHistory.Price
                            );

                        dtgBasket.Rows[dtgBasket.RowCount - 1].Tag = prHistory.Id;

                        break;
                    }
                }
            }

            if (!string.IsNullOrEmpty(_record.DateCreated))
            {
                if (DateTime.TryParse(_record.DateCreated, out DateTime dateCreated))
                {
                    dtpCreated.Value = dateCreated;
                    dtpCreated.Enabled = false;
                }
            }
            else
            {
                dtpCreated.Value = DateTime.Now;
            }
        }

        private void CalcSum()
        {
            double sum = 0;
            foreach (DataGridViewRow row in dtgBasket.Rows)
            {
                sum += double.Parse(row.Cells[3].FormattedValue.ToString().Replace("грн.", ""));
            }

            lblSum.Text = $"Разом: {Math.Round(sum, 2):N2} грн.";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var cells = dtgGames.SelectedRows[0].Cells;
            var selectedId = Convert.ToInt32(cells[0].Value);

            foreach (DataGridViewRow row in dtgBasket.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].FormattedValue) == selectedId)
                {
                    MetroMessageBox.Show(this, "Ця гра вже додана", "Довідка", MessageBoxButtons.OK);
                    return;
                }
            }

            var newRow = new DataGridViewRow();
            newRow.Cells.Add(new DataGridViewTextBoxCell() { Value = cells[0].Value });
            newRow.Cells.Add(new DataGridViewTextBoxCell() { Value = cells[1].Value });
            newRow.Cells.Add(new DataGridViewTextBoxCell() { Value = cells[2].Value });
            newRow.Cells.Add(new DataGridViewTextBoxCell() { Value = cells[3].Value });

            newRow.Tag = dtgGames.SelectedRows[0].Tag;
            dtgBasket.Rows.Add(newRow);

            CalcSum();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            dtgBasket.Rows.Remove(dtgBasket.SelectedRows[0]);

            CalcSum();
        }

        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            cbClients.SelectedIndex = -1;
        }

        private void dtgGames_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgGames.SelectedRows.Count != 0)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void dtgBasket_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgBasket.SelectedRows.Count != 0)
            {
                btnRemove.Enabled = true;
            }
            else
            {
                btnRemove.Enabled = false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cbStatus.SelectedIndex == -1)
            { MetroMessageBox.Show(this, "Виберіть статус замовлення", "Довідка", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (cbClients.SelectedIndex == -1)
            { MetroMessageBox.Show(this, "Виберіть покупця", "Довідка", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (dtgBasket.Rows.Count == 0)
            { MetroMessageBox.Show(this, "Додайте книги в кошик", "Довідка", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (string.IsNullOrEmpty(_record.DateCreated))
                _record.DateCreated = dtpCreated.Value.ToShortDateString();
            if (cbStatus.SelectedIndex == 1)
                _record.DateClosed = DateTime.Now.ToShortDateString();

            if (cbClients.SelectedIndex != -1)
                _record.CustomerID = (cbClients.SelectedItem as CustomerDto).ID;

            _record.State = (cbStatus.SelectedItem as Status).State;

            _record.Items.Clear();
            foreach (DataGridViewRow row in dtgBasket.Rows)
            {
                _record.Items.Add(new Item()
                {
                    ProductID = Convert.ToInt32(row.Tag)
                });
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}