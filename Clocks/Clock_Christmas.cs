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
    public partial class Clock_Christmas : Form
    {
        public Clock_Christmas()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Digitalen casovnik
            DigitalClock objDigital = new DigitalClock();
            lblDigital.Text = objDigital.Digital_Clock();
            ChristmasCLock();
        }

        string pomHH = "00";
        string pomMM = "00";
        string pomSS = "00";
        string pomHHimageString = "Christmas_off_";
        string pomMMimageString = "Christmas_off_";
        string pomSSimageString = "Christmas_off_";
        private void ChristmasCLock()
        {

            int hh = DateTime.Now.Hour;
            //if (hh == 0)
            //    hh = 24;
            pomHH = hh.ToString();
            if (pomHH.Length == 1)
            {
                pBoxHH1.Image = Image.FromFile(@"images\Digits_lights\" + pomHHimageString + "0.gif");
                pBoxHH2.Image = Image.FromFile(@"images\Digits_lights\"+ pomHHimageString + pomHH[0] + ".gif");
            }
            else
            {
                pBoxHH1.Image = Image.FromFile(@"images\Digits_lights\" + pomHHimageString + pomHH[0] + ".gif");
                pBoxHH2.Image = Image.FromFile(@"images\Digits_lights\" + pomHHimageString + pomHH[1] + ".gif");
            }
            int mm = DateTime.Now.Minute;
            //if (mm == 0)
            //    mm = 60;
            pomMM = mm.ToString();
            if (pomMM.Length == 1)
            {
                pBoxMM1.Image = Image.FromFile(@"images\Digits_lights\" + pomMMimageString + "0.gif");
                pBoxMM2.Image = Image.FromFile(@"images\Digits_lights\" + pomMMimageString + pomMM[0] + ".gif");
            }
            else
            {
                pBoxMM1.Image = Image.FromFile(@"images\Digits_lights\" + pomMMimageString + pomMM[0] + ".gif");
                pBoxMM2.Image = Image.FromFile(@"images\Digits_lights\" + pomMMimageString + pomMM[1] + ".gif");
            }
            int ss = DateTime.Now.Second;
            //if (ss == 0)
            //    ss = 60;
            pomSS = ss.ToString();
            if (pomSS.Length == 1)
            {
                pBoxSS1.Image = Image.FromFile(@"images\Digits_lights\" + pomSSimageString + "0.gif");
                pBoxSS2.Image = Image.FromFile(@"images\Digits_lights\" + pomSSimageString + pomSS[0] + ".gif");
            }
            else
            {

                pBoxSS1.Image = Image.FromFile(@"images\Digits_lights\" + pomSSimageString + pomSS[0] + ".gif");
                pBoxSS2.Image = Image.FromFile(@"images\Digits_lights\" + pomSSimageString + pomSS[1] + ".gif");
            }

        }

        // hours
        #region hoursString
        private void rbH_Off_CheckedChanged(object sender, EventArgs e)
        {
            pomHHimageString = "Christmas_off_";
        }

        private void rbH_On_CheckedChanged(object sender, EventArgs e)
        {
            pomHHimageString = "Christmas_all_";
        }

        private void rbH_Random_CheckedChanged(object sender, EventArgs e)
        {
            pomHHimageString = "Christmas_random_";
        }
        #endregion

        //minutes
        #region minutesString
        private void rbM_Off_CheckedChanged(object sender, EventArgs e)
        {
            pomMMimageString = "Christmas_off_";
        }

        private void rbM_On_CheckedChanged(object sender, EventArgs e)
        {
            pomMMimageString = "Christmas_all_";
        }

        private void rbM_Random_CheckedChanged(object sender, EventArgs e)
        {
            pomMMimageString = "Christmas_random_";
        }
        #endregion

        //seconds
        #region secondsString
        private void rbS_Off_CheckedChanged(object sender, EventArgs e)
        {
            pomSSimageString = "Christmas_off_";
        }

        private void rbS_On_CheckedChanged(object sender, EventArgs e)
        {
            pomSSimageString = "Christmas_all_";
        }

        private void rbS_Random_CheckedChanged(object sender, EventArgs e)
        {
            pomSSimageString = "Christmas_random_";
        }
        #endregion
    }
}
