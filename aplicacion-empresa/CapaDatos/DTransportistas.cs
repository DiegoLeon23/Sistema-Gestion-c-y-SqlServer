using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DTransportistas
    {
        public int Id_Transportista { get; set; }
        public String Nombre_Empresa { get; set; }
        public String Direccion { get; set; }
        public String Ciudad { get; set; }
        public String Region { get; set; }
        public String Pais { get; set; }
        public String Telefono { get; set; }
        public String Nombre_Buscado { get; set; }

        public DTransportistas()
        {

        }

        public DTransportistas(int parId_Transportista, String parNombre_Empresa,
        String parDireccion, String parCiudad, String parRegion, String parPais, String parTelefono,
        String parNombre_Buscado)
        {
            this.Id_Transportista = parId_Transportista;
            this.Nombre_Empresa = parNombre_Empresa;
            this.Direccion = parDireccion;
            this.Ciudad = parCiudad;
            this.Region = parRegion;
            this.Pais = parPais;
            this.Telefono = parTelefono;
            this.Nombre_Buscado = parNombre_Buscado;
        }

        public DataTable ListaTransportistas()
        {
            DataTable TablaDatos = new DataTable("Ventas.Transportistas");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Ventas.ListaTransportistas";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlComando.ExecuteNonQuery();

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Ventas.ListaTransportistas. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return TablaDatos;
        }

        public DataTable Mostrar(int parNumeroPagina, int parRegistrosPorPagina)
        {
            DataTable TablaDatos = new DataTable("Ventas.Transportistas");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Ventas.MostrarTransportistas";
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
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Ventas.MostrarTransportistas. " + ex.Message, ex);
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
                SqlComando.CommandText = "Ventas.TamañoTransportistas";
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
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Ventas.TamañoTransportistas. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return totalPaginas;
        }

        public DataTable Buscar(DTransportistas parTransportistas)
        {
            DataTable TablaDatos = new DataTable("Ventas.BuscarTransportista");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Ventas.BuscarTransportista";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre_Buscado = new SqlParameter();
                ParNombre_Buscado.ParameterName = "@NombreBuscado";
                ParNombre_Buscado.SqlDbType = SqlDbType.VarChar;
                ParNombre_Buscado.Size = parTransportistas.Nombre_Buscado.Length;
                ParNombre_Buscado.Value = parTransportistas.Nombre_Buscado;
                SqlComando.Parameters.Add(ParNombre_Buscado);

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Ventas.BuscarTransportistas. " + ex.Message, ex);
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

        public string Insertar(DTransportistas parTransportistas)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Ventas.InsertarTransportista";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre_Empresa = new SqlParameter();
                ParNombre_Empresa.ParameterName = "@Nombre_Empresa";
                ParNombre_Empresa.SqlDbType = SqlDbType.VarChar;
                ParNombre_Empresa.Size = parTransportistas.Nombre_Empresa.Length;
                ParNombre_Empresa.Value = parTransportistas.Nombre_Empresa;
                SqlComando.Parameters.Add(ParNombre_Empresa);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@Direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = parTransportistas.Direccion.Length;
                ParDireccion.Value = parTransportistas.Direccion;
                SqlComando.Parameters.Add(ParDireccion);

                SqlParameter ParCiudad = new SqlParameter();
                ParCiudad.ParameterName = "@Ciudad";
                ParCiudad.SqlDbType = SqlDbType.VarChar;
                ParCiudad.Size = parTransportistas.Ciudad.Length;
                ParCiudad.Value = parTransportistas.Ciudad;
                SqlComando.Parameters.Add(ParCiudad);

                SqlParameter ParRegion = new SqlParameter();
                ParRegion.ParameterName = "@Region";
                ParRegion.SqlDbType = SqlDbType.VarChar;
                ParRegion.Size = parTransportistas.Region.Length;
                ParRegion.Value = parTransportistas.Region;
                SqlComando.Parameters.Add(ParRegion);

                SqlParameter ParPais = new SqlParameter();
                ParPais.ParameterName = "@Pais";
                ParPais.SqlDbType = SqlDbType.VarChar;
                ParPais.Size = parTransportistas.Pais.Length;
                ParPais.Value = parTransportistas.Pais;
                SqlComando.Parameters.Add(ParPais);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = parTransportistas.Telefono.Length;
                ParTelefono.Value = parTransportistas.Telefono;
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
                    Respuesta = "Ya existe un transportista con ese Nombre";
                }
                else if (ex.Number == 515)
                {
                    Respuesta = "Sólo puedes dejar vacíos los campos Región, País y Teléfono";
                }
                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado Ventas.InsertarTransportista. " + ex.Message;
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

        public string Eliminar(DTransportistas parTransportistas)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Ventas.EliminarTransportista";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId_Transportista = new SqlParameter();
                ParId_Transportista.ParameterName = "@Id_Transportista";
                ParId_Transportista.SqlDbType = SqlDbType.Int;
                ParId_Transportista.Value = parTransportistas.Id_Transportista;
                SqlComando.Parameters.Add(ParId_Transportista);

                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    Respuesta = "No puedes eliminar un transportista responsable de uno o varios Pedidos. Debes designar un nuevo responsable para los Pedidos de este transportista antes de eliminarlo.";
                }

                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado Ventas.EliminarTransportista. " + ex.Message;
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

        public string Editar(DTransportistas parTransportistas)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Ventas.EditarTransportista";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId_Transportista = new SqlParameter();
                ParId_Transportista.ParameterName = "@Id_Transportista";
                ParId_Transportista.SqlDbType = SqlDbType.Int;
                ParId_Transportista.Value = parTransportistas.Id_Transportista;
                SqlComando.Parameters.Add(ParId_Transportista);

                SqlParameter ParNombre_Empresa = new SqlParameter();
                ParNombre_Empresa.ParameterName = "@Nombre_Empresa";
                ParNombre_Empresa.SqlDbType = SqlDbType.VarChar;
                ParNombre_Empresa.Size = parTransportistas.Nombre_Empresa.Length;
                ParNombre_Empresa.Value = parTransportistas.Nombre_Empresa;
                SqlComando.Parameters.Add(ParNombre_Empresa);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@Direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = parTransportistas.Direccion.Length;
                ParDireccion.Value = parTransportistas.Direccion;
                SqlComando.Parameters.Add(ParDireccion);

                SqlParameter ParCiudad = new SqlParameter();
                ParCiudad.ParameterName = "@Ciudad";
                ParCiudad.SqlDbType = SqlDbType.VarChar;
                ParCiudad.Size = parTransportistas.Ciudad.Length;
                ParCiudad.Value = parTransportistas.Ciudad;
                SqlComando.Parameters.Add(ParCiudad);

                SqlParameter ParRegion = new SqlParameter();
                ParRegion.ParameterName = "@Region";
                ParRegion.SqlDbType = SqlDbType.VarChar;
                ParRegion.Size = parTransportistas.Region.Length;
                ParRegion.Value = parTransportistas.Region;
                SqlComando.Parameters.Add(ParRegion);

                SqlParameter ParPais = new SqlParameter();
                ParPais.ParameterName = "@Pais";
                ParPais.SqlDbType = SqlDbType.VarChar;
                ParPais.Size = parTransportistas.Pais.Length;
                ParPais.Value = parTransportistas.Pais;
                SqlComando.Parameters.Add(ParPais);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = parTransportistas.Telefono.Length;
                ParTelefono.Value = parTransportistas.Telefono;
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
                    Respuesta = "Ya existe un transportista con ese Nombre";
                }
                else if (ex.Number == 515)
                {
                    Respuesta = "Sólo puedes dejar vacíos los campos Región, País y Teléfono";
                }
                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado Ventas.EditarTransportista. " + ex.Message;
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