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
    public partial class Barrio : System.Web.UI.Page
    {
        String cs = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
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
                Id_localidad.DataValueField = "idLocalidad";
                Id_localidad.DataSource = tab;
                Id_localidad.DataBind();
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
                SqlDataAdapter adp = new SqlDataAdapter("select idBarrio as 'ID_BARRIO',nombreBarrio as 'NOMBRE_BARRIO', descripBarrio as 'DESCRIPCION_BARRIO', idLocalidad as 'ID_LOCALIDAD',  from Barrio", con);
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
        void refrescar()
        {
            Id_localidad.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            Id_localidad.Focus();
        }
        void Agregar()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into Barrio(idBarrio,nombreBarrio,descripBarrio,idLocalidad)values(@id_barrio,@nombre_barrio,@descripcion_barrio,@id_localidad)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id_barrio", TextBox1.Text);
                cmd.Parameters.AddWithValue("@nombre_barrio", TextBox2.Text);
                cmd.Parameters.AddWithValue("@descripcion_barrio", TextBox3.Text);
                cmd.Parameters.AddWithValue("@id_personal_entrega", Id_localidad.SelectedValue);
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
        void actualizar()
        {

            SqlConnection con = new SqlConnection(cs);
            con.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("update Barrio set nombreBarrio=@nombre_barrio,descripBarrio=@descripcion_barrio,idLocalidad=@id_localidad where idBarrio=" + TextBox1.Text, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@nombre_barrio", TextBox2.Text);
                cmd.Parameters.AddWithValue("@descripcion_barrio", TextBox3.Text);
                cmd.Parameters.AddWithValue("@id_localidad",Id_localidad.SelectedValue);
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
                SqlCommand cmd = new SqlCommand("update Pedido set estado=@estado where idBarrio=" + TextBox1.Text, con);
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
        protected void Page_Load(object sender, EventArgs e)
        {
            Id_Localidad();
            llenar();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            eliminar();
        }
    }
}