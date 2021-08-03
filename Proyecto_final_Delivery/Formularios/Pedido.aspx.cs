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
    public partial class Pedido : System.Web.UI.Page
    {
        String cs = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        void Llenar()
        {
            SqlConnection conec;
            conec = new SqlConnection(cs);
            conec.Open();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select idPedido as 'Idpedido', numeroPedido as 'Numero_Pedido', FechaCreacion as Fecha_Creacion', HoraCreacion as 'Hora_Creacion', idLocalidad as 'Id_Localidad', idPersonalEntrega as 'Id_Personal_Entrega', idEstadoPedido as 'Id_Estado_Pedido', idFactura as 'Id_Factura', NombreCliente as 'Nombre_Cliente', TelefonoCliente as 'Telefono_Cliente', idDetallePedido as 'Id_Detalle_Pedido' from Pedido", conec);
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
           
            SqlConnection conec;
            conec = new SqlConnection(cs);
            conec.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("Insert into Pedido(idPedido,numeroPedido,FechaCreacion,HoraCreacion,idLocalidad,idPersonalEntrega,idEstadoPedido,idFactura,NombreCliente,TelefonoCliente,idDetallePedido)values(@codigo_pedido,@numero_pedido,@fecha_creacion,@hora_creacion,@id_localidad,@id_personal_entrega,@id_estado_pedido,@id_factura,@nombre_cliente,@telefono_cliente,@id_detalle_pedido)", conec);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@codigo_pedido", TextBox1.Text);
                cmd.Parameters.AddWithValue("@numero_pedido", TextBox2.Text);
                cmd.Parameters.AddWithValue("@fecha_creacion", TextBox3.Text);
                cmd.Parameters.AddWithValue("@hora_creacion", TextBox4.Text);
                cmd.Parameters.AddWithValue("@id_localidad", TextBox5.Text);
                cmd.Parameters.AddWithValue("@id_personal_entrega", TextBox6.Text);
                cmd.Parameters.AddWithValue("@id_estado_pedido", TextBox7.Text);
                cmd.Parameters.AddWithValue("@id_factura", TextBox8.Text);
                cmd.Parameters.AddWithValue("@nombre_cliente", TextBox9.Text);
                cmd.Parameters.AddWithValue("@telefono_cliente", TextBox10.Text);
                cmd.Parameters.AddWithValue("@id_detalle_pedido", TextBox11.Text);
                cmd.ExecuteNonQuery();

                Response.Write("Registrto Almacenado");
                Llenar();
                Refrescar();

            }
            catch (Exception e)
            {
                Response.Write("Error");
            }
            conec.Close();
        }
        void Refrescar()
        {

            TextBox1.Text = "";
           TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
            TextBox1.Focus();
        }
        void actualizar()
        {
            SqlConnection conec;
            conec = new SqlConnection(cs);
            conec.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update Pedido set numeroPedido=@numero_pedido,FechaCreacion=@fecha_creacion,idLocalidad=@id_localidad,idPersonalEntrega=@id_personal_entrega,idEstadoPedido=@id_estado_pedido,idFactura=@id_factura,NombreCliente=@nombre_cliente,TelefonoCliente=@telefono_cliente,idDetallePedido=@id_detalle_pedido  where idPedido=" + TextBox1.Text, conec);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@numero_pedido", TextBox2.Text);
                cmd.Parameters.AddWithValue("@fecha_creacion", TextBox3.Text);
                cmd.Parameters.AddWithValue("@hora_creacion", TextBox4.Text);
                cmd.Parameters.AddWithValue("@id_localidad", TextBox5.Text);
                cmd.Parameters.AddWithValue("@id_personal_entrega", TextBox6.Text);
                cmd.Parameters.AddWithValue("@id_estado_pedido", TextBox7.Text);
                cmd.Parameters.AddWithValue("@id_factura", TextBox8.Text);
                cmd.Parameters.AddWithValue("@nombre_cliente", TextBox9.Text);
                cmd.Parameters.AddWithValue("@telefono_cliente", TextBox10.Text);
                cmd.Parameters.AddWithValue("@id_detalle_pedido", TextBox11.Text);

                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('Registro actualizado')</script>");
                Llenar();
            }
            catch
            {
                Response.Write("Error");
            }
            conec.Close();

        }
        void eliminar()
        {
            String estado = "INACTIVO";
            SqlConnection conec;
            conec = new SqlConnection(cs);
            conec.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update Pedido set estado=@estado where idPedido=" + TextBox1.Text, conec);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@estado", estado);
                Llenar();
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('Registro eliminado')</script>");
                Llenar();

            }
            catch
            {
                Response.Write("Error");
            }
            conec.Close();

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Calendar1.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox3.Text = Calendar1.SelectedDate.ToString();
            TextBox4.Text = Calendar1.SelectedDates.ToString();
        }
    }
}