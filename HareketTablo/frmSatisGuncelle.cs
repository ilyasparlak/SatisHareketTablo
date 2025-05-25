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
    public partial class frmSatisGuncelle : Form
    {
        public frmSatisGuncelle()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        public string satisId;

        private void frmSatisGuncelle_Load(object sender, EventArgs e)
        {
            UrunListele();
            MusteriListele();
            PersonelListele();
            SatisGetir();
        }

        private void btnSatisGuncelle_Click(object sender, EventArgs e)
        {
            SatisGuncelle();
            OncekiMenu();
        }

        private void btnSatisSil_Click(object sender, EventArgs e)
        {
            SatisSil();
            OncekiMenu();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            OncekiMenu();
        }

        private void SatisGetir()
        {
            txtSatisId.Text = satisId;
            SqlCommand komutSatis = new SqlCommand("select * from tblHareketler where HareketId=@p1", bgl.Baglanti());
            komutSatis.Parameters.AddWithValue("@p1", satisId);
            SqlDataReader drSatis = komutSatis.ExecuteReader();
            while (drSatis.Read())
            {
                cmbUrunAd.SelectedValue = drSatis["Urun"];
                cmbMusteriAd.SelectedValue = drSatis["Musteri"];
                cmbPersonelAd.SelectedValue = drSatis["Personel"];
                txtSatisFiyat.Text = drSatis["Fiyat"].ToString();
            }
            bgl.Baglanti().Close();
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
        }

        private void MusteriListele()
        {
            SqlCommand komutMusteri = new SqlCommand("select * from tblMusteriler", bgl.Baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komutMusteri);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbMusteriAd.ValueMember = "MusteriId";
            cmbMusteriAd.DisplayMember = "MusteriAdSoyad";
            cmbMusteriAd.DataSource = dt;
        }

        private void PersonelListele()
        {
            SqlCommand komutPersonel = new SqlCommand("select * from tblPersoneller", bgl.Baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komutPersonel);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbPersonelAd.ValueMember = "PerId";
            cmbPersonelAd.DisplayMember = "PerAd";
            cmbPersonelAd.DataSource = dt;
        }

        private void SatisGuncelle()
        {
            SqlCommand komutGuncelle = new SqlCommand("update tblHareketler set Urun=@pg1, Musteri=@pg2, Personel=@pg3, Fiyat=@pg4 where HareketId=@pg5", bgl.Baglanti());
            komutGuncelle.Parameters.AddWithValue("@pg1", cmbUrunAd.SelectedValue);
            komutGuncelle.Parameters.AddWithValue("@pg2", cmbMusteriAd.SelectedValue);
            komutGuncelle.Parameters.AddWithValue("@pg3", cmbPersonelAd.SelectedValue);
            komutGuncelle.Parameters.AddWithValue("@pg4", txtSatisFiyat.Text);
            komutGuncelle.Parameters.AddWithValue("@pg5", satisId);
            komutGuncelle.ExecuteNonQuery();
            bgl.Baglanti().Close();
        }

        private void SatisSil()
        {
            SqlCommand komutSil = new SqlCommand("delete from tblHareketler where HareketId=@ps1", bgl.Baglanti());
            komutSil.Parameters.AddWithValue("@ps1", satisId);
            komutSil.ExecuteNonQuery();
            bgl.Baglanti().Close();
        }

        private void OncekiMenu()
        {
            frmSatisListesi frmSatisListesi = new frmSatisListesi();
            frmSatisListesi.Show();
            this.Hide();
        }
    }
}
