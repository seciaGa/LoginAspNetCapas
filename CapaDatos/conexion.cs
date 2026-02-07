using System;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        private static string cadena =
            "Data Source=SECIA;Initial Catalog=LoginDB;Integrated Security=True";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}
