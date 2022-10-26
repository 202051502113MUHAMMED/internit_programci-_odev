using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapEklemeEkrani kitapEklemeEkrani = new KitapEklemeEkrani(this);
            kitapEklemeEkrani.Show();
            this.Hide();
        }

        public void kitapEkle(string kitapAdi)
        {
            listBox1.Items.Add(kitapAdi);
        }
    }
}
