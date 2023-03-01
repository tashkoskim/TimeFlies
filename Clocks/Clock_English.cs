using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeFlies.Clocks
{
    public partial class Clock_English : Form
    {
        public Clock_English()
        {
            InitializeComponent();
        }

        

        private void timerEnglish_Tick(object sender, EventArgs e)
        {
            // Digitalen casovnik
            DigitalClock objDigital = new DigitalClock();
            lblDigital.Text = objDigital.Digital_Clock();
            EnglishCLock();
        }

        private void EnglishCLock()
        {
            disableAll();

            lblEnglishTime.Text = string.Empty;
            lblSeconds.Text = string.Empty;
            string pomVreme = string.Empty;
            int hh = DateTime.Now.Hour%12;
            if (hh == 0)
                hh = 24;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            if (mm == 0)
                pomVreme = "It's " + PretvoriBrojTextEN(hh) + " o'clock.";
            else if (mm == 15)
                pomVreme = "It's quarter past " + PretvoriBrojTextEN(hh) + ".";
            else if (mm == 45)
                pomVreme = "It's quarter to " + PretvoriBrojTextEN(hh + 1) + ".";
            else if (mm == 30)
                pomVreme = "It's half past " + PretvoriBrojTextEN(hh) + ".";
            else if (mm > 0 && mm < 30)
                pomVreme = "It's " + PretvoriBrojTextEN(mm) + " past " + PretvoriBrojTextEN(hh) + ".";
            else if (mm < 60 && mm > 30)
                pomVreme = "It's " + PretvoriBrojTextEN(60-mm) + " to " + PretvoriBrojTextEN(hh+1) + ".";
            //pomVreme += " and " + PretvoriBrojTextEN(ss)+" seconds.";

            UkluciSijalici(hh,mm);
            lblEnglishTime.Text = pomVreme;
            lblSeconds.Text = PretvoriBrojTextEN(ss) + " seconds";
        }

        private void UkluciSijalici(int hh, int mm)
        {
            pBox_itis.Visible = true;
            if (mm >= 57 || mm <=3)
            {
                UkluciSijaliciZaSaat(hh);
                pBox_oclock.Visible = true;
            }
            else if (mm >= 13 && mm<=17)
            {
                pBox_quarter.Visible = true;
                pBox_past.Visible = true;
                UkluciSijaliciZaSaat(hh);
            }
            else if (mm >= 43 && mm <= 47)
            {
                pBox_quarter.Visible = true;
                pBox_to.Visible = true;
                UkluciSijaliciZaSaat(hh+1);
            }
            else if (mm >= 28 && mm <=32)
            {
                pBox_half.Visible = true;
                pBox_past.Visible = true;
                UkluciSijaliciZaSaat(hh);
            }
            else if (mm >= 3 && mm <= 7)
            {
                pBox_five1.Visible = true;
                pBox_past.Visible = true;
                UkluciSijaliciZaSaat(hh);
            }
            else if (mm >= 8 && mm <= 12)
            {
                pBox_ten1.Visible = true;
                pBox_past.Visible = true;
                UkluciSijaliciZaSaat(hh);
            }
            else if (mm >= 18 && mm <= 22)
            {
                pBox_twenty.Visible = true;
                pBox_past.Visible = true;
                UkluciSijaliciZaSaat(hh);
            }
            else if (mm >= 23 && mm <= 27)
            {
                pBox_twenty.Visible = true;
                pBox_five1.Visible = true;
                pBox_past.Visible = true;
                UkluciSijaliciZaSaat(hh);
            }
            else if (mm >= 33 && mm <= 37)
            {
                pBox_twenty.Visible = true;
                pBox_five1.Visible = true;
                pBox_to.Visible = true;
                UkluciSijaliciZaSaat(hh + 1);
            }
            else if (mm >= 38 && mm <= 42)
            {
                pBox_twenty.Visible = true;
                pBox_to.Visible = true;
                UkluciSijaliciZaSaat(hh + 1);
            }
            else if (mm >= 48 && mm <= 52)
            {
                pBox_ten1.Visible = true;
                pBox_to.Visible = true;
                UkluciSijaliciZaSaat(hh + 1);
            }
            else if (mm >= 53 && mm <= 56)
            {
                pBox_five1.Visible = true;
                pBox_to.Visible = true;
                UkluciSijaliciZaSaat(hh+1);
            }

        }

        private void UkluciSijaliciZaSaat(int hh)
        {
            if (hh == 0 || hh == 12)
            {
                pBox_twelve.Visible = true;
            }
            else if (hh == 1)
                pBox_one.Visible = true;
            else if (hh == 2)
                pBox_two.Visible = true;
            else if (hh == 3)
                pBox_three.Visible = true;
            else if (hh == 4)
                pBox_four.Visible = true;
            else if (hh == 5)
                pBox_five2.Visible = true;
            else if (hh == 6)
                pBox_six.Visible = true;
            else if (hh == 7)
                pBox_seven.Visible = true;
            else if (hh == 8)
                pBox_eight.Visible = true;
            else if (hh == 9)
                pBox_nine.Visible = true;
            else if (hh == 10)
                pBox_ten2.Visible = true;
            else if (hh == 11)
                pBox_eleven.Visible = true;

        }
        private void disableAll()
        {
            pBox_itis.Visible = false;
            pBox_half.Visible = false;
            pBox_ten1.Visible = false;
            pBox_quarter.Visible = false;
            pBox_twenty.Visible = false;
            pBox_five1.Visible = false;
            pBox_minutes.Visible = false;
            pBox_to.Visible = false;
            pBox_past.Visible = false;
            pBox_two.Visible = false;
            pBox_three.Visible = false;
            pBox_one.Visible = false;
            pBox_four.Visible = false;
            pBox_five2.Visible = false;
            pBox_six.Visible = false;
            pBox_seven.Visible = false;
            pBox_eight.Visible = false;
            pBox_nine.Visible = false;
            pBox_ten2.Visible = false;
            pBox_eleven.Visible = false;
            pBox_twelve.Visible = false;
            pBox_oclock.Visible = false;
        }
        private static string PretvoriBrojTextEN(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + PretvoriBrojTextEN(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += PretvoriBrojTextEN(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += PretvoriBrojTextEN(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += PretvoriBrojTextEN(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }

        
    }
}
