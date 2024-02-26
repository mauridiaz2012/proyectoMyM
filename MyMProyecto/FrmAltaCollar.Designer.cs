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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.lblLargo = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cboLargo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(110, 126);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(89, 30);
            this.lblCodigo.TabIndex = 18;
            this.lblCodigo.Text = "Codigo";
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.Chocolate;
            this.txtTitulo.Location = new System.Drawing.Point(195, 19);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(507, 87);
            this.txtTitulo.TabIndex = 19;
            this.txtTitulo.Text = "Alta de Collar";
            this.txtTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLargo
            // 
            this.lblLargo.AutoSize = true;
            this.lblLargo.Location = new System.Drawing.Point(110, 170);
            this.lblLargo.Name = "lblLargo";
            this.lblLargo.Size = new System.Drawing.Size(75, 30);
            this.lblLargo.TabIndex = 20;
            this.lblLargo.Text = "Largo";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(110, 215);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(69, 30);
            this.lblColor.TabIndex = 21;
            this.lblColor.Text = "Color";
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Location = new System.Drawing.Point(110, 248);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(80, 30);
            this.lblPrecioCompra.TabIndex = 22;
            this.lblPrecioCompra.Text = "Precio";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(110, 285);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(110, 30);
            this.lblCantidad.TabIndex = 23;
            this.lblCantidad.Text = "Cantidad";
            // 
            // cboColor
            // 
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(182, 215);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(135, 28);
            this.cboColor.TabIndex = 24;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(182, 123);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(91, 26);
            this.txtCodigo.TabIndex = 25;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(182, 249);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 26);
            this.txtPrecio.TabIndex = 27;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(182, 285);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 26);
            this.txtCantidad.TabIndex = 28;
            // 
            // cboLargo
            // 
            this.cboLargo.FormattingEnabled = true;
            this.cboLargo.Location = new System.Drawing.Point(182, 170);
            this.cboLargo.Name = "cboLargo";
            this.cboLargo.Size = new System.Drawing.Size(135, 28);
            this.cboLargo.TabIndex = 29;
            // 
            // FrmAltaCollar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboLargo);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.cboColor);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblPrecioCompra);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblLargo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "FrmAltaCollar";
            this.Text = "Alta Collar";
            this.Load += new System.EventHandler(this.FrmAltaCollar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.Label lblLargo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cboLargo;
    }
}