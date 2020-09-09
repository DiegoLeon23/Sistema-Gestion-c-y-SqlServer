using System;
using System.Collections.Generic;
using System.Data;
using CapaDatos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NProductos
    {
        public static DataTable ListaProductos()
        {
            return new DProductos().ListaProductos();
        }

        public static decimal PrecioProducto(int parIdProducto)
        {
            return new DProductos().PrecioProducto(parIdProducto);
        }

        public static DataTable Mostrar(int parNumeroPagina, int parRegistrosPorPagina)
        {
            return new DProductos().Mostrar(parNumeroPagina, parRegistrosPorPagina);
        }

        public static int Tamaño(int parRegistrosPorPagina)
        {
            return new DProductos().Tamaño(parRegistrosPorPagina);
        }


        public static DataTable Buscar(String parNombre_Buscado)
        {
            DProductos productos = new DProductos();
            productos.Nombre_Buscado = parNombre_Buscado;

            return productos.Buscar(productos);
        }

        public static String Eliminar(int parId_Producto)
        {
            DProductos productos = new DProductos();
            productos.Id_Producto = parId_Producto;

            return productos.Eliminar(productos);
        }

        public static String Insertar(String parNombre_Producto, String parNombre_Categoria,
            decimal parPrecio_Unitario, String parDetalles)
        {
            DProductos productos = new DProductos();
            productos.Nombre_Producto = parNombre_Producto;
            productos.Nombre_Categoria = parNombre_Categoria;
            productos.Precio_Unitario = parPrecio_Unitario;
            productos.Detalles = parDetalles;

            return productos.Insertar(productos);
        }

        public static String Editar(int parId_Producto, String parNombre_Producto, 
            String parNombre_Categoria, decimal parPrecio_Unitario, String parDetalles)
        {
            DProductos productos = new DProductos();
            productos.Id_Producto = parId_Producto;
            productos.Nombre_Producto = parNombre_Producto;
            productos.Nombre_Categoria = parNombre_Categoria;
            productos.Precio_Unitario = parPrecio_Unitario;
            productos.Detalles = parDetalles;

            return productos.Editar(productos);
        }
    }
}
