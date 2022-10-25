using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace KutuphaneUygulamasi
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
        private SyncListBoxes _SyncListBoxes = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.ForeColor = Color.Gray;
            menuStrip1.Font = new Font("Arial", 10, FontStyle.Regular);
            this.menuStrip1.BackColor = Color.FromArgb(255, 64, 64, 64);
            this._SyncListBoxes = new SyncListBoxes(this.yazarlar, this.kitaplar); 
        }

       
        public void kitapEkle(string kitapAdi)
        {
            kitaplar.Items.Add(kitapAdi);
        }
        public void yazarEkle(string yazarAdi)
        {
            yazarlar.Items.Add(yazarAdi);
        }
        public void kitapDuzenle(string duzenlenmisKitapAdi)
        {
            kitaplar.Items[kitaplar.SelectedIndex] = duzenlenmisKitapAdi;
        }
        public void yazarDuzenle(string duzenlenmisYazarAdi)
        {
            yazarlar.Items[yazarlar.SelectedIndex] = duzenlenmisYazarAdi;
        }

       
        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapEklemeEkrani kitapEklemeEkrani = new KitapEklemeEkrani(this);
            kitapEklemeEkrani.Show();
           
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            if (kitaplar.SelectedIndex < 0 && yazarlar.SelectedIndex < 0) return;
            DuzenlemeEkrani duzenlemeEkrani = new DuzenlemeEkrani(this);
            duzenlemeEkrani.Show();
            string yazarAdi = kitaplar.Items[kitaplar.SelectedIndex].ToString();
            string kitapAdi = yazarlar.Items[kitaplar.SelectedIndex].ToString();

            duzenlemeEkrani.yazardzn(yazarAdi);
            duzenlemeEkrani.kitapdzn(kitapAdi);
        }

       
        private void listBKitapAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            kitaplar.SelectedIndex = yazarlar.SelectedIndex;
            Duzenle.Focus();
            if (kitaplar.SelectedIndex >= 0 || yazarlar.SelectedIndex >= 0)
            {
                Duzenle.Enabled = true;
                Sil.Enabled = true;
                SecimKaldir.Enabled = true;
            }
            else
            {
                Duzenle.Enabled = false;
                Sil.Enabled = false;
                SecimKaldir.Enabled = false;
            }
        }

        private void listBYazarAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            yazarlar.SelectedIndex = kitaplar.SelectedIndex;
        }

        
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tümünü Silmek istediğinizden emin misiniz?", "Emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                yazarlar.Items.Clear();
                kitaplar.Items.Clear();
            }
        }

      
        private void btnSecimKaldir_Click(object sender, EventArgs e)
        {
            yazarlar.SelectedIndex = -1;
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            if (kitaplar.SelectedIndex >= 0 || yazarlar.SelectedIndex >= 0)
            {
                if (MessageBox.Show("Silmek istediğinizden emin misiniz?", "Emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int index = yazarlar.SelectedIndex;
                    yazarlar.Items.RemoveAt(index);
                    kitaplar.Items.RemoveAt(index);
                }
            }
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {

        }
    }
}