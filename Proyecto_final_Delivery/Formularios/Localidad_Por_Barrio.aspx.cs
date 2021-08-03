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
    public partial class Localidad_Por_Barrio : System.Web.UI.Page
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
                idbarrio.DataValueField = "idBarrio";
                idbarrio.DataTextField = "nombreBarrio";
                idbarrio.DataSource = tab;
                idbarrio.DataBind();
            }
            catch (Exception e)
            {
                Response.Write("Error");
            }
            con.Close();
        }
        void Id_Localidad()
        {
            SqlConnection con;
            con = new SqlConnection(cs);
            con.Open();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select idLocalidad from Pedido", con);
                DataTable tab = new DataTable();
                tab.Clear();
                adp.Fill(tab);
                idlocalidad.DataValueField = "idLocalidad";
                idlocalidad.DataSource = tab;
                idlocalidad.DataBind();
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
                SqlCommand cmd = new SqlCommand("Insert into LocalidadXBarrio(idLocalidadXBarrio,idLocalidad,idBarrio)values(@id_localidad_por_barrio,@id_localidad,@id_barrio)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id_localidad_por_barrio", TextBox1.Text);
                cmd.Parameters.AddWithValue("@id_localidad", idlocalidad.SelectedValue);
                cmd.Parameters.AddWithValue("@id_barrio", idbarrio.SelectedValue);

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
                SqlDataAdapter adp = new SqlDataAdapter("select idLocalidadXBarrio as 'ID_LOCALIDAD_POR_BARRIO',idLocalidad as 'ID_LOCALIDAD', idBarrio as 'ID_BARRIO'  from localidadXBarrio", con);
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
                SqlCommand cmd = new SqlCommand("update LocalidadXBarrio set idLocalidad=@id_localidad,idBarrio=@id_barrio where idLocalidadXBarrio=" + TextBox1.Text, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id_localidad", idlocalidad.SelectedValue);
                cmd.Parameters.AddWithValue("@id_barrio", idbarrio.SelectedValue);
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
                SqlCommand cmd = new SqlCommand("update LocalidadXBarrio set estado=@estado where idLocalidadXBarrio=" + TextBox1.Text, con);
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
            idbarrio.Text = "";
            idlocalidad.Text = "";
            TextBox1.Focus();
        }
            protected void Page_Load(object sender, EventArgs e)
        {
            Id_Barrio();
            Id_Localidad();
            llenar();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void idlocalida_SelectedIndexChanged(object sender, EventArgs e)
        {

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