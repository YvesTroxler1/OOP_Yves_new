using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mond_Yves
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBerechnen_Click(object sender, EventArgs e)
        {
            // Versuche, die Geschwindigkeit aus dem Textfeld zu parsen
            if (double.TryParse(speedTextBox.Text, out double speed))
            {
                Mondreise m = new Mondreise(speed);

                double duration = m.GetTravelDurationHours();
                

                if (radioButtonDays.Checked)
                {
                     double durationInHours = m.GetTravelDurationHours();
                    textBoxResult.Text = durationInHours.ToString();
                           
                }
                else if (radioButtonHours.Checked)
                {
                    double durationInDays = m.GetTravelDurationDays();
                    textBoxResult.Text = durationInDays.ToString();      
                }
            
            }
            else
            {
                MessageBox.Show("Ungültige Geschwindigkeitsangabe. Bitte geben Sie eine gültige Zahl ein.");
            }
        }

        private void speedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
    

