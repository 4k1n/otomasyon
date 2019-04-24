using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U.S.A.R_BANK
{
    public class Hesap
    {
        public decimal Bakiye { get; set; }

        public decimal Limit { get; set; }

        public decimal Yatirilan { get; set; }
                    
        public decimal Cekilen { get; set; }

        public ulong HesapNo { get; set; }

        public short Sifre { get; set; }

        public string Meslek { get; set; }

        public string Sirket { get; set; }

        public EkHesap Ekhesap { get; set; }

        public Havale HavaleBilgileri { get; set; }

        public Hesap()
        {
            this.Ekhesap = new EkHesap();

            this.HavaleBilgileri = new Havale();

            this.Limit = 750M;

            this.Yatirilan = 0M;

            this.Cekilen = 0M;

        }

        public string HesapÖzetiGöster(Hesap h)
        {
            string temp = "";

            temp += "Hesap Bakiyeniz = " + h.Bakiye + Environment.NewLine +
                   "Ek Bakiyeniz = " + h.Ekhesap.EkBakiye + Environment.NewLine+ 
                   "Havale İşlemleriniz = "+Environment.NewLine+
                   "Hesaptan Çekilen Para Tutarı = "+h.Cekilen+Environment.NewLine+
                   "Hesaptan Yatırılan Para Tutarı = " + h.Yatirilan + Environment.NewLine +
                   "Havale İşlemleriniz = " + h.HavaleBilgileri.HavaleBilgileriGöster(h);

            return temp;
        }

        public void ParaCekme(Hesap h, decimal Tutar)
        {
            decimal temp;
            Limit -= Tutar;

            if ((Tutar>h.Bakiye) && (Tutar>(h.Bakiye+h.Ekhesap.EkBakiye)))
            {
                System.Windows.Forms.MessageBox.Show("Yeterli Bakiyeniz Bulunmamaktadır!"+"\nBakiyenizi öğrenmek için Bakiye Sorgulama sekmesinden yararlanabilirsiniz.");
            }
            else if ((Tutar<=h.Bakiye) && (Tutar<=Limit))
            {
                h.Bakiye -= Tutar;
                Cekilen += Tutar;
            }
            else if ((Tutar > h.Bakiye) && (Tutar < (h.Bakiye + h.Ekhesap.EkBakiye)))
            {
                temp=Tutar-h.Bakiye;
                h.Ekhesap.EkBakiye -= temp;
                h.Bakiye -= (Tutar - temp);
                Cekilen += Tutar;

                System.Windows.Forms.MessageBox.Show("Bakiyeniz yetersiz olduğu için "+temp+" tl Ek hesabınızdan çekilmiştir." );
            }
        }

        public void ParaYatir(Hesap h,decimal Tutar)
        {
            h.Bakiye += Tutar;
            Yatirilan += Tutar;
        }
    }
}
