namespace HareketTablo
{
    partial class frmPersoneller
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
            this.grpbxPersonelKaydi = new System.Windows.Forms.GroupBox();
            this.txtpersonelAd = new System.Windows.Forms.TextBox();
            this.btnPersonelKaydiOlustur = new System.Windows.Forms.Button();
            this.btnFormTemizle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnPersonelListesi = new System.Windows.Forms.Button();
            this.btnPersonelKaydi = new System.Windows.Forms.Button();
            this.grpbxPersonelKaydi.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxPersonelKaydi
            // 
            this.grpbxPersonelKaydi.Controls.Add(this.txtpersonelAd);
            this.grpbxPersonelKaydi.Controls.Add(this.btnPersonelKaydiOlustur);
            this.grpbxPersonelKaydi.Controls.Add(this.btnFormTemizle);
            this.grpbxPersonelKaydi.Controls.Add(this.label1);
            this.grpbxPersonelKaydi.Location = new System.Drawing.Point(13, 185);
            this.grpbxPersonelKaydi.Name = "grpbxPersonelKaydi";
            this.grpbxPersonelKaydi.Size = new System.Drawing.Size(717, 161);
            this.grpbxPersonelKaydi.TabIndex = 10;
            this.grpbxPersonelKaydi.TabStop = false;
            this.grpbxPersonelKaydi.Text = "Yeni Personel Kaydı";
            this.grpbxPersonelKaydi.Visible = false;
            // 
            // txtpersonelAd
            // 
            this.txtpersonelAd.Location = new System.Drawing.Point(322, 39);
            this.txtpersonelAd.Name = "txtpersonelAd";
            this.txtpersonelAd.Size = new System.Drawing.Size(273, 30);
            this.txtpersonelAd.TabIndex = 13;
            // 
            // btnPersonelKaydiOlustur
            // 
            this.btnPersonelKaydiOlustur.Location = new System.Drawing.Point(325, 90);
            this.btnPersonelKaydiOlustur.Name = "btnPersonelKaydiOlustur";
            this.btnPersonelKaydiOlustur.Size = new System.Drawing.Size(270, 48);
            this.btnPersonelKaydiOlustur.TabIndex = 12;
            this.btnPersonelKaydiOlustur.Text = "Personel Kaydet";
            this.btnPersonelKaydiOlustur.UseVisualStyleBackColor = true;
            this.btnPersonelKaydiOlustur.Click += new System.EventHandler(this.btnPersonelKaydiOlustur_Click);
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
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Ad Soyad :";
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(494, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(235, 120);
            this.btnGeri.TabIndex = 9;
            this.btnGeri.Text = "Önceki Menü";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnPersonelListesi
            // 
            this.btnPersonelListesi.Location = new System.Drawing.Point(253, 12);
            this.btnPersonelListesi.Name = "btnPersonelListesi";
            this.btnPersonelListesi.Size = new System.Drawing.Size(235, 120);
            this.btnPersonelListesi.TabIndex = 8;
            this.btnPersonelListesi.Text = "Personel Listesi";
            this.btnPersonelListesi.UseVisualStyleBackColor = true;
            this.btnPersonelListesi.Click += new System.EventHandler(this.btnPersonelListesi_Click);
            // 
            // btnPersonelKaydi
            // 
            this.btnPersonelKaydi.Location = new System.Drawing.Point(12, 12);
            this.btnPersonelKaydi.Name = "btnPersonelKaydi";
            this.btnPersonelKaydi.Size = new System.Drawing.Size(235, 120);
            this.btnPersonelKaydi.TabIndex = 7;
            this.btnPersonelKaydi.Text = "Yeni Personel Kaydı";
            this.btnPersonelKaydi.UseVisualStyleBackColor = true;
            this.btnPersonelKaydi.Click += new System.EventHandler(this.btnPersonelKaydi_Click);
            // 
            // frmPersoneller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(748, 369);
            this.Controls.Add(this.grpbxPersonelKaydi);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnPersonelListesi);
            this.Controls.Add(this.btnPersonelKaydi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmPersoneller";
            this.Text = "Personeller";
            this.grpbxPersonelKaydi.ResumeLayout(false);
            this.grpbxPersonelKaydi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxPersonelKaydi;
        private System.Windows.Forms.TextBox txtpersonelAd;
        private System.Windows.Forms.Button btnPersonelKaydiOlustur;
        private System.Windows.Forms.Button btnFormTemizle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnPersonelListesi;
        private System.Windows.Forms.Button btnPersonelKaydi;
    }
}