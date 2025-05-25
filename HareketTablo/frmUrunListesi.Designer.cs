namespace HareketTablo
{
    partial class frmUrunListesi
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
            this.dgvUrunListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUrunListesi
            // 
            this.dgvUrunListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUrunListesi.Location = new System.Drawing.Point(0, 0);
            this.dgvUrunListesi.Name = "dgvUrunListesi";
            this.dgvUrunListesi.RowHeadersWidth = 51;
            this.dgvUrunListesi.RowTemplate.Height = 24;
            this.dgvUrunListesi.Size = new System.Drawing.Size(862, 501);
            this.dgvUrunListesi.TabIndex = 0;
            this.dgvUrunListesi.DoubleClick += new System.EventHandler(this.dgvUrunListesi_DoubleClick);
            // 
            // frmUrunListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 501);
            this.Controls.Add(this.dgvUrunListesi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmUrunListesi";
            this.Text = "Ürün Listesi";
            this.Load += new System.EventHandler(this.frmUrunListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUrunListesi;
    }
}