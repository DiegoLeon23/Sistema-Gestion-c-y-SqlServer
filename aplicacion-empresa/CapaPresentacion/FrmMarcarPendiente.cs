using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmMarcarPendiente : Form
    {
        Pedidos _owner;

        public FrmMarcarPendiente()
        {
            InitializeComponent();
        }

        public FrmMarcarPendiente(Pedidos owner)
        {
            this._owner = owner;
            InitializeComponent();

            this.labelNombre.Text = String.Format("¿Marcar el Pedido {0} entregado el {1} como Pendiente?",
                this._owner.ObtenerSeleccionPedidos().Cells[2].Value.ToString(),
                Convert.ToDateTime(this._owner.ObtenerSeleccionPedidos().Cells[7].Value).ToString("dd/MM/yyyy"));
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            String mensaje = "";

            mensaje = NPedidos.MarcarEntregadoPendiente(
                Convert.ToInt32(this._owner.ObtenerSeleccionPedidos().Cells[1].Value),
                null);

            if (mensaje == "Y")
            {
                this._owner.Mensaje(String.Format("El Pedido {0} para {1} ha sido marcado como PENDIENTE",
                    this._owner.ObtenerSeleccionPedidos().Cells[2].Value.ToString(), 
                    this._owner.ObtenerSeleccionPedidos().Cells[3].Value.ToString()));
                this._owner.Refrescar();
                this.Close();
            }

            else
            {
                this._owner.MensajeError(mensaje);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
