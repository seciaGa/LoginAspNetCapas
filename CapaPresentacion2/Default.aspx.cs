using CapaNegocio;
using System;
using System.Web.UI;

namespace CapaPresentacion2
{
    public partial class _Default : Page
    {
        CNPersonas bll = new CNPersonas();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            bool acceso = bll.Login(txtUsuario.Text, txtClave.Text);

            if (acceso)
            {
                Session["usuario"] = txtUsuario.Text;
                Response.Redirect("Principal.aspx");
            }
            else
            {
                lblMensaje.Text = "Usuario o clave incorrectos";
            }
        }

        protected void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
        }
    }
}
