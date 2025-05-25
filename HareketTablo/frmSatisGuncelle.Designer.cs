namespace HareketTablo
{
    partial class frmSatisGuncelle
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
            this.btnSatisSil = new System.Windows.Forms.Button();
            this.txtSatisFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSatisId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSatisGuncelle = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUrunAd = new System.Windows.Forms.ComboBox();
            this.cmbMusteriAd = new System.Windows.Forms.ComboBox();
            this.cmbPersonelAd = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSatisSil
            // 
            this.btnSatisSil.Location = new System.Drawing.Point(209, 266);
            this.btnSatisSil.Name = "btnSatisSil";
            this.btnSatisSil.Size = new System.Drawing.Size(147, 48);
            this.btnSatisSil.TabIndex = 45;
            this.btnSatisSil.Text = "Satış Sil";
            this.btnSatisSil.UseVisualStyleBackColor = true;
            this.btnSatisSil.Click += new System.EventHandler(this.btnSatisSil_Click);
            // 
            // txtSatisFiyat
            // 
            this.txtSatisFiyat.Location = new System.Drawing.Point(244, 209);
            this.txtSatisFiyat.Name = "txtSatisFiyat";
            this.txtSatisFiyat.Size = new System.Drawing.Size(273, 30);
            this.txtSatisFiyat.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "Ürün Satış Fiyatı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "Müşteri Ad Soyad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Personel Ad Soyad :";
            // 
            // txtSatisId
            // 
            this.txtSatisId.Enabled = false;
            this.txtSatisId.Location = new System.Drawing.Point(244, 12);
            this.txtSatisId.Name = "txtSatisId";
            this.txtSatisId.Size = new System.Drawing.Size(273, 30);
            this.txtSatisId.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "Satış Id :";
            // 
            // btnSatisGuncelle
            // 
            this.btnSatisGuncelle.Location = new System.Drawing.Point(362, 266);
            this.btnSatisGuncelle.Name = "btnSatisGuncelle";
            this.btnSatisGuncelle.Size = new System.Drawing.Size(155, 48);
            this.btnSatisGuncelle.TabIndex = 36;
            this.btnSatisGuncelle.Text = "Satış Güncelle";
            this.btnSatisGuncelle.UseVisualStyleBackColor = true;
            this.btnSatisGuncelle.Click += new System.EventHandler(this.btnSatisGuncelle_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(47, 266);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(156, 48);
            this.btnGeri.TabIndex = 35;
            this.btnGeri.Text = "Önceki Menü";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Ürün Ad :";
            // 
            // cmbUrunAd
            // 
            this.cmbUrunAd.FormattingEnabled = true;
            this.cmbUrunAd.Location = new System.Drawing.Point(244, 62);
            this.cmbUrunAd.Name = "cmbUrunAd";
            this.cmbUrunAd.Size = new System.Drawing.Size(273, 33);
            this.cmbUrunAd.TabIndex = 46;
            // 
            // cmbMusteriAd
            // 
            this.cmbMusteriAd.FormattingEnabled = true;
            this.cmbMusteriAd.Location = new System.Drawing.Point(244, 111);
            this.cmbMusteriAd.Name = "cmbMusteriAd";
            this.cmbMusteriAd.Size = new System.Drawing.Size(273, 33);
            this.cmbMusteriAd.TabIndex = 47;
            // 
            // cmbPersonelAd
            // 
            this.cmbPersonelAd.FormattingEnabled = true;
            this.cmbPersonelAd.Location = new System.Drawing.Point(244, 161);
            this.cmbPersonelAd.Name = "cmbPersonelAd";
            this.cmbPersonelAd.Size = new System.Drawing.Size(273, 33);
            this.cmbPersonelAd.TabIndex = 48;
            // 
            // frmSatisGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(550, 344);
            this.Controls.Add(this.cmbPersonelAd);
            this.Controls.Add(this.cmbMusteriAd);
            this.Controls.Add(this.cmbUrunAd);
            this.Controls.Add(this.btnSatisSil);
            this.Controls.Add(this.txtSatisFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSatisId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSatisGuncelle);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmSatisGuncelle";
            this.Text = "frmSatisGuncelle";
            this.Load += new System.EventHandler(this.frmSatisGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSatisSil;
        private System.Windows.Forms.TextBox txtSatisFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSatisId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSatisGuncelle;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUrunAd;
        private System.Windows.Forms.ComboBox cmbMusteriAd;
        private System.Windows.Forms.ComboBox cmbPersonelAd;
    }
}