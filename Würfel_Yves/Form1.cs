using System;
using System.Windows.Forms;
using static Würfel_Yves.Program;

namespace Würfel_Yves
{
    public partial class Form1 : Form
    {
        private Wuerfel meinWuerfel; 

        public Form1()
        {
            InitializeComponent();
            meinWuerfel = new Wuerfel(); 
        }

        private void Werfen_Click(object sender, EventArgs e)
        {
            int aktuellerWurf = meinWuerfel.Werfen();
            int letzterWurf = meinWuerfel.LetzterWurf;

           
            aktuellerWurfTextBox.Text = aktuellerWurf.ToString(); 
            LetzterWurfTextBox.Text = letzterWurf.ToString(); 
        }
    }
}
