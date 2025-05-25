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
    public partial class frmMusteriListesi : Form
    {
        public frmMusteriListesi()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        private void frmMusteriListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblMusteriler", bgl.Baglanti());
            da.Fill(dt);
            dgvMusteriListesi.DataSource = dt;
        }

        private void dgvMusteriListesi_DoubleClick(object sender, EventArgs e)
        {
            frmMusteriGuncelle frmMusteriGuncelle = new frmMusteriGuncelle();
            int secilenMusteri = dgvMusteriListesi.SelectedCells[0].RowIndex;
            frmMusteriGuncelle.musteriId = dgvMusteriListesi.Rows[secilenMusteri].Cells[0].Value.ToString();
            frmMusteriGuncelle.Show();
            this.Hide();
        }
    }
}
