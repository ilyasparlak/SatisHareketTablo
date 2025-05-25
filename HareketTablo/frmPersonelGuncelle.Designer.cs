namespace HareketTablo
{
    partial class frmPersonelGuncelle
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
            this.txtPersonelId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPersonelGuncelle = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.txtPersonelAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPersonelSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPersonelId
            // 
            this.txtPersonelId.Enabled = false;
            this.txtPersonelId.Location = new System.Drawing.Point(242, 28);
            this.txtPersonelId.Name = "txtPersonelId";
            this.txtPersonelId.Size = new System.Drawing.Size(273, 30);
            this.txtPersonelId.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Personel Id :";
            // 
            // btnPersonelGuncelle
            // 
            this.btnPersonelGuncelle.Location = new System.Drawing.Point(328, 127);
            this.btnPersonelGuncelle.Name = "btnPersonelGuncelle";
            this.btnPersonelGuncelle.Size = new System.Drawing.Size(187, 48);
            this.btnPersonelGuncelle.TabIndex = 23;
            this.btnPersonelGuncelle.Text = "Personel Güncelle";
            this.btnPersonelGuncelle.UseVisualStyleBackColor = true;
            this.btnPersonelGuncelle.Click += new System.EventHandler(this.btnPersonelGuncelle_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(45, 127);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(137, 48);
            this.btnGeri.TabIndex = 22;
            this.btnGeri.Text = "Önceki Menü";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.Location = new System.Drawing.Point(242, 78);
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(273, 30);
            this.txtPersonelAd.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Personel Ad Soyad :";
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.Location = new System.Drawing.Point(188, 127);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(134, 48);
            this.btnPersonelSil.TabIndex = 26;
            this.btnPersonelSil.Text = "Personel Sil";
            this.btnPersonelSil.UseVisualStyleBackColor = true;
            this.btnPersonelSil.Click += new System.EventHandler(this.btnPersonelSil_Click);
            // 
            // frmPersonelGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(563, 210);
            this.Controls.Add(this.btnPersonelSil);
            this.Controls.Add(this.txtPersonelId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPersonelGuncelle);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.txtPersonelAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmPersonelGuncelle";
            this.Text = "Personel Güncelleme";
            this.Load += new System.EventHandler(this.frmPersonelGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPersonelId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPersonelGuncelle;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.TextBox txtPersonelAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPersonelSil;
    }
}