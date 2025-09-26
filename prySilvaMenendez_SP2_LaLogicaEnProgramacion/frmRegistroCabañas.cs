using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySilvaMenendez_SP2_LaLogicaEnProgramacion
{
    public partial class frmRegistroCabañas : Form
    {
        float precioTipoA = 20;
        float precioTipoB = 34;
        float porPersona = 1;
        float cocina = 1;
        float heladera = 1.5f;
        float televisor = 2;

        public frmRegistroCabañas()
        {
            InitializeComponent();
        }

        private void frmRegistroCabañas_Load_1(object sender, EventArgs e)
        {
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Tipo A");
            cmbTipo.Items.Add("Tipo B");
            cmbTipo.SelectedIndex = 0;

            UpdatePersonas();

            cmbTarjetas.Items.Clear();
            cmbTarjetas.Items.Add("Card Red");
            cmbTarjetas.Items.Add("Card Green");
            cmbTarjetas.Items.Add("Card Blue");

            txtDias.Text = "1";
            chkCocina.Checked = false;
            chkHeladera.Checked = false;
            chkTelevisor.Checked = false;
            btnEfectivo.Checked = true;
            cmbTarjetas.Enabled = false;
            cmbTarjetas.SelectedIndex = -1;
            txtNombre.Text = "";
            txtNumero.Text = "";
            btnAceptar.Enabled = false;
        }

        private void UpdatePersonas()
        {
            cmbPersonas.Items.Clear();
            if (cmbTipo.SelectedIndex == 0)
            {
                cmbPersonas.Items.AddRange(new object[] { 1, 2, 3, 4 });
            }
            else
            {
                cmbPersonas.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6, 7, 8 });
            }
            cmbPersonas.SelectedIndex = 0;
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePersonas();
            cmbPersonas.SelectedIndex = -1;
        }

        private void btnEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (btnEfectivo.Checked)
            {
                cmbTarjetas.Enabled = false;
                cmbTarjetas.SelectedIndex = -1;
            }
        }

        private void btnTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (btnTarjeta.Checked)
            {
                cmbTarjetas.Enabled = true;
                cmbPersonas.SelectedIndex = 0;
            }
        }

        private void txtDias_TextChanged(object sender, EventArgs e) => CheckAceptar();
        private void txtNombre_TextChanged(object sender, EventArgs e) => CheckAceptar();
        private void txtTelefono_TextChanged(object sender, EventArgs e) => CheckAceptar();

        private void CheckAceptar()
        {
            int dias;
            bool diasValid = int.TryParse(txtDias.Text, out dias) && dias > 0;
            bool nombreOk = !string.IsNullOrWhiteSpace(txtNombre.Text);
            bool telOk = !string.IsNullOrWhiteSpace(txtNumero.Text);

            btnAceptar.Enabled = diasValid && nombreOk && telOk;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int dias = int.Parse(txtDias.Text);

            
            float precioBase = (cmbTipo.SelectedIndex == 0) ? precioTipoA : precioTipoB;

           
            int personas = Convert.ToInt32(cmbPersonas.SelectedItem);
            precioBase += porPersona * personas;

            float opcionales = 0;
            if (chkCocina.Checked) opcionales += cocina;
            if (chkHeladera.Checked) opcionales += heladera;
            if (chkTelevisor.Checked) opcionales += televisor;

            
            float total = (precioBase + opcionales) * dias;

           
            if (btnTarjeta.Checked)
            {
                if (cmbTarjetas.SelectedIndex == 0) 
                    total += total * 0.10f;
                else 
                    total += total * 0.20f;
            }

            MessageBox.Show($"Total = US$ {total:0.00}", "Importe de la reserva",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}


