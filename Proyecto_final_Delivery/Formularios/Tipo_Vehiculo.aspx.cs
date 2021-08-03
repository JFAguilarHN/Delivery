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
    public partial class Tipo_Vehiculo : System.Web.UI.Page
    {
        String cs = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        void llenar()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select idTipoVehiculo as 'ID_TIPO_VEHICULO',TipoVehiculo as 'TIPO_VEHICULO' from TipoVehiculo", con);
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
                SqlCommand cmd = new SqlCommand("Insert into TipoVehiculo(idTipoVehiculo,TipoVehiculo)values(@id_tipo_vehiculo,@tipo_vehiculo)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id_tipo_vehiculo", TextBox1.Text);
                cmd.Parameters.AddWithValue("@tipo_vehiculo", TextBox2.Text);
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
                SqlCommand cmd = new SqlCommand("update TipoVehiculo set TipoVehiculo=@tipo_vehiculo where idTipoVehiculo=" + TextBox1.Text, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@tipo_vehiculo", TextBox2.Text);
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
                SqlCommand cmd = new SqlCommand("update TipoVehiculo set estado=@estado where idTipoVehiculo=" + TextBox1.Text, con);
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
            TextBox2.Text = "";
            TextBox1.Focus();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
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