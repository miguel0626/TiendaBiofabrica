using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataLayer
{
    public class ClienteData
    {
        public static bool ProbarConexion()
        {
            using (SqlConnection conex = new SqlConnection
            (ConfigurationManager.ConnectionStrings["Conex_TiendaBiofabrica"].ConnectionString))
            {
                conex.Open();
                if (conex.State == ConnectionState.Open)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
