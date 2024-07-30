using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace library_management__system
{
    internal class connclass
    {
        public SqlConnection Connect()
        {
            SqlConnection con = new SqlConnection("data source =moha;initial catalog=library;integrated security=true;");
            con.Open();
            return con;
        }
    }
}
