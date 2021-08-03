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

namespace Formulario_de_clase.FORMULARIOS.MAESTROS
{
    public partial class Tipo_Productos : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;

        void TipoPizza()
        {
            SqlConnection conectar = new SqlConnection(cs);
            conectar.Open();

            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select idTipoPizza, NombreTipoPizza from TipoPizza", conectar);
                DataTable tab = new DataTable();

                tab.Clear();
                adp.Fill(tab);
                DropDownList1.DataTextField = "NombreTipoPizza";
                DropDownList1.DataValueField = "idTipoPizza";
                DropDownList1.DataSource = tab;
                DropDownList1.DataBind();


            }
            catch (Exception e)
            {

            }
        }

        void VariedadPizza()
        {
            SqlConnection conectar = new SqlConnection(cs);
            conectar.Open();

            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select idVariedadPizza, VP_Nombre from VariedadPizza", conectar);
                DataTable tab = new DataTable();

                tab.Clear();
                adp.Fill(tab);
                DropDownList2.DataTextField = "VP_Nombre";
                DropDownList2.DataValueField = "idVariedadPizza";
                DropDownList2.DataSource = tab;
                DropDownList2.DataBind();


            }
            catch (Exception e)
            {

            }
        }

        void TamañoPizza()
        {
            SqlConnection conectar = new SqlConnection(cs);
            conectar.Open();

            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select idTamañoPizza, TP_Nombre from TamañoPizza", conectar);
                DataTable tab = new DataTable();

                tab.Clear();
                adp.Fill(tab);
                DropDownList3.DataTextField = "TP_Nombre";
                DropDownList3.DataValueField = "idTamañoPizza";
                DropDownList3.DataSource = tab;
                DropDownList3.DataBind();


            }
            catch (Exception e)
            {

            }
        }

        /*void eliminar()
        {
            string estado = "INACTIVO";
            SqlConnection conec;
            conec = new SqlConnection(cs);
            conec.Open();

           

                try
                {
                    SqlCommand cmd = new SqlCommand("update proveedor set estado=@estado where codprov=" + txtcodproveedor.Text, conec);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.ExecuteNonQuery();

                    Response.Write("<script>alert('REGISTRO eliminado')</script>");
                    limpiar();
                    cargar();
                }
                catch (Exception e)
                {
                    Response.Write("ERROR");
                }
            
            conec.Close();
        }*/
        /*void actualizar()
        {
            SqlConnection conec;
            conec = new SqlConnection(cs);
            conec.Open();

            if (txtcorreo.Text == "")
            {
                Response.Write("DIGITE LA DESCRIPCION");
            }
            else
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("update proveedor set  codigo=@codigo, proveedor=@proveedor, direccion=@direccion, telefono=@telefono, correo=@correo  where codprov=" + txtcodproveedor.Text, conec);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@codigo", txtcodigo.Text);
                    cmd.Parameters.AddWithValue("@proveedor", txtproveedor.Text);
                    cmd.Parameters.AddWithValue("@direccion", txtdireccion.Text);
                    cmd.Parameters.AddWithValue("@telefono", txttelefono.Text);
                    cmd.Parameters.AddWithValue("@correo", txtcorreo.Text);
                    cmd.ExecuteNonQuery();

                    Response.Write("<script>alert('REGISTRO ACTUALIZADO')</script>");
                    limpiar();
                    cargar();
                }
                catch (Exception e)
                {
                    Response.Write("ERROR");
                }
            }
            conec.Close();
        }*/

        void cargar()
        {
            SqlConnection conec;
            conec = new SqlConnection(cs);
            conec.Open();

            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select idPizza as 'CODIGO DE PIZZA', Precio as 'PRECIO',idVariedadPizza as 'VARIEDAD DE PIZZA' from Pizza ", conec);
                DataTable tab = new DataTable();
                tab.Clear();
                adp.Fill(tab);
                tabla.DataSource = tab;
                tabla.DataBind();

            }
            catch(Exception e)
            {
                Response.Write("ERROR");
            }
            conec.Close();
        }
       
        /*void limpiar()
        {

            txtcodigo.Text = "";
           
            txtcodigo.Focus();
        }*/

      /*  void agregar()
        {
            string estado = "ACTIVO";
            SqlConnection conec;
            conec = new SqlConnection(cs);
            conec.Open();

            if (txtcodigo.Text == "")
            {
                Response.Write("DIGITE EL CODIGO");
            }
            else
            {



                try
                {
                    SqlCommand cmd = new SqlCommand("insert into proveedor(codprov, codigo, proveedor,direccion,telefono,correo,estado) values (@codprov,@codigo,@proveedor,@direccion,@telefono,@correo,@estado)", conec);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@codprov", txtcodproveedor.Text);
                    cmd.Parameters.AddWithValue("@codigo", txtcodigo.Text);
                    cmd.Parameters.AddWithValue("@proveedor", txtnombre.Text);
                    cmd.Parameters.AddWithValue("@direccion", txtprecio.Text);
                    cmd.Parameters.AddWithValue("@telefono", txttelefono.Text);
                    cmd.Parameters.AddWithValue("@correo", txtcorreo.Text);
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.ExecuteNonQuery();

                    Response.Write("<script>alert('REGISTRO ALMACENADO')</script>");
                    
                    cargar();       
                }

                catch (Exception e)
                {
                    Response.Write("ERROR");

                }
            }
            conec.Close();
        }*/
        protected void Page_Load(object sender, EventArgs e)
        {
            tabla.Visible = false;
            btnocultar_menu.Visible = false;
            cargar();
            TipoPizza();
            VariedadPizza();
            TamañoPizza();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
           // agregar();
           

        }
        protected void Button1_Click2(object sender, EventArgs e)
        {
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            tabla.Visible = true;
            btnmostrar_menu.Visible = false;
            btnocultar_menu.Visible = true;

            //actualizar();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //eliminar(); 
        }

        protected void tabla_SelectedIndexChanged(object sender, EventArgs e)
        {
          /*  txtid.Text = tabla.SelectedRow.Cells[2].Text;
            DropDownList1.SelectedValue = tabla.SelectedRow.Cells[3].Text;
            txtcontacto.Text = tabla.SelectedRow.Cells[4].Text;
            txtnombre.Text = tabla.SelectedRow.Cells[4].Text;*/
        }

        protected void btncancelar_Click(object sender, EventArgs e)
        {
           
        }

        protected void btnocultar_menu_Click(object sender, EventArgs e)
        {
            tabla.Visible = false;
            btnmostrar_menu.Visible = true;
            btnocultar_menu.Visible = false;
        }
    }
}