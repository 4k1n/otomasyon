using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U.S.A.R_BANK
{
    public class Ticari : Musteri
    {
        public List<Hesap> TicariHesaplar = new List<Hesap>();

        public Ticari()
        {

        }

        public override void HesapAc(Hesap h)
        {
            base.HesapAc(h);
            TicariHesaplar.Add(h);
        }

        public override void HesapKapa(Hesap h)
        {
            base.HesapKapa(h);

            for (int i = 0; i < this.TicariHesaplar.Count(); i++)
            {
                if (this.TicariHesaplar[i].HesapNo == h.HesapNo)
                {
                    TicariHesaplar.RemoveAt(i);
                }
            }

        }
    }
}
