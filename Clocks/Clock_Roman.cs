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
    public partial class Clock_Roman : Form
    {
        public Clock_Roman()
        {
            InitializeComponent();
        }

        private void timerRoman_Tick(object sender, EventArgs e)
        {
            // Digitalen casovnik
            DigitalClock objDigital = new DigitalClock();
            lblDigital.Text = objDigital.Digital_Clock();
            RomanClock();
        }

        // Casovnik sto gi pretvora brojkite rimski broevi oddeleni so :
        private void RomanClock()
        {
            lblRoman.Text = string.Empty;
            string pomVreme = string.Empty;
            int hh = DateTime.Now.Hour;
            if (hh == 0)
                hh = 24;
            pomVreme = DekToRoman(hh) + ":";
            int mm = DateTime.Now.Minute;
            if (mm == 0)
                mm = 60;
            pomVreme += DekToRoman(mm) + ":";
            int ss = DateTime.Now.Second;
            if (ss == 0)
                ss = 60;
            pomVreme += DekToRoman(ss);

            lblRoman.Text = pomVreme;
        }

        // F-ja za konverzija na broj vo rimski broj
        private StringBuilder DekToRoman(int n)
        {
            var romanN = new StringBuilder(5);
            var romanMap = new SortedDictionary<int, string>
            {
                { 1, "I" },
                { 4, "IV" },
                { 5, "V" },
                { 9, "IX" },
                { 10, "X" },
                { 40, "XL" },
                { 50, "L" },
                { 90, "XC" },
                { 100, "C" },
                { 400, "CD" },
                { 500, "D" },
                { 900, "CM" },
                { 1000, "M" },
            };

            foreach (var pom in romanMap.Reverse())
            {
                while (n >= pom.Key)
                {
                    n -= pom.Key;
                    romanN.Append(pom.Value);
                }
            }
            return romanN;
        }// kraj za DekToRoman(int n)

       
    }
}
