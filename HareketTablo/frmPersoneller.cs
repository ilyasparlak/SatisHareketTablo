using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HareketTablo
{
    public partial class frmPersoneller : Form
    {
        public frmPersoneller()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        private void btnPersonelKaydi_Click(object sender, EventArgs e)
        {
            grpbxPersonelKaydi.Visible = true;
        }

        private void btnPersonelListesi_Click(object sender, EventArgs e)
        {
            frmPersonelListesi frmPersonelListesi = new frmPersonelListesi();
            frmPersonelListesi.Show();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris();
            frmGiris.Show();
            this.Hide();
        }

        private void btnPersonelKaydiOlustur_Click(object sender, EventArgs e)
        {
            PersonelEkle();
            FormTemizle();
        }

        private void btnFormTemizle_Click(object sender, EventArgs e)
        {
            FormTemizle();
        }

        private void PersonelEkle()
        {
            SqlCommand komutEkle = new SqlCommand("insert into tblPersoneller (PerAd) values (@pe1)", bgl.Baglanti());
            komutEkle.Parameters.AddWithValue("@pe1", txtpersonelAd.Text);
            komutEkle.ExecuteNonQuery();
            bgl.Baglanti().Close();
        }

        private void FormTemizle()
        {
            grpbxPersonelKaydi.Visible = false;
            txtpersonelAd.Text = string.Empty;
        }
    }
}
