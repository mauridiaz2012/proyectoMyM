namespace MyMProyecto
{
    partial class FrmCollares
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
            this.dgvCollares = new System.Windows.Forms.DataGridView();
            this.txtTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollares)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCollares
            // 
            this.dgvCollares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCollares.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCollares.Location = new System.Drawing.Point(86, 112);
            this.dgvCollares.MultiSelect = false;
            this.dgvCollares.Name = "dgvCollares";
            this.dgvCollares.RowHeadersWidth = 62;
            this.dgvCollares.RowTemplate.Height = 28;
            this.dgvCollares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCollares.Size = new System.Drawing.Size(873, 296);
            this.dgvCollares.TabIndex = 0;
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.Chocolate;
            this.txtTitulo.Location = new System.Drawing.Point(380, 28);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(217, 58);
            this.txtTitulo.TabIndex = 20;
            this.txtTitulo.Text = "Collares";
            this.txtTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmCollares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 509);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.dgvCollares);
            this.Name = "FrmCollares";
            this.Text = "Collares";
            this.Load += new System.EventHandler(this.FrmCollares_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCollares;
        private System.Windows.Forms.Label txtTitulo;
    }
}