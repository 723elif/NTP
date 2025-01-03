using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Televizyon> televizyonListesi = new List<Televizyon>();
        private void Form1_Load(object sender, EventArgs e)
        {
            televizyonListesi.Add(new Televizyon("Samsung", "Android", 75, 38000,true));
            televizyonListesi.Add(new Televizyon("LG", "Web OS", 55, 24000, true));
            televizyonListesi.Add(new Televizyon("TLC", "Android", 75, 12000, false));
            televizyonListesi.Add(new Televizyon("Arçelik", "Smart", 75, 8000, false));
            televizyonListesi.Add(new Televizyon("LG", "Android", 105, 50000, true));


            dgvTelevizyon.DataSource = televizyonListesi.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string marka = txtMarka.Text;
            string isletimsistemi = txtİsletimSistemi.Text;
            int boyut = Convert.ToInt32(txtBoyut.Text);
            decimal fiyat = Convert.ToDecimal(txtFiyat.Text);
            bool stok = chkStok.Checked;

            Televizyon tv = new Televizyon(marka, isletimsistemi, boyut, fiyat, stok);

            televizyonListesi.Add(tv);
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Televizyon secilenTv = (Televizyon)dgvTelevizyon.SelectedRows[0].DataBoundItem;
            televizyonListesi.Remove(secilenTv);

            Listele();
              

       
        }


        void Listele()
        {
            dgvTelevizyon.DataSource = televizyonListesi.ToList();
        }
    }
}
