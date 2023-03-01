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
    public partial class Clock_Digital : Form
    {
        public Clock_Digital()
        {
            InitializeComponent();
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Digitalen casovnik
            DigitalClock objDigital = new DigitalClock();
            lblDigital.Text = objDigital.Digital_Clock();
            DigitalLedClock();
        }

        private void DigitalLedClock()
        {
            int hh = DateTime.Now.Hour;
            if (hh == 0)
                hh = 24;
            string pomHH = hh.ToString();
            if (hh < 10)
                pomHH = "0" + hh.ToString();

            int mm = DateTime.Now.Minute;
            if (mm == 0)
                mm = 60;
            string pomMM = mm.ToString();
            if (mm < 10)
                pomMM = "0" + mm.ToString();

            int ss = DateTime.Now.Second;
            if (ss == 0)
                ss = 60;
            string pomSS = ss.ToString();
            if (ss < 10)
                pomSS = "0" + ss.ToString();

            List<string> hh1 = sostaviEdnaCifra(pomHH[0]);
            List<string> hh2 = sostaviEdnaCifra(pomHH[1]);

            List<string> mm1 = sostaviEdnaCifra(pomMM[0]);
            List<string> mm2 = sostaviEdnaCifra(pomMM[1]);

            List<string> ss1 = sostaviEdnaCifra(pomSS[0]);
            List<string> ss2 = sostaviEdnaCifra(pomSS[1]);

            txtBox_Digital.Text = hh1[0] + " " + hh2[0] + "   " + mm1[0] + " " + mm2[0] + "   " + ss1[0] + " " + ss2[0] + Environment.NewLine;
            txtBox_Digital.Text+= hh1[1] + " " + hh2[1] + " . " + mm1[1] + " " + mm2[1] + " . " + ss1[1] + " " + ss2[1] + Environment.NewLine;
            txtBox_Digital.Text+= hh1[2] + " " + hh2[2] + " . " + mm1[2] + " " + mm2[2] + " . " + ss1[2] + " " + ss2[2] + Environment.NewLine;
        }   

        private List<string> sostaviEdnaCifra(char broj)
        {
            List<string> lista = new List<string>();

            switch(broj)
            {
                case '1':
                    lista.Add("   ");
                    lista.Add("  |");
                    lista.Add("  |");
                    break;
                case '2':
                    lista.Add(" _ ");
                    lista.Add(" _|");
                    lista.Add("|_ ");
                    break;
                case '3':
                    lista.Add(" _ ");
                    lista.Add(" _|");
                    lista.Add(" _|");
                    break;
                case '4':
                    lista.Add("   ");
                    lista.Add("|_|");
                    lista.Add("  |");
                    break;
                case '5':
                    lista.Add(" _ ");
                    lista.Add("|_ ");
                    lista.Add(" _|");
                    break;
                case '6':
                    lista.Add(" _ ");
                    lista.Add("|_ ");
                    lista.Add("|_|");
                    break;
                case '7':
                    lista.Add(" _ ");
                    lista.Add("  |");
                    lista.Add("  |");
                    break;
                case '8':
                    lista.Add(" _ ");
                    lista.Add("|_|");
                    lista.Add("|_|");
                    break;
                case '9':
                    lista.Add(" _ ");
                    lista.Add("|_|");
                    lista.Add(" _|");
                    break;
                case '0':
                    lista.Add(" _ ");
                    lista.Add("| |");
                    lista.Add("|_|");
                    break;
                default:
                    break;
            }

            return lista;
        }

        private void Clock_Digital_Load(object sender, EventArgs e)
        {

        }
    }
}
