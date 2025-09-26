namespace prySilvaMenendez_SP2_LaLogicaEnProgramacion
{
    partial class frmRegistroCabañas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mrcTipo = new System.Windows.Forms.GroupBox();
            this.mrcAdicionales = new System.Windows.Forms.GroupBox();
            this.mrcFormadePago = new System.Windows.Forms.GroupBox();
            this.mrcTitular = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbPersonas = new System.Windows.Forms.ComboBox();
            this.cmbDias = new System.Windows.Forms.ComboBox();
            this.mrcTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcTipo
            // 
            this.mrcTipo.Controls.Add(this.cmbDias);
            this.mrcTipo.Controls.Add(this.cmbPersonas);
            this.mrcTipo.Controls.Add(this.cmbTipo);
            this.mrcTipo.Location = new System.Drawing.Point(12, 12);
            this.mrcTipo.Name = "mrcTipo";
            this.mrcTipo.Size = new System.Drawing.Size(411, 119);
            this.mrcTipo.TabIndex = 0;
            this.mrcTipo.TabStop = false;
            this.mrcTipo.Text = "Tipo de Cabaña";
            // 
            // mrcAdicionales
            // 
            this.mrcAdicionales.Location = new System.Drawing.Point(12, 137);
            this.mrcAdicionales.Name = "mrcAdicionales";
            this.mrcAdicionales.Size = new System.Drawing.Size(119, 100);
            this.mrcAdicionales.TabIndex = 1;
            this.mrcAdicionales.TabStop = false;
            this.mrcAdicionales.Text = "Adicionales";
            // 
            // mrcFormadePago
            // 
            this.mrcFormadePago.Location = new System.Drawing.Point(137, 137);
            this.mrcFormadePago.Name = "mrcFormadePago";
            this.mrcFormadePago.Size = new System.Drawing.Size(286, 100);
            this.mrcFormadePago.TabIndex = 2;
            this.mrcFormadePago.TabStop = false;
            this.mrcFormadePago.Text = "Forma de Pago";
            // 
            // mrcTitular
            // 
            this.mrcTitular.Location = new System.Drawing.Point(12, 243);
            this.mrcTitular.Name = "mrcTitular";
            this.mrcTitular.Size = new System.Drawing.Size(411, 100);
            this.mrcTitular.TabIndex = 3;
            this.mrcTitular.TabStop = false;
            this.mrcTitular.Text = "Titular de la Reserva";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(310, 373);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(113, 34);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "&ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(98, 54);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(68, 21);
            this.cmbTipo.TabIndex = 0;
            // 
            // cmbPersonas
            // 
            this.cmbPersonas.FormattingEnabled = true;
            this.cmbPersonas.Location = new System.Drawing.Point(191, 54);
            this.cmbPersonas.Name = "cmbPersonas";
            this.cmbPersonas.Size = new System.Drawing.Size(54, 21);
            this.cmbPersonas.TabIndex = 1;
            // 
            // cmbDias
            // 
            this.cmbDias.FormattingEnabled = true;
            this.cmbDias.Location = new System.Drawing.Point(298, 54);
            this.cmbDias.Name = "cmbDias";
            this.cmbDias.Size = new System.Drawing.Size(59, 21);
            this.cmbDias.TabIndex = 2;
            // 
            // frmRegistroCabañas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 428);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.mrcTitular);
            this.Controls.Add(this.mrcFormadePago);
            this.Controls.Add(this.mrcAdicionales);
            this.Controls.Add(this.mrcTipo);
            this.Name = "frmRegistroCabañas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Reserva de Cabañas";
            this.mrcTipo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcTipo;
        private System.Windows.Forms.GroupBox mrcAdicionales;
        private System.Windows.Forms.GroupBox mrcFormadePago;
        private System.Windows.Forms.GroupBox mrcTitular;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmbDias;
        private System.Windows.Forms.ComboBox cmbPersonas;
        private System.Windows.Forms.ComboBox cmbTipo;
    }
}

