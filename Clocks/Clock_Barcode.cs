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
    public partial class Clock_Barcode : Form
    {
        public Clock_Barcode()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Digitalen casovnik
            DigitalClock objDigital = new DigitalClock();
            lblDigital.Text = objDigital.Digital_Clock();
            BarcodeClock();
        }

        // napraveno so koristenje na font sto pretvora text vo barcode 'Libre barcode'
        private void BarcodeClock()
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

            lblHH.Text = "Í" + pomHH+pomMM+pomSS+ "Î";
           
        }
    }
}
