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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroCabañas));
            this.mrcTipo = new System.Windows.Forms.GroupBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbPersonas = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.mrcAdicionales = new System.Windows.Forms.GroupBox();
            this.chkTelevisor = new System.Windows.Forms.CheckBox();
            this.chkHeladera = new System.Windows.Forms.CheckBox();
            this.chkCocina = new System.Windows.Forms.CheckBox();
            this.mrcFormadePago = new System.Windows.Forms.GroupBox();
            this.lblTarjetas = new System.Windows.Forms.Label();
            this.cmbTarjetas = new System.Windows.Forms.ComboBox();
            this.btnTarjeta = new System.Windows.Forms.RadioButton();
            this.btnEfectivo = new System.Windows.Forms.RadioButton();
            this.mrcTitular = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.ColumnTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.mrcTipo.SuspendLayout();
            this.mrcAdicionales.SuspendLayout();
            this.mrcFormadePago.SuspendLayout();
            this.mrcTitular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcTipo
            // 
            this.mrcTipo.Controls.Add(this.txtDias);
            this.mrcTipo.Controls.Add(this.lblDias);
            this.mrcTipo.Controls.Add(this.lblPersonas);
            this.mrcTipo.Controls.Add(this.lblTipo);
            this.mrcTipo.Controls.Add(this.cmbPersonas);
            this.mrcTipo.Controls.Add(this.cmbTipo);
            this.mrcTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcTipo.Location = new System.Drawing.Point(18, 18);
            this.mrcTipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mrcTipo.Name = "mrcTipo";
            this.mrcTipo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mrcTipo.Size = new System.Drawing.Size(728, 183);
            this.mrcTipo.TabIndex = 0;
            this.mrcTipo.TabStop = false;
            this.mrcTipo.Text = "Tipo de Cabaña";
            // 
            // txtDias
            // 
            this.txtDias.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtDias.Location = new System.Drawing.Point(590, 89);
            this.txtDias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(122, 30);
            this.txtDias.TabIndex = 6;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(531, 91);
            this.lblDias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(51, 25);
            this.lblDias.TabIndex = 5;
            this.lblDias.Text = "Dias";
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Location = new System.Drawing.Point(255, 89);
            this.lblPersonas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(95, 25);
            this.lblPersonas.TabIndex = 4;
            this.lblPersonas.Text = "Personas";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(9, 91);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(51, 25);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo";
            // 
            // cmbPersonas
            // 
            this.cmbPersonas.BackColor = System.Drawing.Color.NavajoWhite;
            this.cmbPersonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonas.FormattingEnabled = true;
            this.cmbPersonas.Location = new System.Drawing.Point(367, 86);
            this.cmbPersonas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPersonas.Name = "cmbPersonas";
            this.cmbPersonas.Size = new System.Drawing.Size(134, 33);
            this.cmbPersonas.TabIndex = 1;
            this.cmbPersonas.SelectedIndexChanged += new System.EventHandler(this.cmbPersonas_SelectedIndexChanged);
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.Color.NavajoWhite;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(72, 86);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(154, 33);
            this.cmbTipo.TabIndex = 0;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged_1);
            // 
            // mrcAdicionales
            // 
            this.mrcAdicionales.Controls.Add(this.chkTelevisor);
            this.mrcAdicionales.Controls.Add(this.chkHeladera);
            this.mrcAdicionales.Controls.Add(this.chkCocina);
            this.mrcAdicionales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcAdicionales.Location = new System.Drawing.Point(18, 211);
            this.mrcAdicionales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mrcAdicionales.Name = "mrcAdicionales";
            this.mrcAdicionales.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mrcAdicionales.Size = new System.Drawing.Size(152, 191);
            this.mrcAdicionales.TabIndex = 1;
            this.mrcAdicionales.TabStop = false;
            this.mrcAdicionales.Text = "Adicionales";
            // 
            // chkTelevisor
            // 
            this.chkTelevisor.AutoSize = true;
            this.chkTelevisor.Location = new System.Drawing.Point(9, 128);
            this.chkTelevisor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkTelevisor.Name = "chkTelevisor";
            this.chkTelevisor.Size = new System.Drawing.Size(118, 29);
            this.chkTelevisor.TabIndex = 2;
            this.chkTelevisor.Text = "&Televisor";
            this.chkTelevisor.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            this.chkHeladera.AutoSize = true;
            this.chkHeladera.Location = new System.Drawing.Point(9, 74);
            this.chkHeladera.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkHeladera.Name = "chkHeladera";
            this.chkHeladera.Size = new System.Drawing.Size(117, 29);
            this.chkHeladera.TabIndex = 1;
            this.chkHeladera.Text = "&Heladera";
            this.chkHeladera.UseVisualStyleBackColor = true;
            // 
            // chkCocina
            // 
            this.chkCocina.AutoSize = true;
            this.chkCocina.Location = new System.Drawing.Point(9, 29);
            this.chkCocina.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkCocina.Name = "chkCocina";
            this.chkCocina.Size = new System.Drawing.Size(100, 29);
            this.chkCocina.TabIndex = 0;
            this.chkCocina.Text = "&Cocina";
            this.chkCocina.UseVisualStyleBackColor = true;
            // 
            // mrcFormadePago
            // 
            this.mrcFormadePago.Controls.Add(this.lblTarjetas);
            this.mrcFormadePago.Controls.Add(this.cmbTarjetas);
            this.mrcFormadePago.Controls.Add(this.btnTarjeta);
            this.mrcFormadePago.Controls.Add(this.btnEfectivo);
            this.mrcFormadePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcFormadePago.Location = new System.Drawing.Point(178, 211);
            this.mrcFormadePago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mrcFormadePago.Name = "mrcFormadePago";
            this.mrcFormadePago.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mrcFormadePago.Size = new System.Drawing.Size(567, 191);
            this.mrcFormadePago.TabIndex = 2;
            this.mrcFormadePago.TabStop = false;
            this.mrcFormadePago.Text = "Forma de Pago";
            // 
            // lblTarjetas
            // 
            this.lblTarjetas.AutoSize = true;
            this.lblTarjetas.Location = new System.Drawing.Point(278, 74);
            this.lblTarjetas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarjetas.Name = "lblTarjetas";
            this.lblTarjetas.Size = new System.Drawing.Size(83, 25);
            this.lblTarjetas.TabIndex = 3;
            this.lblTarjetas.Text = "Tarjetas";
            // 
            // cmbTarjetas
            // 
            this.cmbTarjetas.BackColor = System.Drawing.Color.NavajoWhite;
            this.cmbTarjetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarjetas.FormattingEnabled = true;
            this.cmbTarjetas.Location = new System.Drawing.Point(282, 105);
            this.cmbTarjetas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTarjetas.Name = "cmbTarjetas";
            this.cmbTarjetas.Size = new System.Drawing.Size(180, 33);
            this.cmbTarjetas.TabIndex = 2;
            // 
            // btnTarjeta
            // 
            this.btnTarjeta.AutoSize = true;
            this.btnTarjeta.Location = new System.Drawing.Point(44, 109);
            this.btnTarjeta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTarjeta.Name = "btnTarjeta";
            this.btnTarjeta.Size = new System.Drawing.Size(98, 29);
            this.btnTarjeta.TabIndex = 1;
            this.btnTarjeta.TabStop = true;
            this.btnTarjeta.Text = "&Tarjeta";
            this.btnTarjeta.UseVisualStyleBackColor = true;
            this.btnTarjeta.CheckedChanged += new System.EventHandler(this.btnTarjeta_CheckedChanged_1);
            // 
            // btnEfectivo
            // 
            this.btnEfectivo.AutoSize = true;
            this.btnEfectivo.Location = new System.Drawing.Point(44, 51);
            this.btnEfectivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEfectivo.Name = "btnEfectivo";
            this.btnEfectivo.Size = new System.Drawing.Size(106, 29);
            this.btnEfectivo.TabIndex = 0;
            this.btnEfectivo.TabStop = true;
            this.btnEfectivo.Text = "&Efectivo";
            this.btnEfectivo.UseVisualStyleBackColor = true;
            this.btnEfectivo.CheckedChanged += new System.EventHandler(this.btnEfectivo_CheckedChanged_1);
            // 
            // mrcTitular
            // 
            this.mrcTitular.Controls.Add(this.label2);
            this.mrcTitular.Controls.Add(this.label1);
            this.mrcTitular.Controls.Add(this.txtNumero);
            this.mrcTitular.Controls.Add(this.txtNombre);
            this.mrcTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcTitular.Location = new System.Drawing.Point(18, 411);
            this.mrcTitular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mrcTitular.Name = "mrcTitular";
            this.mrcTitular.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mrcTitular.Size = new System.Drawing.Size(728, 154);
            this.mrcTitular.TabIndex = 3;
            this.mrcTitular.TabStop = false;
            this.mrcTitular.Text = "Titular de la Reserva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefonos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtNumero.Location = new System.Drawing.Point(160, 88);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(434, 30);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged_1);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtNombre.Location = new System.Drawing.Point(160, 48);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(434, 30);
            this.txtNombre.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(1126, 592);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(170, 52);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "&ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // dgvDatos
            // 
            this.dgvDatos.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTipo,
            this.ColumnPersonas,
            this.ColumnDias});
            this.dgvDatos.Location = new System.Drawing.Point(782, 18);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.RowHeadersWidth = 62;
            this.dgvDatos.Size = new System.Drawing.Size(514, 546);
            this.dgvDatos.TabIndex = 5;
            // 
            // ColumnTipo
            // 
            this.ColumnTipo.HeaderText = "Tipo";
            this.ColumnTipo.MinimumWidth = 8;
            this.ColumnTipo.Name = "ColumnTipo";
            this.ColumnTipo.Width = 150;
            // 
            // ColumnPersonas
            // 
            this.ColumnPersonas.HeaderText = "Personas";
            this.ColumnPersonas.MinimumWidth = 8;
            this.ColumnPersonas.Name = "ColumnPersonas";
            this.ColumnPersonas.Width = 150;
            // 
            // ColumnDias
            // 
            this.ColumnDias.HeaderText = "Dias";
            this.ColumnDias.MinimumWidth = 8;
            this.ColumnDias.Name = "ColumnDias";
            this.ColumnDias.Width = 150;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(782, 592);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(170, 52);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "&SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmRegistroCabañas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1340, 658);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.mrcTitular);
            this.Controls.Add(this.mrcFormadePago);
            this.Controls.Add(this.mrcAdicionales);
            this.Controls.Add(this.mrcTipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRegistroCabañas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Reserva de Cabañas";
            this.Load += new System.EventHandler(this.frmRegistroCabañas_Load_1);
            this.mrcTipo.ResumeLayout(false);
            this.mrcTipo.PerformLayout();
            this.mrcAdicionales.ResumeLayout(false);
            this.mrcAdicionales.PerformLayout();
            this.mrcFormadePago.ResumeLayout(false);
            this.mrcFormadePago.PerformLayout();
            this.mrcTitular.ResumeLayout(false);
            this.mrcTitular.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcTipo;
        private System.Windows.Forms.GroupBox mrcAdicionales;
        private System.Windows.Forms.GroupBox mrcFormadePago;
        private System.Windows.Forms.GroupBox mrcTitular;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmbPersonas;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.CheckBox chkTelevisor;
        private System.Windows.Forms.CheckBox chkHeladera;
        private System.Windows.Forms.CheckBox chkCocina;
        private System.Windows.Forms.ComboBox cmbTarjetas;
        private System.Windows.Forms.RadioButton btnTarjeta;
        private System.Windows.Forms.RadioButton btnEfectivo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPersonas;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblTarjetas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDias;
        private System.Windows.Forms.Button btnSalir;
    }
}

