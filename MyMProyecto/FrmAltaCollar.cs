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
    public partial class FrmAltaCollar : Form
    {
        public FrmAltaCollar()
        {
            InitializeComponent();
        }

        private void FrmAltaCollar_Load(object sender, EventArgs e)
        {
           
            cboColor.Items.Add("Blanco");
            cboColor.Items.Add("Negro");
            cboColor.Items.Add("Azul");
            cboColor.Items.Add("Fucsia");
            cboColor.Items.Add("Verde");
            cboColor.Items.Add("Verde Manzana");
            cboColor.Items.Add("Violeta");
            cboColor.Items.Add("Rojo");
            cboColor.Items.Add("Naranja");
            cboColor.Items.Add("Amarillo");
        }
    }
}
