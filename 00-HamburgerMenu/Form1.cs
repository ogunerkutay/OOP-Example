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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<Siparis> tumSiparisler = new List<Siparis>();
        public static List<Siparis> yeniSiparisler = new List<Siparis>();

        public static List<Menu> menuler = new List<Menu>()
        {
            new Menu{Ad = "Big King", Fiyat = 18.25M},
            new Menu{Ad = "Whoopper", Fiyat = 15.25M},
            new Menu{Ad = "Chicken Royal", Fiyat = 11.25M},
            new Menu{Ad = "Köfte Burger", Fiyat = 22.25M},
            new Menu{Ad = "Gamer", Fiyat = 20.25M}
        };

        public static List<Ekstra> ekstralar = new List<Ekstra>()
        {
            new Ekstra{Ad = "Ketçap", Fiyat = 0.5M},
            new Ekstra{Ad = "Mayonez", Fiyat = 0.5M},
            new Ekstra{Ad = "BBQ", Fiyat = 0.75M},
            new Ekstra{Ad = "Hardal", Fiyat = 1M},
            new Ekstra{Ad = "Ranch", Fiyat = 1M},
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in menuler)
            {
                cbMenuler.Items.Add(item);
            }

            foreach (var item in ekstralar)
            {
                flpEkstraMalzemeler.Controls.Add(new CheckBox() {Text = item.Ad, Tag = item });
            }

            foreach (var item in yeniSiparisler)
            {
                lbxSiparisler.Items.Add(item);
            }

            TutarHesaplaVeYazdır();

            rbKucuk.Checked = true;
            cbMenuler.SelectedIndex = 0;
        }

        decimal TutarHesaplaVeYazdır()
        {
            decimal toplamTutar = 0;
            for (int i = 0; i < lbxSiparisler.Items.Count; i++)
            {
                Siparis siparis = (Siparis)lbxSiparisler.Items[i];
                toplamTutar += siparis.ToplamTutar;
            }

            lblToplamTutar.Text = toplamTutar.ToString("C2");
            return toplamTutar;
        }

        private void btnSiparisiEkle_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.SecilenMenu = (Menu)cbMenuler.SelectedItem;   //seçilen menü

            if (rbKucuk.Checked) siparis.Boyut = Boyut.Küçük;      //boyut
            else if (rbOrta.Checked) siparis.Boyut = Boyut.Orta;
            else siparis.Boyut = Boyut.Büyük;

            foreach (CheckBox item in flpEkstraMalzemeler.Controls)
            {
                if (item.Checked) siparis.EkstraMalzemeler.Add((Ekstra)item.Tag);    //ekstralar
            }

            siparis.Adet = Convert.ToInt32(nudAdet.Value);   //adet

            siparis.Hesapla();

            tumSiparisler.Add(siparis);
            yeniSiparisler.Add(siparis);
            lbxSiparisler.Items.Add(siparis);
            TutarHesaplaVeYazdır();

            Helper.Temizle(Controls);


        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Toplam sipariş Tutarı: " + TutarHesaplaVeYazdır().ToString("C2") + "\nSiparişi tamamlamak ister misiniz?", "Sipariş Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dialogResult == DialogResult.Yes)
            {
                lbxSiparisler.Items.Clear();
                yeniSiparisler.Clear();
                lblToplamTutar.Text = "0";
                MessageBox.Show("Siparişiniz tamamlandı");
            }
            else
            {
                MessageBox.Show("Siparişiniz devam ediyor");
            }
        }
    }
}
