using System;
using System.Windows.Forms;

namespace Tannenbaum_Yves
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTannenZeichnen_Click(object sender, EventArgs e)
        {
           
            if (int.TryParse(textBoxStammBreite.Text, out int stammbreite) &&
                int.TryParse(textBoxStammHöhe.Text, out int stammhoehe) &&
                int.TryParse(textBoxKronenHöhe.Text, out int kronenhoehe))
            {
              
                Tanne m = new Tanne(stammhoehe, stammbreite, kronenhoehe);

               
                string tanneZeichnung = m.Zeichnen();

                
                richTextBox1.AppendText(tanneZeichnung);
            }
            else
            {
                MessageBox.Show("Bitte geben Sie gültige Zahlenwerte für Stammhöhe, Stammbreite und Kronenhöhe ein.");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}