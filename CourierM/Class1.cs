using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CourierM
{
     class Class1
    {
        public SqlConnection Cn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();

        public void Connecter()
        {
            Cn.ConnectionString = "Data Source=.;Initial Catalog=courier;Integrated Security=True";
            Cn.Open();
        }

        public void deco()
        {
            Cn.Close();
        }
    }
}
