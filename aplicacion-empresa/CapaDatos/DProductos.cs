using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DProductos
    {
        public int Id_Producto { get; set; }
        public String Nombre_Producto { get; set; }
        public String Nombre_Categoria { get; set; }
        public decimal Precio_Unitario { get; set; }
        public String Detalles { get; set; }
        public String Nombre_Buscado { get; set; }

        public DProductos()
        {

        }

        public DProductos(int parId_Producto, String parNombre_Producto, String parNombre_Categoria,
            decimal parPrecio_Unitario, String parDetalles, String parNombre_Buscado)
        {
            this.Id_Producto = parId_Producto;
            this.Nombre_Producto = parNombre_Producto;
            this.Nombre_Categoria = parNombre_Categoria;
            this.Precio_Unitario = parPrecio_Unitario;
            this.Detalles = parDetalles;
            this.Nombre_Buscado = parNombre_Buscado;
        }

        public DataTable ListaProductos()
        {
            DataTable TablaDatos = new DataTable("Produccion.Productos");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Produccion.ListaProductos";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlComando.ExecuteNonQuery();

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Produccion.ListaProductos. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return TablaDatos;
        }

        public decimal PrecioProducto(int parIdBuscado)
        {
            decimal precio = 0;
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Produccion.PrecioProducto";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdBuscado = new SqlParameter();
                ParIdBuscado.ParameterName = "@IdBuscado";
                ParIdBuscado.SqlDbType = SqlDbType.Int;
                ParIdBuscado.Value = parIdBuscado;
                SqlComando.Parameters.Add(ParIdBuscado);

                SqlParameter ParPrecio = new SqlParameter();
                ParPrecio.ParameterName = "@Precio";
                ParPrecio.SqlDbType = SqlDbType.Money;
                ParPrecio.Direction = ParameterDirection.Output;
                SqlComando.Parameters.Add(ParPrecio);

                SqlComando.ExecuteNonQuery();

                precio = Convert.ToDecimal(ParPrecio.Value.ToString());

            }

            catch (Exception ex)
            {
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Produccion.PrecioProducto. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return precio;
        }

        public DataTable Mostrar(int parNumeroPagina, int parRegistrosPorPagina)
        {
            DataTable TablaDatos = new DataTable("Produccion.v_Productos_NombreCategorias");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Produccion.MostrarProductos";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNumeroPagina = new SqlParameter();
                ParNumeroPagina.ParameterName = "@NumeroPagina";
                ParNumeroPagina.SqlDbType = SqlDbType.Int;
                ParNumeroPagina.Value = parNumeroPagina;
                SqlComando.Parameters.Add(ParNumeroPagina);

                SqlParameter ParRegistrosPorPagina = new SqlParameter();
                ParRegistrosPorPagina.ParameterName = "@RegistrosPorPagina";
                ParRegistrosPorPagina.SqlDbType = SqlDbType.Int;
                ParRegistrosPorPagina.Value = parRegistrosPorPagina;
                SqlComando.Parameters.Add(ParRegistrosPorPagina);

                SqlComando.ExecuteNonQuery();

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Produccion.MostrarProductos. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return TablaDatos;
        }

        public int Tamaño(int parRegistrosPorPagina)
        {
            int totalPaginas = 1;
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Produccion.TamañoProductos";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParRegistrosPorPagina = new SqlParameter();
                ParRegistrosPorPagina.ParameterName = "@RegistrosPorPagina";
                ParRegistrosPorPagina.SqlDbType = SqlDbType.Int;
                ParRegistrosPorPagina.Value = parRegistrosPorPagina;
                SqlComando.Parameters.Add(ParRegistrosPorPagina);

                SqlParameter ParTotalPaginas = new SqlParameter();
                ParTotalPaginas.ParameterName = "@TotalPaginas";
                ParTotalPaginas.SqlDbType = SqlDbType.Int;
                ParTotalPaginas.Direction = ParameterDirection.Output;
                SqlComando.Parameters.Add(ParTotalPaginas);

                SqlComando.ExecuteNonQuery();

                totalPaginas = (int)SqlComando.Parameters["@TotalPaginas"].Value;
            }

            catch (Exception ex)
            {
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Produccion.TamañoProductos. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return totalPaginas;
        }

        public DataTable Buscar(DProductos parProductos)
        {
            DataTable TablaDatos = new DataTable("Produccion.v_Productos_NombreCategorias");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Produccion.BuscarProducto";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre_Buscado = new SqlParameter();
                ParNombre_Buscado.ParameterName = "@NombreBuscado";
                ParNombre_Buscado.SqlDbType = SqlDbType.VarChar;
                ParNombre_Buscado.Size = parProductos.Nombre_Buscado.Length;
                ParNombre_Buscado.Value = parProductos.Nombre_Buscado;
                SqlComando.Parameters.Add(ParNombre_Buscado);

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Produccion.BuscarProducto. " + ex.Message, ex);
            }

            finally
            {
                if (SqlConexion.State == ConnectionState.Open)
                {
                    SqlConexion.Close();
                }
            }

            return TablaDatos;
        }

        public string Insertar(DProductos parProductos)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Produccion.InsertarProducto";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre_Producto = new SqlParameter();
                ParNombre_Producto.ParameterName = "@Nombre_Producto";
                ParNombre_Producto.SqlDbType = SqlDbType.VarChar;
                ParNombre_Producto.Size = parProductos.Nombre_Producto.Length;
                ParNombre_Producto.Value = parProductos.Nombre_Producto;
                SqlComando.Parameters.Add(ParNombre_Producto);

                SqlParameter ParNombre_Categoria = new SqlParameter();
                ParNombre_Categoria.ParameterName = "@Nombre_Categoria";
                ParNombre_Categoria.SqlDbType = SqlDbType.VarChar;
                ParNombre_Categoria.Size = parProductos.Nombre_Categoria.Length;
                ParNombre_Categoria.Value = parProductos.Nombre_Categoria;
                SqlComando.Parameters.Add(ParNombre_Categoria);

                SqlParameter ParPrecio_Unitario = new SqlParameter();
                ParPrecio_Unitario.ParameterName = "@Precio_Unitario";
                ParPrecio_Unitario.SqlDbType = SqlDbType.Money;
                ParPrecio_Unitario.Value = parProductos.Precio_Unitario;
                SqlComando.Parameters.Add(ParPrecio_Unitario);

                SqlParameter ParDetalles = new SqlParameter();
                ParDetalles.ParameterName = "@Detalles";
                ParDetalles.SqlDbType = SqlDbType.VarChar;
                ParDetalles.Size = parProductos.Detalles.Length;
                ParDetalles.Value = parProductos.Detalles;
                SqlComando.Parameters.Add(ParDetalles);

                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (SqlException ex)
            {
                if (ex.Number == 8152)
                {
                    Respuesta = "Has introducido demasiados caracteres en uno de los campos";
                }
                else if (ex.Number == 2627)
                {
                    Respuesta = "Ya existe un producto con ese Nombre";
                }
                else if (ex.Number == 515)
                {
                    Respuesta = "No puedes dejar los campos Nombre y Categoría vacíos";
                }
                else if (ex.Number == 50000)
                {
                    Respuesta = "Debes ingresar el nombre de una Categoría existente. Para ingresar una nueva Categoría, primero debes crearla.";
                }
                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado Produccion.InsertarProducto. " + ex.Message;
                }
            }

            finally
            {
                if (SqlConexion.State == ConnectionState.Open)
                {
                    SqlConexion.Close();
                }
            }

            return Respuesta;
        }

        public string Eliminar(DProductos parProductos)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Produccion.EliminarProducto";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId_Producto = new SqlParameter();
                ParId_Producto.ParameterName = "@Id_Producto";
                ParId_Producto.SqlDbType = SqlDbType.Int;
                ParId_Producto.Value = parProductos.Id_Producto;
                SqlComando.Parameters.Add(ParId_Producto);

                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    Respuesta = "No puedes eliminar un producto presente en un Pedido. Debes eliminar o actualizar los Pedidos antes de eliminar el producto.";
                }

                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado Produccion.EliminarProducto. " + ex.Message;
                }
            }

            finally
            {
                if (SqlConexion.State == ConnectionState.Open)
                {
                    SqlConexion.Close();
                }
            }

            return Respuesta;
        }

        public string Editar(DProductos parProductos)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Produccion.EditarProducto";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId_Producto = new SqlParameter();
                ParId_Producto.ParameterName = "@Id_Producto";
                ParId_Producto.SqlDbType = SqlDbType.Int;
                ParId_Producto.Value = parProductos.Id_Producto;
                SqlComando.Parameters.Add(ParId_Producto);

                SqlParameter ParNombre_Producto = new SqlParameter();
                ParNombre_Producto.ParameterName = "@Nombre_Producto";
                ParNombre_Producto.SqlDbType = SqlDbType.VarChar;
                ParNombre_Producto.Size = parProductos.Nombre_Producto.Length;
                ParNombre_Producto.Value = parProductos.Nombre_Producto;
                SqlComando.Parameters.Add(ParNombre_Producto);

                SqlParameter ParNombre_Categoria = new SqlParameter();
                ParNombre_Categoria.ParameterName = "@Nombre_Categoria";
                ParNombre_Categoria.SqlDbType = SqlDbType.VarChar;
                ParNombre_Categoria.Size = parProductos.Nombre_Categoria.Length;
                ParNombre_Categoria.Value = parProductos.Nombre_Categoria;
                SqlComando.Parameters.Add(ParNombre_Categoria);

                SqlParameter ParPrecio_Unitario = new SqlParameter();
                ParPrecio_Unitario.ParameterName = "@Precio_Unitario";
                ParPrecio_Unitario.SqlDbType = SqlDbType.Money;
                ParPrecio_Unitario.Value = parProductos.Precio_Unitario;
                SqlComando.Parameters.Add(ParPrecio_Unitario);

                SqlParameter ParDetalles = new SqlParameter();
                ParDetalles.ParameterName = "@Detalles";
                ParDetalles.SqlDbType = SqlDbType.VarChar;
                ParDetalles.Size = parProductos.Detalles.Length;
                ParDetalles.Value = parProductos.Detalles;
                SqlComando.Parameters.Add(ParDetalles);

                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (SqlException ex)
            {
                if (ex.Number == 8152)
                {
                    Respuesta = "Has introducido demasiados caracteres en uno de los campos";
                }
                else if (ex.Number == 2627)
                {
                    Respuesta = "Ya existe un producto con ese Nombre";
                }
                else if (ex.Number == 515)
                {
                    Respuesta = "No puedes dejar los campos Nombre y Categoría vacíos";
                }
                else if (ex.Number == 50000)
                {
                    Respuesta = "Debes ingresar el nombre de una Categoría existente. Para ingresar una nueva Categoría, primero debes crearla.";
                }
                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado Produccion.EditarProducto. " + ex.Message;
                }
            }

            finally
            {
                if (SqlConexion.State == ConnectionState.Open)
                {
                    SqlConexion.Close();
                }
            }

            return Respuesta;
        }
    }
}