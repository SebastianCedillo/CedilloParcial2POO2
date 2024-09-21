using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace FrmMENU
{
    public class DAOCliente
    {
        private readonly DBConexion db;

        public DAOCliente()
        {
            db = new DBConexion();
        }

    
        public void InsertarCliente(Cliente cliente)
        {
            using (SqlConnection connection = db.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Clientes (Nombre) VALUES (@Nombre)";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        
        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            using (SqlConnection connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Clientes";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cliente cliente = new Cliente
                            {
                                ID_Cliente = Convert.ToInt32(reader["ID_Cliente"]),
                                Nombre = reader["Nombre"].ToString()
                            };
                            clientes.Add(cliente);
                        }
                    }
                }
            }
            return clientes;
        }

      
        public void ActualizarCliente(Cliente cliente)
        {
            using (SqlConnection connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Clientes SET Nombre = @Nombre WHERE ID_Cliente = @ID_Cliente";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    cmd.Parameters.AddWithValue("@ID_Cliente", cliente.ID_Cliente);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    
        public void EliminarCliente(int idCliente)
        {
            using (SqlConnection connection = db.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Clientes WHERE ID_Cliente = @ID_Cliente";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID_Cliente", idCliente);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}