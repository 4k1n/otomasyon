namespace U.S.A.R_BANK
{
    partial class frmHesapSorgulama
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
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSorgulaHN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHesapBilgileri = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(235, 101);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(100, 20);
            this.txtHesapNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hesap No =";
            // 
            // btnSorgulaHN
            // 
            this.btnSorgulaHN.Location = new System.Drawing.Point(428, 88);
            this.btnSorgulaHN.Name = "btnSorgulaHN";
            this.btnSorgulaHN.Size = new System.Drawing.Size(161, 44);
            this.btnSorgulaHN.TabIndex = 2;
            this.btnSorgulaHN.Text = "Sorgula";
            this.btnSorgulaHN.UseVisualStyleBackColor = true;
            this.btnSorgulaHN.Click += new System.EventHandler(this.btnSorgulaHN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hesap Bilgileri =";
            // 
            // txtHesapBilgileri
            // 
            this.txtHesapBilgileri.Location = new System.Drawing.Point(235, 154);
            this.txtHesapBilgileri.Multiline = true;
            this.txtHesapBilgileri.Name = "txtHesapBilgileri";
            this.txtHesapBilgileri.Size = new System.Drawing.Size(354, 203);
            this.txtHesapBilgileri.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(706, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmHesapSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 433);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtHesapBilgileri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSorgulaHN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHesapNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHesapSorgulama";
            this.Text = "HesapSorgulama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSorgulaHN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHesapBilgileri;
        private System.Windows.Forms.Button btnClose;
    }
}