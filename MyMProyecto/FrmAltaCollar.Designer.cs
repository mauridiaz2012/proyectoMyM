namespace MyMProyecto
{
    partial class FrmAltaCollar
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblLargo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.gbCollar = new System.Windows.Forms.GroupBox();
            this.cboCodigoCollar = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbCollar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLargo
            // 
            this.lblLargo.AutoSize = true;
            this.lblLargo.Location = new System.Drawing.Point(28, 39);
            this.lblLargo.Name = "lblLargo";
            this.lblLargo.Size = new System.Drawing.Size(50, 20);
            this.lblLargo.TabIndex = 18;
            this.lblLargo.Text = "Largo";
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.Chocolate;
            this.txtTitulo.Location = new System.Drawing.Point(49, 9);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(338, 58);
            this.txtTitulo.TabIndex = 19;
            this.txtTitulo.Text = "Alta de Collar";
            this.txtTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(28, 82);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(46, 20);
            this.lblColor.TabIndex = 21;
            this.lblColor.Text = "Color";
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Location = new System.Drawing.Point(28, 160);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(53, 20);
            this.lblPrecioCompra.TabIndex = 22;
            this.lblPrecioCompra.Text = "Precio";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(28, 121);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 20);
            this.lblCantidad.TabIndex = 23;
            this.lblCantidad.Text = "Cantidad";
            // 
            // cboColor
            // 
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(117, 74);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(148, 28);
            this.cboColor.TabIndex = 24;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(117, 154);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(148, 26);
            this.txtPrecio.TabIndex = 27;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(117, 115);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(148, 26);
            this.txtCantidad.TabIndex = 28;
            // 
            // gbCollar
            // 
            this.gbCollar.Controls.Add(this.cboCodigoCollar);
            this.gbCollar.Controls.Add(this.lblCantidad);
            this.gbCollar.Controls.Add(this.txtCantidad);
            this.gbCollar.Controls.Add(this.txtPrecio);
            this.gbCollar.Controls.Add(this.lblPrecioCompra);
            this.gbCollar.Controls.Add(this.cboColor);
            this.gbCollar.Controls.Add(this.lblColor);
            this.gbCollar.Controls.Add(this.lblLargo);
            this.gbCollar.Location = new System.Drawing.Point(59, 105);
            this.gbCollar.Name = "gbCollar";
            this.gbCollar.Size = new System.Drawing.Size(315, 239);
            this.gbCollar.TabIndex = 30;
            this.gbCollar.TabStop = false;
            this.gbCollar.Text = "Collar";
            // 
            // cboCodigoCollar
            // 
            this.cboCodigoCollar.FormattingEnabled = true;
            this.cboCodigoCollar.Location = new System.Drawing.Point(117, 31);
            this.cboCodigoCollar.Name = "cboCodigoCollar";
            this.cboCodigoCollar.Size = new System.Drawing.Size(68, 28);
            this.cboCodigoCollar.TabIndex = 30;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(235, 381);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(139, 34);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(59, 381);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(139, 34);
            this.btnAceptar.TabIndex = 31;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FrmAltaCollar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 477);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbCollar);
            this.Controls.Add(this.txtTitulo);
            this.Name = "FrmAltaCollar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Collar";
            this.Load += new System.EventHandler(this.FrmAltaCollar_Load);
            this.gbCollar.ResumeLayout(false);
            this.gbCollar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblLargo;
        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.GroupBox gbCollar;
        private System.Windows.Forms.ComboBox cboCodigoCollar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}