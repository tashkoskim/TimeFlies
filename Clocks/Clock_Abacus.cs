using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeFlies.Clocks
{
    public partial class Clock_Abacus : Form
    {
        public Clock_Abacus()
        {
            InitializeComponent();
        }

        
        Point[] nizaSSPocetniLokacii1 = new Point[5], nizaSSPocetniLokacii2 = new Point[5];
        Point[] nizaMMPocetniLokacii1 = new Point[5], nizaMMPocetniLokacii2 = new Point[5];
        Point[] nizaHHPocetniLokacii1 = new Point[5], nizaHHPocetniLokacii2 = new Point[5];
        private void Clock_Abacus_Load(object sender, EventArgs e)
        {
            //sekundi
            nizaSSPocetniLokacii1[0] = ss1_1.Location;
            nizaSSPocetniLokacii1[1] = ss1_2.Location;
            nizaSSPocetniLokacii1[2] = ss1_3.Location;
            nizaSSPocetniLokacii1[3] = ss1_4.Location;
            nizaSSPocetniLokacii1[4] = ss1_5.Location;


            nizaSSPocetniLokacii2[0] = ss2_1.Location;
            nizaSSPocetniLokacii2[1] = ss2_2.Location;
            nizaSSPocetniLokacii2[2] = ss2_3.Location;
            nizaSSPocetniLokacii2[3] = ss2_4.Location;
            nizaSSPocetniLokacii2[4] = ss2_5.Location;
            //minuti
            nizaMMPocetniLokacii1[0] = mm1_1.Location;
            nizaMMPocetniLokacii1[1] = mm1_2.Location;
            nizaMMPocetniLokacii1[2] = mm1_3.Location;
            nizaMMPocetniLokacii1[3] = mm1_4.Location;
            nizaMMPocetniLokacii1[4] = mm1_5.Location;


            nizaMMPocetniLokacii2[0] = mm2_1.Location;
            nizaMMPocetniLokacii2[1] = mm2_2.Location;
            nizaMMPocetniLokacii2[2] = mm2_3.Location;
            nizaMMPocetniLokacii2[3] = mm2_4.Location;
            nizaMMPocetniLokacii2[4] = mm2_5.Location;
            //saati
            nizaHHPocetniLokacii1[0] = hh1_1.Location;
            nizaHHPocetniLokacii1[1] = hh1_2.Location;
            nizaHHPocetniLokacii1[2] = hh1_3.Location;
            nizaHHPocetniLokacii1[3] = hh1_4.Location;
            nizaHHPocetniLokacii1[4] = hh1_5.Location;


            nizaHHPocetniLokacii2[0] = hh2_1.Location;
            nizaHHPocetniLokacii2[1] = hh2_2.Location;
            nizaHHPocetniLokacii2[2] = hh2_3.Location;
            nizaHHPocetniLokacii2[3] = hh2_4.Location;
            nizaHHPocetniLokacii2[4] = hh2_5.Location;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Digitalen casovnik
            DigitalClock objDigital = new DigitalClock();
            lblDigital.Text = objDigital.Digital_Clock();
            AbacusClock();
        }

        private void AbacusClock()
        {
            //ResetBeads();
            
            int hh = DateTime.Now.Hour;
            if (hh == 0)
                hh = 24;

            int mm = DateTime.Now.Minute;
            if (mm == 0)
                mm = 60;

            int ss = DateTime.Now.Second;
            if (ss == 0)
                ss = 60;

            //saati
            PictureBox[] nizaPBh1 = { hh1_1, hh1_2, hh1_3, hh1_4, hh1_5 };
            PictureBox[] nizaPBh2 = { hh2_1, hh2_2, hh2_3, hh2_4, hh2_5 };
            int pomHH2 = 0, pomHH1 = hh;
            if (hh >= 10)
            {
                pomHH1 = hh % 10;
                pomHH2 = hh / 10;
                MoveBeads(pomHH2, nizaPBh1, nizaHHPocetniLokacii1);
            }else if(hh==1)
                MoveBeads(0, nizaPBh1, nizaHHPocetniLokacii1);
            MoveBeads(pomHH1, nizaPBh2, nizaHHPocetniLokacii2);
            //---------------------------

            //minuti
            PictureBox[] nizaPBm1 = { mm1_1, mm1_2, mm1_3, mm1_4, mm1_5 };
            PictureBox[] nizaPBm2 = { mm2_1, mm2_2, mm2_3, mm2_4, mm2_5 };
            int pomMM2 = 0, pomMM1 = mm;
            if (mm >= 10)
            {
                pomMM1 = mm % 10;
                pomMM2 = mm / 10;
                MoveBeads(pomMM2, nizaPBm1, nizaMMPocetniLokacii1);
            }else if(mm==1)
                MoveBeads(0, nizaPBm1, nizaMMPocetniLokacii1);
            MoveBeads(pomMM1, nizaPBm2, nizaMMPocetniLokacii2);
            //---------------------------

            //sekundi
            PictureBox[] nizaPBs1 = { ss1_1, ss1_2, ss1_3, ss1_4, ss1_5 };
            PictureBox[] nizaPBs2 = { ss2_1, ss2_2, ss2_3, ss2_4, ss2_5 };
            int pomSS2 = 0, pomSS1 = ss;
            if(ss>=10)
            {
                pomSS1 = ss % 10;
                pomSS2 = ss / 10;
                MoveBeads(pomSS2, nizaPBs1, nizaSSPocetniLokacii1);
            }else if(ss==1)
                MoveBeads(0, nizaPBs1, nizaSSPocetniLokacii1);
            MoveBeads(pomSS1, nizaPBs2, nizaSSPocetniLokacii2);
            //---------------------------
        }

        private void MoveBeads(int n, PictureBox[] niza, Point[] nizaPocetok)
        {
            
            switch(n)
            {
                case 1:
                    niza[0].Location = new Point(nizaPocetok[0].X, nizaPocetok[0].Y - 94);
                    niza[1].Location = new Point(nizaPocetok[1].X, nizaPocetok[1].Y);
                    niza[2].Location = new Point(nizaPocetok[2].X, nizaPocetok[2].Y);
                    niza[3].Location = new Point(nizaPocetok[3].X, nizaPocetok[3].Y);
                    niza[4].Location = new Point(nizaPocetok[4].X, nizaPocetok[4].Y);
                    break;
                case 2:
                    niza[0].Location = new Point(nizaPocetok[0].X, nizaPocetok[0].Y - 94);
                    niza[1].Location = new Point(nizaPocetok[1].X, nizaPocetok[1].Y - 94);
                    niza[2].Location = new Point(nizaPocetok[2].X, nizaPocetok[2].Y);
                    niza[3].Location = new Point(nizaPocetok[3].X, nizaPocetok[3].Y);
                    niza[4].Location = new Point(nizaPocetok[4].X, nizaPocetok[4].Y);
                    break;
                case 3:
                    niza[0].Location = new Point(nizaPocetok[0].X, nizaPocetok[0].Y - 94);
                    niza[1].Location = new Point(nizaPocetok[1].X, nizaPocetok[1].Y - 94);
                    niza[2].Location = new Point(nizaPocetok[2].X, nizaPocetok[2].Y - 94);
                    niza[3].Location = new Point(nizaPocetok[3].X, nizaPocetok[3].Y);
                    niza[4].Location = new Point(nizaPocetok[4].X, nizaPocetok[4].Y);
                    break;
                case 4:
                    niza[0].Location = new Point(nizaPocetok[0].X, nizaPocetok[0].Y - 94);
                    niza[1].Location = new Point(nizaPocetok[1].X, nizaPocetok[1].Y - 94);
                    niza[2].Location = new Point(nizaPocetok[2].X, nizaPocetok[2].Y - 94);
                    niza[3].Location = new Point(nizaPocetok[3].X, nizaPocetok[3].Y - 94);
                    niza[4].Location = new Point(nizaPocetok[4].X, nizaPocetok[4].Y);
                    break;
                case 5:
                    niza[4].Location = new Point(nizaPocetok[4].X, nizaPocetok[4].Y + 57);
                    niza[0].Location = new Point(nizaPocetok[0].X, nizaPocetok[0].Y);
                    niza[1].Location = new Point(nizaPocetok[1].X, nizaPocetok[1].Y);
                    niza[2].Location = new Point(nizaPocetok[2].X, nizaPocetok[2].Y);
                    niza[3].Location = new Point(nizaPocetok[3].X, nizaPocetok[3].Y);
                    break;
                case 6:
                    niza[4].Location = new Point(nizaPocetok[4].X, nizaPocetok[4].Y + 57);
                    niza[0].Location = new Point(nizaPocetok[0].X, nizaPocetok[0].Y - 94);
                    niza[1].Location = new Point(nizaPocetok[1].X, nizaPocetok[1].Y);
                    niza[2].Location = new Point(nizaPocetok[2].X, nizaPocetok[2].Y);
                    niza[3].Location = new Point(nizaPocetok[3].X, nizaPocetok[3].Y);
                    break;
                case 7:
                    niza[4].Location = new Point(nizaPocetok[4].X, nizaPocetok[4].Y + 57);
                    niza[0].Location = new Point(nizaPocetok[0].X, nizaPocetok[0].Y - 94);
                    niza[1].Location = new Point(nizaPocetok[1].X, nizaPocetok[1].Y - 94);
                    niza[2].Location = new Point(nizaPocetok[2].X, nizaPocetok[2].Y);
                    niza[3].Location = new Point(nizaPocetok[3].X, nizaPocetok[3].Y);
                    break;
                case 8:
                    niza[4].Location = new Point(nizaPocetok[4].X, nizaPocetok[4].Y + 57);
                    niza[0].Location = new Point(nizaPocetok[0].X, nizaPocetok[0].Y - 94);
                    niza[1].Location = new Point(nizaPocetok[1].X, nizaPocetok[1].Y - 94);
                    niza[2].Location = new Point(nizaPocetok[2].X, nizaPocetok[2].Y - 94);
                    niza[3].Location = new Point(nizaPocetok[3].X, nizaPocetok[3].Y);
                    break;
                case 9:
                    niza[4].Location = new Point(nizaPocetok[4].X, nizaPocetok[4].Y + 57);
                    niza[0].Location = new Point(nizaPocetok[0].X, nizaPocetok[0].Y - 94);
                    niza[1].Location = new Point(nizaPocetok[1].X, nizaPocetok[1].Y - 94);
                    niza[2].Location = new Point(nizaPocetok[2].X, nizaPocetok[2].Y - 94);
                    niza[3].Location = new Point(nizaPocetok[3].X, nizaPocetok[3].Y - 94);
                    break;
                case 0:
                    // 0
                    niza[4].Location = new Point(nizaPocetok[4].X, nizaPocetok[4].Y);
                    niza[0].Location = new Point(nizaPocetok[0].X, nizaPocetok[0].Y);
                    niza[1].Location = new Point(nizaPocetok[1].X, nizaPocetok[1].Y);
                    niza[2].Location = new Point(nizaPocetok[2].X, nizaPocetok[2].Y);
                    niza[3].Location = new Point(nizaPocetok[3].X, nizaPocetok[3].Y);
                    break;
            }
            
        }

        
        //private void ResetBeads()
        //{
        //    ss1_1.Location = pomSS1_1;
        //    ss1_2.Location = pomSS1_2;
        //    ss1_3.Location = pomSS1_3;
        //    ss1_4.Location = pomSS1_4;
        //    ss1_5.Location = pomSS1_5;

        //    ss2_1.Location = pomSS2_1;
        //    ss2_2.Location = pomSS2_2;
        //    ss2_3.Location = pomSS2_3;
        //    ss2_4.Location = pomSS2_4;
        //    ss2_5.Location = pomSS2_5;
        //}
    }
}
