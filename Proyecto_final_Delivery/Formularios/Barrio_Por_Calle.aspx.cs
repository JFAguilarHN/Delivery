using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;
using System.Collections;
using System.Data;
using System.Data.SqlClient;


namespace Proyecto_final_Delivery.Formularios
{
    public partial class Barrio_Por_Calle : System.Web.UI.Page
    {
        String cs = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        void Id_Barrio()
        {
            SqlConnection con;
            con = new SqlConnection(cs);
            con.Open();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select idBarrio, nombreBarrio from Barrio", con);
                DataTable tab = new DataTable();
                tab.Clear();
                adp.Fill(tab);
                id_barrio.DataValueField = "idBarrio";
                id_barrio.DataTextField = "nombreBarrio";
                id_barrio.DataSource = tab;
                id_barrio.DataBind();
            }
            catch (Exception e)
            {
                Response.Write("Error");
            }
            con.Close();
        }
        void Id_Calle()
        {
            SqlConnection con;
            con = new SqlConnection(cs);
            con.Open();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select idCalle, nombreCalle from Calle", con);
                DataTable tab = new DataTable();
                tab.Clear();
                adp.Fill(tab);
                id_calle.DataValueField = "idCalle";
                id_calle.DataTextField = "nombreCalle";
                id_calle.DataSource = tab;
                id_calle.DataBind();
            }
            catch (Exception e)
            {
                Response.Write("Error");
            }
            con.Close();
        }
        void Agregar()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into BarrioXCalle(idBarrioXCalle,idBarrio,idCalle)values(@id_barrio_por_calle,@id_barrio,@id_calle)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id_barrio_por_calle", TextBox1.Text);
                cmd.Parameters.AddWithValue("@id_barrio",id_barrio.SelectedValue);
                cmd.Parameters.AddWithValue("@id_calle", id_calle.SelectedValue);

                cmd.ExecuteNonQuery();

                Response.Write("Registrto Almacenado");
                llenar();
                refrescar();
            }
            catch (Exception e)
            {
                Response.Write("Error");
            }
            con.Close();
        }
        void llenar()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select idBarrioXCalle as 'ID_BARRIO_POR_CALLE',idBarrio as 'ID_BARRIO', idCalle as 'ID_CALLE'  from BarrioXCalle", con);
                DataTable tab = new DataTable();
                tab.Clear();
                adp.Fill(tab);
                tabla.DataSource = tab;
                tabla.DataBind();
            }
            catch (Exception e)
            {
                Response.Write("Error");
            }
            con.Close();
        }
        void actualizar()
        {

            SqlConnection con = new SqlConnection(cs);
            con.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("update BarrioXCalle set idBarrio=@id_barrio,idCalle=@id_calle  where idBarrioXCalle=" + TextBox1.Text, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id_barrio", id_barrio.SelectedValue);
                cmd.Parameters.AddWithValue("@id_calle", id_calle.SelectedValue);
                cmd.ExecuteNonQuery();

                Response.Write("<script>alert('Registro actualizado')</script>");
                llenar();
            }
            catch
            {
                Response.Write("Error");
            }
            con.Close();
        }
        void eliminar()
        {
            String estado = "INACTIVO";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("update BarrioXCalle set estado=@estado where idBarrioXCalle=" + TextBox1.Text, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('Registro eliminado')</script>");
                llenar();

            }
            catch
            {
                Response.Write("Error");
            }
            con.Close();
        }
        void refrescar()
        {
            TextBox1.Text = "";
            id_barrio.Text = "";
            id_calle.Text = "";
            TextBox1.Focus();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Id_Barrio();
            Id_Calle();
            llenar();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            actualizar();
        }
    }
}