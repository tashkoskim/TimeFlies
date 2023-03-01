using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeFlies.Clocks
{
    public partial class Clock_Hexa : Form
    {
        public Clock_Hexa()
        {
            InitializeComponent();
        }

        private void timerHex_Tick(object sender, EventArgs e)
        {
            // Digitalen casovnik
            DigitalClock objDigital = new DigitalClock();
            lblDigital.Text = objDigital.Digital_Clock();
            HexaClock();
        }

        private void HexaClock()
        {

            lblHexTime.Text = string.Empty;
            string pomTime = string.Empty;

            int hh = DateTime.Now.Hour;
            pomTime = "#" + DekToHex(hh);

            int mm = DateTime.Now.Minute;
            pomTime += DekToHex(mm);

            int ss = DateTime.Now.Second;
            pomTime += DekToHex(ss);

            lblHexTime.Text = pomTime;
            this.BackColor = ColorTranslator.FromHtml(pomTime);
        }

        // F-ja za pretvoranje na dekaden vo heksadekaden sistem
        private string DekToHex(int br)
        {
            string hexa = "";
            int pom = br;
            List<string> brojki = new List<string>();
            while (br >= 1)
            {
                int ostatok = br % 16;
                if(ostatok == 10)
                    brojki.Add("A");
                else if (ostatok == 11)
                    brojki.Add("B");
                else if (ostatok == 12)
                    brojki.Add("C");
                else if (ostatok == 13)
                    brojki.Add("D");
                else if (ostatok == 14)
                    brojki.Add("E");
                else if (ostatok == 15)
                    brojki.Add("F");
                else
                    brojki.Add(ostatok.ToString());

                br = br / 16;
            }

            //pecatenje na listata so for
            for (int i = brojki.Count - 1; i >= 0; i--)
            {
                    hexa += brojki[i];
            }

            if (hexa.Length == 1)
                hexa = "0" + hexa;
            if (pom == 0)
                hexa = "00";

            return hexa;
        }// Kraj DekToHex()

       
    }
}
