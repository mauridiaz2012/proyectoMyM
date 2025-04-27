using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;

namespace MyMProyecto
{
    public partial class FrmPedido : Form
    {
        private List<PedidoDetalle> detallesPedido = new List<PedidoDetalle>();
        private BindingList<PedidoDetalle> bindingDetalles = new BindingList<PedidoDetalle>();

        public FrmPedido()
        {
            InitializeComponent();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            CargarCombos();
            ConfigurarGrilla();
        }

        private void CargarCombos()
        {
            try
            {
                // Cargar clientes
                ClienteNegocio clienteNegocio = new ClienteNegocio();
                cboCliente.DataSource = clienteNegocio.listar();
                cboCliente.DisplayMember = "Nombre";
                cboCliente.ValueMember = "IdCliente";

                // Cargar collares disponibles
                CollarNegocio collarNegocio = new CollarNegocio();
                cboCollar.DataSource = collarNegocio.listar(); //ToDo ver de agregar metodo listar con Stock
                cboCollar.DisplayMember = "Descripcion"; // Ej: "30cm - Rojo"
                cboCollar.ValueMember = "IdCollar";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ConfigurarGrilla()
        {
            dgvDetalles.AutoGenerateColumns = false;
            dgvDetalles.DataSource = bindingDetalles;

            // Configurar columnas
            dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Collar.Descripcion",
                HeaderText = "Collar"
            });

            dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Cantidad",
                HeaderText = "Cantidad"
            });

            dgvDetalles.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "PatronBordado",
                HeaderText = "Patrón"
            });
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Collar collarSeleccionado = (Collar)cboCollar.SelectedItem;

                // Validar
                if (nudCantidad.Value <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida");
                    return;
                }

                // Crear detalle
                PedidoDetalle detalle = new PedidoDetalle()
                {
                    Collar = collarSeleccionado,
                    Cantidad = (int)nudCantidad.Value,
                    PatronBordado = txtPatron.Text,
                    PrecioUnitario = float.Parse(txtPrecioVenta.Text) // Asignar precio actual
            };

                bindingDetalles.Add(detalle);
                CalcularTotal();
                LimpiarControlesDetalle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CalcularTotal()
        {
            float total = 0;
            foreach (var detalle in bindingDetalles)
            {
                total += detalle.Cantidad * detalle.PrecioUnitario;
            }
            lblTotal.Text = total.ToString("C");
        }

        private void LimpiarControlesDetalle()
        {
            nudCantidad.Value = 1;
            txtPatron.Text = string.Empty;
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
            PedidoNegocio pedidoNegocio = new PedidoNegocio();

            try
            {
                // Validaciones básicas
                if (cboCliente.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un cliente");
                    return;
                }

                if (bindingDetalles.Count == 0)
                {
                    MessageBox.Show("Agregue al menos un collar al pedido");
                    return;
                }

                // Crear objeto Pedido
                Pedido nuevoPedido = new Pedido()
                {
                    Fecha = DateTime.Now,
                    Estado = EstadoPedido.Pendiente,
                    Cliente = (Cliente)cboCliente.SelectedItem,
                    Detalles = new List<PedidoDetalle>(bindingDetalles),
                    PrecioTotal = float.Parse(lblTotal.Text.Replace("$", ""))
                };

                // Guardar en BD
                pedidoNegocio.CrearPedido(nuevoPedido);

                MessageBox.Show("Pedido registrado exitosamente!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}