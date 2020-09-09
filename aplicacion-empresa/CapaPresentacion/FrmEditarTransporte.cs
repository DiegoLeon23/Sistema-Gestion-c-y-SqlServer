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
    public partial class FrmEditarTransporte : Form
    {
        Transporte _owner;
        int Id_Transportista;

        public FrmEditarTransporte()
        {
            InitializeComponent();
        }

        public FrmEditarTransporte(Transporte owner)
        {
            _owner = owner;
            InitializeComponent();

            this.Id_Transportista = Convert.ToInt32(_owner.ObtenerSeleccion().Cells["ID"].Value);
            this.textBoxNombre.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["NOMBRE"].Value);
            this.textBoxDireccion.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["DIRECCIÓN"].Value);
            this.textBoxCiudad.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["CIUDAD"].Value);
            this.textBoxRegion.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["REGIÓN"].Value);
            this.textBoxPais.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["PAÍS"].Value);
            this.textBoxTelefono.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["TELÉFONO"].Value);
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
        {//No importa el try ya que no hay conversiones
            String mensaje = NTransportistas.Editar(this.Id_Transportista, this.textBoxNombre.Text, this.textBoxDireccion.Text,
                this.textBoxCiudad.Text, this.textBoxRegion.Text, this.textBoxPais.Text, this.textBoxTelefono.Text);

            if (mensaje == "Y")
            {
                this._owner.Mensaje(String.Format("El Transporte {0} ha sido EDITADO", this.textBoxNombre.Text));
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
