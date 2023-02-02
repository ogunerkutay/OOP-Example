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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnEkstraEkle_Click(object sender, EventArgs e)
        {
            Form1.ekstralar.Add(new Ekstra { Ad = txtEkstraAdi.Text, Fiyat = nudEkstraFiyati.Value });
            Helper.Temizle(Controls);
            MessageBox.Show("Ekstra malzeme eklendi");
        }
    }
}
