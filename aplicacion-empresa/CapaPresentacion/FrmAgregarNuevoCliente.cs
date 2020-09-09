using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmAgregarNuevoCliente : Form
    {
        Clientes _owner;

        public FrmAgregarNuevoCliente()
        {
            InitializeComponent();
        }

        public FrmAgregarNuevoCliente(Clientes owner)
        {
            _owner = owner;
            InitializeComponent();
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            String mensaje = NClientes.Insertar(this.textBoxNombreCliente.Text, this.textBoxNombreContacto.Text, this.textBoxDireccion.Text,
                this.textBoxCiudad.Text, this.textBoxRegion.Text, this.textBoxPais.Text, this.textBoxTelefono.Text,
                this.textBoxFax.Text, this.textBoxEmail.Text);

            if (mensaje == "Y")
            {
                this._owner.Mensaje(String.Format("El Cliente {0} ha sido AGREGADO", 
                    this.textBoxNombreCliente.Text));
                this._owner.Refrescar();
                this.Close();
            }
            else
            {
                MensajeError(mensaje);
            }
        }

    }
}
