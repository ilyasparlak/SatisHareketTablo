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
    public partial class frmSatislar : Form
    {
        public frmSatislar()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        private void btnSatisListesi_Click(object sender, EventArgs e)
        {
            frmSatisListesi frmSatisListesi = new frmSatisListesi();
            frmSatisListesi.Show();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris();
            frmGiris.Show();
            this.Hide();
        }

        private void btnSatisGirisi_Click(object sender, EventArgs e)
        {
            grpbxYeniSatisKaydi.Visible = true;

            UrunListele();
            MusteriListele();
            PersonelListele();
        }

        private void btnSatisKaydiOlustur_Click(object sender, EventArgs e)
        {
            YeniSatisKaydi();
            FormTemizle();
        }

        private void btnFormTemizle_Click(object sender, EventArgs e)
        {
            FormTemizle();
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            
        }

        private void UrunListele()
        {
            SqlCommand komutUrun = new SqlCommand("select * From tblUrunler", bgl.Baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komutUrun);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbUrunAd.ValueMember = "UrunId";
            cmbUrunAd.DisplayMember = "UrunAd";
            cmbUrunAd.DataSource = dt;
            cmbUrunAd.Text = "Lütfen seçiniz.";
        }

        private void MusteriListele()
        {
            SqlCommand komutMusteri = new SqlCommand("select * from tblMusteriler", bgl.Baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komutMusteri);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbMusteriAdSoyad.ValueMember = "MusteriId";
            cmbMusteriAdSoyad.DisplayMember = "MusteriAdSoyad";
            cmbMusteriAdSoyad.DataSource = dt;
            cmbMusteriAdSoyad.Text = "Lütfen seçiniz.";
        }

        private void PersonelListele()
        {
            SqlCommand komutPersonel = new SqlCommand("select * from tblPersoneller", bgl.Baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komutPersonel);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbPersonelAdSoyad.ValueMember = "PerId";
            cmbPersonelAdSoyad.DisplayMember = "PerAd";
            cmbPersonelAdSoyad.DataSource = dt;
            cmbPersonelAdSoyad.Text = "Lütfen seçiniz.";
        }
        private void FormTemizle()
        {
            grpbxYeniSatisKaydi.Visible = false;
            txtSatisFiyati.Text = string.Empty;
        }

        private void YeniSatisKaydi()
        {
            SqlCommand komutEkle = new SqlCommand("insert into tblHareketler (Urun, Musteri, Personel, Fiyat) values (@pe1, @pe2, @pe3, @pe4)", bgl.Baglanti());
            komutEkle.Parameters.AddWithValue("@pe1", cmbUrunAd.SelectedValue);
            komutEkle.Parameters.AddWithValue("@pe2", cmbMusteriAdSoyad.SelectedValue);
            komutEkle.Parameters.AddWithValue("@pe3", cmbPersonelAdSoyad.SelectedValue);
            komutEkle.Parameters.AddWithValue("@pe4", txtSatisFiyati.Text);
            komutEkle.ExecuteNonQuery();
            bgl.Baglanti().Close();
        }
    }
}
