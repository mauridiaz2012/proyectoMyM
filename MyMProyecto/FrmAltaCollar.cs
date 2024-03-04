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
using negocio;

namespace MyMProyecto
{
    public partial class FrmAltaCollar : Form
    {
        public FrmAltaCollar()
        {
            InitializeComponent();
        }

        private void FrmAltaCollar_Load(object sender, EventArgs e)
        {
           ColorCollarNegocio colorCollarNegocio = new ColorCollarNegocio();
            try
            {
                cboColor.DataSource = colorCollarNegocio.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            CodigoCollarNegocio codigoCollarNegocio = new CodigoCollarNegocio();
            try
            {
                cboCodigoCollar.DataSource = codigoCollarNegocio.listar();
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Collar collar = new Collar();
            CollarNegocio negocio = new CollarNegocio();
            try
            {
                collar.Largo = (CodigoCollar)cboCodigoCollar.SelectedItem;
                collar.Color = (ColorCollar)cboColor.SelectedItem;
                collar.PrecioCompra = float.Parse(txtPrecio.Text);
                collar.Cantidad = int.Parse(txtCantidad.Text);

                negocio.agregar(collar);
                MessageBox.Show("Collar agregado exitosamente");
                Close(); 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
    }
}
