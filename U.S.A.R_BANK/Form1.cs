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
    

    public partial class frmUSAR : Form
    {
        public Banka banka;
        public frmMusteriEkle childME;
        public frmGelirGider childGG;
        public frmMusteriSorgulama childMS;
        public frmHesapAc childHA;
        public frmHesapKapa childHK;
        public frmHesapSorgulama childHS;
        public frmHesapOzeti childHO;
        public frmBakiyeSorgulama childBS;
        public frmParaCekme childPC;
        public frmHavale childHV;

        public frmUSAR()
        {
            banka = new Banka();
            childME = new frmMusteriEkle();
            childGG = new frmGelirGider();
            childMS = new frmMusteriSorgulama();
            childHA = new frmHesapAc();
            childHK = new frmHesapKapa();
            childHS = new frmHesapSorgulama();
            childHO = new frmHesapOzeti();
            childBS = new frmBakiyeSorgulama();
            childPC = new frmParaCekme();
            childHV = new frmHavale();

            InitializeComponent();
        }

        public void FormKapat()
        {
            childME.Close();
            childGG.Close();
            childMS.Close();
            childHA.Close();
            childHK.Close();
            childHS.Close();
            childHO.Close();
            childBS.Close();
            childPC.Close();
            childHV.Close();
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKapat();
            childME = new frmMusteriEkle();
            childME.MdiParent = this;
            childME.banka = this.banka;
            childME.Show();
            childME.Location = new Point(0, 0);
        }

        private void gelirGİderRaporuGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKapat();
            childGG = new frmGelirGider();
            childGG.MdiParent = this;
            childGG.banka = this.banka;
            childGG.Show();
            childGG.Location = new Point(0, 0);

        }

        private void müşteriSOrgulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKapat();
            childMS = new frmMusteriSorgulama();
            childMS.MdiParent = this;
            childMS.banka = this.banka;
            childMS.Show();
            childMS.Location = new Point(0, 0);
        }

        private void hesapAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKapat();
            childHA = new frmHesapAc();
            childHA.MdiParent = this;
            childHA.banka = this.banka;
            childHA.Show();
            childHA.Location = new Point(0, 0);
        }

        private void hesapKapaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKapat();
            childHK = new frmHesapKapa();
            childHK.MdiParent = this;
            childHK.banka = this.banka;
            childHK.Show();
            childHK.Location = new Point(0, 0);
        }

        private void hesapSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKapat();
            childHS = new frmHesapSorgulama();
            childHS.MdiParent = this;
            childHS.banka = this.banka;
            childHS.Show();
            childHS.Location = new Point(0, 0);
        }

        private void hesapÖzetiGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKapat();
            childHO = new frmHesapOzeti();
            childHO.MdiParent = this;
            childHO.banka = this.banka;
            childHO.Show();
            childHO.Location = new Point(0, 0);
        }

        private void bakiyeSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKapat();
            childBS = new frmBakiyeSorgulama();
            childBS.MdiParent = this;
            childBS.banka = this.banka;
            childBS.Show();
            childBS.Location = new Point(0, 0);
        }

        private void paraÇekmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKapat();
            childPC = new frmParaCekme();
            childPC.MdiParent = this;
            childPC.banka = this.banka;
            childPC.Show();
            childPC.Location = new Point(0, 0);
        }

        private void havaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKapat();
            childHV = new frmHavale();
            childHV.MdiParent = this;
            childHV.banka = this.banka;
            childHV.Show();
            childHV.Location = new Point(0, 0);
        }
    }
}
