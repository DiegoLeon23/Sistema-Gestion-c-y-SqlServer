using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DConexion
    {
        public static String CnBDEmpresa = "Data Source=LAPTOP-VJF9JH6S\\SQLEXPRESS; Initial Catalog=BDEmpresa; Integrated Security=TRUE;";
        public static String CnMaster = "Data Source=LAPTOP-VJF9JH6S\\SQLEXPRESS; Initial Catalog=master; Integrated Security=TRUE;";

        public String ChequearConexion()
        {
            String mensaje = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();
                mensaje = "Y";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                SqlConexion.Close();
            }

            return mensaje;
        }
    }

}