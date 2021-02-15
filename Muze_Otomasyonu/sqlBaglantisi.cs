using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Muze_Otomasyonu
{
    class sqlBaglantisi
    {
       
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source =(LocalDB)\v11.0;Integrated Security=True;AttachDbFileName='|DataDirectory|\PetShop.mdf'");
           // SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-UM5GSCA\\SQLEXPRESS;Initial Catalog=Muze_Otomasyonu;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
        
    }
}
