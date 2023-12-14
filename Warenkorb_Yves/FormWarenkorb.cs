using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warenkorb_Yves;
namespace Warenkorb
{
    public partial class FormWarenkorb : Form
    {
        public FormWarenkorb(List<OrderItem> orderedItems)
        {
            string Produktetext = "";
            double prise = 0;
            InitializeComponent();
            for (int i = 0; i < orderedItems.Count; i++)
            {
                Produktetext = Produktetext + "\r\n" + orderedItems[i].Quantity.ToString() + " Ex.\t" + orderedItems[i].Product.Name.ToString();
                prise = prise + orderedItems[i].GetAmount(orderedItems[i].Quantity, orderedItems[i].Product.Price);
            }
           textBoxProdukte.Text = Produktetext;
            labelSumme.Text = prise.ToString();
        }
        private void buttonabbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormWarenkorb_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


