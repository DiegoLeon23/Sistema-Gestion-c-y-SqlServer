using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class NConexion
    {
        public static String ChequearConexion()
        {
            return new DConexion().ChequearConexion();
        }
    }
}
