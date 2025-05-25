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
    public partial class frmUrunler : Form
    {
        public frmUrunler()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        private void btnUrunKaydi_Click(object sender, EventArgs e)
        {
            grpbxYeniUrunKaydi.Visible = true;
        }

        private void btnUrunListesi_Click(object sender, EventArgs e)
        {
            frmUrunListesi frmUrunListesi = new frmUrunListesi();
            frmUrunListesi.Show();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris();
            frmGiris.Show();
            this.Hide();
        }

        private void btnSatisKaydiOlustur_Click(object sender, EventArgs e)
        {
            UrunEkle();
            FormTemizle();
        }

        private void btnFormTemizle_Click(object sender, EventArgs e)
        {
            FormTemizle();
        }

        private void FormTemizle()
        {
            grpbxYeniUrunKaydi.Visible = false;
            txtAlisFiyati.Text = string.Empty;
            txtSatisFiyati.Text = string.Empty;
            txtStok.Text = string.Empty;
            txtUrunAd.Text = string.Empty;
        }

        private void UrunEkle()
        {
            SqlCommand komutEkle = new SqlCommand("insert into tblUrunler (UrunAd, UrunStok, UrunAlisFiyat, UrunSatisFiyat) values (@pe1, @pe2, @pe3, @pe4)", bgl.Baglanti());
            komutEkle.Parameters.AddWithValue("@pe1", txtUrunAd.Text);
            komutEkle.Parameters.AddWithValue("@pe2", txtStok.Text);
            komutEkle.Parameters.AddWithValue("@pe3", txtAlisFiyati.Text);
            komutEkle.Parameters.AddWithValue("@pe4", txtSatisFiyati.Text);
            komutEkle.ExecuteNonQuery();
        }
    }
}
