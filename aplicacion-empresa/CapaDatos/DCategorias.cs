using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DCategorias
    {
        public int Id_Categoria { get; set; }
        public String Nombre_Categoria { get; set; }
        public String Descripcion { get; set; }
        public String Nombre_Buscado { get; set; }

        public DCategorias()
        {

        }

        public DCategorias(int parId_Categoria, String parNombre_Categoria, String parDescripcion, String parNombre_Categoria_Buscado)
        {
            this.Id_Categoria = parId_Categoria;
            this.Nombre_Categoria = parNombre_Categoria;
            this.Descripcion = parDescripcion;
            this.Nombre_Buscado = parNombre_Categoria_Buscado;
        }

        public DataTable ListaCategorias()
        {
            DataTable TablaDatos = new DataTable("Produccion.Categorias");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Produccion.ListaCategorias";
                SqlComando.CommandType = CommandType.StoredProcedure;
                
                SqlComando.ExecuteNonQuery();

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Produccion.ListaCategorias. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return TablaDatos;
        }

        public DataTable Mostrar(int parNumeroPagina, int parRegistrosPorPagina)
        {
            DataTable TablaDatos = new DataTable("Produccion.Categorias");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Produccion.MostrarCategorias";
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
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Produccion.MostrarCategorias. " + ex.Message, ex);
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
                SqlComando.CommandText = "Produccion.TamañoCategorias";
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
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Produccion.TamañoCategorias. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return totalPaginas;
        }

        public DataTable Buscar(DCategorias parCategorias)
        {
            DataTable TablaDatos = new DataTable("Produccion.Categorias");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Produccion.BuscarCategoria";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre_Buscado = new SqlParameter();
                ParNombre_Buscado.ParameterName = "@NombreBuscado";
                ParNombre_Buscado.SqlDbType = SqlDbType.VarChar;
                ParNombre_Buscado.Size = parCategorias.Nombre_Buscado.Length;
                ParNombre_Buscado.Value = parCategorias.Nombre_Buscado;
                SqlComando.Parameters.Add(ParNombre_Buscado);

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Produccion.BuscarCategoria. " + ex.Message, ex);
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

        public string Insertar(DCategorias parCategorias)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Produccion.InsertarCategoria";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre_Categoria = new SqlParameter();
                ParNombre_Categoria.ParameterName = "@Nombre_Categoria";
                ParNombre_Categoria.SqlDbType = SqlDbType.VarChar;
                ParNombre_Categoria.Size = parCategorias.Nombre_Categoria.Length;
                ParNombre_Categoria.Value = parCategorias.Nombre_Categoria;
                SqlComando.Parameters.Add(ParNombre_Categoria);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = parCategorias.Descripcion.Length;
                ParDescripcion.Value = parCategorias.Descripcion;
                SqlComando.Parameters.Add(ParDescripcion);

                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (SqlException ex)
            {
                if (ex.Number == 8152)
                {
                    Respuesta = "Has introducido demasiados caracteres en uno de los campos.";
                }
                else if (ex.Number == 2627)
                {
                    Respuesta = "Ya existe una categoría con ese Nombre.";
                }
                else if (ex.Number == 515)
                {
                    Respuesta = "No puedes dejar el campo Nombre vacío.";
                }
                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado Produccion.InsertarCategoria. " + ex.Message;
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

        public string Eliminar(DCategorias parCategorias)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Produccion.EliminarCategoria";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId_Categoria = new SqlParameter();
                ParId_Categoria.ParameterName = "@Id_Categoria";
                ParId_Categoria.SqlDbType = SqlDbType.Int;
                ParId_Categoria.Value = parCategorias.Id_Categoria;
                SqlComando.Parameters.Add(ParId_Categoria);

                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    Respuesta = "No puedes eliminar una categoría que cuenta con Productos. Debes eliminar o actualizar sus Productos antes de eliminar la categoría.";
                }

                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado Produccion.EliminarCategoria. " + ex.Message;
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

        public string Editar(DCategorias parCategorias)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Produccion.EditarCategoria";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId_Categoria = new SqlParameter();
                ParId_Categoria.ParameterName = "@Id_Categoria";
                ParId_Categoria.SqlDbType = SqlDbType.Int;
                ParId_Categoria.Value = parCategorias.Id_Categoria;
                SqlComando.Parameters.Add(ParId_Categoria);

                SqlParameter ParNombre_Categoria = new SqlParameter();
                ParNombre_Categoria.ParameterName = "@Nombre_Categoria";
                ParNombre_Categoria.SqlDbType = SqlDbType.VarChar;
                ParNombre_Categoria.Size = parCategorias.Nombre_Categoria.Length;
                ParNombre_Categoria.Value = parCategorias.Nombre_Categoria;
                SqlComando.Parameters.Add(ParNombre_Categoria);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = parCategorias.Descripcion.Length;
                ParDescripcion.Value = parCategorias.Descripcion;
                SqlComando.Parameters.Add(ParDescripcion);

                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (SqlException ex)
            {
                if (ex.Number == 8152)
                {
                    Respuesta = "Has introducido demasiados caracteres en uno de los campos.";
                }
                else if (ex.Number == 2627)
                {
                    Respuesta = "Ya existe una categoría con ese Nombre.";
                }
                else if (ex.Number == 515)
                {
                    Respuesta = "No puedes dejar el campo Nombre vacío.";
                }
                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado Produccion.EditarCategoria. " + ex.Message;
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