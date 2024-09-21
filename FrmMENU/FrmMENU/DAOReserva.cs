using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FrmMENU
{
    public class DAOReserva
    {
        private readonly DBConexion db;

        public DAOReserva()
        {
            db = new DBConexion();
        }
        
        public void InsertarReserva(Reserva reserva)
        {
            using (SqlConnection connection = db.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Reservas (ID_Habitacion, ID_Cliente, Fecha_Entrada, Fecha_Salida) VALUES (@ID_Habitacion, @ID_Cliente, @FechaEntrada, @FechaSalida)";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID_Habitacion", reserva.ID_Habitacion);
                    cmd.Parameters.AddWithValue("@ID_Cliente", reserva.ID_Cliente);
                    cmd.Parameters.AddWithValue("@FechaEntrada", reserva.FechaEntrada);
                    cmd.Parameters.AddWithValue("@FechaSalida", reserva.FechaSalida);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        
        public List<Reserva> ObtenerReservas()
        {
            List<Reserva> reservas = new List<Reserva>();
            using (SqlConnection connection = db.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Reservas";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Reserva reserva = new Reserva
                            {
                                ID_Reserva = Convert.ToInt32(reader["ID_Reserva"]),
                                ID_Habitacion = Convert.ToInt32(reader["ID_Habitacion"]),
                                ID_Cliente = Convert.ToInt32(reader["ID_Cliente"]),
                                FechaEntrada = Convert.ToDateTime(reader["Fecha_Entrada"]),
                                FechaSalida = Convert.ToDateTime(reader["Fecha_Salida"])
                            };
                            reservas.Add(reserva);
                        }
                    }
                }
            }
            return reservas;
        }


        public void ActualizarReserva(Reserva reserva)
        {
            using (SqlConnection connection = db.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Reservas SET ID_Habitacion = @ID_Habitacion, ID_Cliente = @ID_Cliente, Fecha_Entrada = @FechaEntrada, Fecha_Salida = @FechaSalida WHERE ID_Reserva = @ID_Reserva";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID_Habitacion", reserva.ID_Habitacion);
                    cmd.Parameters.AddWithValue("@ID_Cliente", reserva.ID_Cliente);
                    cmd.Parameters.AddWithValue("@FechaEntrada", reserva.FechaEntrada);
                    cmd.Parameters.AddWithValue("@FechaSalida", reserva.FechaSalida);
                    cmd.Parameters.AddWithValue("@ID_Reserva", reserva.ID_Reserva);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        
        public void EliminarReserva(int idReserva)
        {
            using (SqlConnection connection = db.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Reservas WHERE ID_Reserva = @ID_Reserva";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID_Reserva", idReserva);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}