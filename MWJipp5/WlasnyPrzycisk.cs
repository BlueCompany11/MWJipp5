using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MWJipp5
{
    public partial class WlasnyPrzycisk : Button
    {
        public int IloscWcisniec { get; private set; }
        public event Action PrzyciskSieZuzyl;
        int maxymalnaIloscWcisniec = 10;

        public WlasnyPrzycisk()
        {
            InitializeComponent();
            IloscWcisniec = 0;
            Click += WlasnyPrzycisk_Click;
        }

        private void WlasnyPrzycisk_Click(object sender, EventArgs e)
        {
            IloscWcisniec++;
            if(IloscWcisniec == maxymalnaIloscWcisniec)
            {
                if (PrzyciskSieZuzyl != null)
                {
                    PrzyciskSieZuzyl();
                }
            }
            if(IloscWcisniec >= maxymalnaIloscWcisniec)
            {
                this.Enabled = false;
            }
        }



    }
}
