namespace U.S.A.R_BANK
{
    partial class frmHavale
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnHavale = new System.Windows.Forms.Button();
            this.txtGönderenHesapNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGöderenSifre = new System.Windows.Forms.TextBox();
            this.txtAlıcıHesapNo = new System.Windows.Forms.TextBox();
            this.txtHavaleTutarı = new System.Windows.Forms.TextBox();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gönderen Hesap No =";
            // 
            // btnHavale
            // 
            this.btnHavale.Location = new System.Drawing.Point(225, 315);
            this.btnHavale.Name = "btnHavale";
            this.btnHavale.Size = new System.Drawing.Size(146, 46);
            this.btnHavale.TabIndex = 11;
            this.btnHavale.Text = "Havale Yap";
            this.btnHavale.UseVisualStyleBackColor = true;
            this.btnHavale.Click += new System.EventHandler(this.btnHavale_Click);
            // 
            // txtGönderenHesapNo
            // 
            this.txtGönderenHesapNo.Location = new System.Drawing.Point(225, 60);
            this.txtGönderenHesapNo.Name = "txtGönderenHesapNo";
            this.txtGönderenHesapNo.Size = new System.Drawing.Size(146, 20);
            this.txtGönderenHesapNo.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Gönderen Şifre =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Alıcı Hesap No =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Havale Tutarı =";
            // 
            // txtGöderenSifre
            // 
            this.txtGöderenSifre.Location = new System.Drawing.Point(225, 122);
            this.txtGöderenSifre.Name = "txtGöderenSifre";
            this.txtGöderenSifre.Size = new System.Drawing.Size(146, 20);
            this.txtGöderenSifre.TabIndex = 16;
            // 
            // txtAlıcıHesapNo
            // 
            this.txtAlıcıHesapNo.Location = new System.Drawing.Point(225, 182);
            this.txtAlıcıHesapNo.Name = "txtAlıcıHesapNo";
            this.txtAlıcıHesapNo.Size = new System.Drawing.Size(146, 20);
            this.txtAlıcıHesapNo.TabIndex = 17;
            // 
            // txtHavaleTutarı
            // 
            this.txtHavaleTutarı.Location = new System.Drawing.Point(225, 248);
            this.txtHavaleTutarı.Name = "txtHavaleTutarı";
            this.txtHavaleTutarı.Size = new System.Drawing.Size(146, 20);
            this.txtHavaleTutarı.TabIndex = 18;
            // 
            // frmHavale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 433);
            this.Controls.Add(this.txtHavaleTutarı);
            this.Controls.Add(this.txtAlıcıHesapNo);
            this.Controls.Add(this.txtGöderenSifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGönderenHesapNo);
            this.Controls.Add(this.btnHavale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHavale";
            this.Text = "Havale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHavale;
        private System.Windows.Forms.TextBox txtGönderenHesapNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGöderenSifre;
        private System.Windows.Forms.TextBox txtAlıcıHesapNo;
        private System.Windows.Forms.TextBox txtHavaleTutarı;
    }
}