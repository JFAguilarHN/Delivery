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
    public partial class Personal_Entrega : System.Web.UI.Page
    {
        String cs = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        void personal_entega()
        {
            SqlConnection con;
            con = new SqlConnection(cs);
            con.Open();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select idPersonalEntrega from Pedido", con);
                DataTable tab = new DataTable();
                tab.Clear();
                adp.Fill(tab);
                id_personal_entrega.DataValueField = "idPersonalEntrega";
                id_personal_entrega.DataSource = tab;
                id_personal_entrega.DataBind();
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
                SqlDataAdapter adp = new SqlDataAdapter("select idPersonalEntrega as 'ID_PERSONAL_ENTREGA', NumCarnet as 'NUMERO_DE_CARNET', FechaVencimientoCarnet as 'FECHA_VENCIMIENTO_CARNET', idEstadoPersonalEntrega as 'ID_ESTADO_PERSONAL_ENTREGA',  from PersonalEntrega", con);
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
                SqlCommand cmd = new SqlCommand("Insert into PersonalEntrega(idPersonalEntrega,NumCarnet,FechaVencimientoCarnet,idEstadoPersonalEntrega)values(@id_personal_entrega,@numero_de_carnet,@fecha_vencimiento_carnet,@id_estado_personal_entrega)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id_personal_entrega", id_personal_entrega.SelectedValue);
                cmd.Parameters.AddWithValue("@numero_de_carnt", TextBox1.Text);
                cmd.Parameters.AddWithValue("@fecha_vencimiento_carnet", TextBox2.Text);
                cmd.Parameters.AddWithValue("@id_estado_personal_entrega", TextBox3.Text);
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
                SqlCommand cmd = new SqlCommand("update PersonalEntrega set idPersonalEntrega=@id_personal_entrega,NumCarnet=@numero_de_carnt,FechaVencimientoCarnet=@fecha_vencimiento_carnet,idEstadoPersonalEntrega=@id_estado_personal_entrega where NumCarnet=" + TextBox1.Text, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id_personal_entrega", id_personal_entrega.SelectedValue);
                cmd.Parameters.AddWithValue("@fecha_vencimiento_carnet", TextBox2.Text);
                cmd.Parameters.AddWithValue("@id_estado_personal_entrega", TextBox3.Text);
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
                SqlCommand cmd = new SqlCommand("update PersonalEntrega set estado=@estado where NumCarnet=" + TextBox1.Text, con);
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
          id_personal_entrega.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            id_personal_entrega.Focus();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            personal_entega();
            llenar();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox2.Text = Calendar1.SelectedDate.ToString();
        }
    }
}