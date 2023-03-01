using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeFlies
{
    class DigitalClock
    {
        public string Digital_Clock()
        {
            ////////Digitalen casovnik////////////
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
                time += hh;
            time += ":";
            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
                time += mm;
            time += ":";
            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
                time += ss;
            //lblDigital.Text = time;
            return time;
            /////////////////////////////
        }// Kraj DigitalClock()
    }
}
