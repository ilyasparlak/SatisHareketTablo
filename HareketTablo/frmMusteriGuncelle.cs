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
    public partial class frmMusteriGuncelle : Form
    {
        public frmMusteriGuncelle()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        public string musteriId;

        private void frmMusteriGuncelle_Load(object sender, EventArgs e)
        {
            MusteriCekme();
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            MusteriGuncelle();
            OncekiMenu();
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            MusteriSil();
            OncekiMenu();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            OncekiMenu();
        }

        private void MusteriCekme()
        {
            txtMusteriId.Text = musteriId;
            SqlCommand komutMusteri = new SqlCommand("select * from tblMusteriler where MusteriId=@p1", bgl.Baglanti());
            komutMusteri.Parameters.AddWithValue("@p1", musteriId);
            SqlDataReader dr = komutMusteri.ExecuteReader();
            while (dr.Read())
            {
                txtMusteriAd.Text = dr[1].ToString();
            }
            bgl.Baglanti().Close();
        }

        private void MusteriGuncelle()
        {
            SqlCommand komutGuncelle = new SqlCommand("update tblMusteriler set MusteriAdSoyad=@pg1 where MusteriId=@pg2", bgl.Baglanti());
            komutGuncelle.Parameters.AddWithValue("@pg1", txtMusteriAd.Text);
            komutGuncelle.Parameters.AddWithValue("@pg2", musteriId);
            komutGuncelle.ExecuteNonQuery();
            bgl.Baglanti().Close();
        }

        private void MusteriSil()
        {
            SqlCommand komutSil = new SqlCommand("delete from tblMusteriler where MusteriId=@ps1", bgl.Baglanti());
            komutSil.Parameters.AddWithValue("@ps1", musteriId);
            komutSil.ExecuteNonQuery();
            bgl.Baglanti().Close();
        }

        private void OncekiMenu()
        {
            frmMusteriListesi frmMusteriListesi = new frmMusteriListesi();
            frmMusteriListesi.Show();
            this.Hide();
        }
    }
}
