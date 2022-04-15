using BookShop.Core.Models;
using BookShop.UI.Utility;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static BookShop.UI.Utility.Helpers;

namespace BookShop.UI.Forms.EditForms
{
    public partial class EditProductForm : MetroForm
    {
        private readonly ICollection<Genre> _genres;
        private readonly Product _product;

        public EditProductForm(Product product, ICollection<Genre> genres)
        {
            InitializeComponent();

            _product = product;
            _genres = genres;
        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {
            txtTitle.Text = _product.Title;
            txtDesc.Text = _product.Description;

            lstExistedGenres.Items.AddRange(_genres.Select(x => x.MapToItem()).ToArray());
            lstGameGenres.Items.AddRange(_product.ProductGenre.Select(x => x.Genre.MapToItem()).ToArray());

            _product.ProductPriceHistory.ToList().ForEach(x => dtgPrices.Rows.Add(x.Id, x.Price + " грн.", x.DateCreated, !Convert.ToBoolean(x.IsDeleted)));

            if (_product.Image != null)
                using (var ms = new MemoryStream(_product.Image))
                    picGame.Image = Image.FromStream(ms);

            if (DateTime.TryParse(_product.DateCreated, out DateTime created))
                dtpCreated.Value = created;

            if (DateTime.TryParse(_product.ProductDateCreated, out DateTime pcreated))
                dtpProductCreated.Value = pcreated;
        }

        private void btnRemovePrice_Click(object sender, EventArgs e)
        {
            dtgPrices.Rows.Remove(dtgPrices.SelectedRows[0]);
        }

        private void btnAddPrice_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPrice.Text))
            {
                MetroMessageBox.Show(this, "Введіть нову ціну", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var str = txtNewPrice.Text.Trim().Replace('.', ',');
            if (double.TryParse(str, out double value) || value < 1)
            {
                dtgPrices.Rows.Add("", value.ToString("N2") + " грн.", DateTime.Now.ToShortDateString(), true);
                txtNewPrice.Text = string.Empty;
                txtNewPrice.Focus();
            }
            else
            {
                MetroMessageBox.Show(this, "Некоректне введення вартості", "Довідка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (IsAnyEmpty(string.IsNullOrEmpty, txtTitle.Text) || dtgPrices.Rows.Count == 0)
            {
                MetroMessageBox.Show(this, "Заповніть обов'язкові поля", "Довідка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.None;
                return;
            }

            _product.ProductGenre.Clear();

            foreach (ListViewItem item in lstGameGenres.Items)
            {
                var genre = item.Tag as Genre;
                _product.ProductGenre.Add(new ProductGenre() { Genre = genre, Product = _product });
            }

            foreach (DataGridViewRow row in dtgPrices.Rows)
            {
                var id = row.Cells[0].FormattedValue.ToString();

                if (!string.IsNullOrEmpty(id))
                {
                    var product = _product.ProductPriceHistory.FirstOrDefault(x => x.Id == Convert.ToInt32(id));
                    if (product != null)
                        product.IsDeleted = Convert.ToInt32(!Convert.ToBoolean(row.Cells[3].Value));
                }
                else
                {
                    _product.ProductPriceHistory.Add(new ProductPriceHistory()
                    {
                        Price = Double.Parse(row.Cells[1].FormattedValue.ToString().Replace(" грн.", "")),
                        DateCreated = DateTime.Now.ToShortDateString(),
                        IsDeleted = Convert.ToInt32(!Convert.ToBoolean(row.Cells[3].Value)),
                        Product = _product
                    });
                }
            }

            _product.Title = txtTitle.Text.Trim();
            _product.Description = txtDesc.Text.Trim();
            _product.DateCreated = dtpCreated.Value.ToShortDateString();
            _product.ProductDateCreated = dtpProductCreated.Value.ToShortDateString();
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            picGame.Image.Dispose();
            picGame.Image = null;
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            var openFD = new OpenFileDialog();
            openFD.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFD.Title = "Вибір зображення книги";

            if (openFD.ShowDialog() == DialogResult.OK)
            {
                picGame.Image = Image.FromFile(openFD.FileName);
                _product.Image = File.ReadAllBytes(openFD.FileName);
            }
        }

        private void btnRemoveGanre_Click(object sender, EventArgs e)
        {
            lstGameGenres.Items.Remove(lstGameGenres.SelectedItems[0]);
        }

        private void btnAddNewGenre_Click(object sender, EventArgs e)
        {
            var genre = lstExistedGenres.SelectedItems[0].Tag as Genre;

            foreach (ListViewItem item in lstGameGenres.Items)
            {
                if ((item.Tag as Genre).Id == genre.Id)
                {
                    MetroMessageBox.Show(this, "Цей жанр вже доданий", "Довідка", MessageBoxButtons.OK);
                    return;
                }
            }

            var newItem = new ListViewItem(genre.Name) { Tag = genre };
            lstGameGenres.Items.Add(newItem);
        }

        private void lstExistedGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstExistedGenres.SelectedItems.Count != 0)
            {
                btnAddNewGenre.Enabled = true;
            }
            else
            {
                btnAddNewGenre.Enabled = false;
            }
        }

        private void lstGameGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGameGenres.SelectedItems.Count != 0)
            {
                btnRemoveGanre.Enabled = true;
            }
            else
            {
                btnRemoveGanre.Enabled = false;
            }
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
