using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U.S.A.R_BANK
{
    public abstract class Musteri
    {
        public List<Hesap> HesapListesi { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public ulong TcNo { get; set; }

        public DateTime DogumTarihi { get; set; }

        public string Adres { get; set; }

        public ulong Telefon { get; set; }

        public ulong MusteriNo { get; set; }

        public Musteri()
        {
            HesapListesi = new List<Hesap>();
        }

        public virtual void HesapAc(Hesap h)
        {
            HesapListesi.Add(h);
        }

        public virtual void HesapKapa(Hesap h)
        {
            for (int i = 0; i <this.HesapListesi.Count(); i++)
            {
                if(this.HesapListesi[i].HesapNo==h.HesapNo)
                {
                    HesapListesi.RemoveAt(i);
                }
            }
        }


    }
}
