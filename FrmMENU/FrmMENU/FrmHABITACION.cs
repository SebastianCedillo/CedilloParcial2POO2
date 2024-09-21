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
    public partial class FrmHABITACION : Form
    {

        private DAOHabitacion daoHabitacion;

        public FrmHABITACION()
        {
            InitializeComponent();

            daoHabitacion = new DAOHabitacion();
            CargarHabitaciones();

        }
        private void CargarHabitaciones()
        {
            dataGridView1.DataSource = daoHabitacion.ObtenerHabitaciones();
        }

        private void LimpiarCampos()
        {
            txtIDHabitacion.Clear();
            txtNumero.Clear();
            txtIDHotel.Clear();
        }


        private void button1_Click(object sender, EventArgs e)
        {


            Habitacion habitacion = new Habitacion
            {
                Numero = txtNumero.Text,
                ID_Hotel = Convert.ToInt32(txtIDHotel.Text)
            };

            daoHabitacion.InsertarHabitacion(habitacion);
            CargarHabitaciones();
            LimpiarCampos();

        }

        private void FrmHABITACION_Load(object sender, EventArgs e)
        {

        }
    }
}
