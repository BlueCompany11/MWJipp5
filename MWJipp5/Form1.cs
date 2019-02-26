using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MWJipp5Lib;

namespace MWJipp5
{
    public partial class Form1 : Form
    {
        IstotaZyjaca czlowiek;
        IstotaZyjaca pies;

        public Form1()
        {
            InitializeComponent();
            czlowiek = new Czlowiek();
            pies = new Pies();
            czlowiek.Choroba += Czlowiek_Choroba;
            pies.Choroba += Pies_Choroba;
            btnCzlowiek.PrzyciskSieZuzyl += BtnCzlowiek_PrzyciskSieZuzyl;
            btnPies.PrzyciskSieZuzyl += BtnPies_PrzyciskSieZuzyl;
        }

        private void BtnPies_PrzyciskSieZuzyl()
        {
            MessageBox.Show("Pies zmarl smiercia naturalna");
        }

        private void BtnCzlowiek_PrzyciskSieZuzyl()
        {
            MessageBox.Show("Czlowiek zmarl smiercia naturalna");
        }
        
        private void Pies_Choroba()
        {
            MessageBox.Show("Pies zapadl w chorobe");
        }

        private void Czlowiek_Choroba()
        {
            MessageBox.Show("Czlowiek zapadl w chorobe");
        }

        private void btnCzlowiek_Click(object sender, EventArgs e)
        {
            czlowiek.PrzezyjRok();
        }

        private void btnPies_Click(object sender, EventArgs e)
        {
            pies.PrzezyjRok();
        }
    }
}
