using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoSimolator;

namespace Auto_Yves
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Auto selectedAuto;
        
        public Form()
        {
            InitializeComponent();  
            
            comboBoxAutos.Items.Add(new Auto("Porsche", 250));
            comboBoxAutos.Items.Add(new Auto("Opel", 90));
            comboBoxAutos.Items.Add(new Auto("Ferrari", 370));

            pictureBoxStartAuto.Click += pictureBoxStartAuto_Click;
            pictureBoxTanken.Click += pictureBoxTanken_Click;

            
        }
  
    

          


       


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBremse_Click(object sender, EventArgs e)
        {

        }

        private void buttonGas_Click(object sender, EventArgs e)
        {
            if (selectedAuto.IstMotorGestartet)
            {

                selectedAuto.GibGas();





            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBoxHupe_Click(object sender, EventArgs e)
        {

        }
    
        private void comboBoxAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAuto = comboBoxAutos.SelectedItem as Auto;
        }

        private void pictureBoxStartAuto_Click(object sender, EventArgs e)
        {
            if (selectedAuto != null)
            {
                while(selectedAuto.TankFeullstand > 0)
                {
                    selectedAuto.SchalteMotorEin();
                    // Hier kannst du weitere Aktionen nach dem Starten des Motors ausführen
                }
       
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie ein Auto aus.", "Kein Auto ausgewählt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void pictureBoxTanken_Click(object sender, EventArgs e)
        {
            if (selectedAuto != null)
            {
                try
                {
                    // Starte den Tankvorgang asynchron
                    Task.Run(() => TankenAsync(selectedAuto));
                    // Hier kannst du nach dem Tanken weitere Aktionen ausführen
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fehler beim Tanken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie ein Auto aus.", "Kein Auto ausgewählt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async Task TankenAsync(Auto auto)
        {
            // Simuliere den Tankvorgang asynchron
            for (int i = 0; i <= 100; i++)
            {
                await Task.Delay(25); // Simuliere eine Verzögerung
                 // Aktualisiere den Tankfüllstand
                UpdateProgressBar(i); // Aktualisiere die ProgressBar
            }
        } 

        private void UpdateProgressBar(int value)
        {
            if (progressBarTanken.InvokeRequired)
            {
                progressBarTanken.Invoke((MethodInvoker)delegate
                {
                    progressBarTanken.Value = value;
                });
            }
            else
            {
                progressBarTanken.Value = value;
            }
        }
    }
}