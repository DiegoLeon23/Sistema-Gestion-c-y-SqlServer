using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DRestauracion
    {
        public String GenerarBackUp()
        {
            String Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnMaster;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "dbo.GenerarBackUp";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (Exception ex)
            {
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado dbo.GenerarBackUp. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return Respuesta;
        }

        public String RestaurarBackUp(String parNombreArchivo)
        {
            String Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnMaster;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "dbo.RestaurarBackUp";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombreArchivo = new SqlParameter();
                ParNombreArchivo.ParameterName = "@NombreArchivo";
                ParNombreArchivo.SqlDbType = SqlDbType.VarChar;
                ParNombreArchivo.Size = parNombreArchivo.Length;
                ParNombreArchivo.Value = parNombreArchivo;
                SqlComando.Parameters.Add(ParNombreArchivo);

                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (Exception ex)
            {
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado dbo.RestaurarBackUp. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return Respuesta;
        }
    }
}
