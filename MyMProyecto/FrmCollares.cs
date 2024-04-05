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
    public partial class FrmCollares : Form
    {
        private List<Collar> listarCollares; 
        public FrmCollares()
        {
            InitializeComponent();
        }

        private void cargar()
        {
            CollarNegocio negocio = new CollarNegocio();
            try
            {
                listarCollares = negocio.listar();

                CollarNegocio collarNegocio = new CollarNegocio();
               
                dgvCollares.DataSource = listarCollares;
            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.ToString());
            }
        }

        private void FrmCollares_Load(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
