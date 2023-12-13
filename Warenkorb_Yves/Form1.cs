using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Warenkorb_Yves
{
    public partial class Form1 : Form
    {
        private readonly DataAccess dataAccess = new DataAccess();

        public Form1()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            List<Product> products = dataAccess.GetProducts();

            // Fülle die ComboBox mit den Produkten
            comboBoxProducts.DisplayMember = "Name";
            comboBoxProducts.ValueMember = "Id";
            comboBoxProducts.DataSource = products;

            // Füge das SelectedIndexChanged-Ereignis hinzu
            comboBoxProducts.SelectedIndexChanged += ComboBoxProducts_SelectedIndexChanged;
        }

        private void ComboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hier kannst du den ausgewählten Artikel verwenden
            if (comboBoxProducts.SelectedItem is Product selectedProduct)
            {
                // Aktualisiere die Anzeige, um den ausgewählten Artikel anzuzeigen
                Product.Text = $"Ausgewähltes Produkt: {selectedProduct.Name}";
            }
        }
    }
}