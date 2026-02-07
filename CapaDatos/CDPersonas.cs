using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDPersonas
    {
        public bool ValidarUsuario(string usuario, string clave)
        {
            bool existe = false;

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string sql = "SELECT COUNT(*) FROM Usuarios WHERE usuario = @u AND clave = @c";
                SqlCommand cmd = new SqlCommand(sql, cn);

                cmd.Parameters.AddWithValue("@u", usuario);
                cmd.Parameters.AddWithValue("@c", clave);

                cn.Open();
                int count = (int)cmd.ExecuteScalar();

                existe = count > 0;
            }

            return existe;
        }
    }
}

