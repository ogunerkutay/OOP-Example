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
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        void ChildForm(Form childForm)
        {
            bool durum = false;
            foreach (Form form in this.MdiChildren)
            {
                if(form.Name == childForm.Name)
                {
                    durum = true;
                    form.Activate();
                }
                else
                {
                    form.Close();
                }
            }

            if(durum == false)
            {
                childForm.MdiParent = this;
                Width = childForm.Width + 25;
                Height = childForm.Height + 70;
                childForm.Dock = DockStyle.Fill;
                childForm.Show();
            }
        }

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form1());
        }

        private void siparişBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form4());
        }

        private void menüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form2());
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form3());
        }
    }
}
