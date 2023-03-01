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
    public partial class Clock_ASCII : Form
    {
        public Clock_ASCII()
        {
            InitializeComponent();
        }

        private void timer_ASCII_Tick(object sender, EventArgs e)
        {
            // Digitalen casovnik
            DigitalClock objDigital = new DigitalClock();
            lblDigital.Text = objDigital.Digital_Clock();
            ASCIIclock();
        }

        private void ASCIIclock()
        {
            int hh = DateTime.Now.Hour;
            if (hh == 0)
                hh = 24;
           

            int mm = DateTime.Now.Minute;
            if (mm == 0)
                mm = 60;
            

            int ss = DateTime.Now.Second;
            if (ss == 0)
                ss = 60;

            hh = 2;
            mm = 1;
            rtxtBox_ASCII.Text = ((char)1).ToString() + " : " + (char)mm + " : " + (char)2;
            
        }

        private void Clock_ASCII_Load(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.UTF8.GetBytes("☻");

            Encoding enc = System.Text.Encoding.Unicode;

            rtxtBox_ASCII.Text = enc.GetString(bytes);
        }
    }
}
