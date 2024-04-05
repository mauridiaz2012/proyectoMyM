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
using dominio;

namespace MyMProyecto
{
    public partial class FrmPrincipal : Form
    {
        private List<Cliente> listaCliente;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaCliente altaCliente = new FrmAltaCliente();
            altaCliente.ShowDialog();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAltaCollar altaCollar = new FrmAltaCollar();
            altaCollar.ShowDialog();
        }

        private void listarCollaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCollares listarCollares = new FrmCollares();
            listarCollares.ShowDialog();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //ToDo:
         //Hacer el metodo modificar, previamente se deben listar los clientes.
            
        }

        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente listarClientes = new FrmCliente();
            listarClientes.ShowDialog();
        }
    }
}
