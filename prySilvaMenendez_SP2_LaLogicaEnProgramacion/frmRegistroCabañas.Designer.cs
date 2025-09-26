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
            this.txtDias = new System.Windows.Forms.TextBox();
            this.mrcTipo.SuspendLayout();
            this.mrcAdicionales.SuspendLayout();
            this.mrcFormadePago.SuspendLayout();
            this.mrcTitular.SuspendLayout();
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
            this.mrcTipo.Location = new System.Drawing.Point(12, 12);
            this.mrcTipo.Name = "mrcTipo";
            this.mrcTipo.Size = new System.Drawing.Size(485, 119);
            this.mrcTipo.TabIndex = 0;
            this.mrcTipo.TabStop = false;
            this.mrcTipo.Text = "Tipo de Cabaña";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(354, 59);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(36, 17);
            this.lblDias.TabIndex = 5;
            this.lblDias.Text = "Dias";
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Location = new System.Drawing.Point(170, 58);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(68, 17);
            this.lblPersonas.TabIndex = 4;
            this.lblPersonas.Text = "Personas";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(6, 59);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(36, 17);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo";
            // 
            // cmbPersonas
            // 
            this.cmbPersonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonas.FormattingEnabled = true;
            this.cmbPersonas.Items.AddRange(new object[] {
            "4",
            "8"});
            this.cmbPersonas.Location = new System.Drawing.Point(244, 51);
            this.cmbPersonas.Name = "cmbPersonas";
            this.cmbPersonas.Size = new System.Drawing.Size(91, 24);
            this.cmbPersonas.TabIndex = 1;
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cmbTipo.Location = new System.Drawing.Point(48, 56);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(104, 24);
            this.cmbTipo.TabIndex = 0;
            // 
            // mrcAdicionales
            // 
            this.mrcAdicionales.Controls.Add(this.chkTelevisor);
            this.mrcAdicionales.Controls.Add(this.chkHeladera);
            this.mrcAdicionales.Controls.Add(this.chkCocina);
            this.mrcAdicionales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcAdicionales.Location = new System.Drawing.Point(12, 137);
            this.mrcAdicionales.Name = "mrcAdicionales";
            this.mrcAdicionales.Size = new System.Drawing.Size(101, 124);
            this.mrcAdicionales.TabIndex = 1;
            this.mrcAdicionales.TabStop = false;
            this.mrcAdicionales.Text = "Adicionales";
            // 
            // chkTelevisor
            // 
            this.chkTelevisor.AutoSize = true;
            this.chkTelevisor.Location = new System.Drawing.Point(6, 83);
            this.chkTelevisor.Name = "chkTelevisor";
            this.chkTelevisor.Size = new System.Drawing.Size(85, 21);
            this.chkTelevisor.TabIndex = 2;
            this.chkTelevisor.Text = "&Televisor";
            this.chkTelevisor.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            this.chkHeladera.AutoSize = true;
            this.chkHeladera.Location = new System.Drawing.Point(6, 48);
            this.chkHeladera.Name = "chkHeladera";
            this.chkHeladera.Size = new System.Drawing.Size(85, 21);
            this.chkHeladera.TabIndex = 1;
            this.chkHeladera.Text = "&Heladera";
            this.chkHeladera.UseVisualStyleBackColor = true;
            // 
            // chkCocina
            // 
            this.chkCocina.AutoSize = true;
            this.chkCocina.Location = new System.Drawing.Point(6, 19);
            this.chkCocina.Name = "chkCocina";
            this.chkCocina.Size = new System.Drawing.Size(70, 21);
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
            this.mrcFormadePago.Location = new System.Drawing.Point(119, 137);
            this.mrcFormadePago.Name = "mrcFormadePago";
            this.mrcFormadePago.Size = new System.Drawing.Size(378, 124);
            this.mrcFormadePago.TabIndex = 2;
            this.mrcFormadePago.TabStop = false;
            this.mrcFormadePago.Text = "Forma de Pago";
            // 
            // lblTarjetas
            // 
            this.lblTarjetas.AutoSize = true;
            this.lblTarjetas.Location = new System.Drawing.Point(185, 48);
            this.lblTarjetas.Name = "lblTarjetas";
            this.lblTarjetas.Size = new System.Drawing.Size(60, 17);
            this.lblTarjetas.TabIndex = 3;
            this.lblTarjetas.Text = "Tarjetas";
            // 
            // cmbTarjetas
            // 
            this.cmbTarjetas.BackColor = System.Drawing.Color.NavajoWhite;
            this.cmbTarjetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarjetas.FormattingEnabled = true;
            this.cmbTarjetas.Location = new System.Drawing.Point(188, 68);
            this.cmbTarjetas.Name = "cmbTarjetas";
            this.cmbTarjetas.Size = new System.Drawing.Size(121, 24);
            this.cmbTarjetas.TabIndex = 2;
            // 
            // btnTarjeta
            // 
            this.btnTarjeta.AutoSize = true;
            this.btnTarjeta.Location = new System.Drawing.Point(29, 71);
            this.btnTarjeta.Name = "btnTarjeta";
            this.btnTarjeta.Size = new System.Drawing.Size(71, 21);
            this.btnTarjeta.TabIndex = 1;
            this.btnTarjeta.TabStop = true;
            this.btnTarjeta.Text = "&Tarjeta";
            this.btnTarjeta.UseVisualStyleBackColor = true;
            // 
            // btnEfectivo
            // 
            this.btnEfectivo.AutoSize = true;
            this.btnEfectivo.Location = new System.Drawing.Point(29, 33);
            this.btnEfectivo.Name = "btnEfectivo";
            this.btnEfectivo.Size = new System.Drawing.Size(76, 21);
            this.btnEfectivo.TabIndex = 0;
            this.btnEfectivo.TabStop = true;
            this.btnEfectivo.Text = "&Efectivo";
            this.btnEfectivo.UseVisualStyleBackColor = true;
            // 
            // mrcTitular
            // 
            this.mrcTitular.Controls.Add(this.label2);
            this.mrcTitular.Controls.Add(this.label1);
            this.mrcTitular.Controls.Add(this.txtNumero);
            this.mrcTitular.Controls.Add(this.txtNombre);
            this.mrcTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcTitular.Location = new System.Drawing.Point(12, 267);
            this.mrcTitular.Name = "mrcTitular";
            this.mrcTitular.Size = new System.Drawing.Size(485, 100);
            this.mrcTitular.TabIndex = 3;
            this.mrcTitular.TabStop = false;
            this.mrcTitular.Text = "Titular de la Reserva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefonos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtNumero.Location = new System.Drawing.Point(107, 57);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(291, 23);
            this.txtNumero.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtNombre.Location = new System.Drawing.Point(107, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(291, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(339, 382);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(113, 34);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "&ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // txtDias
            // 
            this.txtDias.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtDias.Location = new System.Drawing.Point(396, 53);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(83, 23);
            this.txtDias.TabIndex = 6;
            // 
            // frmRegistroCabañas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(509, 428);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.mrcTitular);
            this.Controls.Add(this.mrcFormadePago);
            this.Controls.Add(this.mrcAdicionales);
            this.Controls.Add(this.mrcTipo);
            this.Name = "frmRegistroCabañas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Reserva de Cabañas";
            this.Load += new System.EventHandler(this.frmRegistroCabañas_Load);
            this.mrcTipo.ResumeLayout(false);
            this.mrcTipo.PerformLayout();
            this.mrcAdicionales.ResumeLayout(false);
            this.mrcAdicionales.PerformLayout();
            this.mrcFormadePago.ResumeLayout(false);
            this.mrcFormadePago.PerformLayout();
            this.mrcTitular.ResumeLayout(false);
            this.mrcTitular.PerformLayout();
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
    }
}

