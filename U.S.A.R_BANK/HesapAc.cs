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
    public partial class frmHesapAc : Form
    {
        public Banka banka;
        public Hesap h;
        public ulong KEMN;
    
        public frmHesapAc()
        {
            InitializeComponent();
        }

        private void btnHesapOlustur_Click(object sender, EventArgs e)
        {
            if (rbtnBireysel.Checked)
            {
                KEMN = Convert.ToUInt64(txtMNGiriniz.Text);
                h = new Hesap();
                h.Sifre = Convert.ToInt16(txtSifre.Text);
                h.Meslek = txtMeslek.Text;
                h.HesapNo = banka.BireyselHesapNoAtama();
                banka.MusteriHesapAc(KEMN,h);

                MessageBox.Show("Hesap Numaranız = "+h.HesapNo);

            }

            else if (rbtnTicari.Checked)
            {
                KEMN = Convert.ToUInt64(txtMNGiriniz.Text);
                h = new Hesap();
                h.Sifre = Convert.ToInt16(txtSifre.Text);
                h.Sirket = txtSirket.Text;
                h.HesapNo = banka.TicariHesapNoAtama();
                banka.MusteriHesapAc(KEMN, h);

                MessageBox.Show("Hesap Numaranız = " + h.HesapNo);

            }

            else
                MessageBox.Show("Hesap Türü Seçmek Zorunludur");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtnBireysel_CheckedChanged(object sender, EventArgs e)
        {
            txtSirket.Hide();
            label3.Hide();

            txtMeslek.Show();
            label2.Show();
            txtMNGiriniz.Text = Convert.ToString(7);
        }

        private void rbtnTicari_CheckedChanged(object sender, EventArgs e)
        {
            txtMeslek.Hide();
            label2.Hide();

            txtSirket.Show();
            label3.Show();
            txtMNGiriniz.Text = Convert.ToString(9);
        }

        private void frmHesapAc_Load(object sender, EventArgs e)
        {
            label2.Hide();
            label3.Hide();

            txtMeslek.Hide();
            txtSirket.Hide();
            
        }

    }
}
