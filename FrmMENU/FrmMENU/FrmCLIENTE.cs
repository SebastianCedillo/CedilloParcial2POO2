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
    public partial class FrmCLIENTE : Form
    {
        private DAOCliente daoCliente;

        public FrmCLIENTE()
        {
            InitializeComponent();

            daoCliente = new DAOCliente();
            CargarClientes();

        }

        private void CargarClientes()
        {
            dataGridView1.DataSource = daoCliente.ObtenerClientes();
        }

        private void FrmCLIENTE_Load(object sender, EventArgs e)
        {

        }

        private void LimpiarCampos()
        {
            txtIDCliente.Clear();
            txtNombre.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Cliente cliente = new Cliente
            {
                Nombre = txtNombre.Text
            };

            daoCliente.InsertarCliente(cliente);
            CargarClientes();
            LimpiarCampos();

        }
    }
}
