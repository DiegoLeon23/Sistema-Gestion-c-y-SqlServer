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
    public partial class Empleados : UserControl
    {
        int numeroPagina = 1;
        int registrosPorPagina = 25;
        int cantidadPaginas;

        public Empleados()
        {
            InitializeComponent();
            Mostrar();
        }

        public void Mostrar()
        {
            try
            {
                this.Dock = DockStyle.Fill;
                this.dataGridViewEmpleados.DataSource = NEmpleados.Mostrar(numeroPagina, registrosPorPagina);
                this.dataGridViewEmpleados.Columns[0].Visible = false;
                cantidadPaginas = NEmpleados.Tamaño(registrosPorPagina);
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
                this.dataGridViewEmpleados.DataSource = NEmpleados.Buscar(this.textBoxBuscarApellido.Text);
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
            this.textBoxBuscarApellido.Text = String.Empty;
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
            DataGridViewRow filaSeleccionada = this.dataGridViewEmpleados.Rows[this.dataGridViewEmpleados.CurrentRow.Index];
            return filaSeleccionada;
        }
        
        private void textBoxBuscarApellido_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxBuscarApellido.Text == String.Empty)
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
                if (this.dataGridViewEmpleados.Rows.Count > 0)
                {
                    FrmEditarEmpleado editarEmpleado = new FrmEditarEmpleado(this);
                    editarEmpleado.ShowDialog();
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
                if (this.dataGridViewEmpleados.Rows.Count > 0)
                {
                    DialogResult confirmacion = MessageBox.Show("¿Seguro deseas eliminar este empleado?", "Eliminar Empleado",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (confirmacion == DialogResult.OK)
                    {
                        String mensaje = NEmpleados.Eliminar(Convert.ToInt32(ObtenerSeleccion().Cells["ID"].Value));
                        if (mensaje == "Y")
                        {
                            Mensaje(String.Format("El Empleado {0}, {1} ha sido ELIMINADO", 
                                Convert.ToString(ObtenerSeleccion().Cells["APELLIDO"].Value), 
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
            FrmAgregarNuevoEmpleado nuevoEmpleado = new FrmAgregarNuevoEmpleado(this);
            nuevoEmpleado.ShowDialog();
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
