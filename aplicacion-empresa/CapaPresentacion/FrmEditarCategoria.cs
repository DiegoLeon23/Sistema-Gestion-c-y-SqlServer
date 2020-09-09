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
    public partial class FrmEditarCategoria : Form
    {
        Categorias _owner;
        int Id_Categoria;

        public FrmEditarCategoria()
        {
            InitializeComponent();
        }

        public FrmEditarCategoria(Categorias owner)
        {
            _owner = owner;
            InitializeComponent();

            this.Id_Categoria = Convert.ToInt32(_owner.ObtenerSeleccion().Cells["ID"].Value);
            this.textBoxNombre.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["NOMBRE"].Value);
            this.textBoxDescripcion.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["DESCRIPCIÓN"].Value);
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
            String mensaje = NCategorias.Editar(this.Id_Categoria, this.textBoxNombre.Text, this.textBoxDescripcion.Text);

            if (mensaje == "Y")
            {
                this._owner.Mensaje(String.Format("La Categoría {0} ha sido EDITADA", this.textBoxNombre.Text));
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
