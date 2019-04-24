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
    public partial class frmBakiyeSorgulama : Form
    {
        public Banka banka;

        public frmBakiyeSorgulama()
        {
            InitializeComponent();
        }

        private void btnBakiyeGoster_Click(object sender, EventArgs e)
        {
            ulong KontHspNo = Convert.ToUInt64(txtHesapNoBS.Text);
            short KontrolSifre = Convert.ToInt16(txtSifreBS.Text);
            txtBakiye.Text = banka.BakiyeGöster(KontHspNo,KontrolSifre);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
