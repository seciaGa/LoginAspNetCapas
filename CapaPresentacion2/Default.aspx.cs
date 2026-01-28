using System;
using CapaNegocio;

namespace CapaPresentacion2
{
    public partial class _Default : System.Web.UI.Page
    {
        CNPersonas negocio = new CNPersonas();

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            bool correcto = negocio.Login(
                txtUsuario.Text.Trim(),
                txtClave.Text.Trim()
            );

            if (correcto)
            {
                lblMensaje.ForeColor = System.Drawing.Color.Green;
                lblMensaje.Text = "Usuario y clave correctos";
            }
            else
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Text = "Usuario o clave incorrectos";
            }
        }
    }
}
