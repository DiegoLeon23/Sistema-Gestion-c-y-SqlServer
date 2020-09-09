﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using System.IO;

namespace CapaPresentacion
{
    public partial class FrmInicio : Form
    {
        Empleados empleados;
        Transporte transporte;
        Clientes clientes;
        Categorias categorias;
        Productos productos;
        Pedidos pedidos;

        public FrmInicio()
        {
            String mensaje = NConexion.ChequearConexion();
            if (mensaje == "Y")
            {
                InitializeComponent();
                Iniciar();
            }
            else
            {
                MessageBox.Show("El Sistema de Gestión no se puede iniciar ya que existió un error al conectarse con la Base de Datos. " + mensaje,
                  "Error al iniciar el Sistema de Gestión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
        }

        public void Iniciar()
        {
            pedidos = new Pedidos();
            this.panelContenedor.Controls.Clear();
            this.panelContenedor.Controls.Add(pedidos);
        }

        private void buttonEmpleados_Click(object sender, EventArgs e)
        {
            if (empleados == null)
            {
                empleados = new Empleados();
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(empleados);
            }
            else
            {
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(empleados);
            }
        }

        private void buttonTransporte_Click(object sender, EventArgs e)
        {
            if (transporte == null)
            {
                transporte = new Transporte();
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(transporte);
            }
            else
            {
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(transporte);
            }
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            if (clientes == null)
            {
                clientes = new Clientes();
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(clientes);
            }
            else
            {
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(clientes);
            }
        }

        private void buttonCategorias_Click(object sender, EventArgs e)
        {
            if (categorias == null)
            {
                categorias = new Categorias();
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(categorias);
            }
            else
            {
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(categorias);
            }
        }

        private void buttonProductos_Click(object sender, EventArgs e)
        {
            if (productos == null)
            {
                productos = new Productos();
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(productos);
            }
            else
            {
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(productos);
            }
        }

        private void buttonPedidos_Click(object sender, EventArgs e)
        {
            if (pedidos == null)
            {
                pedidos = new Pedidos();
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(pedidos);
            }
            else
            {
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(pedidos);
            }
        }

        private void buttonReportes_Click(object sender, EventArgs e)
        {
            try
            {
                FrmReportes administracionReportes = new FrmReportes();
                administracionReportes.ShowDialog();
            }

            catch (Exception ex)
            {
                MensajeError(ex.Message);
            }
        }

        public void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BlogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://hernanmartin.me/");
        }

        private void TwitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://twitter.com/HMartin91/");
        }

        private void YouTubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://youtube.com/user/hernanmartindemczuk/");
        }

        private void generarCopiaDeSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirmacion = MessageBox.Show("¿Seguro deseas generar una Copia de Seguridad?", "Generar Copia de Seguridad",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (confirmacion == DialogResult.OK)
                {
                    String mensaje = NRestauracion.GenerarBackUp();
                    if (mensaje == "Y")
                    {
                        MessageBox.Show("Se ha generado una nueva Copia de Seguridad.\nLa Base de Datos puede ser restaurada al estado actual en el futuro.",
                            "Generar Copia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Generar Copia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Generar Copia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void restaurarCopiasDeSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = openFileDialogRestaurarCopiaSeguridad.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                DialogResult confirmacion = MessageBox.Show("¿Seguro deseas restaurar la Base de Datos con esta Copia de Seguridad? \n\nIMPORTANTE: Se recomienda realizar una Copia de Seguridad antes de proceder con la Restauración.",
                    "Restaurar Copia de Seguridad", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (confirmacion == DialogResult.OK)
                {
                    String nombreArchivo = openFileDialogRestaurarCopiaSeguridad.FileName;
                    try
                    {
                        String mensaje = NRestauracion.RestaurarBackUp(nombreArchivo);
                        if (mensaje == "Y")
                        {
                            MessageBox.Show("La Base de Datos se ha restaurado satisfactoriamente", "Restaurar Copia de Seguridad",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (pedidos != null)
                            {
                                this.pedidos.Refrescar();
                            }
                            if (productos != null)
                            {
                                this.productos.Refrescar();
                            }
                            if (categorias != null)
                            {
                                this.categorias.Refrescar();
                            }
                            if (clientes != null)
                            {
                                this.clientes.Refrescar();
                            }
                            if (empleados != null)
                            {
                                this.empleados.Refrescar();
                            }
                            if (transporte != null)
                            {
                                this.transporte.Refrescar();
                            }
                        }
                        else
                        {
                            MessageBox.Show(mensaje, "Restaurar Copia de Seguridad",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message, "Restaurar Copia de Seguridad",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Restaurar Copia de Seguridad",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
