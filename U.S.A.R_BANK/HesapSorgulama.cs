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
    public partial class frmHesapSorgulama : Form
    {
        public Banka banka;

        public frmHesapSorgulama()
        {
            InitializeComponent();
        }

        private void btnSorgulaHN_Click(object sender, EventArgs e)
        {
            ulong KontNo;
            KontNo = Convert.ToUInt64(txtHesapNo.Text);
            txtHesapBilgileri.Text =banka.HesapKontrol(KontNo);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
