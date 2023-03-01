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
    public partial class Clock_MK : Form
    {
        public Clock_MK()
        {
            InitializeComponent();
        }

        private void timerMK_Tick(object sender, EventArgs e)
        {
            // Digitalen casovnik
            DigitalClock objDigital = new DigitalClock();
            lblDigital.Text = objDigital.Digital_Clock();
            MKClock();
        }

        // Casovnik sto gi pretvora brojkite vo mk zborovi (pravi korekcija samo na 'eden' vo 'edna' pr. sekunda ili minuva, 'dva' vo 'dve'
        public void MKClock()
        {
            lblCas.Text = string.Empty;
            lblMM.Text = string.Empty;
            lblSS.Text = string.Empty;
            string pomVreme = string.Empty;
            int hh = DateTime.Now.Hour;
            string pomHH = PretvoriBrojTextMK(hh) + " часот, ";
            if (hh == 0)
                pomHH = "Дваесет и четири часот, ";
            pomVreme =  pomHH + Environment.NewLine;
            lblCas.Text = UppercaseFirst(pomVreme);

            int mm = DateTime.Now.Minute;
            string pomMM = PretvoriBrojTextMK(mm) + " минути и ";
            if (pomMM.Contains("еден"))
                pomMM = pomMM.Replace("еден минути", "една минута");
            if (pomMM.Contains("два"))
                pomMM = pomMM.Replace("два минути","две минути");
            pomVreme = pomMM + Environment.NewLine;
            lblMM.Text = pomVreme;

            int ss = DateTime.Now.Second;
            string pomSS = PretvoriBrojTextMK(ss) + " секунди.";
            if (pomSS.Contains("еден"))
                pomSS = pomSS.Replace("еден секунди.","една секунда.");
            if (pomSS.Contains("два"))
                pomSS = pomSS.Replace("два секунди.", "две секунди.");
            if (ss == 0)
                pomSS = " шеесет секунди.";
            pomVreme = pomSS;
            lblSS.Text = pomVreme;
        }

        static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        public string PretvoriBrojTextMK(int br)
        {
            string broj = "";
            string[] nizaBroeviOsnovni = { "", "еден", "два", "три", "четири", "пет", "шест", "седум", "осум", "девет", "десет", "единаесет", "дванаесет", "тринаесет", "четиринаесет", "петнаесет", "шестнаесет", "седумнаесет", "осумнаесет", "деветнаесет" };
            string[] nizaBroevi10ki = { "", "десет", "дваесет", "триесет", "четириесет", "педесет", "шеесет", "седумдесет", "осумдесет", "деведесет" };
            string[] nizaBroevi100ki = { "", "сто", "двесте", "триста", "четиристотини", "петстотини", "шестотини", "седумстотини", "осумстотини", "деветстотини" };
            //string[] nizaBroevi1000ki = {"илјада","","","","","","","",""}


            //pomosen broj
            // int pomBr = br;

            if (br >= 0 && br < 20)
            {
                broj = nizaBroeviOsnovni[br];
            }
            else if (br >= 10 && br < 100)
            {
                broj += nizaBroevi10ki[br / 10];
                br %= 10;
                if (br > 0)
                    broj += " и " + PretvoriBrojTextMK(br);
            }
            else if (br >= 100 && br < 1000)
            {
                broj += nizaBroevi100ki[br / 100];
                br %= 100;
                if (br > 0)
                    broj += " " + PretvoriBrojTextMK(br);
            }
            else if (br >= 1000 && br < 2000)
            {
                broj += "илјада";
                br %= 1000;
                if (br > 0)
                    broj += " " + PretvoriBrojTextMK(br);
            }
            else if (br >= 2000 && br < 3000)
            {
                broj += "две илјади";
                br %= 2000;
                if (br > 0)
                    broj += " " + PretvoriBrojTextMK(br);
            }
            else if (br >= 3000 && br < 1000000)
            {
                broj += PretvoriBrojTextMK(br / 1000) + " илјади";
                broj = broj.Replace(" два ", " две ");
                br %= 1000;
                if (br > 0)
                    broj += " " + PretvoriBrojTextMK(br);
            }
            else if (br >= 1000000 && br < 2000000)
            {
                broj += "еден милион";
                br %= 1000000;
                if (br > 0)
                    broj += " " + PretvoriBrojTextMK(br);
            }
            else if (br >= 2000000 && br <= 999999999)
            {
                broj += PretvoriBrojTextMK(br / 1000000) + " милиони";
                br %= 1000000;
                if (br > 0)
                    broj += " " + PretvoriBrojTextMK(br);
            }

            if (broj == "" && br == 0)
                broj = "нула";
            if (br < 0)
                broj = "минус " + PretvoriBrojTextMK(Math.Abs(br));
            return broj;
        }

        
    }
}
