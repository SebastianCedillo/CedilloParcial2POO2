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

            connectionString = "Server=DESKTOP-0OS6OUS;Database=BDHOTEL;User Id=sa;Password=SebastianCedillo9;";
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}