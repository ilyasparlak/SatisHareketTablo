namespace HareketTablo
{
    partial class frmMusteriler
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
            this.grpbxMusteriKaydi = new System.Windows.Forms.GroupBox();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.btnMusteriKaydiOlustur = new System.Windows.Forms.Button();
            this.btnFormTemizle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnMusteriListesi = new System.Windows.Forms.Button();
            this.btnMusteriKaydi = new System.Windows.Forms.Button();
            this.grpbxMusteriKaydi.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxMusteriKaydi
            // 
            this.grpbxMusteriKaydi.Controls.Add(this.txtMusteriAd);
            this.grpbxMusteriKaydi.Controls.Add(this.btnMusteriKaydiOlustur);
            this.grpbxMusteriKaydi.Controls.Add(this.btnFormTemizle);
            this.grpbxMusteriKaydi.Controls.Add(this.label1);
            this.grpbxMusteriKaydi.Location = new System.Drawing.Point(13, 185);
            this.grpbxMusteriKaydi.Name = "grpbxMusteriKaydi";
            this.grpbxMusteriKaydi.Size = new System.Drawing.Size(717, 161);
            this.grpbxMusteriKaydi.TabIndex = 14;
            this.grpbxMusteriKaydi.TabStop = false;
            this.grpbxMusteriKaydi.Text = "Yeni Ürün Kaydı";
            this.grpbxMusteriKaydi.Visible = false;
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Location = new System.Drawing.Point(322, 39);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(273, 30);
            this.txtMusteriAd.TabIndex = 13;
            // 
            // btnMusteriKaydiOlustur
            // 
            this.btnMusteriKaydiOlustur.Location = new System.Drawing.Point(325, 90);
            this.btnMusteriKaydiOlustur.Name = "btnMusteriKaydiOlustur";
            this.btnMusteriKaydiOlustur.Size = new System.Drawing.Size(270, 48);
            this.btnMusteriKaydiOlustur.TabIndex = 12;
            this.btnMusteriKaydiOlustur.Text = "Müşteri Kaydet";
            this.btnMusteriKaydiOlustur.UseVisualStyleBackColor = true;
            this.btnMusteriKaydiOlustur.Click += new System.EventHandler(this.btnMusteriKaydiOlustur_Click);
            // 
            // btnFormTemizle
            // 
            this.btnFormTemizle.Location = new System.Drawing.Point(125, 90);
            this.btnFormTemizle.Name = "btnFormTemizle";
            this.btnFormTemizle.Size = new System.Drawing.Size(191, 48);
            this.btnFormTemizle.TabIndex = 11;
            this.btnFormTemizle.Text = "Form Temizle";
            this.btnFormTemizle.UseVisualStyleBackColor = true;
            this.btnFormTemizle.Click += new System.EventHandler(this.btnFormTemizle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Ad Soyad :";
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(494, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(235, 120);
            this.btnGeri.TabIndex = 13;
            this.btnGeri.Text = "Önceki Menü";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnMusteriListesi
            // 
            this.btnMusteriListesi.Location = new System.Drawing.Point(253, 12);
            this.btnMusteriListesi.Name = "btnMusteriListesi";
            this.btnMusteriListesi.Size = new System.Drawing.Size(235, 120);
            this.btnMusteriListesi.TabIndex = 12;
            this.btnMusteriListesi.Text = "Müşteri Listesi";
            this.btnMusteriListesi.UseVisualStyleBackColor = true;
            this.btnMusteriListesi.Click += new System.EventHandler(this.btnMusteriListesi_Click);
            // 
            // btnMusteriKaydi
            // 
            this.btnMusteriKaydi.Location = new System.Drawing.Point(12, 12);
            this.btnMusteriKaydi.Name = "btnMusteriKaydi";
            this.btnMusteriKaydi.Size = new System.Drawing.Size(235, 120);
            this.btnMusteriKaydi.TabIndex = 11;
            this.btnMusteriKaydi.Text = "Yeni Müşteri Kaydı";
            this.btnMusteriKaydi.UseVisualStyleBackColor = true;
            this.btnMusteriKaydi.Click += new System.EventHandler(this.btnMusteriKaydi_Click);
            // 
            // frmMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(744, 361);
            this.Controls.Add(this.grpbxMusteriKaydi);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnMusteriListesi);
            this.Controls.Add(this.btnMusteriKaydi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmMusteriler";
            this.Text = "Müşteriler";
            this.grpbxMusteriKaydi.ResumeLayout(false);
            this.grpbxMusteriKaydi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxMusteriKaydi;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.Button btnMusteriKaydiOlustur;
        private System.Windows.Forms.Button btnFormTemizle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnMusteriListesi;
        private System.Windows.Forms.Button btnMusteriKaydi;
    }
}