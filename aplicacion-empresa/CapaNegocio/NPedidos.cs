using System;
using System.Collections.Generic;
using System.Data;
using CapaDatos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NPedidos
    {
        public static DataTable MostrarPedidosPendientes(int parNumeroPagina, int parRegistrosPorPagina)
        {
            return new DPedidos().MostrarPedidosPendientes(parNumeroPagina, parRegistrosPorPagina);
        }

        public static DataTable MostrarPedidosEntregados(int parNumeroPagina, int parRegistrosPorPagina)
        {
            return new DPedidos().MostrarPedidosEntregados(parNumeroPagina, parRegistrosPorPagina);
        }

        public static int TamañoPedidosPendientes(int parRegistrosPorPagina)
        {
            return new DPedidos().TamañoPedidosPendientes(parRegistrosPorPagina);
        }

        public static int TamañoPedidosEntregados(int parRegistrosPorPagina)
        {
            return new DPedidos().TamañoPedidosEntregados(parRegistrosPorPagina);
        }

        public static DataTable BuscarPedidoPendiente(String parPedido_Buscado)
        {
            DPedidos pedidos = new DPedidos();
            pedidos.Pedido_Buscado = parPedido_Buscado;

            return pedidos.BuscarPedidoPendiente(pedidos);
        }

        public static DataTable BuscarPedidoEntregado(String parPedido_Buscado)
        {
            DPedidos pedidos = new DPedidos();
            pedidos.Pedido_Buscado = parPedido_Buscado;

            return pedidos.BuscarPedidoEntregado(pedidos);
        }

        public static String Eliminar(int parId_Pedido)
        {
            DPedidos pedidos = new DPedidos();
            pedidos.Id_Pedido = parId_Pedido;

            return pedidos.Eliminar(pedidos);
        }

        public static String Insertar(String parNombre_Cliente, String parNombre_Transporte,
            String parNombre_Empleado, String parFecha_Ordenado, String parFecha_Requerido,
            decimal parCosto_Envio)
        {
            DPedidos pedidos = new DPedidos();
            pedidos.Nombre_Cliente = parNombre_Cliente;
            pedidos.Nombre_Transporte = parNombre_Transporte;
            pedidos.Nombre_Empleado = parNombre_Empleado;
            pedidos.Fecha_Ordenado = parFecha_Ordenado;
            pedidos.Fecha_Requerido = parFecha_Requerido;
            pedidos.Costo_Envio = parCosto_Envio;
            
            return pedidos.Insertar(pedidos);
        }

        public static String Editar(int parIdPedido, String parNombre_Cliente, String parNombre_Transporte,
            String parNombre_Empleado, String parFecha_Ordenado, String parFecha_Requerido,
            String parFecha_Entregado, decimal parCosto_Envio)
        {
            DPedidos pedidos = new DPedidos();
            pedidos.Id_Pedido = parIdPedido;
            pedidos.Nombre_Cliente = parNombre_Cliente;
            pedidos.Nombre_Transporte = parNombre_Transporte;
            pedidos.Nombre_Empleado = parNombre_Empleado;
            pedidos.Fecha_Ordenado = parFecha_Ordenado;
            pedidos.Fecha_Requerido = parFecha_Requerido;
            pedidos.Fecha_Entregado = parFecha_Entregado;
            pedidos.Costo_Envio = parCosto_Envio;

            return pedidos.Editar(pedidos);
        }

        public static String MarcarEntregadoPendiente(int parIdPedido, String parFecha_Entregado)
        {
            DPedidos pedidos = new DPedidos();
            pedidos.Id_Pedido = parIdPedido;
            pedidos.Fecha_Entregado = parFecha_Entregado;

            return pedidos.MarcarEntregadoPendiente(pedidos);
        }
    }
}
