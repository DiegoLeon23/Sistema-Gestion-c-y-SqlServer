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
    public partial class FrmAgregarNuevaCategoria : Form
    {
        Categorias _owner;

        public FrmAgregarNuevaCategoria()
        {
            InitializeComponent();
        }

        public FrmAgregarNuevaCategoria(Categorias owner)
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
            String mensaje = NCategorias.Insertar(this.textBoxNombre.Text, this.textBoxDescripcion.Text);

            if (mensaje == "Y")
            {
                this._owner.Mensaje(String.Format("La Categoría {0} ha sido AGREGADA", this.textBoxNombre.Text));
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
