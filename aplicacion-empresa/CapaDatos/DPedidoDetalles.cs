using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DPedidoDetalles
    {
        public int Id_Pedido { get; set; }
        public String Nombre_Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio_Unitario { get; set; }
        public decimal Descuento { get; set; }

        public DPedidoDetalles()
        {

        }

        public DPedidoDetalles(int parId_Pedido, String parNombre_Producto, int parCantidad,
            decimal parPrecio_Unitario, decimal parDescuento)
        {
            this.Id_Pedido = parId_Pedido;
            this.Nombre_Producto = parNombre_Producto;
            this.Cantidad = parCantidad;
            this.Precio_Unitario = parPrecio_Unitario;
            this.Descuento = parDescuento;
        }

        public DataTable MostrarPedidoDetalles(int parIdPedido)
        {
            DataTable TablaDatos = new DataTable("Ventas.PedidoDetalles");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Ventas.MostrarPedidoDetalles";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdPedido = new SqlParameter();
                ParIdPedido.ParameterName = "@Id_Pedido";
                ParIdPedido.SqlDbType = SqlDbType.Int;
                ParIdPedido.Value = parIdPedido;
                SqlComando.Parameters.Add(ParIdPedido);

                SqlComando.ExecuteNonQuery();

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Ventas.MostrarPedidoDetalles. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return TablaDatos;
        }
        
        public string Insertar(DPedidoDetalles parPedidoDetalles)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Ventas.InsertarPedidoDetalles";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre_Producto = new SqlParameter();
                ParNombre_Producto.ParameterName = "@Nombre_Producto";
                ParNombre_Producto.SqlDbType = SqlDbType.VarChar;
                ParNombre_Producto.Size = parPedidoDetalles.Nombre_Producto.Length;
                ParNombre_Producto.Value = parPedidoDetalles.Nombre_Producto;
                SqlComando.Parameters.Add(ParNombre_Producto);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@Cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = parPedidoDetalles.Cantidad;
                SqlComando.Parameters.Add(ParCantidad);

                SqlParameter ParPrecioUnitario = new SqlParameter();
                ParPrecioUnitario.ParameterName = "@Precio_Unitario";
                ParPrecioUnitario.SqlDbType = SqlDbType.Money;
                ParPrecioUnitario.Value = parPedidoDetalles.Precio_Unitario;
                SqlComando.Parameters.Add(ParPrecioUnitario);

                SqlParameter ParDescuento = new SqlParameter();
                ParDescuento.ParameterName = "@Descuento";
                ParDescuento.SqlDbType = SqlDbType.Decimal;
                ParDescuento.Value = parPedidoDetalles.Descuento;
                SqlComando.Parameters.Add(ParDescuento);

                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (SqlException ex)
            {
                if (ex.Number == 8152)
                {
                    Respuesta = "Has introducido demasiados caracteres en uno de los campos";
                }
                else if (ex.Number == 515)
                {
                    Respuesta = "No puedes dejar campos vacíos";
                }
                else if (ex.Number == 2627)
                {
                    Respuesta = "No puedes insertar más de una vez el mismo producto en un pedido. Si quieres agregar más de un mismo producto simplemente modifica la cantidad del mismo.";
                }
                else if (ex.Number == 50000)
                {
                    Respuesta = "Ingresa un producto existente. Si el producto no existe deberás primero crearlo";
                }
                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado Ventas.InsertarPedidoDetalles. " + ex.Message;
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

        public string Editar(DPedidoDetalles parPedidoDetalles)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Ventas.EditarPedidoDetalles";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId_Pedido = new SqlParameter();
                ParId_Pedido.ParameterName = "@Id_Pedido";
                ParId_Pedido.SqlDbType = SqlDbType.Int;
                ParId_Pedido.Value = parPedidoDetalles.Id_Pedido;
                SqlComando.Parameters.Add(ParId_Pedido);

                SqlParameter ParNombre_Producto = new SqlParameter();
                ParNombre_Producto.ParameterName = "@Nombre_Producto";
                ParNombre_Producto.SqlDbType = SqlDbType.VarChar;
                ParNombre_Producto.Size = parPedidoDetalles.Nombre_Producto.Length;
                ParNombre_Producto.Value = parPedidoDetalles.Nombre_Producto;
                SqlComando.Parameters.Add(ParNombre_Producto);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@Cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = parPedidoDetalles.Cantidad;
                SqlComando.Parameters.Add(ParCantidad);
                
                SqlParameter ParPrecioUnitario = new SqlParameter();
                ParPrecioUnitario.ParameterName = "@Precio_Unitario";
                ParPrecioUnitario.SqlDbType = SqlDbType.Money;
                ParPrecioUnitario.Value = parPedidoDetalles.Precio_Unitario;
                SqlComando.Parameters.Add(ParPrecioUnitario);

                SqlParameter ParDescuento = new SqlParameter();
                ParDescuento.ParameterName = "@Descuento";
                ParDescuento.SqlDbType = SqlDbType.Decimal;
                ParDescuento.Value = parPedidoDetalles.Descuento;
                SqlComando.Parameters.Add(ParDescuento);
     
                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (SqlException ex)
            {
                if (ex.Number == 8152)
                {
                    Respuesta = "Has introducido demasiados caracteres en uno de los campos";
                }
                else if (ex.Number == 515)
                {
                    Respuesta = "No puedes dejar campos vacíos";
                }
                else if (ex.Number == 2627)
                {
                    Respuesta = "No puedes insertar más de una vez el mismo producto en un pedido. Si quieres agregar más de un mismo producto simplemente modifica la cantidad del mismo.";
                }
                else if (ex.Number == 50000)
                {
                    Respuesta = "Ingresa un producto existente. Si el p oducto no existe deberás primero crearlo";
                }
                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado Ventas.EditarPedidoDetalles. " + ex.Message;
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