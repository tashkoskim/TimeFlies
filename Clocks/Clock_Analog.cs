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
    public partial class Clock_Analog : Form
    {
        Bitmap back, hour, minute, second, glass;

        private void Clock_Analog_Load(object sender, EventArgs e)
        {

        }

        public Clock_Analog()
        {
            InitializeComponent();

            back = new Bitmap(@"images\Analog_clock.png");
            hour = new Bitmap(@"images\Analog_clock_mala.png");
            minute = new Bitmap(@"images\Analog_clock_golema.png");
            second = new Bitmap(@"images\Analog_clock_sekunda.png");
            glass = new Bitmap(@"images\Analog_clock_glass.png");
            AnalogClock();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            // Digitalen casovnik
            DigitalClock objDigital = new DigitalClock();
            lblDigital.Text = objDigital.Digital_Clock();

            AnalogClock();
        }

        private void AnalogClock()
        {
            DateTime Now = DateTime.Now;
            int hh = Now.Hour;
            int mm = Now.Minute;
            int ss = Now.Second;

            Single AngleS = ss * 6;
            Single AngleM = mm * 6 + AngleS / 60;
            Single AngleH = hh * 30 + AngleM / 12;

            backBox.Image = back;

            backBox.Controls.Add(hourBox);
            hourBox.Size = new Size(1000, 1008);
            hourBox.Location = new Point(-250, -252);
            hourBox.Image = rotateImage(hour, AngleH);

            hourBox.Controls.Add(minuteBox);
            minuteBox.Size = new Size(1000, 1008);
            minuteBox.Location = new Point(0, 0);
            minuteBox.Image = rotateImage(minute, AngleM);

            minuteBox.Controls.Add(secondBox);
            secondBox.Size = new Size(1000, 1008);
            secondBox.Location = new Point(0, 0);
            secondBox.Image = rotateImage(second, AngleS);

            secondBox.Controls.Add(pBoxGlass);

            pBoxGlass.Location = new Point(250, 250);
            pBoxGlass.Image = new Bitmap(@"images\Analog_clock_glass.png");
        }

        private Bitmap rotateImage(Bitmap rotateMe, float angle)
        {
            Bitmap rotatedImage = new Bitmap(rotateMe.Width, rotateMe.Height);

            using(Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform(rotateMe.Width / 2, rotateMe.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-rotateMe.Width / 2, -rotateMe.Height / 2);
               
                g.DrawImage(rotateMe, new Point(130, 131));
            }

            return rotatedImage;
        }
    }
}
