using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;

namespace MyMProyecto
{
    public partial class FrmAltaCliente : Form
    {
        public FrmAltaCliente()
        {
            InitializeComponent();
        }

        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {

           RedSocialNegocio redSocialNegocio = new RedSocialNegocio();
            try
            {
                cboRedSocial.DataSource = redSocialNegocio.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }



        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteNegocio negocio = new ClienteNegocio();
            try
            {
                cliente.Nombre = txtNombre.Text;
                cliente.NroTelefono = txtTelefono.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.RedSocial = (RedSocial)cboRedSocial.SelectedItem;
                cliente.NombreUsuario = txtNombreUsuario.Text;

                negocio.agregar(cliente);
                MessageBox.Show("Cliente agregado exitosamente");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
