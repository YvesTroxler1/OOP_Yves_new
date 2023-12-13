using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Würfel_Yves
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public class Wuerfel
        {
            Random r = new Random();
            int aktuellerWurf;
            int letzterWurf;

            public int LetzterWurf
            {
                get { return letzterWurf; }
            }

            public int Werfen()
            {
                letzterWurf = aktuellerWurf;
                aktuellerWurf = r.Next(1, 7);
                return aktuellerWurf;
            }
        }



    }


}
