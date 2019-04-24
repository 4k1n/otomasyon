using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U.S.A.R_BANK
{
   public class Havale
    {
        public decimal HavaleTutarı { get; set; }

        public Hesap Gönderen { get; set; }

        public Hesap Alıcı { get; set; }

        public void MusteriKontrol()
        {
            
        }

        public string HavaleBilgileriGöster(Hesap h)
        {
            string temp = "";

            temp += Environment.NewLine+"Gönderen Kişinin Hesap Numarası: " + h.HesapNo + Environment.NewLine +
                    //"Alan Kişinin Hesap Numarası: " + Alıcı.HesapNo + Environment.NewLine +  
                    //Alıcı değeri dönmediği için program hata veriyor o yüzden yorum satırı yapdım çözmeye çalışıcam çözerseniz yazın abi
                    "Gönderilen Miktar: " + HavaleTutarı + Environment.NewLine;

            return temp;

        }
    }
}
