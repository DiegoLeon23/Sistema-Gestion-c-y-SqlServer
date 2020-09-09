using System;
using System.Collections.Generic;
using System.Data; 
using System.Data.SqlClient; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DEmpleados
    { 
        public int Id_Empleado { get; set; }
        public String Nombre_Empleado { get; set; }
        public String Apellido_Empleado { get; set; }
        public String Direccion { get; set; }
        public String Ciudad { get; set; }
        public String Region { get; set; }
        public String Pais { get; set; }
        public String Telefono { get; set; }
        public String Apellido_Buscado { get; set; }

        public DEmpleados()
        {

        }

        public DEmpleados(int parId_Empleado, String parNombre_Empleado, String parApellido_Empleado,
        String parDireccion, String parCiudad, String parRegion, String parPais, String parTelefono,
        String parApellido_Buscado)
        {
            this.Id_Empleado = parId_Empleado;
            this.Nombre_Empleado = parNombre_Empleado;
            this.Apellido_Empleado = parApellido_Empleado;
            this.Direccion = parDireccion;
            this.Ciudad = parCiudad;
            this.Region = parRegion;
            this.Pais = parPais;
            this.Telefono = parTelefono;
            this.Apellido_Buscado = parApellido_Buscado;
        }

        public DataTable ListaEmpleados()
        {
            DataTable TablaDatos = new DataTable("RecursosHumanos.Empleados");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "RecursosHumanos.ListaEmpleados";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlComando.ExecuteNonQuery();

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado RecursosHumanos.ListaEmpleados. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return TablaDatos;
        }

        public DataTable Mostrar(int parNumeroPagina, int parRegistrosPorPagina)
        {
            DataTable TablaDatos = new DataTable("RecursosHumanos.Empleados");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "RecursosHumanos.MostrarEmpleados";
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
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado RecursosHumanos.MostrarEmpleados. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return TablaDatos;
        }

        public int Tamaño(int parRegistrosPorPagina)
        {
            SqlConnection SqlConexion = new SqlConnection();
            int totalPaginas = 1;

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "RecursosHumanos.TamañoEmpleados";
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
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado RecursosHumanos.TamañoEmpleado. " + ex.Message, ex); 
            }

            finally
            {
                SqlConexion.Close();
            }

            return totalPaginas;
        }

        public DataTable Buscar(DEmpleados parEmpleados)
        {
            DataTable TablaDatos = new DataTable("RecursosHumanos.Empleados");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "RecursosHumanos.BuscarEmpleado";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParApellido_Buscado = new SqlParameter();
                ParApellido_Buscado.ParameterName = "@ApellidoBuscado";
                ParApellido_Buscado.SqlDbType = SqlDbType.VarChar;
                ParApellido_Buscado.Size = parEmpleados.Apellido_Buscado.Length;
                ParApellido_Buscado.Value = parEmpleados.Apellido_Buscado;
                SqlComando.Parameters.Add(ParApellido_Buscado);

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado RecursosHumanos.BuscarEmpleado. " + ex.Message, ex);
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

        public string Insertar(DEmpleados parEmpleados)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;

                SqlConexion.Open();
                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "RecursosHumanos.InsertarEmpleado";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre_Empleado = new SqlParameter();
                ParNombre_Empleado.ParameterName = "@Nombre_Empleado";
                ParNombre_Empleado.SqlDbType = SqlDbType.VarChar;
                ParNombre_Empleado.Size = parEmpleados.Nombre_Empleado.Length;
                ParNombre_Empleado.Value = parEmpleados.Nombre_Empleado;
                SqlComando.Parameters.Add(ParNombre_Empleado);

                SqlParameter ParApellido_Empleado = new SqlParameter();
                ParApellido_Empleado.ParameterName = "@Apellido_Empleado";
                ParApellido_Empleado.SqlDbType = SqlDbType.VarChar;
                ParApellido_Empleado.Size = parEmpleados.Apellido_Empleado.Length;
                ParApellido_Empleado.Value = parEmpleados.Apellido_Empleado;
                SqlComando.Parameters.Add(ParApellido_Empleado);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@Direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = parEmpleados.Direccion.Length;
                ParDireccion.Value = parEmpleados.Direccion;
                SqlComando.Parameters.Add(ParDireccion);

                SqlParameter ParCiudad = new SqlParameter();
                ParCiudad.ParameterName = "@Ciudad";
                ParCiudad.SqlDbType = SqlDbType.VarChar;
                ParCiudad.Size = parEmpleados.Ciudad.Length;
                ParCiudad.Value = parEmpleados.Ciudad;
                SqlComando.Parameters.Add(ParCiudad);

                SqlParameter ParRegion = new SqlParameter();
                ParRegion.ParameterName = "@Region";
                ParRegion.SqlDbType = SqlDbType.VarChar;
                ParRegion.Size = parEmpleados.Region.Length;
                ParRegion.Value = parEmpleados.Region;
                SqlComando.Parameters.Add(ParRegion);

                SqlParameter ParPais = new SqlParameter();
                ParPais.ParameterName = "@Pais";
                ParPais.SqlDbType = SqlDbType.VarChar;
                ParPais.Size = parEmpleados.Pais.Length;
                ParPais.Value = parEmpleados.Pais;
                SqlComando.Parameters.Add(ParPais);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = parEmpleados.Telefono.Length;
                ParTelefono.Value = parEmpleados.Telefono;
                SqlComando.Parameters.Add(ParTelefono);

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
                    Respuesta = "Ya existe un empleado con ese Nombre y Apellido";
                }
                else if (ex.Number == 515)
                {
                    Respuesta = "Sólo puedes dejar vacíos los campos Región, País y Teléfono";
                }
                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado RecursosHumanos.InsertarEmpleado. " + ex.Message;
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

        public string Eliminar(DEmpleados parEmpleado)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "RecursosHumanos.EliminarEmpleado";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId_Empleado = new SqlParameter();
                ParId_Empleado.ParameterName = "@Id_Empleado";
                ParId_Empleado.SqlDbType = SqlDbType.Int;
                ParId_Empleado.Value = parEmpleado.Id_Empleado;
                SqlComando.Parameters.Add(ParId_Empleado);

                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    Respuesta = "No puedes eliminar un empleado responsable de uno o varios Pedidos. Debes designar un nuevo responsable para los Pedidos de este empleado antes de eliminarlo.";
                }

                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado RecursosHumanos.EliminarEmpleado. " + ex.Message;
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

        public string Editar(DEmpleados parEmpleados)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "RecursosHumanos.EditarEmpleado";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId_Empleado = new SqlParameter();
                ParId_Empleado.ParameterName = "@Id_Empleado";
                ParId_Empleado.SqlDbType = SqlDbType.Int;
                ParId_Empleado.Value = parEmpleados.Id_Empleado;
                SqlComando.Parameters.Add(ParId_Empleado);

                SqlParameter ParNombre_Empleado = new SqlParameter();
                ParNombre_Empleado.ParameterName = "@Nombre_Empleado";
                ParNombre_Empleado.SqlDbType = SqlDbType.VarChar;
                ParNombre_Empleado.Size = parEmpleados.Nombre_Empleado.Length;
                ParNombre_Empleado.Value = parEmpleados.Nombre_Empleado;
                SqlComando.Parameters.Add(ParNombre_Empleado);

                SqlParameter ParApellido_Empleado = new SqlParameter();
                ParApellido_Empleado.ParameterName = "@Apellido_Empleado";
                ParApellido_Empleado.SqlDbType = SqlDbType.VarChar;
                ParApellido_Empleado.Size = parEmpleados.Apellido_Empleado.Length;
                ParApellido_Empleado.Value = parEmpleados.Apellido_Empleado;
                SqlComando.Parameters.Add(ParApellido_Empleado);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@Direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = parEmpleados.Direccion.Length;
                ParDireccion.Value = parEmpleados.Direccion;
                SqlComando.Parameters.Add(ParDireccion);

                SqlParameter ParCiudad = new SqlParameter();
                ParCiudad.ParameterName = "@Ciudad";
                ParCiudad.SqlDbType = SqlDbType.VarChar;
                ParCiudad.Size = parEmpleados.Ciudad.Length;
                ParCiudad.Value = parEmpleados.Ciudad;
                SqlComando.Parameters.Add(ParCiudad);

                SqlParameter ParRegion = new SqlParameter();
                ParRegion.ParameterName = "@Region";
                ParRegion.SqlDbType = SqlDbType.VarChar;
                ParRegion.Size = parEmpleados.Region.Length;
                ParRegion.Value = parEmpleados.Region;
                SqlComando.Parameters.Add(ParRegion);

                SqlParameter ParPais = new SqlParameter();
                ParPais.ParameterName = "@Pais";
                ParPais.SqlDbType = SqlDbType.VarChar;
                ParPais.Size = parEmpleados.Pais.Length;
                ParPais.Value = parEmpleados.Pais;
                SqlComando.Parameters.Add(ParPais);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = parEmpleados.Telefono.Length;
                ParTelefono.Value = parEmpleados.Telefono;
                SqlComando.Parameters.Add(ParTelefono);

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
                    Respuesta = "Ya existe un empleado con ese Nombre y Apellido";
                }
                else if (ex.Number == 515)
                {
                    Respuesta = "Sólo puedes dejar vacíos los campos Región, País y Teléfono";
                }
                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado RecursosHumanos.EditarEmpleado. " + ex.Message;
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