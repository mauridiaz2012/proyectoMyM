namespace MyMProyecto
{
    partial class FrmPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.cboCollar = new System.Windows.Forms.ComboBox();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblFechaValor = new System.Windows.Forms.Label();
            this.lblMascota = new System.Windows.Forms.Label();
            this.cboMascota = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCollar = new System.Windows.Forms.Label();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblPatron = new System.Windows.Forms.Label();
            this.cboPatron = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLinea1 = new System.Windows.Forms.Label();
            this.txtDatoLinea1 = new System.Windows.Forms.TextBox();
            this.txtDatoLinea2 = new System.Windows.Forms.TextBox();
            this.lblDatoLinea2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblTotalTexto = new System.Windows.Forms.Label();
            this.lblTota = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(146, 61);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(194, 28);
            this.cboCliente.TabIndex = 31;
            // 
            // cboCollar
            // 
            this.cboCollar.FormattingEnabled = true;
            this.cboCollar.Location = new System.Drawing.Point(91, 32);
            this.cboCollar.Name = "cboCollar";
            this.cboCollar.Size = new System.Drawing.Size(95, 28);
            this.cboCollar.TabIndex = 32;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDetalles.Location = new System.Drawing.Point(538, 34);
            this.dgvDetalles.MultiSelect = false;
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.RowHeadersWidth = 62;
            this.dgvDetalles.RowTemplate.Height = 28;
            this.dgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalles.Size = new System.Drawing.Size(1004, 296);
            this.dgvDetalles.TabIndex = 33;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(276, 85);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 26);
            this.nudCantidad.TabIndex = 35;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(142, 456);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 20);
            this.lblTotal.TabIndex = 37;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(54, 61);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(87, 30);
            this.lblCliente.TabIndex = 38;
            this.lblCliente.Text = "Cliente";
            this.lblCliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(346, 64);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 20);
            this.lblFecha.TabIndex = 39;
            this.lblFecha.Text = "Fecha";
            // 
            // lblFechaValor
            // 
            this.lblFechaValor.AutoSize = true;
            this.lblFechaValor.Location = new System.Drawing.Point(426, 66);
            this.lblFechaValor.Name = "lblFechaValor";
            this.lblFechaValor.Size = new System.Drawing.Size(0, 20);
            this.lblFechaValor.TabIndex = 40;
            // 
            // lblMascota
            // 
            this.lblMascota.AutoSize = true;
            this.lblMascota.Location = new System.Drawing.Point(54, 106);
            this.lblMascota.Name = "lblMascota";
            this.lblMascota.Size = new System.Drawing.Size(105, 30);
            this.lblMascota.TabIndex = 41;
            this.lblMascota.Text = "Mascota";
            // 
            // cboMascota
            // 
            this.cboMascota.FormattingEnabled = true;
            this.cboMascota.Location = new System.Drawing.Point(146, 106);
            this.cboMascota.Name = "cboMascota";
            this.cboMascota.Size = new System.Drawing.Size(194, 28);
            this.cboMascota.TabIndex = 42;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(43, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 139);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Pedido";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPrecioUnitario);
            this.groupBox2.Controls.Add(this.lblPrecio);
            this.groupBox2.Controls.Add(this.lblCantidad);
            this.groupBox2.Controls.Add(this.cboPatron);
            this.groupBox2.Controls.Add(this.lblPatron);
            this.groupBox2.Controls.Add(this.lblColor);
            this.groupBox2.Controls.Add(this.cboColor);
            this.groupBox2.Controls.Add(this.lblCollar);
            this.groupBox2.Controls.Add(this.cboCollar);
            this.groupBox2.Controls.Add(this.nudCantidad);
            this.groupBox2.Location = new System.Drawing.Point(43, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 176);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle del Collar";
            // 
            // lblCollar
            // 
            this.lblCollar.AutoSize = true;
            this.lblCollar.Location = new System.Drawing.Point(11, 35);
            this.lblCollar.Name = "lblCollar";
            this.lblCollar.Size = new System.Drawing.Size(74, 30);
            this.lblCollar.TabIndex = 39;
            this.lblCollar.Text = "Collar";
            // 
            // cboColor
            // 
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(276, 32);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(120, 28);
            this.cboColor.TabIndex = 43;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(192, 35);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(46, 20);
            this.lblColor.TabIndex = 44;
            this.lblColor.Text = "Color";
            // 
            // lblPatron
            // 
            this.lblPatron.AutoSize = true;
            this.lblPatron.Location = new System.Drawing.Point(11, 87);
            this.lblPatron.Name = "lblPatron";
            this.lblPatron.Size = new System.Drawing.Size(84, 30);
            this.lblPatron.TabIndex = 45;
            this.lblPatron.Text = "Patron";
            // 
            // cboPatron
            // 
            this.cboPatron.FormattingEnabled = true;
            this.cboPatron.Location = new System.Drawing.Point(91, 84);
            this.cboPatron.Name = "cboPatron";
            this.cboPatron.Size = new System.Drawing.Size(95, 28);
            this.cboPatron.TabIndex = 46;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(192, 87);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(110, 30);
            this.lblCantidad.TabIndex = 47;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(11, 136);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(80, 30);
            this.lblPrecio.TabIndex = 48;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(91, 133);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(166, 26);
            this.txtPrecioUnitario.TabIndex = 49;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDatoLinea2);
            this.groupBox3.Controls.Add(this.lblDatoLinea2);
            this.groupBox3.Controls.Add(this.txtDatoLinea1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblLinea1);
            this.groupBox3.Location = new System.Drawing.Point(43, 418);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(467, 176);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de Bordado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Color";
            // 
            // lblLinea1
            // 
            this.lblLinea1.AutoSize = true;
            this.lblLinea1.Location = new System.Drawing.Point(11, 35);
            this.lblLinea1.Name = "lblLinea1";
            this.lblLinea1.Size = new System.Drawing.Size(92, 30);
            this.lblLinea1.TabIndex = 39;
            this.lblLinea1.Text = "Linea 1";
            // 
            // txtDatoLinea1
            // 
            this.txtDatoLinea1.Location = new System.Drawing.Point(80, 32);
            this.txtDatoLinea1.Name = "txtDatoLinea1";
            this.txtDatoLinea1.Size = new System.Drawing.Size(240, 26);
            this.txtDatoLinea1.TabIndex = 46;
            // 
            // txtDatoLinea2
            // 
            this.txtDatoLinea2.Enabled = false;
            this.txtDatoLinea2.Location = new System.Drawing.Point(80, 97);
            this.txtDatoLinea2.Name = "txtDatoLinea2";
            this.txtDatoLinea2.Size = new System.Drawing.Size(240, 26);
            this.txtDatoLinea2.TabIndex = 48;
            // 
            // lblDatoLinea2
            // 
            this.lblDatoLinea2.AutoSize = true;
            this.lblDatoLinea2.Location = new System.Drawing.Point(11, 100);
            this.lblDatoLinea2.Name = "lblDatoLinea2";
            this.lblDatoLinea2.Size = new System.Drawing.Size(61, 20);
            this.lblDatoLinea2.TabIndex = 47;
            this.lblDatoLinea2.Text = "Linea 2";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(533, 347);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(149, 27);
            this.btnAgregar.TabIndex = 46;
            this.btnAgregar.Text = "Agregar detalle";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(788, 347);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(149, 27);
            this.btnQuitar.TabIndex = 47;
            this.btnQuitar.Text = "Quitar detalle";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGuardar);
            this.groupBox4.Controls.Add(this.lblTota);
            this.groupBox4.Controls.Add(this.lblTotalTexto);
            this.groupBox4.Location = new System.Drawing.Point(579, 418);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(467, 176);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Total";
            // 
            // lblTotalTexto
            // 
            this.lblTotalTexto.AutoSize = true;
            this.lblTotalTexto.Location = new System.Drawing.Point(11, 35);
            this.lblTotalTexto.Name = "lblTotalTexto";
            this.lblTotalTexto.Size = new System.Drawing.Size(72, 30);
            this.lblTotalTexto.TabIndex = 39;
            this.lblTotalTexto.Text = "Total:";
            // 
            // lblTota
            // 
            this.lblTota.AutoSize = true;
            this.lblTota.Location = new System.Drawing.Point(140, 38);
            this.lblTota.Name = "lblTota";
            this.lblTota.Size = new System.Drawing.Size(0, 30);
            this.lblTota.TabIndex = 40;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(144, 126);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(149, 27);
            this.btnGuardar.TabIndex = 47;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1588, 605);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cboMascota);
            this.Controls.Add(this.lblMascota);
            this.Controls.Add(this.lblFechaValor);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPedido";
            this.Text = "FrmPedido";
            this.Load += new System.EventHandler(this.FrmPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.ComboBox cboCollar;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblFechaValor;
        private System.Windows.Forms.Label lblMascota;
        private System.Windows.Forms.ComboBox cboMascota;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cboPatron;
        private System.Windows.Forms.Label lblPatron;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.Label lblCollar;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDatoLinea2;
        private System.Windows.Forms.Label lblDatoLinea2;
        private System.Windows.Forms.TextBox txtDatoLinea1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLinea1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblTotalTexto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTota;
    }
}