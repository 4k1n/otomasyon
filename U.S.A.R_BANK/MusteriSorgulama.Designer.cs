namespace U.S.A.R_BANK
{
    partial class frmMusteriSorgulama
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
            this.lblMNSorgu = new System.Windows.Forms.Label();
            this.btnMNSorgula = new System.Windows.Forms.Button();
            this.txtMNSorgu = new System.Windows.Forms.TextBox();
            this.txtMusteriBilgileri = new System.Windows.Forms.TextBox();
            this.lblMusteriBilgileri = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMNSorgu
            // 
            this.lblMNSorgu.AutoSize = true;
            this.lblMNSorgu.Location = new System.Drawing.Point(67, 88);
            this.lblMNSorgu.Name = "lblMNSorgu";
            this.lblMNSorgu.Size = new System.Drawing.Size(67, 13);
            this.lblMNSorgu.TabIndex = 0;
            this.lblMNSorgu.Text = "Müsteri No =";
            // 
            // btnMNSorgula
            // 
            this.btnMNSorgula.Location = new System.Drawing.Point(491, 77);
            this.btnMNSorgula.Name = "btnMNSorgula";
            this.btnMNSorgula.Size = new System.Drawing.Size(151, 35);
            this.btnMNSorgula.TabIndex = 1;
            this.btnMNSorgula.Text = "Sorgula";
            this.btnMNSorgula.UseVisualStyleBackColor = true;
            this.btnMNSorgula.Click += new System.EventHandler(this.btnMNSorgula_Click);
            // 
            // txtMNSorgu
            // 
            this.txtMNSorgu.Location = new System.Drawing.Point(223, 85);
            this.txtMNSorgu.Name = "txtMNSorgu";
            this.txtMNSorgu.Size = new System.Drawing.Size(145, 20);
            this.txtMNSorgu.TabIndex = 2;
            // 
            // txtMusteriBilgileri
            // 
            this.txtMusteriBilgileri.Location = new System.Drawing.Point(165, 140);
            this.txtMusteriBilgileri.Multiline = true;
            this.txtMusteriBilgileri.Name = "txtMusteriBilgileri";
            this.txtMusteriBilgileri.Size = new System.Drawing.Size(477, 215);
            this.txtMusteriBilgileri.TabIndex = 3;
            // 
            // lblMusteriBilgileri
            // 
            this.lblMusteriBilgileri.AutoSize = true;
            this.lblMusteriBilgileri.Location = new System.Drawing.Point(67, 239);
            this.lblMusteriBilgileri.Name = "lblMusteriBilgileri";
            this.lblMusteriBilgileri.Size = new System.Drawing.Size(88, 13);
            this.lblMusteriBilgileri.TabIndex = 4;
            this.lblMusteriBilgileri.Text = "Müşteri Bilgileri = ";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(705, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 26);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMusteriSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 433);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblMusteriBilgileri);
            this.Controls.Add(this.txtMusteriBilgileri);
            this.Controls.Add(this.txtMNSorgu);
            this.Controls.Add(this.btnMNSorgula);
            this.Controls.Add(this.lblMNSorgu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMusteriSorgulama";
            this.Text = "MusteriSorgulama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMNSorgu;
        private System.Windows.Forms.Button btnMNSorgula;
        private System.Windows.Forms.TextBox txtMNSorgu;
        private System.Windows.Forms.TextBox txtMusteriBilgileri;
        private System.Windows.Forms.Label lblMusteriBilgileri;
        private System.Windows.Forms.Button btnClose;
    }
}