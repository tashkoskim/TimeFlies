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
    public partial class Clock_Morse : Form
    {
        public Clock_Morse()
        {
            InitializeComponent();
        }

        private void timerMorse_Tick(object sender, EventArgs e)
        {
            // Digitalen casovnik
            DigitalClock objDigital = new DigitalClock();
            lblDigital.Text = objDigital.Digital_Clock();
            MorseClock();
        }

        // Morse clock
        private void MorseClock()
        {
            lblMorse.Text = string.Empty;
            string pomVreme = string.Empty;
            int hh = DateTime.Now.Hour;
            if (hh == 0)
                hh = 24;
            pomVreme = DekToMorse(hh) + " / ";
            int mm = DateTime.Now.Minute;
            if (mm == 0)
                mm = 60;
            pomVreme += DekToMorse(mm) + " / ";
            int ss = DateTime.Now.Second;
            if (ss == 0)
                ss = 60;
            pomVreme += DekToMorse(ss);

            lblMorse.Text = pomVreme.Trim();
        }

        // F-ja za konverzija na broj vo morzeova azbuka
        private string DekToMorse(int n)
        {
            var morseN = string.Empty;
            var morseMap = new SortedDictionary<int, string>
            {
                { '0', "-----" },
                { '1', ".----" },
                { '2', "..---" },
                { '3', "...--" },
                { '4', "....-" },
                { '5', "....." },
                { '6', "-...." },
                { '7', "--..." },
                { '8', "---.." },
                { '9', "----." },
                
            };

            string pomN = n.ToString();
            foreach(char c in pomN)
            {
                string pom = "";
                morseMap.TryGetValue(c, out pom);
                morseN +=  pom + " ";
            }
            

            return morseN.Trim();
        }

        
    }
}
