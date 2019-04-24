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
    public partial class frmParaCekme : Form
    {
        public Banka banka;

        ulong KontHesapNo;
        short Sifre;
        decimal Tutar;

        public frmParaCekme()
        {
            InitializeComponent();
        }

        private void btnParaCekme_Click(object sender, EventArgs e)
        {
            KontHesapNo = Convert.ToUInt64(txtHesapNo.Text);
            Sifre = Convert.ToInt16(txtSife.Text);
            Tutar = Convert.ToDecimal(txtTutar.Text);

            if (Tutar>750)
            {
                MessageBox.Show("Hesaptan günlük para çekme limiti 750 tl dir");
            }
            else if (Tutar < 750)
            {
                banka.ParaCekme(KontHesapNo, Sifre, Tutar);

                MessageBox.Show("İşleminiz başarıyla tamamlanmıştır.");
            }
        }

        private void btnParaYatırma_Click(object sender, EventArgs e)
        {

            KontHesapNo = Convert.ToUInt64(txtHesapNo.Text);
            Sifre = Convert.ToInt16(txtSife.Text);
            Tutar = Convert.ToInt32(txtTutar.Text);

            banka.ParaYatırma(KontHesapNo, Sifre, Tutar);

            MessageBox.Show("İşleminiz başarıyla tamamlanmıştır.");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
