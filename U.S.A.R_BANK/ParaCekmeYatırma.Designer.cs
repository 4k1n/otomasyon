namespace U.S.A.R_BANK
{
    partial class frmParaCekme
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnParaCekme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.txtSife = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnParaYatırma = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // btnParaCekme
            // 
            this.btnParaCekme.Location = new System.Drawing.Point(473, 106);
            this.btnParaCekme.Name = "btnParaCekme";
            this.btnParaCekme.Size = new System.Drawing.Size(118, 49);
            this.btnParaCekme.TabIndex = 10;
            this.btnParaCekme.Text = "Para Çek";
            this.btnParaCekme.UseVisualStyleBackColor = true;
            this.btnParaCekme.Click += new System.EventHandler(this.btnParaCekme_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hesap No =";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(291, 259);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(130, 20);
            this.txtTutar.TabIndex = 12;
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(291, 106);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(130, 20);
            this.txtHesapNo.TabIndex = 13;
            // 
            // txtSife
            // 
            this.txtSife.Location = new System.Drawing.Point(291, 182);
            this.txtSife.Name = "txtSife";
            this.txtSife.Size = new System.Drawing.Size(130, 20);
            this.txtSife.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Şifre =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tutar =";
            // 
            // btnParaYatırma
            // 
            this.btnParaYatırma.Location = new System.Drawing.Point(473, 230);
            this.btnParaYatırma.Name = "btnParaYatırma";
            this.btnParaYatırma.Size = new System.Drawing.Size(118, 49);
            this.btnParaYatırma.TabIndex = 22;
            this.btnParaYatırma.Text = "Para Yatır";
            this.btnParaYatırma.UseVisualStyleBackColor = true;
            this.btnParaYatırma.Click += new System.EventHandler(this.btnParaYatırma_Click);
            // 
            // frmParaCekme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 433);
            this.Controls.Add(this.btnParaYatırma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSife);
            this.Controls.Add(this.txtHesapNo);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnParaCekme);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmParaCekme";
            this.Text = "ParaCekme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnParaCekme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.TextBox txtSife;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnParaYatırma;
    }
}