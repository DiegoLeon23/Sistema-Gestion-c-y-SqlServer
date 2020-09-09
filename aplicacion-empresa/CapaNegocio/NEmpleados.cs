using System;
using System.Collections.Generic;
using System.Data;
using CapaDatos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NEmpleados
    {
        public static DataTable ListaEmpleados()
        {
            return new DEmpleados().ListaEmpleados();
        }

        public static DataTable Mostrar(int parNumeroPagina, int parRegistrosPorPagina)
        {
            return new DEmpleados().Mostrar(parNumeroPagina, parRegistrosPorPagina);
        }

        public static int Tamaño(int parRegistrosPorPagina)
        {
            return new DEmpleados().Tamaño(parRegistrosPorPagina);
        }


        public static DataTable Buscar(String parApellido_Buscado)
        {
            DEmpleados empleados = new DEmpleados();
            empleados.Apellido_Buscado = parApellido_Buscado;
            
            return empleados.Buscar(empleados);
        }

        public static String Eliminar(int parId_Empleado)
        {
            DEmpleados empleado = new DEmpleados();
            empleado.Id_Empleado = parId_Empleado;

            return empleado.Eliminar(empleado);
        }

        public static String Insertar(String parNombre_Empleado, String parApellido_Empleado,
            String parDireccion, String parCiudad, String parRegion, String parPais, 
            String parTelefono)
        {
            DEmpleados empleado = new DEmpleados();
            empleado.Nombre_Empleado = parNombre_Empleado;
            empleado.Apellido_Empleado = parApellido_Empleado;
            empleado.Direccion = parDireccion;
            empleado.Ciudad = parCiudad;
            empleado.Region = parRegion;
            empleado.Pais = parPais;
            empleado.Telefono = parTelefono;

            return empleado.Insertar(empleado);
        }

        public static String Editar(int parId_Empleado, String parNombre_Empleado, String parApellido_Empleado,
            String parDireccion, String parCiudad, String parRegion, String parPais,
            String parTelefono)
        {
            DEmpleados empleado = new DEmpleados();
            empleado.Id_Empleado = parId_Empleado;
            empleado.Nombre_Empleado = parNombre_Empleado;
            empleado.Apellido_Empleado = parApellido_Empleado;
            empleado.Direccion = parDireccion;
            empleado.Ciudad = parCiudad;
            empleado.Region = parRegion;
            empleado.Pais = parPais;
            empleado.Telefono = parTelefono;

            return empleado.Editar(empleado);
        } 
    }
}
