namespace U.S.A.R_BANK
{
    partial class frmHesapKapa
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHKHN = new System.Windows.Forms.TextBox();
            this.txtHKMN = new System.Windows.Forms.TextBox();
            this.btnHesapKapa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSifreHK = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri No Giriniz =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hesap No Giriniz =";
            // 
            // txtHKHN
            // 
            this.txtHKHN.Location = new System.Drawing.Point(283, 174);
            this.txtHKHN.Name = "txtHKHN";
            this.txtHKHN.Size = new System.Drawing.Size(146, 20);
            this.txtHKHN.TabIndex = 2;
            // 
            // txtHKMN
            // 
            this.txtHKMN.Location = new System.Drawing.Point(283, 83);
            this.txtHKMN.Name = "txtHKMN";
            this.txtHKMN.Size = new System.Drawing.Size(146, 20);
            this.txtHKMN.TabIndex = 3;
            // 
            // btnHesapKapa
            // 
            this.btnHesapKapa.Location = new System.Drawing.Point(298, 308);
            this.btnHesapKapa.Name = "btnHesapKapa";
            this.btnHesapKapa.Size = new System.Drawing.Size(109, 37);
            this.btnHesapKapa.TabIndex = 6;
            this.btnHesapKapa.Text = "Hesap Kapa";
            this.btnHesapKapa.UseVisualStyleBackColor = true;
            this.btnHesapKapa.Click += new System.EventHandler(this.btnHesapKapa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Şİfre Giriniz =";
            // 
            // txtSifreHK
            // 
            this.txtSifreHK.Location = new System.Drawing.Point(283, 269);
            this.txtSifreHK.Name = "txtSifreHK";
            this.txtSifreHK.Size = new System.Drawing.Size(146, 20);
            this.txtSifreHK.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(706, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmHesapKapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 433);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtSifreHK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHesapKapa);
            this.Controls.Add(this.txtHKMN);
            this.Controls.Add(this.txtHKHN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHesapKapa";
            this.Text = "HesapKapa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHKHN;
        private System.Windows.Forms.TextBox txtHKMN;
        private System.Windows.Forms.Button btnHesapKapa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSifreHK;
        private System.Windows.Forms.Button btnClose;
    }
}