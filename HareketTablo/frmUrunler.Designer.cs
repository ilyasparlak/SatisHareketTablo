namespace HareketTablo
{
    partial class frmUrunler
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
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnUrunListesi = new System.Windows.Forms.Button();
            this.btnUrunKaydi = new System.Windows.Forms.Button();
            this.grpbxYeniUrunKaydi = new System.Windows.Forms.GroupBox();
            this.txtAlisFiyati = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.btnSatisKaydiOlustur = new System.Windows.Forms.Button();
            this.btnFormTemizle = new System.Windows.Forms.Button();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbxYeniUrunKaydi.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(494, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(235, 120);
            this.btnGeri.TabIndex = 5;
            this.btnGeri.Text = "Önceki Menü";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnUrunListesi
            // 
            this.btnUrunListesi.Location = new System.Drawing.Point(253, 12);
            this.btnUrunListesi.Name = "btnUrunListesi";
            this.btnUrunListesi.Size = new System.Drawing.Size(235, 120);
            this.btnUrunListesi.TabIndex = 4;
            this.btnUrunListesi.Text = "Ürün Listesi";
            this.btnUrunListesi.UseVisualStyleBackColor = true;
            this.btnUrunListesi.Click += new System.EventHandler(this.btnUrunListesi_Click);
            // 
            // btnUrunKaydi
            // 
            this.btnUrunKaydi.Location = new System.Drawing.Point(12, 12);
            this.btnUrunKaydi.Name = "btnUrunKaydi";
            this.btnUrunKaydi.Size = new System.Drawing.Size(235, 120);
            this.btnUrunKaydi.TabIndex = 3;
            this.btnUrunKaydi.Text = "Yeni Ürün Kaydı";
            this.btnUrunKaydi.UseVisualStyleBackColor = true;
            this.btnUrunKaydi.Click += new System.EventHandler(this.btnUrunKaydi_Click);
            // 
            // grpbxYeniUrunKaydi
            // 
            this.grpbxYeniUrunKaydi.Controls.Add(this.txtAlisFiyati);
            this.grpbxYeniUrunKaydi.Controls.Add(this.txtStok);
            this.grpbxYeniUrunKaydi.Controls.Add(this.txtUrunAd);
            this.grpbxYeniUrunKaydi.Controls.Add(this.btnSatisKaydiOlustur);
            this.grpbxYeniUrunKaydi.Controls.Add(this.btnFormTemizle);
            this.grpbxYeniUrunKaydi.Controls.Add(this.txtSatisFiyati);
            this.grpbxYeniUrunKaydi.Controls.Add(this.label4);
            this.grpbxYeniUrunKaydi.Controls.Add(this.label3);
            this.grpbxYeniUrunKaydi.Controls.Add(this.label2);
            this.grpbxYeniUrunKaydi.Controls.Add(this.label1);
            this.grpbxYeniUrunKaydi.Location = new System.Drawing.Point(13, 185);
            this.grpbxYeniUrunKaydi.Name = "grpbxYeniUrunKaydi";
            this.grpbxYeniUrunKaydi.Size = new System.Drawing.Size(717, 332);
            this.grpbxYeniUrunKaydi.TabIndex = 6;
            this.grpbxYeniUrunKaydi.TabStop = false;
            this.grpbxYeniUrunKaydi.Text = "Yeni Ürün Kaydı";
            this.grpbxYeniUrunKaydi.Visible = false;
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.Location = new System.Drawing.Point(288, 150);
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(273, 30);
            this.txtAlisFiyati.TabIndex = 15;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(291, 92);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(273, 30);
            this.txtStok.TabIndex = 14;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(291, 39);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(273, 30);
            this.txtUrunAd.TabIndex = 13;
            // 
            // btnSatisKaydiOlustur
            // 
            this.btnSatisKaydiOlustur.Location = new System.Drawing.Point(294, 255);
            this.btnSatisKaydiOlustur.Name = "btnSatisKaydiOlustur";
            this.btnSatisKaydiOlustur.Size = new System.Drawing.Size(270, 48);
            this.btnSatisKaydiOlustur.TabIndex = 12;
            this.btnSatisKaydiOlustur.Text = "Ürün Kaydet";
            this.btnSatisKaydiOlustur.UseVisualStyleBackColor = true;
            this.btnSatisKaydiOlustur.Click += new System.EventHandler(this.btnSatisKaydiOlustur_Click);
            // 
            // btnFormTemizle
            // 
            this.btnFormTemizle.Location = new System.Drawing.Point(94, 255);
            this.btnFormTemizle.Name = "btnFormTemizle";
            this.btnFormTemizle.Size = new System.Drawing.Size(191, 48);
            this.btnFormTemizle.TabIndex = 11;
            this.btnFormTemizle.Text = "Form Temizle";
            this.btnFormTemizle.UseVisualStyleBackColor = true;
            this.btnFormTemizle.Click += new System.EventHandler(this.btnFormTemizle_Click);
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(291, 207);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(273, 30);
            this.txtSatisFiyati.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tahmini Satış Fiyatı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alış Fiyatı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stok Adedi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Ad :";
            // 
            // frmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(742, 541);
            this.Controls.Add(this.grpbxYeniUrunKaydi);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnUrunListesi);
            this.Controls.Add(this.btnUrunKaydi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmUrunler";
            this.Text = "Ürünler";
            this.grpbxYeniUrunKaydi.ResumeLayout(false);
            this.grpbxYeniUrunKaydi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnUrunListesi;
        private System.Windows.Forms.Button btnUrunKaydi;
        private System.Windows.Forms.GroupBox grpbxYeniUrunKaydi;
        private System.Windows.Forms.Button btnSatisKaydiOlustur;
        private System.Windows.Forms.Button btnFormTemizle;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlisFiyati;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtUrunAd;
    }
}