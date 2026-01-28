using System;
using CapaNegocio;

namespace CapaPresentacion2
{
    public partial class Principal : System.Web.UI.Page
    {
        CNPersonas cn = new CNPersonas();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text.Trim();

            bool loginCorrecto = cn.Login(usuario, clave);

            if (loginCorrecto)
            {
                lblMensaje.ForeColor = System.Drawing.Color.Green;
                lblMensaje.Text = "Bienvenido al sistema";

              
            }
            else
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Text = "Usuario o clave incorrectos";
            }
        }
    }
}
