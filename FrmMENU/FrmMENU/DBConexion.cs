using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SqlClient;
namespace FrmMENU
{
    public class DBConexion
    {
        private readonly string connectionString;

        public DBConexion()
        {

            connectionString = "Data Source=PC01125858;Initial Catalog=BDHotel;Integrated Security=True;";
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}