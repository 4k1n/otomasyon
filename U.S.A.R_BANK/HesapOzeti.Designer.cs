namespace U.S.A.R_BANK
{
    partial class frmHesapOzeti
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHesapNoSorgu = new System.Windows.Forms.TextBox();
            this.btnHesapOzeti = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifreHO = new System.Windows.Forms.TextBox();
            this.txtHesapOzeti = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesap No =";
            // 
            // txtHesapNoSorgu
            // 
            this.txtHesapNoSorgu.Location = new System.Drawing.Point(267, 52);
            this.txtHesapNoSorgu.Name = "txtHesapNoSorgu";
            this.txtHesapNoSorgu.Size = new System.Drawing.Size(136, 20);
            this.txtHesapNoSorgu.TabIndex = 1;
            // 
            // btnHesapOzeti
            // 
            this.btnHesapOzeti.Location = new System.Drawing.Point(452, 50);
            this.btnHesapOzeti.Name = "btnHesapOzeti";
            this.btnHesapOzeti.Size = new System.Drawing.Size(180, 78);
            this.btnHesapOzeti.TabIndex = 2;
            this.btnHesapOzeti.Text = "Hesap Özeti Sorgula";
            this.btnHesapOzeti.UseVisualStyleBackColor = true;
            this.btnHesapOzeti.Click += new System.EventHandler(this.btnHesapOzeti_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hesap Özeti =";
            // 
            // txtSifreHO
            // 
            this.txtSifreHO.Location = new System.Drawing.Point(267, 108);
            this.txtSifreHO.Name = "txtSifreHO";
            this.txtSifreHO.Size = new System.Drawing.Size(136, 20);
            this.txtSifreHO.TabIndex = 5;
            // 
            // txtHesapOzeti
            // 
            this.txtHesapOzeti.Location = new System.Drawing.Point(240, 151);
            this.txtHesapOzeti.Multiline = true;
            this.txtHesapOzeti.Name = "txtHesapOzeti";
            this.txtHesapOzeti.Size = new System.Drawing.Size(392, 244);
            this.txtHesapOzeti.TabIndex = 6;
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
            // frmHesapOzeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 433);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtHesapOzeti);
            this.Controls.Add(this.txtSifreHO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHesapOzeti);
            this.Controls.Add(this.txtHesapNoSorgu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHesapOzeti";
            this.Text = "HesapOzeti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHesapNoSorgu;
        private System.Windows.Forms.Button btnHesapOzeti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSifreHO;
        private System.Windows.Forms.TextBox txtHesapOzeti;
        private System.Windows.Forms.Button btnClose;
    }
}