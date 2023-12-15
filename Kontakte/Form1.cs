using System.Windows.Forms;
using System;
using System.ComponentModel;

namespace Kontakte
{
    public partial class Form1 : Form
    {
        private readonly ContactList contactList = new ContactList();

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
          

        }

        private void InitializeDataGridView()
        {
            // Annahme: Sie haben bereits eine DataGridView auf Ihrem Formular platziert (zum Beispiel mit dem Namen dataGridViewKontakte).
            // Optional: Legen Sie die Spaltenüberschriften fest.


            // Verbinden Sie die DataGridView mit der ContactList.
            dataGridViewKontakte.DataSource = contactList.Contacts;

            // Optional: Automatische Generierung der Spalten deaktivieren.
            dataGridViewKontakte.AutoGenerateColumns = false;
        }
        private void buttonAddContact_Click(object sender, EventArgs e)
        {
            Contacts newContact = new Contacts
            {
                Name = textBoxContactName.Text,
                email = textBoxContactEmail.Text,
                phone = textBoxContactPhone.Text,
            };

            // Füge den neuen Kontakt zur bestehenden ContactList hinzu.
            contactList.Contacts.Add(newContact);

            // Aktualisiere die Datenquelle der DataGridView.
            dataGridViewKontakte.Refresh();
        }
        private void buttonClearDataGridView_Click(object sender, EventArgs e)
        {
            // Löschen Sie alle Zeilen im DataGridView.
            contactList.Clear();
        }

        private void textBoxContactName_TextChanged(object sender, EventArgs e)
        {
            Name = textBoxContactName.Text;
        }

        private void textBoxContactEmail_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBoxContactPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}