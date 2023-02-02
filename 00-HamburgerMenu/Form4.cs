using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _00_HamburgerMenu
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal ekstraMalzemeGeliri = 0;
            int satisAdedi = 0;

            if(Form1.tumSiparisler != null)
            {
                foreach (Siparis siparis in Form1.tumSiparisler)
                {
                    ciro += siparis.ToplamTutar;

                    foreach (Ekstra ekstra in siparis.EkstraMalzemeler)
                    {
                        ekstraMalzemeGeliri += ekstra.Fiyat;
                    }

                    satisAdedi += siparis.Adet;
                    lbxTumSiparisler.Items.Add(siparis);
                }
            }

            lblCiro.Text = ciro.ToString("C2");
            lblEkstraMalzemeGeliri.Text = ekstraMalzemeGeliri.ToString("C2");
            lblSatilanUrunAdedi.Text = satisAdedi.ToString();
            lblToplamSiparisSayisi.Text = lbxTumSiparisler.Items.Count.ToString();
        }
    }
}
