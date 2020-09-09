using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DReportes
    {
        public DReportes()
        {

        }

        public DataTable MostrarTop10Clientes(String parFechaInicial, String parFechaFinal)
        {
            DataTable TablaDatos = new DataTable("Reportes.Top10Clientes");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Reportes.Top10Clientes";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParFechaInicial = new SqlParameter();
                ParFechaInicial.ParameterName = "@FechaInicial";
                ParFechaInicial.SqlDbType = SqlDbType.VarChar;
                ParFechaInicial.Value = parFechaInicial;
                SqlComando.Parameters.Add(ParFechaInicial);

                SqlParameter ParFechaFinal = new SqlParameter();
                ParFechaFinal.ParameterName = "@FechaFinal";
                ParFechaFinal.SqlDbType = SqlDbType.VarChar;
                ParFechaFinal.Value = parFechaFinal;
                SqlComando.Parameters.Add(ParFechaFinal);

                SqlComando.ExecuteNonQuery();

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Reportes.Top10Clientes. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return TablaDatos;
        }

        public DataTable MostrarTop10Empleados(String parFechaInicial, String parFechaFinal)
        {
            DataTable TablaDatos = new DataTable("Reportes.Top10Empleados");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Reportes.Top10Empleados";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParFechaInicial = new SqlParameter();
                ParFechaInicial.ParameterName = "@FechaInicial";
                ParFechaInicial.SqlDbType = SqlDbType.VarChar;
                ParFechaInicial.Value = parFechaInicial;
                SqlComando.Parameters.Add(ParFechaInicial);

                SqlParameter ParFechaFinal = new SqlParameter();
                ParFechaFinal.ParameterName = "@FechaFinal";
                ParFechaFinal.SqlDbType = SqlDbType.VarChar;
                ParFechaFinal.Value = parFechaFinal;
                SqlComando.Parameters.Add(ParFechaFinal);

                SqlComando.ExecuteNonQuery();

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Reportes.Top10Empleados. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return TablaDatos;
        }

        public DataTable MostrarTop10Productos(String parFechaInicial, String parFechaFinal)
        {
            DataTable TablaDatos = new DataTable("Reportes.Top10Productos");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Reportes.Top10Productos";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParFechaInicial = new SqlParameter();
                ParFechaInicial.ParameterName = "@FechaInicial";
                ParFechaInicial.SqlDbType = SqlDbType.VarChar;
                ParFechaInicial.Value = parFechaInicial;
                SqlComando.Parameters.Add(ParFechaInicial);

                SqlParameter ParFechaFinal = new SqlParameter();
                ParFechaFinal.ParameterName = "@FechaFinal";
                ParFechaFinal.SqlDbType = SqlDbType.VarChar;
                ParFechaFinal.Value = parFechaFinal;
                SqlComando.Parameters.Add(ParFechaFinal);

                SqlComando.ExecuteNonQuery();

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Reportes.Top10Productos. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return TablaDatos;
        }

        public DataTable MostrarHistorialCliente(String parFechaInicial, String parFechaFinal, String parCliente)
        {
            DataTable TablaDatos = new DataTable("Reportes.HistorialCliente");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Reportes.HistorialCliente";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParFechaInicial = new SqlParameter();
                ParFechaInicial.ParameterName = "@FechaInicial";
                ParFechaInicial.SqlDbType = SqlDbType.VarChar;
                ParFechaInicial.Value = parFechaInicial;
                SqlComando.Parameters.Add(ParFechaInicial);

                SqlParameter ParFechaFinal = new SqlParameter();
                ParFechaFinal.ParameterName = "@FechaFinal";
                ParFechaFinal.SqlDbType = SqlDbType.VarChar;
                ParFechaFinal.Value = parFechaFinal;
                SqlComando.Parameters.Add(ParFechaFinal);

                SqlParameter ParCliente = new SqlParameter();
                ParCliente.ParameterName = "@Cliente";
                ParCliente.SqlDbType = SqlDbType.VarChar;
                ParCliente.Value = parCliente;
                SqlComando.Parameters.Add(ParCliente);

                SqlComando.ExecuteNonQuery();

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Reportes.HistorialCliente. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return TablaDatos;
        }

        public DataTable MostrarHistorialEmpleado(String parFechaInicial, String parFechaFinal, String parEmpleado)
        {
            DataTable TablaDatos = new DataTable("Reportes.HistorialEmpleado");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Reportes.HistorialEmpleado";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParFechaInicial = new SqlParameter();
                ParFechaInicial.ParameterName = "@FechaInicial";
                ParFechaInicial.SqlDbType = SqlDbType.VarChar;
                ParFechaInicial.Value = parFechaInicial;
                SqlComando.Parameters.Add(ParFechaInicial);

                SqlParameter ParFechaFinal = new SqlParameter();
                ParFechaFinal.ParameterName = "@FechaFinal";
                ParFechaFinal.SqlDbType = SqlDbType.VarChar;
                ParFechaFinal.Value = parFechaFinal;
                SqlComando.Parameters.Add(ParFechaFinal);

                SqlParameter ParEmpleado = new SqlParameter();
                ParEmpleado.ParameterName = "@Empleado";
                ParEmpleado.SqlDbType = SqlDbType.VarChar;
                ParEmpleado.Value = parEmpleado;
                SqlComando.Parameters.Add(ParEmpleado);

                SqlComando.ExecuteNonQuery();

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Reportes.HistorialEmpleado. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return TablaDatos;
        }

        public DataTable MostrarHistorialProducto(String parFechaInicial, String parFechaFinal, String parProducto)
        {
            DataTable TablaDatos = new DataTable("Reportes.HistorialProducto");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Reportes.HistorialProducto";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParFechaInicial = new SqlParameter();
                ParFechaInicial.ParameterName = "@FechaInicial";
                ParFechaInicial.SqlDbType = SqlDbType.VarChar;
                ParFechaInicial.Value = parFechaInicial;
                SqlComando.Parameters.Add(ParFechaInicial);

                SqlParameter ParFechaFinal = new SqlParameter();
                ParFechaFinal.ParameterName = "@FechaFinal";
                ParFechaFinal.SqlDbType = SqlDbType.VarChar;
                ParFechaFinal.Value = parFechaFinal;
                SqlComando.Parameters.Add(ParFechaFinal);

                SqlParameter ParProducto = new SqlParameter();
                ParProducto.ParameterName = "@Producto";
                ParProducto.SqlDbType = SqlDbType.VarChar;
                ParProducto.Value = parProducto;
                SqlComando.Parameters.Add(ParProducto);

                SqlComando.ExecuteNonQuery();

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Reportes.HistorialProducto. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return TablaDatos;
        }
    }
}
