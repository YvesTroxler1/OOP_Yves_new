using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warenkorb;
namespace Warenkorb
{
    public partial class FormProduktliste : Form
    {
        public FormProduktliste()
        {
            InitializeComponent();
            
        }
    
        public void getProduct()
        {
            // Verbindung zur Datenbank herstellen
            string connectionString = "Server=mssql1.webland.ch;Database=d041e_blj;User Id=d041e_blj;Password=BljDbPw_01;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            // Abfrage vorbereiten
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from products";
            // Abfrage ausführen
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Product p = new Product();
                p.Name = reader["product_name"].ToString();
                p.Price = Convert.ToDouble(reader["price"]);
                comboBoxProdukt.Items.Add(p);
            }
        }
        // Liste deklarieren und intialisieren
        List<OrderItem> orderedItems = new List<OrderItem>();

        private void linkLabelWarenkorb_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormWarenkorb formWarenkorb = new FormWarenkorb(this.orderedItems);
            formWarenkorb.ShowDialog();

        }

        private void FormProduktliste_Load_1(object sender, EventArgs e)
        {
            getProduct();
        }

        private void buttonHinzufugen_Click_1(object sender, EventArgs e)
        {
            if (numericUpDown1Anzahl.Value > 0 && comboBoxProdukt.SelectedItem != null)
            {
                // neues OrderItem instanziieren und zur Liste hinzufügen
                OrderItem item = new OrderItem();
                item.Product = comboBoxProdukt.SelectedItem as Product;
                item.Quantity = Convert.ToInt32(numericUpDown1Anzahl.Value);
                orderedItems.Add(item);
                int anzwaren = Convert.ToInt32(labelWarenkorbAnzahl.Text);
                anzwaren++;
                labelWarenkorbAnzahl.Text = anzwaren.ToString();
            }
        }
    }
}