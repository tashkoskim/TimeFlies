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
    public partial class Clock_predator : Form
    {
        public Clock_predator()
        {
            InitializeComponent();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Digitalen casovnik
            DigitalClock objDigital = new DigitalClock();
            lblDigital.Text = objDigital.Digital_Clock();
            PredatorClock();
        }

        string pomHH = "00";
        string pomMM = "00";
        string pomSS = "00";

        private void PredatorClock()
        {

            int hh = DateTime.Now.Hour;
            if (hh == 0)
                hh = 24;
            pomHH = hh.ToString();
            if (pomHH.Length == 1)
            {
                pBoxHH1.Image = null;
                if (pomHH[0] == '0')
                    pBoxHH2.Image = null;
                else
                    pBoxHH2.Image = Image.FromFile(@"images\predator_" + pomHH[0] + ".png");
            }
            else
            {
                if (pomHH[0] == '0')
                    pBoxHH1.Image = null;
                else
                    pBoxHH1.Image = Image.FromFile(@"images\predator_" + pomHH[0] + ".png");
                if (pomHH[1] == '0')
                    pBoxHH2.Image = null;
                else
                    pBoxHH2.Image = Image.FromFile(@"images\predator_" + pomHH[1] + ".png");
            }
            int mm = DateTime.Now.Minute;
            if (mm == 0)
                mm = 60;
            pomMM = mm.ToString();
            if (pomMM.Length == 1)
            {
                pBoxMM1.Image = null;
                if (pomMM[0] == '0')
                    pBoxMM2.Image = null;
                else
                    pBoxMM2.Image = Image.FromFile(@"images\predator_" + pomMM[0] + ".png");
            }
            else
            {
                if (pomMM[0] == '0')
                    pBoxMM1.Image = null;
                else
                    pBoxMM1.Image = Image.FromFile(@"images\predator_" + pomMM[0] + ".png");
                if (pomMM[1] == '0')
                    pBoxMM2.Image = null;
                else
                    pBoxMM2.Image = Image.FromFile(@"images\predator_" + pomMM[1] + ".png");
            }
            int ss = DateTime.Now.Second;
            if (ss == 0)
                ss = 60;
            pomSS = ss.ToString();
            if (pomSS.Length == 1)
            {
                pBoxSS1.Image = null;
                if (pomSS[0] == '0')
                    pBoxSS2.Image = null;
                else
                    pBoxSS2.Image = Image.FromFile(@"images\predator_" + pomSS[0] + ".png");
            }
            else
            {
                if (pomSS[0] == '0')
                    pBoxSS1.Image = null;
                else
                    pBoxSS1.Image = Image.FromFile(@"images\predator_" + pomSS[0] + ".png");

                if(pomSS[1] == '0')
                    pBoxSS2.Image = null;
                else
                    pBoxSS2.Image = Image.FromFile(@"images\predator_" + pomSS[1] + ".png");

            }

        }
    }
}
