using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeFlies.Clocks
{
    public partial class Clock_SignLanguage : Form
    {
        public Clock_SignLanguage()
        {
            InitializeComponent();
            
            
        }

        private void timerSign_Tick(object sender, EventArgs e)
        {
            // Digitalen casovnik
            DigitalClock objDigital = new DigitalClock();
            lblDigital.Text = objDigital.Digital_Clock();
            SignLanguageClock();
        }


        
      

        string pomHH = "00";
        string pomMM = "00";
        string pomSS = "00";

        private void SignLanguageClock()
        {
            
            int hh = DateTime.Now.Hour;
            if (hh == 0)
                hh = 24;
            pomHH = hh.ToString();
            if(pomHH.Length==1)
            {
                pBoxHH1.Image = null;
                pBoxHH2.Image = Image.FromFile(@"images\" + pomHH[0] + ".png");
            }else
            {
                pBoxHH1.Image = Image.FromFile(@"images\" + pomHH[0] + ".png");
                pBoxHH2.Image = Image.FromFile(@"images\" + pomHH[1] + ".png");
            }
            int mm = DateTime.Now.Minute;
            if (mm == 0)
                mm = 60;
            pomMM = mm.ToString();
            if (pomMM.Length == 1)
            {
                pBoxMM1.Image = null;
                pBoxMM2.Image = Image.FromFile(@"images\" + pomMM[0] + ".png");
            }
            else
            {
                pBoxMM1.Image = Image.FromFile(@"images\" + pomMM[0] + ".png");
                pBoxMM2.Image = Image.FromFile(@"images\" + pomMM[1] + ".png");
            }
            int ss = DateTime.Now.Second;
            if (ss == 0)
                ss = 60;
            pomSS = ss.ToString();
            if (pomSS.Length == 1)
            {
                pBoxSS1.Image = null;
                pBoxSS2.Image = Image.FromFile(@"images\" + pomSS[0] + ".png");
            }
            else
            {              
                
                pBoxSS1.Image = Image.FromFile(@"images\" + pomSS[0] + ".png");
                pBoxSS2.Image = Image.FromFile(@"images\" + pomSS[1] + ".png");
                
            }

        }

        //int s = 0;
        //private void timerSmeniSlika_Tick(object sender, EventArgs e)
        //{
        //    if(pomSS.Length==1)
        //    {
        //        if(pomSS[0] != predSS[0])
        //        {
        //            string pomTrans = pomSS[0] + "_trans.gif";
        //            string pomStatic = pomSS[0] + ".png";
        //            if (s == 0)
        //                pBoxHH1.Image = Image.FromFile(@"images\"+pomTrans+"");
        //            if (s >= 5)
        //            {
        //                //smeni slika
        //                pBoxHH1.Image = Image.FromFile(@"images\"+pomStatic+"");
        //                timerSmeniSlika.Stop();
        //                predSS = pomSS;
        //            }

        //            s++;
        //        }
        //    }else
        //    {
        //        if (pomSS[0] != predSS[0])
        //        {
        //            string pomTrans = pomSS + "_trans.gif";
        //            string pomStatic = pomSS + ".png";
        //            if (s == 0)
        //                pBoxHH1.Image = Image.FromFile(@"images\" + pomTrans + "");
        //            if (s >= 5)
        //            {
        //                //smeni slika
        //                pBoxHH1.Image = Image.FromFile(@"images\" + pomStatic + "");
        //                timerSmeniSlika.Stop();
        //                predSS = pomSS;
        //            }

        //            s++;
        //        }
        //    }
            
        //}


        
    }
}
