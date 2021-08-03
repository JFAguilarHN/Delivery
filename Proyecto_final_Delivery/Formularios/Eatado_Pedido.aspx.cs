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
    public partial class Eatado_Pedido : System.Web.UI.Page
    {
        String cs = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        void Llenar()
        {
            SqlConnection conec;
            conec = new SqlConnection(cs);
            conec.Open();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select idEstadoPedido as 'ID_ESTADO_PEDIDO', NomEstadoPedido as 'NOMBRE_ESTADO_PEDIDO', DescripEstadoPedido as 'DESCRIPCION_ESTADO_PEDIDO'  from EstadoPedido", conec);
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

        void refrescar()
        {
           
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox1.Focus();
        }
        void Agregar()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into EstadoPedido(idEstadoPedido,NomEstadoPedido,DescripEstadoPedido)values(@id_estado_pedido,@nombre_estado_pedido,@descripcion_estado_pedido)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id_estado_pedido", TextBox1.Text);
                cmd.Parameters.AddWithValue("@nombre_estado_pedido", TextBox2.Text);
                cmd.Parameters.AddWithValue("@descripcion_estado_pedido", TextBox3.Text);
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
        void actualizar()
        {

            SqlConnection con = new SqlConnection(cs);
            con.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("update EstadoPedido set NomEstadoPedido=@nombre_estado_pedido,DescripEstadoPedido=@descripcion_estado_pedido  where idEstadoPedido=" + TextBox1.Text, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@nombre_estado_pedido", TextBox2.Text);
                cmd.Parameters.AddWithValue("@descripcion_estado_pedido", TextBox3.Text);
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
                SqlCommand cmd = new SqlCommand("update EstadoPedido set estado=@estado where idEstadoPedido=" + TextBox1.Text, con);
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