using System;
using CapaDatos;

namespace CapaNegocio
{
    public class CNPersonas
    {
        CDPersonas dal = new CDPersonas();

        public bool Login(string usuario, string clave)
        {
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
                return false;

            return dal.ValidarUsuario(usuario, clave);
        }
    }
}

