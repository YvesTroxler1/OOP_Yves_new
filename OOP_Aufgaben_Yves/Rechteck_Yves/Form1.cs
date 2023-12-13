using System;
using System.Windows.Forms;

namespace RechteckBerechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBerechnen_Click(object sender, EventArgs e)
        {
            // Überprüfe, ob gültige Zahlen eingegeben wurden
            if (double.TryParse(textBoxBreite.Text, out double breite) && double.TryParse(textBoxHöhe.Text, out double hoehe))
            {
                // Berechne die Fläche
                double flaeche = breite * hoehe;

                // Zeige das Ergebnis in der Ergebnis-Textbox an
                textBoxFläche.Text = $"Fläche: {flaeche}";
            }
            else
            {
                // Fehlermeldung anzeigen, wenn ungültige Eingaben vorhanden sind
                MessageBox.Show("Bitte gültige Zahlen für Breite und Höhe eingeben.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            // Schließe das Formular (die Anwendung)
            this.Close();
        }
    }
}