namespace U.S.A.R_BANK
{
    partial class frmBakiyeSorgulama
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
            this.btnBakiyeGoster = new System.Windows.Forms.Button();
            this.lblHesapNoBS = new System.Windows.Forms.Label();
            this.txtHesapNoBS = new System.Windows.Forms.TextBox();
            this.lblSifreBS = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.txtSifreBS = new System.Windows.Forms.TextBox();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBakiyeGoster
            // 
            this.btnBakiyeGoster.Location = new System.Drawing.Point(287, 209);
            this.btnBakiyeGoster.Name = "btnBakiyeGoster";
            this.btnBakiyeGoster.Size = new System.Drawing.Size(169, 38);
            this.btnBakiyeGoster.TabIndex = 0;
            this.btnBakiyeGoster.Text = "Bakiye Göster";
            this.btnBakiyeGoster.UseVisualStyleBackColor = true;
            this.btnBakiyeGoster.Click += new System.EventHandler(this.btnBakiyeGoster_Click);
            // 
            // lblHesapNoBS
            // 
            this.lblHesapNoBS.AutoSize = true;
            this.lblHesapNoBS.Location = new System.Drawing.Point(144, 102);
            this.lblHesapNoBS.Name = "lblHesapNoBS";
            this.lblHesapNoBS.Size = new System.Drawing.Size(64, 13);
            this.lblHesapNoBS.TabIndex = 1;
            this.lblHesapNoBS.Text = "Hesap No =";
            // 
            // txtHesapNoBS
            // 
            this.txtHesapNoBS.Location = new System.Drawing.Point(287, 95);
            this.txtHesapNoBS.Name = "txtHesapNoBS";
            this.txtHesapNoBS.Size = new System.Drawing.Size(169, 20);
            this.txtHesapNoBS.TabIndex = 2;
            // 
            // lblSifreBS
            // 
            this.lblSifreBS.AutoSize = true;
            this.lblSifreBS.Location = new System.Drawing.Point(144, 165);
            this.lblSifreBS.Name = "lblSifreBS";
            this.lblSifreBS.Size = new System.Drawing.Size(37, 13);
            this.lblSifreBS.TabIndex = 3;
            this.lblSifreBS.Text = "Şifre =";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Location = new System.Drawing.Point(144, 280);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(48, 13);
            this.lblBakiye.TabIndex = 4;
            this.lblBakiye.Text = "Bakiye =";
            // 
            // txtSifreBS
            // 
            this.txtSifreBS.Location = new System.Drawing.Point(287, 158);
            this.txtSifreBS.Name = "txtSifreBS";
            this.txtSifreBS.Size = new System.Drawing.Size(169, 20);
            this.txtSifreBS.TabIndex = 5;
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(287, 273);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(169, 20);
            this.txtBakiye.TabIndex = 6;
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
            // frmBakiyeSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 433);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.txtSifreBS);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.lblSifreBS);
            this.Controls.Add(this.txtHesapNoBS);
            this.Controls.Add(this.lblHesapNoBS);
            this.Controls.Add(this.btnBakiyeGoster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBakiyeSorgulama";
            this.Text = "BakiyeSorgulama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBakiyeGoster;
        private System.Windows.Forms.Label lblHesapNoBS;
        private System.Windows.Forms.TextBox txtHesapNoBS;
        private System.Windows.Forms.Label lblSifreBS;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.TextBox txtSifreBS;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.Button btnClose;
    }
}