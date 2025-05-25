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
    public partial class frmSatisListesi : Form
    {
        public frmSatisListesi()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbHareketTabloDataSet2.HareketTablo' table. You can move, or remove it, as needed.
            //this.hareketTabloTableAdapter.Fill(this.dbHareketTabloDataSet2.HareketTablo);

            SqlDataAdapter da = new SqlDataAdapter("execute HareketTablo", bgl.Baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            frmSatisGuncelle frmSatisGuncelle = new frmSatisGuncelle();
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            frmSatisGuncelle.satisId = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frmSatisGuncelle.Show();
            this.Hide();
        }
    }
}
