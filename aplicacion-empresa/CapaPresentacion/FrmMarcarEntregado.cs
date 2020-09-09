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
    public partial class FrmMarcarEntregado : Form
    {
        Pedidos _owner;

        public FrmMarcarEntregado()
        {
            InitializeComponent();
        }

        public FrmMarcarEntregado(Pedidos owner)
        {
            this._owner = owner;
            InitializeComponent();
            this.labelNombre.Text = String.Format("¿Cuándo fue entregado el Pedido {0} ordenado el {1}?",
                this._owner.ObtenerSeleccionPedidos().Cells[2].Value.ToString(),
                Convert.ToDateTime(this._owner.ObtenerSeleccionPedidos().Cells[6].Value).ToString("dd/MM/yyyy"));
            this.textBoxHoy.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void buttonHoy_Click(object sender, EventArgs e)
        {
            String mensaje = "";

            mensaje = NPedidos.MarcarEntregadoPendiente(
                Convert.ToInt32(this._owner.ObtenerSeleccionPedidos().Cells[1].Value),
                DateTime.Now.ToString("dd/MM/yyyy"));

            if (mensaje == "Y")
            {
                this._owner.Mensaje(String.Format("El Pedido {0} para {1} ha sido marcado como ENTREGADO",
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

        private void buttonFecha_Click(object sender, EventArgs e)
        {
            String mensaje = "";

            mensaje = NPedidos.MarcarEntregadoPendiente(
                Convert.ToInt32(this._owner.ObtenerSeleccionPedidos().Cells[1].Value),
                this.dateTimePickerMarcarFecha.Value.ToString("dd/MM/yyyy"));

            if (mensaje == "Y")
            {
                this._owner.Mensaje(String.Format("El Pedido {0} para {1} ha sido marcado como ENTREGADO",
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
    }
}
