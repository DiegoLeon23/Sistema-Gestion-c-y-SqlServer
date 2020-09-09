using System;
using System.Collections.Generic;
using System.Data; //Importamos para DataTable
using CapaDatos; //Importamos para DEmpleados
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NTransportistas
    {
        public static DataTable ListaTransportistas()
        {
            return new DTransportistas().ListaTransportistas();
        }

        public static DataTable Mostrar(int parNumeroPagina, int parRegistrosPorPagina)
        {
            return new DTransportistas().Mostrar(parNumeroPagina, parRegistrosPorPagina);
        }

        public static int Tamaño(int parRegistrosPorPagina)
        {
            return new DTransportistas().Tamaño(parRegistrosPorPagina);
        }


        public static DataTable Buscar(String parNombre_Buscado)
        {
            DTransportistas transportistas = new DTransportistas();
            transportistas.Nombre_Buscado = parNombre_Buscado;

            return transportistas.Buscar(transportistas);
        }

        public static String Eliminar(int parId_Transportista)
        {
            DTransportistas transportistas = new DTransportistas();
            transportistas.Id_Transportista = parId_Transportista;

            return transportistas.Eliminar(transportistas);
        }

        public static String Insertar(String parNombre_Empresa, String parDireccion, String parCiudad, 
            String parRegion, String parPais, String parTelefono)
        {
            DTransportistas transportistas = new DTransportistas();
            transportistas.Nombre_Empresa = parNombre_Empresa;
            transportistas.Direccion = parDireccion;
            transportistas.Ciudad = parCiudad;
            transportistas.Region = parRegion;
            transportistas.Pais = parPais;
            transportistas.Telefono = parTelefono;

            return transportistas.Insertar(transportistas);
        }

        public static String Editar(int parId_Transportista, String parNombre_Empresa, String parDireccion, 
            String parCiudad, String parRegion, String parPais, String parTelefono)
        {
            DTransportistas transportistas = new DTransportistas();
            transportistas.Id_Transportista = parId_Transportista;
            transportistas.Nombre_Empresa = parNombre_Empresa;
            transportistas.Direccion = parDireccion;
            transportistas.Ciudad = parCiudad;
            transportistas.Region = parRegion;
            transportistas.Pais = parPais;
            transportistas.Telefono = parTelefono;

            return transportistas.Editar(transportistas);
        }
    }
}
