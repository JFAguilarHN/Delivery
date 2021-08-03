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
    public partial class Localidad : System.Web.UI.Page
    {
        String cs = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        void Id_Localidad()
        {
            SqlConnection con;
            con = new SqlConnection(cs);
            con.Open();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select idLocalidad,  from Pedido", con);
                DataTable tab = new DataTable();
                tab.Clear();
                adp.Fill(tab);
                id_localidad.DataValueField = "idLocalidad";
                id_localidad.DataSource = tab;
                id_localidad.DataBind();
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
                SqlDataAdapter adp = new SqlDataAdapter("select idLocalidad as 'ID_LOCALIDAD', NombreLocalidad as 'NOMBRE_LOCALIDAD', codigoPostal as 'CODIGO_POSTAL'  from localidad", con);
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
        void Agregar()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into Localidad(idLocalidad,NombreLocalidad,codigoPostal)values(@id_localidad,@nombre_localidad,@codigo_postal)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id_localidad", id_localidad.SelectedValue);
                cmd.Parameters.AddWithValue("@nombre_localidad", TextBox1.Text);
                cmd.Parameters.AddWithValue("@codigo_postal", TextBox2.Text);
                cmd.ExecuteNonQuery();

                Response.Write("Registro Almacenado");
                llenar();
                refrescar();
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
                SqlCommand cmd = new SqlCommand("update Localidad set idLocalidad=@id_localidad,codigoPostal=@codigo_postal where NombreLocalidad=" + TextBox1.Text, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id_localidad", id_localidad.SelectedValue);
                cmd.Parameters.AddWithValue("@codigo_postal", TextBox2.Text);
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
                SqlCommand cmd = new SqlCommand("update Localidad set estado=@estado where NombreLocalidad=" + TextBox1.Text, con);
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
            id_localidad.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
            id_localidad.Focus();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Id_Localidad();
            llenar();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Agregar();
        }
    }
}