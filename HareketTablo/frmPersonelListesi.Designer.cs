namespace HareketTablo
{
    partial class frmPersonelListesi
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
            this.dgvPersonelListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonelListesi
            // 
            this.dgvPersonelListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonelListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonelListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersonelListesi.Location = new System.Drawing.Point(0, 0);
            this.dgvPersonelListesi.Name = "dgvPersonelListesi";
            this.dgvPersonelListesi.RowHeadersWidth = 51;
            this.dgvPersonelListesi.RowTemplate.Height = 24;
            this.dgvPersonelListesi.Size = new System.Drawing.Size(646, 285);
            this.dgvPersonelListesi.TabIndex = 0;
            this.dgvPersonelListesi.DoubleClick += new System.EventHandler(this.dgvPersonelListesi_DoubleClick);
            // 
            // frmPersonelListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(646, 285);
            this.Controls.Add(this.dgvPersonelListesi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmPersonelListesi";
            this.Text = "Personel Listesi";
            this.Load += new System.EventHandler(this.frmPersonelListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonelListesi;
    }
}