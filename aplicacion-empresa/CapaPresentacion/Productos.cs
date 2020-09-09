using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class Productos : UserControl
    {
        int numeroPagina = 1;
        int registrosPorPagina = 25;
        int cantidadPaginas;

        public Productos()
        {
            InitializeComponent();
            Mostrar();
        }   

        public void Mostrar()
        {
            try
            {
                this.Dock = DockStyle.Fill;
                this.dataGridViewProductos.DataSource = NProductos.Mostrar(numeroPagina, registrosPorPagina);
                this.dataGridViewProductos.Columns[0].Visible = false;
                this.dataGridViewProductos.Columns[4].DefaultCellStyle.Format = "0.00## $";
                this.dataGridViewProductos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                cantidadPaginas = NProductos.Tamaño(registrosPorPagina);
                this.labelPagina.Text = String.Format("Página {0} de {1}", numeroPagina, cantidadPaginas);
            }
            catch (Exception ex)
            {
                MensajeError(ex.Message);
            }
        }

        public void Buscar()
        {
            try
            {
                this.dataGridViewProductos.DataSource = NProductos.Buscar(this.textBoxBuscarNombre.Text);
            }
            catch (Exception ex)
            {
                MensajeError(ex.Message);
            }
        }

        public void Refrescar()
        {
            this.numeroPagina = 1;
            this.Mostrar();
            this.textBoxBuscarNombre.Text = String.Empty;
        }

        public void Mensaje(String mensaje)
        {
            this.labelMensajes.Text = mensaje;
        }

        public void LimpiarMensaje()
        {
            this.labelMensajes.Text = String.Empty;
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DataGridViewRow ObtenerSeleccion()
        {
            DataGridViewRow filaSeleccionada = this.dataGridViewProductos.Rows[this.dataGridViewProductos.CurrentRow.Index];
            return filaSeleccionada;
        }

        private void textBoxBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxBuscarNombre.Text == String.Empty)
            {
                this.numeroPagina = 1;
                this.Mostrar();
                this.tableLayoutPanelPaginacion.Show();
            }
            else
            {
                this.Buscar();
                this.tableLayoutPanelPaginacion.Hide();
            }
        }

        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            this.Refrescar();
            this.LimpiarMensaje();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridViewProductos.Rows.Count > 0)
                {
                    FrmEditarProducto editarProducto = new FrmEditarProducto(this);
                    editarProducto.ShowDialog();
                }
                else
                {
                    MensajeError("Debes seleccionar una fila para editar");
                }
            }
            catch (Exception ex)
            {
                MensajeError(ex.Message);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridViewProductos.Rows.Count > 0)
                {
                    DialogResult confirmacion = MessageBox.Show("¿Seguro deseas eliminar este producto?", "Eliminar Producto",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (confirmacion == DialogResult.OK)
                    {
                        String mensaje = NProductos.Eliminar(Convert.ToInt32(ObtenerSeleccion().Cells["ID"].Value));
                        if (mensaje == "Y")
                        {
                            Mensaje(String.Format("El Producto {0} ha sido ELIMINADO", 
                                Convert.ToString(ObtenerSeleccion().Cells["NOMBRE"].Value)));
                            Refrescar();
                        }
                        else
                        {
                            MensajeError(mensaje);
                            Refrescar();
                        }
                    }
                }
                else
                {
                    MensajeError("Debes seleccionar una fila para eliminar");
                }
                
            }
            catch (Exception ex)
            {
                MensajeError(ex.Message);
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarNuevoProducto nuevoProducto = new FrmAgregarNuevoProducto(this);
            nuevoProducto.ShowDialog();
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            if (numeroPagina > 1)
            {
                numeroPagina = numeroPagina - 1;
                Mostrar();
            }
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            if (numeroPagina < cantidadPaginas)
            {
                numeroPagina = numeroPagina + 1;
                Mostrar();
            }
        }

    }
}
