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
    public partial class frmHesapOzeti : Form
    {
        public Banka banka;

        public frmHesapOzeti()
        {
            InitializeComponent();
        }

        private void btnHesapOzeti_Click(object sender, EventArgs e)
        {
            ulong KontHspNo = Convert.ToUInt64(txtHesapNoSorgu.Text);
            short KontrolSifre = Convert.ToInt16(txtSifreHO.Text);
            txtHesapOzeti.Text = ""+banka.HesapOzetKontrol(KontHspNo,KontrolSifre);
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
