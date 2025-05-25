using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HareketTablo
{
    internal class SqlBaglanti
    {
        public SqlConnection Baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-6O7H141\\SQLEXPRESS;Initial Catalog=dbHareketTablo;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
