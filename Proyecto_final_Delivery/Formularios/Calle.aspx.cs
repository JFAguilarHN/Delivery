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
    public partial class Calle : System.Web.UI.Page
    {
        String cs = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        void Id_Barrio()
        {
            SqlConnection con;
            con = new SqlConnection(cs);
            con.Open();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select idBarrio from Barrio", con);
                DataTable tab = new DataTable();
                tab.Clear();
                adp.Fill(tab);
                id_barrio.DataValueField = "idBarrio";
                id_barrio.DataSource = tab;
                id_barrio.DataBind();
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
                SqlDataAdapter adp = new SqlDataAdapter("select idCalle as 'ID_CALLE',nombreCalle as 'NOMBRE_CALLE', descripCalle as 'DESCRIPCION_CALLE', idBarrio as 'ID_BARRIO' from Calle", con);
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
                SqlCommand cmd = new SqlCommand("Insert into Calle(idCalle,nombreCalle,descripCalle,idBarrio)values(@id_calle,@nombre_calle,@descripcion_calle,@id_barrio)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id_calle", TextBox1.Text);
                cmd.Parameters.AddWithValue("@nombre_calle", TextBox2.Text);
                cmd.Parameters.AddWithValue("@descripcion_calle", TextBox3.Text);
                cmd.Parameters.AddWithValue("@id_barrio", id_barrio.SelectedValue);
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
                SqlCommand cmd = new SqlCommand("update Calle set nombreCalle=@nombre_calle,descripCalle=@descripcion_calle,idBarrio=@id_Barrio where idCalle=" + TextBox1.Text, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@nombre_calle", TextBox2.Text);
                cmd.Parameters.AddWithValue("@descripcion_calle", TextBox3.Text);
                cmd.Parameters.AddWithValue("@id_barrio", id_barrio.SelectedValue);
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
                SqlCommand cmd = new SqlCommand("update Calle set estado=@estado where idCalle=" + TextBox1.Text, con);
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
            id_barrio.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            id_barrio.Focus();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Id_Barrio();
            llenar();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Agregar();
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