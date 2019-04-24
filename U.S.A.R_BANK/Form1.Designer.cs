namespace U.S.A.R_BANK
{
    partial class frmUSAR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirGİderRaporuGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriSOrgulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapKapaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapSorgulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapÖzetiGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bakiyeSorgulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraÇekmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.havaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaSayfaToolStripMenuItem,
            this.müşteriToolStripMenuItem,
            this.hesapToolStripMenuItem,
            this.paraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anaSayfaToolStripMenuItem
            // 
            this.anaSayfaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriEkleToolStripMenuItem,
            this.gelirGİderRaporuGörüntüleToolStripMenuItem});
            this.anaSayfaToolStripMenuItem.Name = "anaSayfaToolStripMenuItem";
            this.anaSayfaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.anaSayfaToolStripMenuItem.Text = "Banka";
            // 
            // müşteriEkleToolStripMenuItem
            // 
            this.müşteriEkleToolStripMenuItem.Name = "müşteriEkleToolStripMenuItem";
            this.müşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.müşteriEkleToolStripMenuItem.Text = "Müşteri Ekle";
            this.müşteriEkleToolStripMenuItem.Click += new System.EventHandler(this.müşteriEkleToolStripMenuItem_Click);
            // 
            // gelirGİderRaporuGörüntüleToolStripMenuItem
            // 
            this.gelirGİderRaporuGörüntüleToolStripMenuItem.Name = "gelirGİderRaporuGörüntüleToolStripMenuItem";
            this.gelirGİderRaporuGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.gelirGİderRaporuGörüntüleToolStripMenuItem.Text = "Gelir Gİder Raporu Görüntüle";
            this.gelirGİderRaporuGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.gelirGİderRaporuGörüntüleToolStripMenuItem_Click);
            // 
            // müşteriToolStripMenuItem
            // 
            this.müşteriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriSOrgulaToolStripMenuItem,
            this.hesapAçToolStripMenuItem,
            this.hesapKapaToolStripMenuItem});
            this.müşteriToolStripMenuItem.Name = "müşteriToolStripMenuItem";
            this.müşteriToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.müşteriToolStripMenuItem.Text = "Müşteri";
            // 
            // müşteriSOrgulaToolStripMenuItem
            // 
            this.müşteriSOrgulaToolStripMenuItem.Name = "müşteriSOrgulaToolStripMenuItem";
            this.müşteriSOrgulaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.müşteriSOrgulaToolStripMenuItem.Text = "Müşteri Sorgula";
            this.müşteriSOrgulaToolStripMenuItem.Click += new System.EventHandler(this.müşteriSOrgulaToolStripMenuItem_Click);
            // 
            // hesapAçToolStripMenuItem
            // 
            this.hesapAçToolStripMenuItem.Name = "hesapAçToolStripMenuItem";
            this.hesapAçToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.hesapAçToolStripMenuItem.Text = "Hesap Aç";
            this.hesapAçToolStripMenuItem.Click += new System.EventHandler(this.hesapAçToolStripMenuItem_Click);
            // 
            // hesapKapaToolStripMenuItem
            // 
            this.hesapKapaToolStripMenuItem.Name = "hesapKapaToolStripMenuItem";
            this.hesapKapaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.hesapKapaToolStripMenuItem.Text = "Hesap Kapa";
            this.hesapKapaToolStripMenuItem.Click += new System.EventHandler(this.hesapKapaToolStripMenuItem_Click);
            // 
            // hesapToolStripMenuItem
            // 
            this.hesapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapSorgulamaToolStripMenuItem,
            this.hesapÖzetiGösterToolStripMenuItem,
            this.bakiyeSorgulamaToolStripMenuItem});
            this.hesapToolStripMenuItem.Name = "hesapToolStripMenuItem";
            this.hesapToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.hesapToolStripMenuItem.Text = "Hesap";
            // 
            // hesapSorgulamaToolStripMenuItem
            // 
            this.hesapSorgulamaToolStripMenuItem.Name = "hesapSorgulamaToolStripMenuItem";
            this.hesapSorgulamaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.hesapSorgulamaToolStripMenuItem.Text = "Hesap Sorgulama";
            this.hesapSorgulamaToolStripMenuItem.Click += new System.EventHandler(this.hesapSorgulamaToolStripMenuItem_Click);
            // 
            // hesapÖzetiGösterToolStripMenuItem
            // 
            this.hesapÖzetiGösterToolStripMenuItem.Name = "hesapÖzetiGösterToolStripMenuItem";
            this.hesapÖzetiGösterToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.hesapÖzetiGösterToolStripMenuItem.Text = "Hesap Özeti Göster";
            this.hesapÖzetiGösterToolStripMenuItem.Click += new System.EventHandler(this.hesapÖzetiGösterToolStripMenuItem_Click);
            // 
            // bakiyeSorgulamaToolStripMenuItem
            // 
            this.bakiyeSorgulamaToolStripMenuItem.Name = "bakiyeSorgulamaToolStripMenuItem";
            this.bakiyeSorgulamaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.bakiyeSorgulamaToolStripMenuItem.Text = "Bakiye Sorgulama";
            this.bakiyeSorgulamaToolStripMenuItem.Click += new System.EventHandler(this.bakiyeSorgulamaToolStripMenuItem_Click);
            // 
            // paraToolStripMenuItem
            // 
            this.paraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paraÇekmeToolStripMenuItem,
            this.havaleToolStripMenuItem});
            this.paraToolStripMenuItem.Name = "paraToolStripMenuItem";
            this.paraToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.paraToolStripMenuItem.Text = "Para İşlemleri";
            // 
            // paraÇekmeToolStripMenuItem
            // 
            this.paraÇekmeToolStripMenuItem.Name = "paraÇekmeToolStripMenuItem";
            this.paraÇekmeToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.paraÇekmeToolStripMenuItem.Text = "Para Çekme / Yatırma";
            this.paraÇekmeToolStripMenuItem.Click += new System.EventHandler(this.paraÇekmeToolStripMenuItem_Click);
            // 
            // havaleToolStripMenuItem
            // 
            this.havaleToolStripMenuItem.Name = "havaleToolStripMenuItem";
            this.havaleToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.havaleToolStripMenuItem.Text = "Havale";
            this.havaleToolStripMenuItem.Click += new System.EventHandler(this.havaleToolStripMenuItem_Click);
            // 
            // frmUSAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmUSAR";
            this.Text = "U.S.A.R BANK";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anaSayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriSOrgulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelirGİderRaporuGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapKapaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapSorgulamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapÖzetiGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bakiyeSorgulamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraÇekmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem havaleToolStripMenuItem;
    }
}

