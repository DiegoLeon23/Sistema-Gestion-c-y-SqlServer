using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DPedidos
    {
        public int Id_Pedido { get; set; }
        public String Nombre_Cliente { get; set; }
        public String Nombre_Transporte { get; set; }
        public String Nombre_Empleado { get; set; }
        public String Fecha_Ordenado { get; set; }
        public String Fecha_Requerido { get; set; }
        public String Fecha_Entregado { get; set; }
        public decimal Costo_Envio { get; set; }
        public String Pedido_Buscado { get; set; }

        public DPedidos()
        {

        }

        public DPedidos(int parId_Pedido, String parNombre_Cliente, String parNombre_Transporte,
            String parNombre_Empleado, String parFecha_Ordenado, String parFecha_Requerido,
            String parFecha_Entregado, decimal parCosto_Envio, String parPedido_Buscado)
        {
            this.Id_Pedido = parId_Pedido;
            this.Nombre_Cliente = parNombre_Cliente;
            this.Nombre_Transporte = parNombre_Transporte;
            this.Nombre_Empleado = parNombre_Empleado;
            this.Fecha_Ordenado = parFecha_Ordenado;
            this.Fecha_Requerido = parFecha_Requerido;
            this.Fecha_Entregado = parFecha_Entregado;
            this.Costo_Envio = parCosto_Envio;
            this.Pedido_Buscado = parPedido_Buscado;
        }

        public DataTable MostrarPedidosPendientes(int parNumeroPagina, int parRegistrosPorPagina)
        {
            DataTable TablaDatos = new DataTable("Ventas.v_Pedidos");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Ventas.MostrarPedidosPendientes";
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
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Ventas.MostrarPedidosPendientes. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return TablaDatos;
        }

        public DataTable MostrarPedidosEntregados(int parNumeroPagina, int parRegistrosPorPagina)
        {
            DataTable TablaDatos = new DataTable("Ventas.v_Pedidos");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Ventas.MostrarPedidosEntregados";
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
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Ventas.MostrarPedidosEntregados. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return TablaDatos;
        }

        public int TamañoPedidosPendientes(int parRegistrosPorPagina)
        {
            SqlConnection SqlConexion = new SqlConnection();
            int totalPaginas = 1;

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Ventas.TamañoPedidosPendientes";
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
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Ventas.TamañoPedidosPendientes. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return totalPaginas;
        }

        public int TamañoPedidosEntregados(int parRegistrosPorPagina)
        {
            SqlConnection SqlConexion = new SqlConnection();
            int totalPaginas = 1;

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Ventas.TamañoPedidosEntregados";
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
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Ventas.TamañoPedidosEntregados. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return totalPaginas;
        }

        public DataTable BuscarPedidoPendiente(DPedidos parPedidos)
        {
            DataTable TablaDatos = new DataTable("Ventas.v_Pedidos");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Ventas.BuscarPedidoPendiente";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre_Buscado = new SqlParameter();
                ParNombre_Buscado.ParameterName = "@Pedido_Buscado";
                ParNombre_Buscado.SqlDbType = SqlDbType.VarChar;
                ParNombre_Buscado.Size = parPedidos.Pedido_Buscado.Length;
                ParNombre_Buscado.Value = parPedidos.Pedido_Buscado;
                SqlComando.Parameters.Add(ParNombre_Buscado);

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Ventas.BuscarPedidoPendiente. " + ex.Message, ex);
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

        public DataTable BuscarPedidoEntregado(DPedidos parPedidos)
        {
            DataTable TablaDatos = new DataTable("Ventas.v_Pedidos");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Ventas.BuscarPedidoEntregado";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre_Buscado = new SqlParameter();
                ParNombre_Buscado.ParameterName = "@Pedido_Buscado";
                ParNombre_Buscado.SqlDbType = SqlDbType.VarChar;
                ParNombre_Buscado.Size = parPedidos.Pedido_Buscado.Length;
                ParNombre_Buscado.Value = parPedidos.Pedido_Buscado;
                SqlComando.Parameters.Add(ParNombre_Buscado);

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Ventas.BuscarPedidoEntregado. " + ex.Message, ex);
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

        public string Insertar(DPedidos parPedidos)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();
        
            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Ventas.InsertarPedido";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre_Cliente = new SqlParameter();
                ParNombre_Cliente.ParameterName = "@Nombre_Cliente";
                ParNombre_Cliente.SqlDbType = SqlDbType.VarChar;
                ParNombre_Cliente.Size = parPedidos.Nombre_Cliente.Length;
                ParNombre_Cliente.Value = parPedidos.Nombre_Cliente;
                SqlComando.Parameters.Add(ParNombre_Cliente);

                SqlParameter ParNombre_Transporte = new SqlParameter();
                ParNombre_Transporte.ParameterName = "@Nombre_Transporte";
                ParNombre_Transporte.SqlDbType = SqlDbType.VarChar;
                ParNombre_Transporte.Size = parPedidos.Nombre_Transporte.Length;
                ParNombre_Transporte.Value = parPedidos.Nombre_Transporte;
                SqlComando.Parameters.Add(ParNombre_Transporte);

                SqlParameter ParNombre_Empleado = new SqlParameter();
                ParNombre_Empleado.ParameterName = "@Nombre_Empleado";
                ParNombre_Empleado.SqlDbType = SqlDbType.VarChar;
                ParNombre_Empleado.Size = parPedidos.Nombre_Empleado.Length;
                ParNombre_Empleado.Value = parPedidos.Nombre_Empleado;
                SqlComando.Parameters.Add(ParNombre_Empleado);

                SqlParameter ParFecha_Ordenado = new SqlParameter();
                ParFecha_Ordenado.ParameterName = "@Fecha_Ordenado";
                ParFecha_Ordenado.SqlDbType = SqlDbType.DateTime;
                ParFecha_Ordenado.Value = parPedidos.Fecha_Ordenado;
                SqlComando.Parameters.Add(ParFecha_Ordenado);

                SqlParameter ParFecha_Requerido = new SqlParameter();
                ParFecha_Requerido.ParameterName = "@Fecha_Requerido";
                ParFecha_Requerido.SqlDbType = SqlDbType.DateTime;
                ParFecha_Requerido.Value = parPedidos.Fecha_Requerido;
                SqlComando.Parameters.Add(ParFecha_Requerido);

                SqlParameter ParCosto_Envio = new SqlParameter();
                ParCosto_Envio.ParameterName = "@Costo_Envio";
                ParCosto_Envio.SqlDbType = SqlDbType.Money;
                ParCosto_Envio.Value = parPedidos.Costo_Envio;
                SqlComando.Parameters.Add(ParCosto_Envio);

                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (SqlException ex)
            {
                if (ex.Number == 8152)
                {
                    Respuesta = "Has introducido demasiados caracteres en uno de los campos";
                }
                else if (ex.Number == 547)
                {
                    Respuesta = "La Fecha Requerido tiene que ser posterior a la Fecha Ordeando";
                }
                else if (ex.Number == 515)
                {
                    Respuesta = "No puedes dejar los campos Cliente, Transportista, Empleado o Fecha Ordenado vacíos";
                }
                else if (ex.Number == 50000)
                {
                    Respuesta = "Debes ingresar un Cliente, Empleado o Transportista existente";
                }
                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado Ventas.InsertarPedido. " + ex.Message;
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

        public string Eliminar(DPedidos parPedidos)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Ventas.EliminarPedido";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId_Pedido = new SqlParameter();
                ParId_Pedido.ParameterName = "@Id_Pedido";
                ParId_Pedido.SqlDbType = SqlDbType.Int;
                ParId_Pedido.Value = parPedidos.Id_Pedido;
                SqlComando.Parameters.Add(ParId_Pedido);

                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (Exception ex)
            {
                Respuesta = "Error al intentar ejecutar el procedimiento almacenado Ventas.EliminarPedido. " + ex.Message;
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

        public string Editar(DPedidos parPedidos)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Ventas.EditarPedido";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId_Pedido = new SqlParameter();
                ParId_Pedido.ParameterName = "@Id_Pedido";
                ParId_Pedido.SqlDbType = SqlDbType.Int;
                ParId_Pedido.Value = parPedidos.Id_Pedido;
                SqlComando.Parameters.Add(ParId_Pedido);

                SqlParameter ParNombre_Cliente = new SqlParameter();
                ParNombre_Cliente.ParameterName = "@Nombre_Cliente";
                ParNombre_Cliente.SqlDbType = SqlDbType.VarChar;
                ParNombre_Cliente.Size = parPedidos.Nombre_Cliente.Length;
                ParNombre_Cliente.Value = parPedidos.Nombre_Cliente;
                SqlComando.Parameters.Add(ParNombre_Cliente);

                SqlParameter ParNombre_Transporte = new SqlParameter();
                ParNombre_Transporte.ParameterName = "@Nombre_Transporte";
                ParNombre_Transporte.SqlDbType = SqlDbType.VarChar;
                ParNombre_Transporte.Size = parPedidos.Nombre_Transporte.Length;
                ParNombre_Transporte.Value = parPedidos.Nombre_Transporte;
                SqlComando.Parameters.Add(ParNombre_Transporte);

                SqlParameter ParNombre_Empleado = new SqlParameter();
                ParNombre_Empleado.ParameterName = "@Nombre_Empleado";
                ParNombre_Empleado.SqlDbType = SqlDbType.VarChar;
                ParNombre_Empleado.Size = parPedidos.Nombre_Empleado.Length;
                ParNombre_Empleado.Value = parPedidos.Nombre_Empleado;
                SqlComando.Parameters.Add(ParNombre_Empleado);

                SqlParameter ParFecha_Ordenado = new SqlParameter();
                ParFecha_Ordenado.ParameterName = "@Fecha_Ordenado";
                ParFecha_Ordenado.SqlDbType = SqlDbType.DateTime;
                ParFecha_Ordenado.Value = parPedidos.Fecha_Ordenado;
                SqlComando.Parameters.Add(ParFecha_Ordenado);

                SqlParameter ParFecha_Requerido = new SqlParameter();
                ParFecha_Requerido.ParameterName = "@Fecha_Requerido";
                ParFecha_Requerido.SqlDbType = SqlDbType.DateTime;
                ParFecha_Requerido.Value = parPedidos.Fecha_Requerido;
                SqlComando.Parameters.Add(ParFecha_Requerido);

                SqlParameter ParFecha_Entregado = new SqlParameter();
                ParFecha_Entregado.ParameterName = "@Fecha_Entregado";
                ParFecha_Entregado.SqlDbType = SqlDbType.DateTime;
                ParFecha_Entregado.Value = parPedidos.Fecha_Entregado;
                SqlComando.Parameters.Add(ParFecha_Entregado);

                SqlParameter ParCosto_Envio = new SqlParameter();
                ParCosto_Envio.ParameterName = "@Costo_Envio";
                ParCosto_Envio.SqlDbType = SqlDbType.Money;
                ParCosto_Envio.Value = parPedidos.Costo_Envio;
                SqlComando.Parameters.Add(ParCosto_Envio);

                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (SqlException ex)
            {
                if (ex.Number == 8152)
                {
                    Respuesta = "Has introducido demasiados caracteres en uno de los campos";
                }
                else if (ex.Number == 547)
                {
                    Respuesta = "La Fecha Requerido o la Fecha Entregado tienen que ser posteriores a la Fecha Ordeando";
                }
                else if (ex.Number == 515)
                {
                    Respuesta = "No puedes dejar los campos Cliente, Transportista, Empleado o Fecha Ordenado vacíos";
                }
                else if (ex.Number == 50000)
                {
                    Respuesta = "Debes ingresar un Cliente, Empleado o Transportista existente";
                }
                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado Ventas.EditarPedido. " + ex.Message;
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

        public string MarcarEntregadoPendiente(DPedidos parPedidos)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Ventas.MarcarEntregadoPendiente";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId_Pedido = new SqlParameter();
                ParId_Pedido.ParameterName = "@Id_Pedido";
                ParId_Pedido.SqlDbType = SqlDbType.Int;
                ParId_Pedido.Value = parPedidos.Id_Pedido;
                SqlComando.Parameters.Add(ParId_Pedido);

                SqlParameter ParFecha_Entregado = new SqlParameter();
                ParFecha_Entregado.ParameterName = "@Fecha_Entregado";
                ParFecha_Entregado.SqlDbType = SqlDbType.DateTime;
                ParFecha_Entregado.Value = parPedidos.Fecha_Entregado;
                SqlComando.Parameters.Add(ParFecha_Entregado);

                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (SqlException ex)
            {
                if (ex.Number == 8152)
                {
                    Respuesta = "Has introducido demasiados caracteres en uno de los campos";
                }
                else if (ex.Number == 547)
                {
                    Respuesta = "La Fecha Requerido o la Fecha Entregado tienen que ser posteriores a la Fecha Ordeando";
                }
                else if (ex.Number == 515)
                {
                    Respuesta = "No puedes dejar campos vacíos";
                }
                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado Ventas.MarcarEntregadoPendiente. " + ex.Message;
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