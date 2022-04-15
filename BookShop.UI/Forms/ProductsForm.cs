using BookShop.Core.Models;
using BookShop.Core.Services;
using BookShop.UI.Forms.EditForms;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BookShop.UI.Forms
{
    public partial class ProductsForm : MetroForm
    {
        private readonly ProductsService _prService = new ProductsService(Settings.Context);
        private readonly GenresService _gService = new GenresService(Settings.Context);

        private List<Product> _items;

        public ProductsForm()
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            if (Settings.CurrentUser.UserType == Core.Other.UserType.Admin)
            {
                flpEditing.Enabled = true;
            }

            UpdateDataGrid();
            UpdateCounter();
        }

        private void UpdateDataGrid()
        {
            dataGrid.Rows.Clear();
            dtgPrices.Rows.Clear();

            var products = _prService.GetAll();
            products.ToList().ForEach(pr =>
                           dataGrid.Rows.Add(
                                   pr.Id,
                                   pr.Title,
                                   pr.DateCreated,
                                   pr.ProductDateCreated,
                                   pr.ProductPriceHistory.LastOrDefault()?.Price,
                                   pr.ProductPriceHistory.Any(x => x.IsDeleted == 0) ? true : false
                               ));

            _items = new List<Product>(products);
        }

        private void UpdateCounter()
        {
            lblCount.Text = dataGrid.Rows.Count.ToString();
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            dtgPrices.Rows.Clear();
            dtgGenres.Rows.Clear();

            if (dataGrid.SelectedRows.Count != 0)
            {
                if (Settings.CurrentUser.UserType == Core.Other.UserType.Admin )
                {
                    btnEdit.Enabled = true;
                }

                    var selectedProduct = _prService.Find((Convert.ToInt32(dataGrid.SelectedRows[0].Cells[0].FormattedValue)));

                txtDesc.Text = selectedProduct.Description;

                if (selectedProduct.Image != null)
                    using (var ms = new MemoryStream(selectedProduct.Image))
                        picGame.Image = Image.FromStream(ms);
                else
                    picGame.Image = null;

                selectedProduct.ProductPriceHistory.ToList().ForEach(x => dtgPrices.Rows.Add(x.Id, x.Price, x.DateCreated));
                selectedProduct.ProductGenre.ToList().ForEach(x => dtgGenres.Rows.Add(x.GenreId, x.Genre.Name));
            }
            else
            {
                txtDesc.Text = string.Empty;
                picGame.Image?.Dispose();
                picGame.Image = null;
                dtgPrices.Rows.Clear();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGrid.SelectedRows[0].Cells[0].Value);

            if (_prService.Remove(id))
            {
                dataGrid.Rows.Remove(dataGrid.SelectedRows[0]);
                MetroMessageBox.Show(this, $"Книга видалена", "Довідка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateCounter();
            }
            else
            {
                MetroMessageBox.Show(this, "Помилка при видаленні запису", "Не вдалося видалити запис", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var product = _prService.Find(Convert.ToInt32(dataGrid.SelectedRows[0].Cells[0].Value));

            if (product != null)
            {
                var dialogResult = new EditProductForm(product, _gService.GetAll()).ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    _prService.Update(product);
                    MetroMessageBox.Show(this, $"Книга {product.Title} змінена", "Довідка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateDataGrid();
                    UpdateCounter();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var product = new Product();

            var dialogResult = new EditProductForm(product, _gService.GetAll()).ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                _prService.Add(product);
                MetroMessageBox.Show(this, $"Книга {product.Title} успішно створена", "Довідка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateDataGrid();
                UpdateCounter();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilter.Text))
            {
                dataGrid.Rows.Clear();
                _items.Where(x => x.Title.Contains(txtFilter.Text.Trim())).ToList()?.ForEach(pr =>
                              dataGrid.Rows.Add(
                                      pr.Id,
                                      pr.Title,
                                      pr.DateCreated,
                                      pr.ProductDateCreated,
                                      pr.ProductPriceHistory.LastOrDefault().Price,
                                      pr.ProductPriceHistory.Any(x => Convert.ToBoolean(x.IsDeleted)) ? false : true
                                  ));
            }
            else
            {
                UpdateDataGrid();
            }
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
