using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator1
{
    public partial class Kalkulator : Form
    {
        public Kalkulator()
        {
            InitializeComponent();
        }
        string LiczbaPierwsza, LiczbaDruga;
        char RodzajDzialania = ' ';
        private void Bdzielenie_Click(object sender, EventArgs e)
        {
            RodzajDzialania = '/';
            TBwynik.Text = "";
        }

        private void Bmnozenie_Click(object sender, EventArgs e)
        {
            RodzajDzialania = '*';
            TBwynik.Text = "";
        }

        private void Bodejmowanie_Click(object sender, EventArgs e)
        {
            RodzajDzialania = '-';
            TBwynik.Text = "";
        }

        private void Bdodawanie_Click(object sender, EventArgs e)
        {
            RodzajDzialania = '+';
            TBwynik.Text = "";
        }

        private void Bwynik_Click(object sender, EventArgs e)
        {
            switch (RodzajDzialania)
            {
                case ('+'):
                    TBwynik.Text = (int.Parse(LiczbaPierwsza) + int.Parse(LiczbaDruga)).ToString();
                        break;
                case ('-'):
                    TBwynik.Text = (int.Parse(LiczbaPierwsza) - int.Parse(LiczbaDruga)).ToString();
                    break;
                case ('*'):
                    TBwynik.Text = (int.Parse(LiczbaPierwsza) * int.Parse(LiczbaDruga)).ToString();
                    break;
                case ('/'):
                    TBwynik.Text = (int.Parse(LiczbaPierwsza) / int.Parse(LiczbaDruga)).ToString();
                    break;
            }

            LiczbaPierwsza = "";
            LiczbaDruga = "";
            RodzajDzialania = ' ';

        }

        private void B0_Click(object sender, EventArgs e)
        {
            Dzialanie(0);
        }

        private void B1_Click(object sender, EventArgs e)
        {
            Dzialanie(1);
        }

        private void B2_Click(object sender, EventArgs e)
        {
            Dzialanie(2);
        }

        private void B3_Click(object sender, EventArgs e)
        {
            Dzialanie(3);
        }

        private void B6_Click(object sender, EventArgs e)
        {
            Dzialanie(6);
        }

        private void B5_Click(object sender, EventArgs e)
        {
            Dzialanie(5);
        }

        private void B4_Click(object sender, EventArgs e)
        {
            Dzialanie(4);
        }

        private void B7_Click(object sender, EventArgs e)
        {
            Dzialanie(7);
        }

        private void B8_Click(object sender, EventArgs e)
        {
            Dzialanie(8);
        }

        private void B9_Click(object sender, EventArgs e)
        {
            Dzialanie(9);
        }

        private void TBwynik_TextChanged(object sender, EventArgs e)
        {

        }
        private void Dzialanie(int liczba)
        {
            if (RodzajDzialania == ' ')
            {
                LiczbaPierwsza += liczba;
                TBwynik.Text = LiczbaPierwsza;
            }
            else
            {
                LiczbaDruga += liczba;
                TBwynik.Text = LiczbaDruga;
            }
        }
    }
}
