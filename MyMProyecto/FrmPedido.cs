using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MyMProyecto
{
    public partial class FrmPedido : Form
    {
        private BindingList<PedidoDetalle> bindingDetalles = new BindingList<PedidoDetalle>();
        private decimal totalPedido = 0;

        public FrmPedido()
        {
            InitializeComponent();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            lblFechaValor.Text = DateTime.Now.ToString("dd/MM/yyyy");
            CargarCombos();
            ConfigurarGrilla();
        }

        private void CargarCombos()
        {
            try
            {
                // Clientes
                ClienteNegocio clienteNegocio = new ClienteNegocio();
                cboCliente.DataSource = clienteNegocio.listar();
                cboCliente.DisplayMember = "ResumenCliente";
                cboCliente.ValueMember = "IdCliente";

                cboCliente.SelectedIndex = -1;
                //MessageBox.Show("Clientes OK");

                // Collares
                CollarNegocio collarNegocio = new CollarNegocio();
                cboCollar.DataSource = collarNegocio.listarConStock();
                cboCollar.DisplayMember = "CodigoCollar";
                cboCollar.ValueMember = "IdCollar";
                cboCollar.SelectedIndex = -1;
                //MessageBox.Show("Collares OK");

                // Colores
                ColorCollarNegocio colorNegocio = new ColorCollarNegocio();
                cboColor.DataSource = colorNegocio.listar();
                cboColor.DisplayMember = "Color";
                cboColor.ValueMember = "IdColor";
                cboColor.SelectedIndex = -1;
                //MessageBox.Show("Colores OK");

                // Patrones
                PatronNegocio patronNegocio = new PatronNegocio();
                cboPatron.DataSource = patronNegocio.ObtenerActivos();
                cboPatron.DisplayMember = "NombrePatron";
                cboPatron.ValueMember = "IdPatron";
                cboPatron.SelectedIndex = -1;
                //MessageBox.Show("Patrones OK");

                cboMascota.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }



        private void ConfigurarGrilla()
        {
            dgvDetalles.AutoGenerateColumns = false;
            dgvDetalles.AllowUserToAddRows = false;

            dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ResumenDetalle",
                HeaderText = "Detalle",
                Width = 400,
                ReadOnly = true
            });
            dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Cantidad",
                HeaderText = "Cant.",
                Width = 60,
                ReadOnly = true
            });
            dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "PrecioUnitario",
                HeaderText = "Precio Unit.",
                Width = 100,
                ReadOnly = true
            });
            dgvDetalles.DataSource = bindingDetalles;
        }

        // Al cambiar el cliente, cargamos sus mascotas
        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCliente.SelectedItem == null) return;
            if(cboCliente.SelectedIndex == -1) return;

            try
            {
                Cliente clienteSeleccionado = (Cliente)cboCliente.SelectedItem;
                MascotaNegocio mascotaNegocio = new MascotaNegocio();

                List<Mascota> mascotas = mascotaNegocio.ObtenerPorCliente(clienteSeleccionado.IdCliente);
                
                cboMascota.DisplayMember = "ResumenMascota";
                cboMascota.ValueMember = "IdMascota";
                cboMascota.DataSource = mascotas;
               // cboMascota.DataSource = mascotaNegocio.ObtenerPorCliente(clienteSeleccionado.IdCliente);
                
                cboMascota.SelectedIndex = -1;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar mascotas: " + ex.Message);
            }
        }

        private void cboMascota_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMascota.SelectedItem == null) return;

            Mascota mascota = (Mascota)cboMascota.SelectedItem;
           
        }

        // Al cambiar el collar, habilitamos o deshabilitamos DatoLinea2
        private void cboCollar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCollar.SelectedItem == null) return;

            Collar collarSeleccionado = (Collar)cboCollar.SelectedItem;

            //Debug
            //MessageBox.Show($"Collar: {collarSeleccionado.CodigoCollar} - AdmiteDosLineas: {collarSeleccionado.AdmiteDosLineas}");

            // Si el collar admite dos líneas habilitamos el segundo campo
            txtDatoLinea2.Enabled = collarSeleccionado.AdmiteDosLineas;
            lblDatoLinea2.ForeColor = collarSeleccionado.AdmiteDosLineas
                ? System.Drawing.Color.Black
                : System.Drawing.Color.Gray;

            if (!collarSeleccionado.AdmiteDosLineas)
                txtDatoLinea2.Text = string.Empty;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones
                if (cboCliente.SelectedItem == null) { MessageBox.Show("Seleccione un cliente."); return; }
                if (cboMascota.SelectedItem == null) { MessageBox.Show("Seleccione una mascota."); return; }
                if (cboCollar.SelectedItem == null) { MessageBox.Show("Seleccione un collar."); return; }
                if (cboColor.SelectedItem == null) { MessageBox.Show("Seleccione un color."); return; }
                if (cboPatron.SelectedItem == null) { MessageBox.Show("Seleccione un patrón."); return; }
                if (string.IsNullOrWhiteSpace(txtDatoLinea1.Text)) { MessageBox.Show("Ingrese el dato de bordado."); return; }
                if (nudCantidad.Value <= 0) { MessageBox.Show("Ingrese una cantidad válida."); return; }

                //MessageBox.Show("Pasó todas las validaciones");

                if (!decimal.TryParse(txtPrecioUnitario.Text, out decimal precioUnitario) || precioUnitario <= 0)
                {
                    MessageBox.Show("Ingrese un precio válido.");
                    return;
                }
               // MessageBox.Show("Precio OK: " + precioUnitario);
                Collar collarSeleccionado = (Collar)cboCollar.SelectedItem;
                ColorCollar colorSeleccionado = (ColorCollar)cboColor.SelectedItem;
                Mascota mascotaSeleccionada = (Mascota)cboMascota.SelectedItem;
                Patron patronSeleccionado = (Patron)cboPatron.SelectedItem;

                // Validar stock
                if (collarSeleccionado.Cantidad < (int)nudCantidad.Value)
                {
                    MessageBox.Show($"Stock insuficiente. Stock disponible: {collarSeleccionado.Cantidad}");
                    return;
                }

                PedidoDetalle detalle = new PedidoDetalle()
                {
                    Collar = collarSeleccionado,
                    IdCollar = collarSeleccionado.IdCollar,
                    Color = colorSeleccionado,
                    IdColor = colorSeleccionado.IdColor,
                    Mascota = mascotaSeleccionada,
                    IdMascota = mascotaSeleccionada.IdMascota,
                    IdPatron = patronSeleccionado.IdPatron,
                    PatronBordado = patronSeleccionado.NombrePatron,
                    DatoLinea1 = txtDatoLinea1.Text.Trim(),
                    DatoLinea2 = collarSeleccionado.AdmiteDosLineas ? txtDatoLinea2.Text.Trim() : null,
                    Cantidad = (int)nudCantidad.Value,
                    PrecioUnitario = precioUnitario
                };

                bindingDetalles.Add(detalle);
                CalcularTotal();
                LimpiarControlesDetalle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar detalle: " + ex.Message);
            }
        }

        private void CalcularTotal()
        {
            totalPedido = 0;
            foreach (var detalle in bindingDetalles)
                totalPedido += detalle.Cantidad * detalle.PrecioUnitario;

            lblTota.Text =totalPedido.ToString("C");
        }

        private void LimpiarControlesDetalle()
        {
            cboCollar.SelectedIndex = -1;
            cboColor.SelectedIndex = -1;
            cboPatron.SelectedIndex = -1;
            cboMascota.SelectedIndex = -1;
            txtDatoLinea1.Text = string.Empty;
            txtDatoLinea2.Text = string.Empty;
            txtDatoLinea2.Enabled = false;
            nudCantidad.Value = 1;
            txtPrecioUnitario.Text = string.Empty;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvDetalles.CurrentRow != null)
            {
                bindingDetalles.RemoveAt(dgvDetalles.CurrentRow.Index);
                CalcularTotal();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboCliente.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un cliente.");
                    return;
                }
                if (bindingDetalles.Count == 0)
                {
                    MessageBox.Show("Agregue al menos un collar al pedido.");
                    return;
                }

                Pedido nuevoPedido = new Pedido()
                {
                    Fecha = DateTime.Now,
                    Estado = EstadoPedido.Pendiente,
                    Cliente = (Cliente)cboCliente.SelectedItem,
                    IdCliente = ((Cliente)cboCliente.SelectedItem).IdCliente,
                    Detalles = new List<PedidoDetalle>(bindingDetalles),
                    PrecioTotal = totalPedido
                };

                PedidoNegocio pedidoNegocio = new PedidoNegocio();
                pedidoNegocio.CrearPedido(nuevoPedido);

                MessageBox.Show("¡Pedido registrado exitosamente!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar pedido: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}