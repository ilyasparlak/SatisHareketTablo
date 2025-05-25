using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HareketTablo
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnSatislar_Click(object sender, EventArgs e)
        {
            frmSatislar frmSatislar = new frmSatislar();
            frmSatislar.Show();
            this.Hide();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            frmUrunler frmUrunler = new frmUrunler();
            frmUrunler.Show();
            this.Hide();
        }

        private void btnPersoneller_Click(object sender, EventArgs e)
        {
            frmPersoneller frmPersoneller = new frmPersoneller();
            frmPersoneller.Show();
            this.Hide();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            frmMusteriler frmMusteriler = new frmMusteriler();
            frmMusteriler.Show();
            this.Hide();
        }
    }
}
