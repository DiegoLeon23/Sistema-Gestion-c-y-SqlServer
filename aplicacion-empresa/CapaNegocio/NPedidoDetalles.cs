using System;
using System.Collections.Generic;
using System.Data;
using CapaDatos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NPedidoDetalles
    {
        public static DataTable MostrarPedidoDetalles(int parIdPedido)
        {
            return new DPedidoDetalles().MostrarPedidoDetalles(parIdPedido);
        }

        public static String Insertar(String parNombre_Producto, int parCantidad,
            decimal parPrecio_Unitario, decimal parDescuento)
        {
            DPedidoDetalles pedidoDetalles = new DPedidoDetalles();
            pedidoDetalles.Nombre_Producto = parNombre_Producto;
            pedidoDetalles.Cantidad = parCantidad;
            pedidoDetalles.Precio_Unitario = parPrecio_Unitario;
            pedidoDetalles.Descuento = parDescuento;

            return pedidoDetalles.Insertar(pedidoDetalles);
        }

        public static String Editar(int parIdPedido, String parNombre_Producto, int parCantidad,
            decimal parPrecio_Unitario, decimal parDescuento)
        {
            DPedidoDetalles pedidoDetalles = new DPedidoDetalles();
            pedidoDetalles.Id_Pedido = parIdPedido;
            pedidoDetalles.Nombre_Producto = parNombre_Producto;
            pedidoDetalles.Cantidad = parCantidad;
            pedidoDetalles.Precio_Unitario = parPrecio_Unitario;
            pedidoDetalles.Descuento = parDescuento;

            return pedidoDetalles.Editar(pedidoDetalles);
        }

    }
}
