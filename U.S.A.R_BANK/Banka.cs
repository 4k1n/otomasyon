using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U.S.A.R_BANK
{
    public class Banka
    {        
        public ulong SubeKodu;
        public ulong HesapNo;
        public ulong MusteriNo;
        public ulong TipNO;
        public decimal BankaVarlik { get; set; }

        public List<Hesap> BankaHesapListesi = new List<Hesap>();
        public List<Bireysel> BireyselMusteriler = new List<Bireysel>();
        public List<Ticari> TicariMusteriler = new List<Ticari>();

        public void BireyselMusteriEkle(Bireysel mb)
        {
            BireyselMusteriler.Add(mb);
        }
        public void TicariMusteriEkle(Ticari mt)
        {
            TicariMusteriler.Add(mt);
        }

        public ulong BireyselHesapNoAtama()
        {
            SubeKodu = 162800000000;
            Random HspNo = new Random();
            HesapNo = Convert.ToUInt64(HspNo.Next(10000000, 50000000));
            HesapNo = HesapNo + SubeKodu;
            if (HesapNoKontrol(HesapNo) != -1)
                HesapNo=BireyselHesapNoAtama();

            return HesapNo;
        }
        public ulong TicariHesapNoAtama()
        {
            SubeKodu = 162800000000;
            Random HspNo = new Random();
            HesapNo = Convert.ToUInt64(HspNo.Next(0000000, 100000000));
            HesapNo = HesapNo + SubeKodu;
            if (HesapNoKontrol(HesapNo) != -1)
                HesapNo=TicariHesapNoAtama();

            return HesapNo;
        }

        public ulong BireyselMusteriNoAtama()
        {
            TipNO = 70000000;
            Random MstrNo = new Random();
            MusteriNo = Convert.ToUInt64(MstrNo.Next(1000000, 9000000));
            MusteriNo += TipNO;
            if (MusteriNoKontrol(MusteriNo) != -1)
               MusteriNo= BireyselMusteriNoAtama();

            return MusteriNo;
        }
        public ulong TicariMusteriNoAtama()
        {
            TipNO = 90000000;
            Random MstrNo = new Random();
            MusteriNo = Convert.ToUInt64(MstrNo.Next(1000000, 9000000));
            MusteriNo += TipNO;
            if (MusteriNoKontrol(MusteriNo) != -1)
                MusteriNo=TicariMusteriNoAtama();

            return MusteriNo;
        }

        public void GelirGiderRaporu()
        {

        }

        public void MusteriHesapAc(ulong KEMN,Hesap h)
        {
            if (KEMN / 10000000 == 7)
            {
                for (int i = 0; i < BireyselMusteriler.Count(); i++)
                {
                    if (BireyselMusteriler[i].MusteriNo == KEMN)
                    {
                        BireyselMusteriler[i].HesapAc(h);
                        BankaHesapListesi.Add(h);
                        BankaVarlik += 500M;
                    }
                }
            }

            else if (KEMN / 10000000 == 9)
            {
                for (int i = 0; i < TicariMusteriler.Count(); i++)
                {
                    if (TicariMusteriler[i].MusteriNo == KEMN)
                    {
                        TicariMusteriler[i].HesapAc(h);
                        BankaHesapListesi.Add(h);
                    }
                }
            }
        }
        public void MusteriHesapKapa(ulong KEMN,ulong KEHN,short KES)
        {
            if (KEMN / 10000000 == 7)
            {
                for (int i = 0; i < BireyselMusteriler.Count(); i++)
                {
                    if (BireyselMusteriler[i].MusteriNo == KEMN)
                    {
                        for (int j = 0; j < BankaHesapListesi.Count(); j++)
                        {
                            if (BankaHesapListesi[j].HesapNo == KEHN)
                            {
                                if (BankaHesapListesi[j].Sifre == KES)
                                {
                                    if(BankaHesapListesi[j].Bakiye==0M)
                                    {
                                        BireyselMusteriler[i].HesapKapa(BankaHesapListesi[j]);
                                        BankaHesapListesi.RemoveAt(j);
                                    }
                                    else
                                    {
                                        System.Windows.Forms.MessageBox.Show("Hesabınız kapatılamamıştır." + "\n" + "Bunun Nedenleri :" + "\n" + "1.Bakiyeniz 0 tl olmaması" + "\n" + "2.Ek Hesapdan kullandığınız paranın geri ödenmemesi" + "\n" + "olabilir");
                                    }
                                }
                                else
                                    System.Windows.Forms.MessageBox.Show("Yanlış Bir Şifre Girdiniz ! ");

                            }
                            
                        }
                    }
                }
            }

            else if (KEMN / 10000000 == 9)
            {
                for (int i = 0; i < TicariMusteriler.Count(); i++)
                {
                    if (TicariMusteriler[i].MusteriNo == KEMN)
                    {
                        for (int j = 0; j < BankaHesapListesi.Count(); j++)
                        {
                            if (BankaHesapListesi[j].HesapNo == KEHN)
                            {
                                if (BankaHesapListesi[j].Sifre == KES)
                                {
                                    TicariMusteriler[i].HesapKapa(BankaHesapListesi[j]);
                                    BankaHesapListesi.RemoveAt(j);
                                }
                                else
                                    System.Windows.Forms.MessageBox.Show("Yanlış Bir Şifre Girdiniz ! ");

                            }
                            else
                                System.Windows.Forms.MessageBox.Show("Girdiğiniz Hesap Numarası Sisteme Kayıtlı Değildir !!!");
                        }
                    }
                }
            }
        }

        public int MusteriNoKontrol(ulong KontrolNo)
        {
            int sonuc = -1;

            if (KontrolNo / 10000000 == 7)
            {
                for (int i = 0; i < BireyselMusteriler.Count(); i++)
                {
                    if (BireyselMusteriler[i].MusteriNo == KontrolNo)
                    {
                        sonuc = i;
                    }
                }
            }

            else if (KontrolNo / 10000000 == 9)
            {
                for (int i = 0; i < TicariMusteriler.Count(); i++)
                {
                    if (TicariMusteriler[i].MusteriNo == KontrolNo)
                    {
                        sonuc = i;
                    }
                }
            }

            return sonuc;
        }
        public int HesapNoKontrol(ulong KontrolNo)
        {
            int sonuc = -1;

            if ((KontrolNo - 162800000000) > 10000000)
            {
                for (int i = 0; i < BankaHesapListesi.Count(); i++)
                {
                    if (BankaHesapListesi[i].HesapNo == KontrolNo)
                        sonuc = i;
                }

            }

            return sonuc;
        }
        public string HesapOzetKontrol(ulong KontrolNo, short KontrolSifre)
        {

            string temp = "";

            if (KontrolNo - 162800000000 > 10000000)
            {
                
                for (int i = 0; i < BankaHesapListesi.Count(); i++)
                {
                    if (BankaHesapListesi[i].HesapNo == KontrolNo)
                    {
                        if (BankaHesapListesi[i].Sifre==KontrolSifre)
                        {
                          temp= BankaHesapListesi[i].HesapÖzetiGöster(BankaHesapListesi[i]);
                        }
                        else
                            System.Windows.Forms.MessageBox.Show("Yanlış Bir Şifre Girdiniz ! ");

                    }
                    else
                        System.Windows.Forms.MessageBox.Show("Girdiğiniz Hesap Numarası Sisteme Kayıtlı Değildir !!!" );
                }

            }

            return temp;
        }

        public string BakiyeGöster(ulong KontrolNo, short KontrolSifre)
        {

            string temp = "";

            if (KontrolNo - 162800000000 > 10000000)
            {

                for (int i = 0; i < BankaHesapListesi.Count(); i++)
                {
                    if (BankaHesapListesi[i].HesapNo == KontrolNo)
                    {
                        if (BankaHesapListesi[i].Sifre == KontrolSifre)
                        {
                            temp =Convert.ToString(BankaHesapListesi[i].Bakiye);
                        }
                        else
                            System.Windows.Forms.MessageBox.Show("Yanlış Bir Şifre Girdiniz ! ");

                    }
                    
                }

            }

            return temp;
        }

        public string MusteriSorgulama(ulong KontrolNo)
        {
            string  temp = "Sorgulanan Musterinin Bilgileri :  "+Environment.NewLine;

            if ((KontrolNo / 10000000) == 7)
            {
                for (int i = 0; i < BireyselMusteriler.Count(); i++)
                {
                    if (BireyselMusteriler[i].MusteriNo == KontrolNo)
                    {
                        temp += "Adı = " + BireyselMusteriler[i].Ad + Environment.NewLine +
                              "Soyadı = " + BireyselMusteriler[i].Soyad + Environment.NewLine +
                              "Tc Kimlik No = " + BireyselMusteriler[i].TcNo + Environment.NewLine +
                              "Doğum Tarihi = " + BireyselMusteriler[i].DogumTarihi + Environment.NewLine +
                              "Telefon Numarası = " + BireyselMusteriler[i].Telefon + Environment.NewLine +
                              "Adresi = " + BireyselMusteriler[i].Adres;
                    }
                }
            }

            else if ((KontrolNo / 10000000) == 9)
            {
                for (int i = 0; i < TicariMusteriler.Count(); i++)
                {
                    if (TicariMusteriler[i].MusteriNo == KontrolNo)
                    {
                        temp += "Adı = " + TicariMusteriler[i].Ad + Environment.NewLine +
                              "Soyadı = " + TicariMusteriler[i].Soyad + Environment.NewLine +
                              "Tc Kimlik No = " + TicariMusteriler[i].TcNo + Environment.NewLine +
                              "Doğum Tarihi = " + TicariMusteriler[i].DogumTarihi + Environment.NewLine +
                              "Telefon Numarası = " + TicariMusteriler[i].Telefon + Environment.NewLine +
                              "Adresi = " + TicariMusteriler[i].Adres;
                    }
                }
            }

            return temp;
        }

        public string HesapKontrol(ulong KontrolNo)
        {
            string temp = "";

            if ((KontrolNo - 162800000000) < 50000000)
            {
                for (int i = 0; i < BireyselMusteriler.Count(); i++)
                {
                    for (int j = 0; j < BireyselMusteriler[i].HesapListesi.Count(); j++)
                    {
                        if (BireyselMusteriler[i].HesapListesi[j].HesapNo == KontrolNo)
                        {
                            temp += "Bu Hesap " + BireyselMusteriler[i].MusteriNo +" "+ " no'lu " + BireyselMusteriler[i].Ad + " " + BireyselMusteriler[i].Soyad +"  "+"şahsına aittir.";
                        }
                            
                    }
                }

            }

            else if ((KontrolNo - 162800000000) > 50000000)
            {
                for (int i = 0; i < TicariMusteriler.Count(); i++)
                {
                    for (int j = 0; j < TicariMusteriler[i].HesapListesi.Count(); j++)
                    {
                        if (TicariMusteriler[i].HesapListesi[j].HesapNo == KontrolNo)
                        { 
                            temp += "Bu Hesap " + TicariMusteriler[i].MusteriNo + "no'lu " + TicariMusteriler[i].Ad + " " + TicariMusteriler[i].Soyad + " " + "şahsına aittir.";
                        }
                    }
                }

            }

            else
                temp += "Girilen hesap numarasına bağlı hesap bulunamamıştır.";

            return temp;
        }


        public void ParaYatırma(ulong KontrolNo, short KontrolSifre,decimal Tutar)
        {

            if (KontrolNo - 162800000000 > 10000000)
            {

                for (int i = 0; i < BankaHesapListesi.Count(); i++)
                {
                    if (BankaHesapListesi[i].HesapNo == KontrolNo)
                    {
                        if (BankaHesapListesi[i].Sifre == KontrolSifre)
                        {
                            BankaHesapListesi[i].ParaYatir(BankaHesapListesi[i], Tutar);
                        }
                        else
                            System.Windows.Forms.MessageBox.Show("Yanlış Bir Şifre Girdiniz ! ");

                    }
                   
                }

            }

            
        }
        public void ParaCekme(ulong KontrolNo, short KontrolSifre, decimal Tutar)
        {

            if (KontrolNo - 162800000000 > 10000000)
            {
                
                for (int i = 0; i < BankaHesapListesi.Count(); i++)
                {
                    if (BankaHesapListesi[i].HesapNo == KontrolNo)
                    {
                        if (BankaHesapListesi[i].Sifre == KontrolSifre)
                        {
                            BankaHesapListesi[i].ParaCekme(BankaHesapListesi[i], Tutar);
                        }
                        else
                            System.Windows.Forms.MessageBox.Show("Yanlış Bir Şifre Girdiniz ! ");

                    }

                }

            }


        }
    }
}
