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
    public partial class frmMusteriSorgulama : Form
    {
        public Banka banka;

        public frmMusteriSorgulama()
        {
            InitializeComponent();
        }

        private void btnMNSorgula_Click(object sender, EventArgs e)
        {
            ulong KMNo;
            KMNo = Convert.ToUInt64(txtMNSorgu.Text);
            txtMusteriBilgileri.Text = banka.MusteriSorgulama(KMNo);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
