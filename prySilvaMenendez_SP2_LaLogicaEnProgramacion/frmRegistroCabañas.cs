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
        private float precioTipoA = 20;
        private float precioTipoB = 34;
        private float porPersona = 1;
        private float cocina = 1;
        private float heladera = 1.5f;
        private float televisor = 2;

        struct Reserva
        {
            string Tipo;
            int Cantidad;
            int Dias;
        }

        Reserva [] vecReserva = new Reserva [10];
        string [,] matReserva = new string [3,3];

        int IndiceFila = 0;

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
                cmbPersonas.SelectedIndex = -1;

                cmbTarjetas.Items.Clear();
                cmbTarjetas.Items.Add("Card Red");
                cmbTarjetas.Items.Add("Card Green");
                cmbTarjetas.Items.Add("Card Blue");
                cmbTarjetas.SelectedIndex = -1;
                cmbTarjetas.Enabled = false;

                btnEfectivo.Checked = false;
                btnTarjeta.Checked = false;

                txtDias.Clear();
                chkCocina.Checked = false;
                chkHeladera.Checked = false;
                chkTelevisor.Checked = false;
                txtNombre.Clear();
                txtNumero.Clear();
            }

        private void UpdatePersonas()
        {
            cmbPersonas.Items.Clear();

            if (cmbTipo.SelectedIndex == 0)
            {
                for (int i = 1; i <= 4; i++)
                    cmbPersonas.Items.Add(i);
            }
            else if (cmbTipo.SelectedIndex == 1)
            {
                for (int i = 1; i <= 8; i++)
                    cmbPersonas.Items.Add(i);
            }
            cmbPersonas.SelectedIndex = -1;
        }
        private void cmbTipo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            UpdatePersonas();
        }
            private void btnEfectivo_CheckedChanged_1(object sender, EventArgs e)
            {
                if (btnEfectivo.Checked)
                {
                    cmbTarjetas.Enabled = false;
                    cmbTarjetas.SelectedIndex = -1;
                }
            }

        private void btnTarjeta_CheckedChanged_1(object sender, EventArgs e)
        {
            if (btnTarjeta.Checked)
            {
                cmbTarjetas.Enabled = true;
                if (cmbTarjetas.Items.Count > 0)
                    cmbTarjetas.SelectedIndex = 0;
            }
        }

        private void txtDias_TextChanged(object sender, EventArgs e) => CheckAceptar();
        private void txtNombre_TextChanged(object sender, EventArgs e) => CheckAceptar();
        private void txtNumero_TextChanged(object sender, EventArgs e) => CheckAceptar();

        private void CheckAceptar()
        {
            int dias;
            bool diasValid = int.TryParse(txtDias.Text, out dias) && dias > 0;
            bool nombreOk = !string.IsNullOrWhiteSpace(txtNombre.Text);
            bool telOk = !string.IsNullOrWhiteSpace(txtNumero.Text);
            bool personasOk = cmbPersonas.SelectedIndex >= 0;
        }
        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            matReserva[IndiceFila, 0] = cmbTipo.Text;
            matReserva[IndiceFila, 1] = cmbPersonas.Text;
            matReserva[IndiceFila, 2] = txtDias.Text;
            IndiceFila++;

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

                LimpiarUI();
        }
        void LimpiarUI()
        {
            cmbTipo.SelectedIndex = 0;
            txtDias.Text = "0";
            chkCocina.Checked = false;
            chkHeladera.Checked = false;
            chkTelevisor.Checked = false;

            btnEfectivo.Checked = true;
            txtNombre.Text = "";
            txtNumero.Text = "";

        }

        private void cmbPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAceptar();
        }

        private void txtNumero_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}



