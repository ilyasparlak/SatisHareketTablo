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
    public partial class frmUrunListesi : Form
    {
        public frmUrunListesi()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        private void frmUrunListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblUrunler", bgl.Baglanti());
            da.Fill(dt);
            dgvUrunListesi.DataSource = dt;
        }

        private void dgvUrunListesi_DoubleClick(object sender, EventArgs e)
        {
            frmUrunGuncelle frmUrunGuncelle = new frmUrunGuncelle();
            int secilen = dgvUrunListesi.SelectedCells[0].RowIndex;
            frmUrunGuncelle.urunId = dgvUrunListesi.Rows[secilen].Cells[0].Value.ToString();
            frmUrunGuncelle.Show();
            this.Hide();
        }
    }
}
