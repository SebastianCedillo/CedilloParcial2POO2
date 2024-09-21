using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMENU
{
    public partial class FrmRESERVA : Form
    {
        private DAOReserva daoReserva;

        public FrmRESERVA()
        {
            InitializeComponent();
            daoReserva = new DAOReserva();
            CargarReservas();

        }
        private void CargarReservas()
        {
            dataGridView1.DataSource = daoReserva.ObtenerReservas();
        }
        private void FrmRESERVA_Load(object sender, EventArgs e)
        {

        }


        private void LimpiarCampos()
        {
            txtIDReserva.Clear();
            txtIDHabitacion.Clear();
            txtIDCliente.Clear();
            dtpFechaEntrada.Value = DateTime.Now;
            dtpFechaSalida.Value = DateTime.Now;
        }

        private bool ValidarCampos()
        {


            if (txtIDHabitacion.Text == "")
            {
                MessageBox.Show("El ID de la habitación es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDHabitacion.Focus();
                return false;
            }
            else if (txtIDHabitacion.Text == "")
            {
                MessageBox.Show("El ID de la habitación debe ser un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDHabitacion.Focus();
                return false;
            }

         
            if (txtIDCliente.Text == "")
            {
                MessageBox.Show("El ID del cliente es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDCliente.Focus();
                return false;
            }
            else if (txtIDCliente.Text == "")
            {
                MessageBox.Show("El ID del cliente debe ser un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDCliente.Focus();
                return false;
            }

        
            if (dtpFechaEntrada.Value >= dtpFechaSalida.Value)
            {
                MessageBox.Show("La fecha de entrada debe ser anterior a la fecha de salida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaEntrada.Focus();
                return false;
            }

            return true;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    Reserva reserva = new Reserva
                    {
                        ID_Habitacion = Convert.ToInt32(txtIDHabitacion.Text),
                        ID_Cliente = Convert.ToInt32(txtIDCliente.Text),
                        FechaEntrada = dtpFechaEntrada.Value,
                        FechaSalida = dtpFechaSalida.Value
                    };

                    daoReserva.InsertarReserva(reserva);
                    MessageBox.Show("Reserva insertada con éxito.");
                    CargarReservas();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al insertar: {ex.Message}");
                }
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() && !string.IsNullOrEmpty(txtIDReserva.Text))
            {
                try
                {
                    Reserva reserva = new Reserva
                    {
                        ID_Reserva = Convert.ToInt32(txtIDReserva.Text),
                        ID_Habitacion = Convert.ToInt32(txtIDHabitacion.Text),
                        ID_Cliente = Convert.ToInt32(txtIDCliente.Text),
                        FechaEntrada = dtpFechaEntrada.Value,
                        FechaSalida = dtpFechaSalida.Value
                    };

                    daoReserva.ActualizarReserva(reserva);
                    MessageBox.Show("Reserva actualizada con éxito.");
                    CargarReservas();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una reserva para actualizar.");
            }


        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIDReserva.Text))
            {
                try
                {
                    int idReserva = Convert.ToInt32(txtIDReserva.Text);
                    daoReserva.EliminarReserva(idReserva);
                    MessageBox.Show("Reserva eliminada con éxito.");
                    CargarReservas();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una reserva para eliminar.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0)
            {
                 DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtIDReserva.Text = row.Cells["ID_Reserva"].Value.ToString();
                txtIDHabitacion.Text = row.Cells["ID_Habitacion"].Value.ToString();
                txtIDCliente.Text = row.Cells["ID_Cliente"].Value.ToString();
                dtpFechaEntrada.Value = Convert.ToDateTime(row.Cells["Fecha_Entrada"].Value);
                dtpFechaSalida.Value = Convert.ToDateTime(row.Cells["Fecha_Salida"].Value);
            }


        }
    }
}
