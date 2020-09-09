using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class NRestauracion
    {
        public static String GenerarBackUp()
        {
            return new DRestauracion().GenerarBackUp();
        }

        public static String RestaurarBackUp(String parNombreArchivo)
        {
            return new DRestauracion().RestaurarBackUp(parNombreArchivo);
        }
    }
}
