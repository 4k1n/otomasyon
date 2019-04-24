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
    public partial class frmHesapKapa : Form
    {
        public Banka banka;

        public frmHesapKapa()
        {
            InitializeComponent();
        }

        private void btnHesapKapa_Click(object sender, EventArgs e)
        {
            ulong MusteriNo = Convert.ToUInt64(txtHKMN.Text);
            ulong HesapNo = Convert.ToUInt64(txtHKHN.Text);
            short Sifre = Convert.ToInt16(txtSifreHK.Text);

            banka.MusteriHesapKapa(MusteriNo, HesapNo, Sifre);
            MessageBox.Show("Hesabınız başarıyla Kapatılmıştır");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
            