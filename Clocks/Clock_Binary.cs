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
    public partial class Clock_Binary : Form
    {
        public Clock_Binary()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Digitalen casovnik
            DigitalClock objDigital = new DigitalClock();
            lblDigital.Text = objDigital.Digital_Clock();
            BinaryClock();
        }

        // Binaren casovnik
        private void BinaryClock()
        {
            TurnLedsOff();
            int hh = DateTime.Now.Hour;
            if (hh < 10)
            {
                TurnLedOn(DekToBin(hh), 'H', false, true);
            }
            else
            {
                int hh_br1 = hh / 10;
                int hh_br2 = hh % 10;
                TurnLedOn(DekToBin(hh_br1), 'H', true, false);
                TurnLedOn(DekToBin(hh_br2), 'H', false, true);
            }
            int mm = DateTime.Now.Minute;
            if (mm < 10)
            {
                TurnLedOn(DekToBin(mm), 'M', false, true);
            }
            else
            {
                int mm_br1 = mm / 10;
                int mm_br2 = mm % 10;
                TurnLedOn(DekToBin(mm_br1), 'M', true, false);
                TurnLedOn(DekToBin(mm_br2), 'M', false, true);
            }
            int ss = DateTime.Now.Second;
            if (ss < 10)
            {
                TurnLedOn(DekToBin(ss), 'S', false, true);
            }
            else
            {
                int ss_br1 = ss / 10;
                int ss_br2 = ss % 10;
                TurnLedOn(DekToBin(ss_br1), 'S', true, false);
                TurnLedOn(DekToBin(ss_br2), 'S', false, true);
            }
        }// Kraj BinaryCLock()

        private void TurnLedOn(string bin, char tip, bool br1, bool br2)
        {
            if (tip == 'H')
            {
                // hour
                if (br1 == true)
                {
                    if (bin[2] == '1')
                        pBx_H1_2.BackgroundImage = Image.FromFile(@"images\LedRedOn.png");
                    if (bin[3] == '1')
                        pBx_H1_1.BackgroundImage = Image.FromFile(@"images\LedRedOn.png");
                }
                else if (br2 == true)
                {
                    if (bin[0] == '1')
                        pBx_H2_8.BackgroundImage = Image.FromFile(@"images\LedRedOn.png");
                    if (bin[1] == '1')
                        pBx_H2_4.BackgroundImage = Image.FromFile(@"images\LedRedOn.png");
                    if (bin[2] == '1')
                        pBx_H2_2.BackgroundImage = Image.FromFile(@"images\LedRedOn.png");
                    if (bin[3] == '1')
                        pBx_H2_1.BackgroundImage = Image.FromFile(@"images\LedRedOn.png");
                }
            }

            else if (tip == 'M')
            {
                // minute
                if (br1 == true)
                {
                    if (bin[1] == '1')
                        pBx_M1_4.BackgroundImage = Image.FromFile(@"images\LedBlueOn.png");
                    if (bin[2] == '1')
                        pBx_M1_2.BackgroundImage = Image.FromFile(@"images\LedBlueOn.png");
                    if (bin[3] == '1')
                        pBx_M1_1.BackgroundImage = Image.FromFile(@"images\LedBlueOn.png");
                }
                else if (br2 == true)
                {
                    if (bin[0] == '1')
                        pBx_M2_8.BackgroundImage = Image.FromFile(@"images\LedBlueOn.png");
                    if (bin[1] == '1')
                        pBx_M2_4.BackgroundImage = Image.FromFile(@"images\LedBlueOn.png");
                    if (bin[2] == '1')
                        pBx_M2_2.BackgroundImage = Image.FromFile(@"images\LedBlueOn.png");
                    if (bin[3] == '1')
                        pBx_M2_1.BackgroundImage = Image.FromFile(@"images\LedBlueOn.png");
                }

            }


            else if (tip == 'S')
            {
                // second
                if (br1 == true)
                {
                    if (bin[1] == '1')
                        pBx_S1_4.BackgroundImage = Image.FromFile(@"images\LedYellowOn.png");
                    if (bin[2] == '1')
                        pBx_S1_2.BackgroundImage = Image.FromFile(@"images\LedYellowOn.png");
                    if (bin[3] == '1')
                        pBx_S1_1.BackgroundImage = Image.FromFile(@"images\LedYellowOn.png");
                }
                else if (br2 == true)
                {
                    if (bin[0] == '1')
                        pBx_S2_8.BackgroundImage = Image.FromFile(@"images\LedYellowOn.png");
                    if (bin[1] == '1')
                        pBx_S2_4.BackgroundImage = Image.FromFile(@"images\LedYellowOn.png");
                    if (bin[2] == '1')
                        pBx_S2_2.BackgroundImage = Image.FromFile(@"images\LedYellowOn.png");
                    if (bin[3] == '1')
                        pBx_S2_1.BackgroundImage = Image.FromFile(@"images\LedYellowOn.png");
                }

            }

        }// Kraj TurnLedOn()

        private void TurnLedsOff()
        {
            // hour
            pBx_H1_2.BackgroundImage = Image.FromFile(@"images\LedRedOff.png");
            pBx_H1_1.BackgroundImage = Image.FromFile(@"images\LedRedOff.png");
            pBx_H2_8.BackgroundImage = Image.FromFile(@"images\LedRedOff.png");
            pBx_H2_4.BackgroundImage = Image.FromFile(@"images\LedRedOff.png");
            pBx_H2_2.BackgroundImage = Image.FromFile(@"images\LedRedOff.png");
            pBx_H2_1.BackgroundImage = Image.FromFile(@"images\LedRedOff.png");

            // minute
            pBx_M1_4.BackgroundImage = Image.FromFile(@"images\LedBlueOff.png");
            pBx_M1_2.BackgroundImage = Image.FromFile(@"images\LedBlueOff.png");
            pBx_M1_1.BackgroundImage = Image.FromFile(@"images\LedBlueOff.png");
            pBx_M2_8.BackgroundImage = Image.FromFile(@"images\LedBlueOff.png");
            pBx_M2_4.BackgroundImage = Image.FromFile(@"images\LedBlueOff.png");
            pBx_M2_2.BackgroundImage = Image.FromFile(@"images\LedBlueOff.png");
            pBx_M2_1.BackgroundImage = Image.FromFile(@"images\LedBlueOff.png");

            // second
            pBx_S1_4.BackgroundImage = Image.FromFile(@"images\LedYellowOff.png");
            pBx_S1_2.BackgroundImage = Image.FromFile(@"images\LedYellowOff.png");
            pBx_S1_1.BackgroundImage = Image.FromFile(@"images\LedYellowOff.png");
            pBx_S2_8.BackgroundImage = Image.FromFile(@"images\LedYellowOff.png");
            pBx_S2_4.BackgroundImage = Image.FromFile(@"images\LedYellowOff.png");
            pBx_S2_2.BackgroundImage = Image.FromFile(@"images\LedYellowOff.png");
            pBx_S2_1.BackgroundImage = Image.FromFile(@"images\LedYellowOff.png");

        }// Kraj TurnLedsOff()

        // F-ja za pretvoranje na dekaden vo binaren sistem
        private string DekToBin(int br)
        {
            string binaren = "";
            int pom = br;
            List<int> brojki = new List<int>();
            while (br >= 1)
            {
                brojki.Add(br % 2);
                br = br / 2;
            }

            //pecatenje na listata so for
            for (int i = brojki.Count - 1; i >= 0; i--)
            {
                binaren += brojki[i];
            }
            if (binaren != "0" && binaren.Length == 1)
                binaren = "000" + binaren;
            else if (binaren != "0" && binaren.Length == 2)
                binaren = "00" + binaren;
            else if (binaren != "0" && binaren.Length == 3)
                binaren = "0" + binaren;
            if (pom == 0)
                binaren = "0000";

            return binaren;
        }// Kraj DekToBin()

        
    }

}
