using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_HamburgerMenu
{
    public class Siparis
    {
        public Siparis()
        {
            EkstraMalzemeler = new List<Ekstra>();
        }
        public Menu SecilenMenu{ get; set; }
        public List<Ekstra> EkstraMalzemeler { get; set; }
        public Boyut Boyut { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SecilenMenu.Fiyat;
            switch (Boyut)
            {
                case Boyut.Orta:
                    ToplamTutar *= 1.1M;
                    break;
                case Boyut.Büyük:
                    ToplamTutar *= 1.25M;
                    break;
            }

            foreach (Ekstra ekstra in EkstraMalzemeler)
            {
                ToplamTutar += ekstra.Fiyat;
            }

            ToplamTutar *= Adet;
        }

        public override string ToString()
        {
            string bilgilendirme = null;

            if(EkstraMalzemeler.Count < 1)
            {
                bilgilendirme = $"{SecilenMenu.Ad} Menü x {Adet} adet, {Boyut} boy, Toplam= {ToplamTutar:C2}";
            }
            else
            {
                string ekstralar = null;
                foreach (Ekstra ekstra in EkstraMalzemeler)
                {
                    ekstralar += ekstra.Ad + ", ";
                }

                bilgilendirme = $"{SecilenMenu.Ad} Menü x {Adet} adet, {Boyut} boy, {ekstralar} Toplam= {ToplamTutar:C2}";
            }

            return bilgilendirme;
        }
    }
}
