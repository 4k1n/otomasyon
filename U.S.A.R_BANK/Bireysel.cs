using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U.S.A.R_BANK
{
    public class Bireysel : Musteri
    {
        public List<Hesap> BireyselHesaplar = new List<Hesap>();

        public Bireysel()
        {

        }

        public override void HesapAc(Hesap h)
        {
            base.HesapAc(h);
            BireyselHesaplar.Add(h);
            
        }

        public override void HesapKapa(Hesap h)
        {
            base.HesapKapa(h);

            for (int i = 0; i < this.BireyselHesaplar.Count(); i++)
            {
                if (this.BireyselHesaplar[i].HesapNo == h.HesapNo)
                {
                    BireyselHesaplar.RemoveAt(i);
                }
            }

        }
    }
}

