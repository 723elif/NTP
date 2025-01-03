using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_1
{
    internal class Televizyon
    {
        string marka;
        string isletimSistemi;
        int boyut;
        decimal fiyat;
        bool stok;

        public string Marka { get => marka; set => marka = value; }
        public string Model { get => isletimSistemi; set => isletimSistemi = value; }
        public int Boyut { get => boyut; set => boyut = value; }
        public decimal Fiyat { get => fiyat; set => fiyat = value; }
        public bool Stok { get => stok; set => stok = value; }

        public Televizyon(string marka, string model, int boyut, decimal fiyat, bool stok)
        {
            Marka = marka;
            Model = isletimSistemi;
            Boyut = boyut;
            Fiyat = fiyat;
            Stok = stok;
        }


    }
}
