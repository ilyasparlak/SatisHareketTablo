﻿namespace HareketTablo
{
    partial class frmMusteriListesi
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
            this.dgvMusteriListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMusteriListesi
            // 
            this.dgvMusteriListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMusteriListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMusteriListesi.Location = new System.Drawing.Point(0, 0);
            this.dgvMusteriListesi.Name = "dgvMusteriListesi";
            this.dgvMusteriListesi.RowHeadersWidth = 51;
            this.dgvMusteriListesi.RowTemplate.Height = 24;
            this.dgvMusteriListesi.Size = new System.Drawing.Size(579, 191);
            this.dgvMusteriListesi.TabIndex = 0;
            this.dgvMusteriListesi.DoubleClick += new System.EventHandler(this.dgvMusteriListesi_DoubleClick);
            // 
            // frmMusteriListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 191);
            this.Controls.Add(this.dgvMusteriListesi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmMusteriListesi";
            this.Text = "frmMusteriListesi";
            this.Load += new System.EventHandler(this.frmMusteriListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMusteriListesi;
    }
}