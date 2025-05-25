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
    public partial class frmPersonelGuncelle : Form
    {
        public frmPersonelGuncelle()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        public string personelId;

        private void frmPersonelGuncelle_Load(object sender, EventArgs e)
        {
            PersonelCekme();
        }

        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            PersonelGuncelle();
            OncekiMenu();
        }
        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            PersonelSil();
            OncekiMenu();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            OncekiMenu();
        }

        private void PersonelCekme()
        {
            txtPersonelId.Text = personelId;
            SqlCommand komutPersonel = new SqlCommand("select * from tblPersoneller where PerId=@p1", bgl.Baglanti());
            komutPersonel.Parameters.AddWithValue("@p1", personelId);
            SqlDataReader dr = komutPersonel.ExecuteReader();
            while (dr.Read())
            {
                txtPersonelAd.Text = dr[1].ToString();
            }
            bgl.Baglanti().Close();
        }

        private void PersonelGuncelle()
        {
            SqlCommand komutGuncelle = new SqlCommand("update tblPersoneller set PerAd=@pg1 where PerId=@pg2", bgl.Baglanti());
            komutGuncelle.Parameters.AddWithValue("@pg1", txtPersonelAd.Text);
            komutGuncelle.Parameters.AddWithValue("@pg2", txtPersonelId.Text);
            komutGuncelle.ExecuteNonQuery();
            bgl.Baglanti().Close();
        }

        private void PersonelSil()
        {
            SqlCommand komutSil = new SqlCommand("delete from tblPersoneller where PerId=@ps1", bgl.Baglanti());
            komutSil.Parameters.AddWithValue("@ps1", personelId);
            komutSil.ExecuteNonQuery();
            bgl.Baglanti().Close();
        }

        private void OncekiMenu()
        {
            frmPersonelListesi frmPersonelListesi = new frmPersonelListesi();
            frmPersonelListesi.Show();
            this.Hide();
        }

    }
}
