using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoSimolator;

namespace AutoSimolator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;

            pictureBoxTanken.Click += pictureBoxTanken_Click;
            pictureBoxStartAuto.Click += pictureBoxStartAuto_Click;
            pictureBoxHupe.Click += pictureBoxHupe_Click;

            buttonGas.MouseDown += buttonGas_MouseDown;
            buttonGas.MouseUp += buttonGas_MouseUp;

            buttonBremse.MouseDown += buttonBremse_MouseDown;
            buttonBremse.MouseUp += buttonBremse_MouseUp;

            



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] Marken = { "Porsche", "Opel", "Ferrari" };
            string[] PS = { "250", "90", "370" };
            for (int i = 0; i < Marken.Length; i++)
            {
                Auto auto = new Auto(Marken[i], Convert.ToInt32(PS[i]));
                comboBoxAutos.Items.Add(auto);
            }


        }

        private void comboBoxAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAutos.SelectedItem != null)
            {
                Auto auto = comboBoxAutos.SelectedItem as Auto;

                labelPS.Text = auto.PS.ToString();
                textBoxTempo.Text = auto.AktuelleGeschwindikeit.ToString();
                progressBarTank.Value = auto.TankFeullstand;
                auto.BerechneGang();
                textBoxGang.Text = auto.AktuellerGang.ToString();
                if (auto.IstMotorGestartet == true)
                {
                    pictureBox1.BackColor = Color.Green;
                }
                else
                {
                    panel1.BackColor = Color.Red;
                }
            }
        }

        private void pictureBoxTanken_Click(object sender, EventArgs e)
        {
            if (comboBoxAutos.SelectedItem != null)
            {

                Auto auto = comboBoxAutos.SelectedItem as Auto;
                if (auto.IstMotorGestartet != true)
                {
                    if (auto.AktuelleGeschwindikeit <= 0)
                    {
                        auto.auftanken();

                    }
                    else
                    {
                        MessageBox.Show("Stop driving and slow down your car!");
                    }
                }
                else
                {
                    MessageBox.Show("Shut down the engine");
                }
                progressBarTank.Value = auto.TankFeullstand;
            }
            else
            {
                MessageBox.Show("No Car Selected");
            }

        }

        private void pictureBoxStartAuto_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxAutos.SelectedItem != null)
                {

                    Auto auto = comboBoxAutos.SelectedItem as Auto;
                    if (auto.IstMotorGestartet == true)
                    {
                        auto.SchalteMotorAus();
                        if (auto.IstMotorGestartet != true)
                        {
                            pictureBox1.BackColor = Color.Red;
                        }
                        textBoxTempo.Text = auto.AktuelleGeschwindikeit.ToString();
                        textBoxGang.Text = auto.AktuellerGang.ToString();
                    }
                    else
                    {
                        auto.SchalteMotorEin();
                        if (auto.IstMotorGestartet == true)
                        {
                            panel1.BackColor = Color.Green;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No Car Selected");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public bool Gasgeben = false;
        private void buttonGas_MouseDown(object sender, MouseEventArgs e)
        {
            if (comboBoxAutos.SelectedItem != null)
            {
                Auto auto = comboBoxAutos.SelectedItem as Auto;
                Gasgeben = true;
                if (auto.IstMotorGestartet == true)
                {
                    while (Gasgeben == true)
                    {
                        Application.DoEvents();
                        auto.GibGas();
                        textBoxTempo.Text = auto.AktuelleGeschwindikeit.ToString();
                        textBoxGang.Text = auto.AktuellerGang.ToString();
                        progressBarTank.Value = auto.TankFeullstand;
                        if (auto.IstMotorGestartet != true)
                        {
                            panel1.BackColor = Color.Red;
                        }

                    }
                }
                else
                {
                    MessageBox.Show("start engine");
                }
            }
            else
            {
                MessageBox.Show("No Car Selected");

            }
        }

        private void buttonGas_MouseUp(object sender, MouseEventArgs e)
        {
            Gasgeben = false;
        }



        bool bremsen = false;
        private void buttonBremse_MouseDown(object sender, MouseEventArgs e)
        {
            if (comboBoxAutos.SelectedItem != null)
            {
                Auto auto = comboBoxAutos.SelectedItem as Auto;
                bremsen = true;

                while (bremsen == true)
                {
                    Application.DoEvents();
                    auto.Bremse();
                    textBoxTempo.Text = auto.AktuelleGeschwindikeit.ToString();
                    textBoxGang.Text = auto.AktuellerGang.ToString();

                }
            }
            else
            {
                MessageBox.Show("No Car Selected");

            }

        }

        private void buttonBremse_MouseUp(object sender, MouseEventArgs e)
        {
            bremsen = false;
        }

        private void pictureBoxHupe_Click(object sender, EventArgs e)
        {
            if (comboBoxAutos.SelectedItem != null)
            {
                Auto auto = comboBoxAutos.SelectedItem as Auto;

                if (auto.IstMotorGestartet == true)
                {
                    auto.Hupen();

                }
                else
                {
                    MessageBox.Show("start engine");
                }
            }
            else
            {
                MessageBox.Show("No Car Selected");

            }
        }
    }
}
