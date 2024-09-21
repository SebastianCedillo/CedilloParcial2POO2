using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace FrmMENU
{
    public class DAOHabitacion
    {
        private readonly DBConexion db;

        public DAOHabitacion()
        {
            db = new DBConexion();
        }

      
        public void InsertarHabitacion(Habitacion habitacion)
        {
            using (SqlConnection connection = db.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Habitaciones (Numero, ID_Hotel) VALUES (@Numero, @ID_Hotel)";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Numero", habitacion.Numero);
                    cmd.Parameters.AddWithValue("@ID_Hotel", habitacion.ID_Hotel);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public List<Habitacion> ObtenerHabitaciones()
        {
            List<Habitacion> habitaciones = new List<Habitacion>();
            using (SqlConnection connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Habitaciones";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Habitacion habitacion = new Habitacion
                            {
                                ID_Habitacion = Convert.ToInt32(reader["ID_Habitacion"]),
                                Numero = reader["Numero"].ToString(),
                                ID_Hotel = Convert.ToInt32(reader["ID_Hotel"])
                            };
                            habitaciones.Add(habitacion);
                        }
                    }
                }
            }
            return habitaciones;
        }

    
        public void ActualizarHabitacion(Habitacion habitacion)
        {
            using (SqlConnection connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Habitaciones SET Numero = @Numero, ID_Hotel = @ID_Hotel WHERE ID_Habitacion = @ID_Habitacion";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Numero", habitacion.Numero);
                    cmd.Parameters.AddWithValue("@ID_Hotel", habitacion.ID_Hotel);
                    cmd.Parameters.AddWithValue("@ID_Habitacion", habitacion.ID_Habitacion);
                    cmd.ExecuteNonQuery();
                }
            }
        }

 
        public void EliminarHabitacion(int idHabitacion)
        {
            using (SqlConnection connection = db.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Habitaciones WHERE ID_Habitacion = @ID_Habitacion";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID_Habitacion", idHabitacion);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}