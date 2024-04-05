using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMProyecto
{
    public partial class FrmCliente : Form
    {
        private List<Cliente> listarClientes;
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void cargar()
        {
            ClienteNegocio negocio = new ClienteNegocio();
            try
            {
                listarClientes = negocio.listar();
                ClienteNegocio clienteNegocio = new ClienteNegocio();
                dgvClientes.DataSource = listarClientes;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
