using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U.S.A.R_BANK
{
    public partial class frmMusteriEkle : Form
    {
        public Banka banka;

        public frmMusteriEkle()
        {
            InitializeComponent();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            if (rbtnBireysel.Checked)
            {

                Bireysel mb = new Bireysel();

                mb.Ad = txtAd.Text;
                mb.Soyad = txtSoyad.Text;
                mb.TcNo = Convert.ToUInt64(txtTcNo.Text);
                mb.Telefon = Convert.ToUInt64(txtTelefon.Text);
                mb.Adres = txtAdres.Text;
                mb.DogumTarihi = Convert.ToDateTime(dtpDogum.Value);
                mb.MusteriNo = banka.BireyselMusteriNoAtama();

                

                banka.BireyselMusteriEkle(mb);
                MessageBox.Show("İşleminiz başarıyla gerçekleşmiştir."+Environment.NewLine+"Müşter Numaranız = "+mb.MusteriNo);
            }

            else if (rbtnTicari.Checked)
            {


                Ticari mt = new Ticari();

                mt.Ad = txtAd.Text;
                mt.Soyad = txtSoyad.Text;
                mt.TcNo = Convert.ToUInt64(txtTcNo.Text);
                mt.Telefon = Convert.ToUInt64(txtTelefon.Text);
                mt.Adres = txtAdres.Text;
                mt.DogumTarihi = Convert.ToDateTime(dtpDogum.Value);
                mt.MusteriNo = banka.TicariMusteriNoAtama();
                

                banka.TicariMusteriEkle(mt);
                MessageBox.Show("İşleminiz başarıyla gerçekleşmiştir." + Environment.NewLine + "Müşter Numaranız = " + mt.MusteriNo);
            }   

            else
                MessageBox.Show("Hesap Türü Seçmek Zorunludur");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


