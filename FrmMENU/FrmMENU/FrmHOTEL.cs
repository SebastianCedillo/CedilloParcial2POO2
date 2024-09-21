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
    public partial class FrmHOTEL : Form
    {
        private DAOHotel daoHotel;

        public FrmHOTEL()
        {
            InitializeComponent();
            daoHotel = new DAOHotel();
            CargarHoteles();

        }
        private void CargarHoteles()
        {
            dataGridView1.DataSource = daoHotel.ObtenerHoteles();
        }

        private void FrmHOTEL_Load(object sender, EventArgs e)
        {

        }

        private void LimpiarCampos()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtUbicacion.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Hotel hotel = new Hotel
            {
                Nombre = txtNombre.Text,
                Ubicacion = txtUbicacion.Text
            };

            daoHotel.InsertarHotel(hotel);
            CargarHoteles();
            LimpiarCampos();

        }
    }
}
