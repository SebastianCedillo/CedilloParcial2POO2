using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;


namespace FrmMENU
{
    public class DAOHotel
    {
        private readonly DBConexion db;

        public DAOHotel()
        {
            db = new DBConexion();
        }

      
        public void InsertarHotel(Hotel hotel)
        {
            using (SqlConnection connection = db.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Hoteles (Nombre, Ubicacion) VALUES (@Nombre, @Ubicacion)";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Nombre", hotel.Nombre);
                    cmd.Parameters.AddWithValue("@Ubicacion", hotel.Ubicacion);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Hotel> ObtenerHoteles()
        {
            List<Hotel> hoteles = new List<Hotel>();
            using (SqlConnection connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Hoteles";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Hotel hotel = new Hotel
                            {
                                ID_Hotel = Convert.ToInt32(reader["ID_Hotel"]),
                                Nombre = reader["Nombre"].ToString(),
                                Ubicacion = reader["Ubicacion"].ToString()
                            };
                            hoteles.Add(hotel);
                        }
                    }
                }
            }
            return hoteles;
        }

       
        public void ActualizarHotel(Hotel hotel)
        {
            using (SqlConnection connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Hoteles SET Nombre = @Nombre, Ubicacion = @Ubicacion WHERE ID_Hotel = @ID_Hotel";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Nombre", hotel.Nombre);
                    cmd.Parameters.AddWithValue("@Ubicacion", hotel.Ubicacion);
                    cmd.Parameters.AddWithValue("@ID_Hotel", hotel.ID_Hotel);
                    cmd.ExecuteNonQuery();
                }
            }
        }

     
        public void EliminarHotel(int idHotel)
        {
            using (SqlConnection connection = db.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Hoteles WHERE ID_Hotel = @ID_Hotel";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID_Hotel", idHotel);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}