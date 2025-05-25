using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HareketTablo
{
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        private void btnMusteriKaydi_Click(object sender, EventArgs e)
        {
            grpbxMusteriKaydi.Visible = true;
        }

        private void btnMusteriListesi_Click(object sender, EventArgs e)
        {
            frmMusteriListesi frmMusteriListesi = new frmMusteriListesi();
            frmMusteriListesi.Show();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris();
            frmGiris.Show();
            this.Hide();
        }

        private void btnMusteriKaydiOlustur_Click(object sender, EventArgs e)
        {
            MusteriEkle();
            FormTemizle();
        }

        private void btnFormTemizle_Click(object sender, EventArgs e)
        {
            FormTemizle();
        }

        private void MusteriEkle()
        {
            SqlCommand komutEkle = new SqlCommand("insert into tblMusteriler (MusteriAdSoyad) values (@pe1)", bgl.Baglanti());
            komutEkle.Parameters.AddWithValue("@pe1", txtMusteriAd.Text);
            komutEkle.ExecuteNonQuery();
            bgl.Baglanti().Close();
        }

        private void FormTemizle()
        {
            grpbxMusteriKaydi.Visible = false;
            txtMusteriAd.Text = string.Empty;
        }
    }
}
