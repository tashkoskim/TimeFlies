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
    public partial class Clock_Balls : Form
    {
        class Mover
        {
            static Random rnd = new Random();
            Vector2 location;
            Vector2 velocity;
            SolidBrush color;

            public Mover(int width1, int height1, int width2, int height2, SolidBrush c)
            {
                location = new Vector2(rnd.Next(width1, width2), rnd.Next(height1, height2));
                velocity = new Vector2(rnd.Next(3), 2);
                color = c;
            }

            public void Update(int w1, int h1, int w2, int h2)
            {
                // velocity.X = rnd.Next(-10, 11);
                // velocity.Y = rnd.Next(-10, 11);
                if (location.X < w1 || location.X > w2)
                {
                    velocity.X *= -1;
                }
                if (location.Y < h1 || location.Y > h2)
                {
                    velocity.Y *= -1;
                }
                location = Vector2.Add(location, velocity);
            }

            public void Display(Graphics e)
            {
                e.FillEllipse(color, location.X, location.Y, 20, 20);
            }
        }

        Mover mover;
        List<Mover> secondsMovers = new List<Mover>();
        List<Mover> minutesMovers = new List<Mover>();
        List<Mover> hoursMovers = new List<Mover>();
        int s=0, m=0, h = 0;
        int sBoja = 240, mBoja=240, hBoja=240;
        public Clock_Balls()
        {
            InitializeComponent();
        }

        private void Clock_Balls_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            Timer timer = new Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
            timer.Enabled = true;
            //-------------------------

            s = DateTime.Now.Second;
            if (s == 0)
                s = 60;

            for (int i = 0; i < s; i++)
            {
                Color testC = Color.FromArgb(sBoja, sBoja, 255);
                sBoja -= 4;
                mover = new Mover(610, 0, 885, 300, new SolidBrush(testC));
                secondsMovers.Add(mover);
            }
            //------------------------------
            // minutes
            m = DateTime.Now.Minute;
            if (m == 0)
                m = 60;

            for (int i = 0; i < m; i++)
            {
                Color testC = Color.FromArgb(mBoja, 255, mBoja);
                mBoja -= 4;
                mover = new Mover(310, 0, 580, 300, new SolidBrush(testC));
                minutesMovers.Add(mover);
            }
            //------------------------------
            // hours
            h = DateTime.Now.Hour;
            if (h == 0)
                m = 24;

            for (int i = 0; i < h; i++)
            {
                Color testC = Color.FromArgb(255, hBoja, hBoja);
                hBoja -= 10;
                mover = new Mover(0, 0, 280, 300, new SolidBrush(testC));
                hoursMovers.Add(mover);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Digitalen casovnik
            DigitalClock objDigital = new DigitalClock();
            lblDigital.Text = objDigital.Digital_Clock();

            s++;
            if (s>=60)
            {
                secondsMovers.Clear();
                s = 1;
                sBoja = 240;
                //-----------------
                m++;
                Color testC = Color.FromArgb(mBoja, 255, mBoja);
                mBoja -= 4;
                mover = new Mover(310, 0, 580, 300, new SolidBrush(testC));
                minutesMovers.Add(mover);
            }
            else
            {
                Color testC = Color.FromArgb(sBoja, sBoja, 255);
                sBoja -= 4;
                mover = new Mover(610, 0, 885, 300, new SolidBrush(testC));
                secondsMovers.Add(mover);
            }

            //------------------
           
            if (m >= 60)
            {
                minutesMovers.Clear();
                m = 0;
                mBoja = 240;
                //----------------
                h++;
                Color testC = Color.FromArgb(255, hBoja, hBoja);
                hBoja -= 10;
                mover = new Mover(0, 0, 280, 300, new SolidBrush(testC));
                hoursMovers.Add(mover);
            }

            if(h>=24)
            {
                hoursMovers.Clear();
                h = 0;
                hBoja = 240; 
            }
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Invalidate();
        }

        private void Clock_Balls_Paint(object sender, PaintEventArgs e)
        {
            foreach (Mover m in secondsMovers)
            {
                m.Update(610, 0, 885, 300);
                m.Display(e.Graphics);
            }

            foreach (Mover m in minutesMovers)
            {
                m.Update(310, 0, 580, 300);
                m.Display(e.Graphics);
            }

            foreach (Mover m in hoursMovers)
            {
                m.Update(0, 0, 280, 300);
                m.Display(e.Graphics);
            }
        }
    }
}
