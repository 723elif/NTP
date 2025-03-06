using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ErrorProvider ep = new ErrorProvider();

     

        private void txtNumara_Validating(object sender, CancelEventArgs e)
        {

            if (int.TryParse(txtNumara.Text, out int sonuc))
            {
                ep.SetError(txtNumara, "");
            }
            else
            {
                e.Cancel = true;
                ep.SetError(txtNumara, "Numara Giriş Hatalı");
            }
        }

        private void txtAdSoyad_Validating(object sender, CancelEventArgs e)
        {
            if (txtAdSoyad.Text == "")
            {
                e.Cancel= true;
                ep.SetError(txtAdSoyad,"");
            }
        }

        private void txtDersNotu_Validating(object sender, CancelEventArgs e)
        {
            int dersnotu;
            if (int.TryParse(txtDersNotu.Text, out dersnotu))
            {
                if (dersnotu < 0 || dersnotu > 100)
                {
                    e.Cancel = true;
                    ep.SetError(txtDersNotu, "0 ile 100 arasına değer giriniz");
                }
                else
                {
                    ep.SetError(txtDersNotu, "");
                }
            }
            else
            {
                e.Cancel = true;
                ep.SetError(txtDersNotu, "Sayılal değer giriniz");
            }
            }

        }
    }

