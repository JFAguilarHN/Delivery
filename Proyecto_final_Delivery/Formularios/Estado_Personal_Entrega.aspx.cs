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
    public partial class Estado_Personal_Entrega : System.Web.UI.Page
    {
        String cs = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        void Id_Estado_personal_Entrega()
        {
            SqlConnection con;
            con = new SqlConnection(cs);
            con.Open();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select idEstadoPersonalEntrega from EstadoPersonalEntrega", con);
                DataTable tab = new DataTable();
                tab.Clear();
                adp.Fill(tab);
                id_estado_personal_entrega.DataValueField = "idEstadoPersonalEntrega";
                id_estado_personal_entrega.DataSource = tab;
                id_estado_personal_entrega.DataBind();
            }
            catch (Exception e)
            {
                Response.Write("Error");
            }
            con.Close();
        }
        void Llenar()
        {
            SqlConnection conec;
            conec = new SqlConnection(cs);
            conec.Open();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select idEstadoPersonalEntrega as 'ID_ESTADO_PERSONAL_ENTREGA', NombreEstPerEnt as 'NOMBRE_ESTADO_PERSONAL_ENTREGA', DescripEstPerEnt as 'DESCRIPCION_ESTADO_PERSONAL_ENTREGA'  from EstadoPersonalEntrega", conec);
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
            conec.Close();
        }
        void Agregar()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into EstadoPersonalEntrega(idEstadoPersonalEntrega,NombreEstPerEnt,DescripEstPerEnt)values(@id_estado_personal_entrega,@nombre_estado_personal_entrega,@descripcion_estado_personal_entrega)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id_estado_personal_entrega", id_estado_personal_entrega.SelectedValue);
                cmd.Parameters.AddWithValue("@nombre_estado_personal_entrega", TextBox1.Text);
                cmd.Parameters.AddWithValue("@descripcion_estado_personal_entrega", TextBox2.Text);
                cmd.ExecuteNonQuery();

                Response.Write("Registrto Almacenado");
                Llenar();
                refrescar();
            }
            catch (Exception e)
            {
                Response.Write("Error");
            }
            con.Close();
        }
        void refrescar()
        {
            id_estado_personal_entrega.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
            id_estado_personal_entrega.Focus();
        }
        void actualizar()
        {

            SqlConnection con = new SqlConnection(cs);
            con.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("update EstadoPersonalEntrega set idEstadoPersonalEntrega=@id_estado_personal_entrega,DescripEstPerEnt=@descripcion_estado_personal_entrega  where NombreEstPerEnt=" + TextBox1.Text, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@nombre_estado_pedido", id_estado_personal_entrega.SelectedValue);
                cmd.Parameters.AddWithValue("@descripcion_estado_pedido", TextBox2.Text);
                cmd.ExecuteNonQuery();

                Response.Write("<script>alert('Registro actualizado')</script>");
                Llenar();
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
                SqlCommand cmd = new SqlCommand("update EstadoPersonalEntrega set estado=@estado where NombreEstPerEnt=" + TextBox1.Text, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('Registro eliminado')</script>");
                Llenar();

            }
            catch
            {
                Response.Write("Error");
            }
            con.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Llenar();
            Id_Estado_personal_Entrega();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
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