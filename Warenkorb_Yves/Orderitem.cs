using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warenkorb_Yves;
namespace Warenkorb
{
    public class OrderItem
    {
        Product product;
        int quantity;
        public Product Product
        {
            get { return product; }
            set { product = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public double GetAmount(int anz, double price)
        {
            double result = anz * price;
            return result;
        }
    }
}