using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{

    public class CNHabitaciones
    {
        CDHabitaciones habitaciones = new CDHabitaciones();
        public DataTable ObtenerHabitacionesN()
        {
            return habitaciones.ObtenerHabitaciones();
        }

        public bool agregar_habitaciones(int numero, string descripcion, int cant)
        {
            return habitaciones.AgregarHabitacion(numero, descripcion, cant);
            }

        public bool modificar_habitaciones(int id, int numero, string descripcion, int cant)
        {
            return habitaciones.ModificarHabitacion(id, numero, descripcion, cant);
        }

        public bool Eliminar_habitaciones(int id)
        {
            return habitaciones.EliminarHabitacion(id);
        }
    } 
}
