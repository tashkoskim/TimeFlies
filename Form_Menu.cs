using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeFlies.Clocks;

namespace TimeFlies
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Clock_Binary"] as Clock_Binary) != null)
            {
                //Form is already open
            }else
            {
                Clock_Binary obj = new Clock_Binary();
                obj.Show();
            }
            
        }

        private void btnMK_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Clock_MK"] as Clock_MK) != null)
            {
                //Form is already open
            }
            else
            {
                Clock_MK obj = new Clock_MK();
                obj.Show();
            }
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Clock_Hexa"] as Clock_Hexa) != null)
            {
                //Form is already open
            }
            else
            {
                Clock_Hexa obj = new Clock_Hexa();
                obj.Show();
            }
        }

        private void btnRoman_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Clock_Roman"] as Clock_Roman) != null)
            {
                //Form is already open
            }
            else
            {
                Clock_Roman obj = new Clock_Roman();
                obj.Show();
            }
        }

        private void buttonMorse_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Clock_Morse"] as Clock_Morse) != null)
            {
                //Form is already open
            }
            else
            {
                Clock_Morse obj = new Clock_Morse();
                obj.Show();
            }
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Clock_SignLanguage"] as Clock_SignLanguage) != null)
            {
                //Form is already open
            }
            else
            {
                Clock_SignLanguage obj = new Clock_SignLanguage();
                obj.Show();
            }
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Clock_English"] as Clock_English) != null)
            {
                //Form is already open
            }
            else
            {
                Clock_English obj = new Clock_English();
                obj.Show();
            }
        }

        private void btnBarcode_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Clock_Barcode"] as Clock_Barcode) != null)
            {
                //Form is already open
            }
            else
            {
                Clock_Barcode obj = new Clock_Barcode();
                obj.Show();
            }
        }

        private void btnDigital_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Clock_Digital"] as Clock_Digital) != null)
            {
                //Form is already open
            }
            else
            {
                Clock_Digital obj = new Clock_Digital();
                obj.Show();
            }
        }

        private void btnAbacus_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Clock_Abacus"] as Clock_Abacus) != null)
            {
                //Form is already open
            }
            else
            {
                Clock_Abacus obj = new Clock_Abacus();
                obj.Show();
            }
        }

        private void btnPredator_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Clock_predator"] as Clock_predator) != null)
            {
                //Form is already open
            }
            else
            {
                Clock_predator obj = new Clock_predator();
                obj.Show();
            }

        }

        private void btnAnalog_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Clock_Analog"] as Clock_Analog) != null)
            {
                //Form is already open
            }
            else
            {
                Clock_Analog obj = new Clock_Analog();
                obj.Show();
            }
        }

        private void btnCounter_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Clock_Counter"] as Clock_Counter) != null)
            {
                //Form is already open
            }
            else
            {
                Clock_Counter obj = new Clock_Counter();
                obj.Show();
            }
        }

        private void btnBall_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Clock_Balls"] as Clock_Balls) != null)
            {
                //Form is already open
            }
            else
            {
                Clock_Balls obj = new Clock_Balls();
                obj.Show();
            }
        }

        private void btn_Christmas_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Clock_Christmas"] as Clock_Christmas) != null)
            {
                //Form is already open
            }
            else
            {
                Clock_Christmas obj = new Clock_Christmas();
                obj.Show();
            }
        }
    }
}
