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
    public partial class FrmMENU : Form
    {
        public FrmMENU()
        {
            InitializeComponent();
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCLIENTE Ventana = new FrmCLIENTE();
            Ventana.Show();
        }

        private void registrarHabitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmHABITACION Ventana = new FrmHABITACION();
            Ventana.Show();

        }

        private void registrarHotelToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmHOTEL Ventana = new FrmHOTEL();
            Ventana.Show();

        }

        private void generarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmRESERVA Ventana = new FrmRESERVA();
            Ventana.Show();

        }

        private void FrmMENU_Load(object sender, EventArgs e)
        {

        }
    }
}
