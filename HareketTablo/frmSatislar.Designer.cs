namespace HareketTablo
{
    partial class frmSatislar
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
            this.btnSatisGirisi = new System.Windows.Forms.Button();
            this.btnSatisListesi = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.grpbxYeniSatisKaydi = new System.Windows.Forms.GroupBox();
            this.btnSatisKaydiOlustur = new System.Windows.Forms.Button();
            this.btnFormTemizle = new System.Windows.Forms.Button();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPersonelAdSoyad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMusteriAdSoyad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUrunAd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbxYeniSatisKaydi.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSatisGirisi
            // 
            this.btnSatisGirisi.Location = new System.Drawing.Point(12, 12);
            this.btnSatisGirisi.Name = "btnSatisGirisi";
            this.btnSatisGirisi.Size = new System.Drawing.Size(235, 120);
            this.btnSatisGirisi.TabIndex = 0;
            this.btnSatisGirisi.Text = "Yeni Satış Kaydı";
            this.btnSatisGirisi.UseVisualStyleBackColor = true;
            this.btnSatisGirisi.Click += new System.EventHandler(this.btnSatisGirisi_Click);
            // 
            // btnSatisListesi
            // 
            this.btnSatisListesi.Location = new System.Drawing.Point(253, 12);
            this.btnSatisListesi.Name = "btnSatisListesi";
            this.btnSatisListesi.Size = new System.Drawing.Size(235, 120);
            this.btnSatisListesi.TabIndex = 1;
            this.btnSatisListesi.Text = "Satış Listesi";
            this.btnSatisListesi.UseVisualStyleBackColor = true;
            this.btnSatisListesi.Click += new System.EventHandler(this.btnSatisListesi_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(494, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(235, 120);
            this.btnGeri.TabIndex = 2;
            this.btnGeri.Text = "Önceki Menü";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // grpbxYeniSatisKaydi
            // 
            this.grpbxYeniSatisKaydi.Controls.Add(this.btnSatisKaydiOlustur);
            this.grpbxYeniSatisKaydi.Controls.Add(this.btnFormTemizle);
            this.grpbxYeniSatisKaydi.Controls.Add(this.btnPersonelEkle);
            this.grpbxYeniSatisKaydi.Controls.Add(this.btnMusteriEkle);
            this.grpbxYeniSatisKaydi.Controls.Add(this.btnUrunEkle);
            this.grpbxYeniSatisKaydi.Controls.Add(this.txtSatisFiyati);
            this.grpbxYeniSatisKaydi.Controls.Add(this.label4);
            this.grpbxYeniSatisKaydi.Controls.Add(this.cmbPersonelAdSoyad);
            this.grpbxYeniSatisKaydi.Controls.Add(this.label3);
            this.grpbxYeniSatisKaydi.Controls.Add(this.cmbMusteriAdSoyad);
            this.grpbxYeniSatisKaydi.Controls.Add(this.label2);
            this.grpbxYeniSatisKaydi.Controls.Add(this.cmbUrunAd);
            this.grpbxYeniSatisKaydi.Controls.Add(this.label1);
            this.grpbxYeniSatisKaydi.Location = new System.Drawing.Point(12, 160);
            this.grpbxYeniSatisKaydi.Name = "grpbxYeniSatisKaydi";
            this.grpbxYeniSatisKaydi.Size = new System.Drawing.Size(717, 332);
            this.grpbxYeniSatisKaydi.TabIndex = 3;
            this.grpbxYeniSatisKaydi.TabStop = false;
            this.grpbxYeniSatisKaydi.Text = "Yeni Satış Kaydı";
            this.grpbxYeniSatisKaydi.Visible = false;
            // 
            // btnSatisKaydiOlustur
            // 
            this.btnSatisKaydiOlustur.Location = new System.Drawing.Point(213, 255);
            this.btnSatisKaydiOlustur.Name = "btnSatisKaydiOlustur";
            this.btnSatisKaydiOlustur.Size = new System.Drawing.Size(270, 48);
            this.btnSatisKaydiOlustur.TabIndex = 12;
            this.btnSatisKaydiOlustur.Text = "Satış Kaydı Oluştur";
            this.btnSatisKaydiOlustur.UseVisualStyleBackColor = true;
            this.btnSatisKaydiOlustur.Click += new System.EventHandler(this.btnSatisKaydiOlustur_Click);
            // 
            // btnFormTemizle
            // 
            this.btnFormTemizle.Location = new System.Drawing.Point(515, 203);
            this.btnFormTemizle.Name = "btnFormTemizle";
            this.btnFormTemizle.Size = new System.Drawing.Size(191, 33);
            this.btnFormTemizle.TabIndex = 11;
            this.btnFormTemizle.Text = "Form Temizle";
            this.btnFormTemizle.UseVisualStyleBackColor = true;
            this.btnFormTemizle.Click += new System.EventHandler(this.btnFormTemizle_Click);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Location = new System.Drawing.Point(515, 149);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(191, 33);
            this.btnPersonelEkle.TabIndex = 10;
            this.btnPersonelEkle.Text = "Yeni Personel Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(515, 91);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(191, 33);
            this.btnMusteriEkle.TabIndex = 9;
            this.btnMusteriEkle.Text = "Yeni Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(515, 38);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(191, 33);
            this.btnUrunEkle.TabIndex = 8;
            this.btnUrunEkle.Text = "Yeni Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(213, 207);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(273, 30);
            this.txtSatisFiyati.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Satış Fiyatı :";
            // 
            // cmbPersonelAdSoyad
            // 
            this.cmbPersonelAdSoyad.FormattingEnabled = true;
            this.cmbPersonelAdSoyad.Location = new System.Drawing.Point(213, 150);
            this.cmbPersonelAdSoyad.Name = "cmbPersonelAdSoyad";
            this.cmbPersonelAdSoyad.Size = new System.Drawing.Size(273, 33);
            this.cmbPersonelAdSoyad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Personel Ad Soyad :";
            // 
            // cmbMusteriAdSoyad
            // 
            this.cmbMusteriAdSoyad.FormattingEnabled = true;
            this.cmbMusteriAdSoyad.Location = new System.Drawing.Point(213, 92);
            this.cmbMusteriAdSoyad.Name = "cmbMusteriAdSoyad";
            this.cmbMusteriAdSoyad.Size = new System.Drawing.Size(273, 33);
            this.cmbMusteriAdSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri Ad Soyad :";
            // 
            // cmbUrunAd
            // 
            this.cmbUrunAd.FormattingEnabled = true;
            this.cmbUrunAd.Location = new System.Drawing.Point(213, 39);
            this.cmbUrunAd.Name = "cmbUrunAd";
            this.cmbUrunAd.Size = new System.Drawing.Size(273, 33);
            this.cmbUrunAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı :";
            // 
            // frmSatislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(739, 510);
            this.Controls.Add(this.grpbxYeniSatisKaydi);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnSatisListesi);
            this.Controls.Add(this.btnSatisGirisi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmSatislar";
            this.Text = "Satışlar";
            this.grpbxYeniSatisKaydi.ResumeLayout(false);
            this.grpbxYeniSatisKaydi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSatisGirisi;
        private System.Windows.Forms.Button btnSatisListesi;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.GroupBox grpbxYeniSatisKaydi;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPersonelAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMusteriAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUrunAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSatisKaydiOlustur;
        private System.Windows.Forms.Button btnFormTemizle;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnUrunEkle;
    }
}