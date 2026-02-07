using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion2
{
    public partial class Habitaciones : System.Web.UI.Page
    {
        CNHabitaciones _habitaciones = new CNHabitaciones();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGrid();
            }
        }

        private void CargarGrid()
        {
            gvHabitaciones.DataSource = _habitaciones.ObtenerHabitacionesN();
            gvHabitaciones.DataBind();


        }

        protected void btnguardar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtnumero.Text);
            string descripcion = txtdescripcion.Text;
            int cantidad = Convert.ToInt32(txtcant.Text);

            bool correcto = _habitaciones.agregar_habitaciones(numero, descripcion, cantidad);
            if (correcto)
            {
                Response.Write("<script>alert('Habitación agregada');</script>");
                CargarGrid();
            }else
            {
                Response.Write("<script>alert('Error al agregar');</script>");
            }
        }
    }
}