using System;
using System.Collections.Generic;
using System.Data;
using CapaDatos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NCategorias
    {
        public static DataTable ListaCategorias()
        {
            return new DCategorias().ListaCategorias();
        }

        public static DataTable Mostrar(int parNumeroPagina, int parRegistrosPorPagina)
        {
            return new DCategorias().Mostrar(parNumeroPagina, parRegistrosPorPagina);
        }

        public static int Tamaño(int parRegistrosPorPagina)
        {
            return new DCategorias().Tamaño(parRegistrosPorPagina);
        }


        public static DataTable Buscar(String parNombre_Buscado)
        {
            DCategorias categorias = new DCategorias();
            categorias.Nombre_Buscado = parNombre_Buscado;

            return categorias.Buscar(categorias);
        }

        public static String Eliminar(int parId_Categoria)
        {
            DCategorias categorias = new DCategorias();
            categorias.Id_Categoria = parId_Categoria;

            return categorias.Eliminar(categorias);
        }

        public static String Insertar(String parNombre_Categoria, String parDescripcion)
        {
            DCategorias categorias = new DCategorias();
            categorias.Nombre_Categoria = parNombre_Categoria;
            categorias.Descripcion = parDescripcion;

            return categorias.Insertar(categorias);
        }

        public static String Editar(int parId_Categoria, String parNombre_Categoria, String parDescripcion)
        {
            DCategorias categorias = new DCategorias();
            categorias.Id_Categoria = parId_Categoria;
            categorias.Nombre_Categoria = parNombre_Categoria;
            categorias.Descripcion = parDescripcion;

            return categorias.Editar(categorias);
        }
    }
}
