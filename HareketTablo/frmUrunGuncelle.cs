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
    public partial class frmUrunGuncelle : Form
    {
        public frmUrunGuncelle()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        public string urunId;

        private void frmUrunGuncelle_Load(object sender, EventArgs e)
        {
            UrunCekme();
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            UrunGuncelle();
            OncekiMenu();
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            UrunSil();
            OncekiMenu();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            OncekiMenu();
        }

        private void UrunCekme()
        {
            txtUrunId.Text = urunId;
            SqlCommand komutUrun = new SqlCommand("select * from tblUrunler where UrunId=@p1", bgl.Baglanti());
            komutUrun.Parameters.AddWithValue("@p1", urunId);
            SqlDataReader drUrun = komutUrun.ExecuteReader();
            while (drUrun.Read())
            {
                txtUrunAd.Text = drUrun[1].ToString();
                txtStokMiktari.Text = drUrun[2].ToString();
                txtAlisFiyat.Text = drUrun[3].ToString();
                txtSatisFiyat.Text = drUrun[4].ToString();
            }
            bgl.Baglanti().Close();
        }

        private void UrunGuncelle()
        {
            SqlCommand komutGuncelle = new SqlCommand("update tblUrunler set UrunAd=@pg1, UrunStok=@pg2, UrunAlisFiyat=@pg3, UrunSatisFiyat=@pg4 where UrunId=@pg5", bgl.Baglanti());
            komutGuncelle.Parameters.AddWithValue("@pg1", txtUrunAd.Text);
            komutGuncelle.Parameters.AddWithValue("@pg2", txtStokMiktari.Text);
            komutGuncelle.Parameters.AddWithValue("@pg3", txtAlisFiyat.Text);
            komutGuncelle.Parameters.AddWithValue("@pg4", txtSatisFiyat.Text);
            komutGuncelle.Parameters.AddWithValue("@pg5", urunId);
            komutGuncelle.ExecuteNonQuery();
            bgl.Baglanti().Close();
        }

        private void UrunSil()
        {
            SqlCommand komutSil = new SqlCommand("delete from tblUrunler where UrunId=@ps1", bgl.Baglanti());
            komutSil.Parameters.AddWithValue("@ps1", urunId);
            komutSil.ExecuteNonQuery();
            bgl.Baglanti().Close();
        }

        private void OncekiMenu()
        {
            frmUrunListesi frmUrunListesi = new frmUrunListesi();
            frmUrunListesi.Show();
            this.Hide();
        }
    }
}
