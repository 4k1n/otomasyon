namespace U.S.A.R_BANK
{
    partial class frmHesapAc
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
            this.lblMNGiriniz = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.txtMNGiriniz = new System.Windows.Forms.TextBox();
            this.rbtnBireysel = new System.Windows.Forms.RadioButton();
            this.rbtnTicari = new System.Windows.Forms.RadioButton();
            this.btnHesapOlustur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMeslek = new System.Windows.Forms.TextBox();
            this.txtSirket = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMNGiriniz
            // 
            this.lblMNGiriniz.AutoSize = true;
            this.lblMNGiriniz.Location = new System.Drawing.Point(94, 156);
            this.lblMNGiriniz.Name = "lblMNGiriniz";
            this.lblMNGiriniz.Size = new System.Drawing.Size(98, 13);
            this.lblMNGiriniz.TabIndex = 0;
            this.lblMNGiriniz.Text = "Müşteri No Giriniz =";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(293, 27);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(106, 13);
            this.lblTip.TabIndex = 1;
            this.lblTip.Text = "Hesap Tipini Seçiniz ";
            // 
            // txtMNGiriniz
            // 
            this.txtMNGiriniz.Location = new System.Drawing.Point(253, 149);
            this.txtMNGiriniz.Name = "txtMNGiriniz";
            this.txtMNGiriniz.Size = new System.Drawing.Size(190, 20);
            this.txtMNGiriniz.TabIndex = 2;
            // 
            // rbtnBireysel
            // 
            this.rbtnBireysel.AutoSize = true;
            this.rbtnBireysel.Location = new System.Drawing.Point(296, 67);
            this.rbtnBireysel.Name = "rbtnBireysel";
            this.rbtnBireysel.Size = new System.Drawing.Size(95, 17);
            this.rbtnBireysel.TabIndex = 3;
            this.rbtnBireysel.TabStop = true;
            this.rbtnBireysel.Text = "Bireysel Hesap";
            this.rbtnBireysel.UseVisualStyleBackColor = true;
            this.rbtnBireysel.CheckedChanged += new System.EventHandler(this.rbtnBireysel_CheckedChanged);
            // 
            // rbtnTicari
            // 
            this.rbtnTicari.AutoSize = true;
            this.rbtnTicari.Location = new System.Drawing.Point(296, 110);
            this.rbtnTicari.Name = "rbtnTicari";
            this.rbtnTicari.Size = new System.Drawing.Size(85, 17);
            this.rbtnTicari.TabIndex = 4;
            this.rbtnTicari.TabStop = true;
            this.rbtnTicari.Text = "Ticari Hesap";
            this.rbtnTicari.UseVisualStyleBackColor = true;
            this.rbtnTicari.CheckedChanged += new System.EventHandler(this.rbtnTicari_CheckedChanged);
            // 
            // btnHesapOlustur
            // 
            this.btnHesapOlustur.Location = new System.Drawing.Point(296, 285);
            this.btnHesapOlustur.Name = "btnHesapOlustur";
            this.btnHesapOlustur.Size = new System.Drawing.Size(103, 47);
            this.btnHesapOlustur.TabIndex = 5;
            this.btnHesapOlustur.Text = "Hesap Oluştur";
            this.btnHesapOlustur.UseVisualStyleBackColor = true;
            this.btnHesapOlustur.Click += new System.EventHandler(this.btnHesapOlustur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hesap Şifresi Giriniz =";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(253, 202);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(190, 20);
            this.txtSifre.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(706, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Meleğinizi Giriniz  =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Şirket İsminizi Giriniz  =";
            // 
            // txtMeslek
            // 
            this.txtMeslek.Location = new System.Drawing.Point(253, 247);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.Size = new System.Drawing.Size(190, 20);
            this.txtMeslek.TabIndex = 11;
            // 
            // txtSirket
            // 
            this.txtSirket.Location = new System.Drawing.Point(253, 247);
            this.txtSirket.Name = "txtSirket";
            this.txtSirket.Size = new System.Drawing.Size(190, 20);
            this.txtSirket.TabIndex = 12;
            // 
            // frmHesapAc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 433);
            this.Controls.Add(this.txtSirket);
            this.Controls.Add(this.txtMeslek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHesapOlustur);
            this.Controls.Add(this.rbtnTicari);
            this.Controls.Add(this.rbtnBireysel);
            this.Controls.Add(this.txtMNGiriniz);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblMNGiriniz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHesapAc";
            this.Text = "HesapAc";
            this.Load += new System.EventHandler(this.frmHesapAc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMNGiriniz;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.TextBox txtMNGiriniz;
        private System.Windows.Forms.RadioButton rbtnBireysel;
        private System.Windows.Forms.RadioButton rbtnTicari;
        private System.Windows.Forms.Button btnHesapOlustur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMeslek;
        private System.Windows.Forms.TextBox txtSirket;
    }
}