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
    public partial class frmPersonelListesi : Form
    {
        public frmPersonelListesi()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        private void frmPersonelListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblPersoneller", bgl.Baglanti());
            da.Fill(dt);
            dgvPersonelListesi.DataSource = dt;
        }

        private void dgvPersonelListesi_DoubleClick(object sender, EventArgs e)
        {
            frmPersonelGuncelle frmPersonelGuncelle = new frmPersonelGuncelle();
            int secilenPersonel = dgvPersonelListesi.SelectedCells[0].RowIndex;
            frmPersonelGuncelle.personelId = dgvPersonelListesi.Rows[secilenPersonel].Cells[0].Value.ToString();
            frmPersonelGuncelle.Show();
            this.Hide();
        }
    }
}
