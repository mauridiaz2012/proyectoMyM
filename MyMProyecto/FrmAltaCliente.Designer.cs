namespace MyMProyecto
{
    partial class FrmAltaCliente
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNroTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblRedSocial = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.cboRedSocial = new System.Windows.Forms.ComboBox();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblNroTelefono
            // 
            this.lblNroTelefono.AutoSize = true;
            this.lblNroTelefono.Location = new System.Drawing.Point(28, 81);
            this.lblNroTelefono.Name = "lblNroTelefono";
            this.lblNroTelefono.Size = new System.Drawing.Size(104, 20);
            this.lblNroTelefono.TabIndex = 1;
            this.lblNroTelefono.Text = "Nro. Telefono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(28, 128);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 20);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblRedSocial
            // 
            this.lblRedSocial.AutoSize = true;
            this.lblRedSocial.Location = new System.Drawing.Point(28, 171);
            this.lblRedSocial.Name = "lblRedSocial";
            this.lblRedSocial.Size = new System.Drawing.Size(86, 20);
            this.lblRedSocial.TabIndex = 3;
            this.lblRedSocial.Text = "Red Social";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(28, 213);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(124, 20);
            this.lblNombreUsuario.TabIndex = 4;
            this.lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(158, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(317, 26);
            this.txtNombre.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(158, 75);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(317, 26);
            this.txtTelefono.TabIndex = 6;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(158, 122);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(567, 26);
            this.txtDireccion.TabIndex = 7;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(158, 210);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(317, 26);
            this.txtNombreUsuario.TabIndex = 8;
            // 
            // cboRedSocial
            // 
            this.cboRedSocial.FormattingEnabled = true;
            this.cboRedSocial.Location = new System.Drawing.Point(158, 163);
            this.cboRedSocial.Name = "cboRedSocial";
            this.cboRedSocial.Size = new System.Drawing.Size(308, 28);
            this.cboRedSocial.TabIndex = 9;
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.lblNombre);
            this.gbCliente.Controls.Add(this.lblNombreUsuario);
            this.gbCliente.Controls.Add(this.txtNombreUsuario);
            this.gbCliente.Controls.Add(this.lblRedSocial);
            this.gbCliente.Controls.Add(this.cboRedSocial);
            this.gbCliente.Controls.Add(this.lblDireccion);
            this.gbCliente.Controls.Add(this.txtNombre);
            this.gbCliente.Controls.Add(this.lblNroTelefono);
            this.gbCliente.Controls.Add(this.txtTelefono);
            this.gbCliente.Controls.Add(this.txtDireccion);
            this.gbCliente.Location = new System.Drawing.Point(37, 99);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(755, 288);
            this.gbCliente.TabIndex = 10;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.Chocolate;
            this.txtTitulo.Location = new System.Drawing.Point(232, 25);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(364, 58);
            this.txtTitulo.TabIndex = 11;
            this.txtTitulo.Text = "Alta de Cliente";
            this.txtTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(190, 412);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(152, 34);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(444, 412);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(152, 34);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 480);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.gbCliente);
            this.Name = "FrmAltaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Cliente";
            this.Load += new System.EventHandler(this.FrmAltaCliente_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNroTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblRedSocial;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.ComboBox cboRedSocial;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}