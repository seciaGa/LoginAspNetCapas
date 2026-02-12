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
            dgvHabitaciones.DataSource = _habitaciones.ObtenerHabitacionesN();
            dgvHabitaciones.DataBind();


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

        protected void dgvHabitaciones_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            dgvHabitaciones.EditIndex = -1;
            CargarGrid();

        }

        protected void dgvHabitaciones_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(dgvHabitaciones.DataKeys[e.RowIndex].Value);
            if(_habitaciones.Eliminar_habitaciones(id))
            {
                Response.Write("<script>alert('Habitación eliminada');</script>");
                CargarGrid();
            }
            else
            {
                Response.Write("<script>alert('Error al eliminar');</script>");
            }

        }

        protected void dgvHabitaciones_RowEditing(object sender, GridViewEditEventArgs e)
        {
            dgvHabitaciones.EditIndex = e.NewEditIndex;
            CargarGrid();
        }

        protected void dgvHabitaciones_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(dgvHabitaciones.DataKeys[e.RowIndex].Value);
            GridViewRow row = dgvHabitaciones.Rows[e.RowIndex];

            int numero = int.Parse((row.Cells[1].Controls[0] as System.Web.UI.WebControls.TextBox).Text);
            string descripcion = (row.Cells[2].Controls[0] as System.Web.UI.WebControls.TextBox).Text;
            int cantidad = int.Parse((row.Cells[3].Controls[0] as System.Web.UI.WebControls.TextBox).Text);

            if (_habitaciones.modificar_habitaciones(id, numero, descripcion, cantidad))
            {
                Response.Write("<script>alert('Habitación modificada');</script>");
                dgvHabitaciones.EditIndex = -1;
                CargarGrid();
            }
            else
            {
                Response.Write("<script>alert('Error al modificar');</script>");
            }

        }

        protected void gvHabitaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}