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
    public partial class Vehiculo : System.Web.UI.Page
    {
        String cs = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        void Id_Tipo_Vehiculo()
        {
            SqlConnection con;
            con = new SqlConnection(cs);
            con.Open();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select idTipoVehiculo, TipoVehiculo from TipoVehiculo", con);
                DataTable tab = new DataTable();
                tab.Clear();
                adp.Fill(tab);
                id_tipo_vehiculo.DataValueField = "idTipoVehiculo";
                id_tipo_vehiculo.DataTextField = "TipoVehiculo";
                id_tipo_vehiculo.DataSource = tab;
                id_tipo_vehiculo.DataBind();
            }
            catch (Exception e)
            {
                Response.Write("Error");
            }
            con.Close();
        }
        void Id_Personal_Entrega()
        {
            SqlConnection con;
            con = new SqlConnection(cs);
            con.Open();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select idPersonalEntrega,  from Pedido", con);
                DataTable tab = new DataTable();
                tab.Clear();
                adp.Fill(tab);
                idpersonalentrega.DataValueField = "idPersonalEntrega";
                idpersonalentrega.DataSource = tab;
                idpersonalentrega.DataBind();
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
                SqlDataAdapter adp = new SqlDataAdapter("select idVehiculo as 'ID_VEHICULO', Patente as 'PATENTE', Marca as'MARCA' Modelo as 'MODELO', idTipoVehiculo as 'ID_TIPO_VEHICULO', idPersonalEntrega as 'ID_PERSONAL_ENTREGA' from Vehiculo", conec);
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
                SqlCommand cmd = new SqlCommand("Insert into Vehiculo(idVehiculo,Patente,Marca,Modelo,idTipoVehiculo,idPersonalEntrega)values(@id_vehiculo,@patente,@marca,@modelo,@id_tipo_vehiculo,@id_personal_entrega)", conec);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id_vehiculo", TextBox1.Text);
                cmd.Parameters.AddWithValue("@patente", TextBox2.Text);
                cmd.Parameters.AddWithValue("@marca", TextBox3.Text);
                cmd.Parameters.AddWithValue("@modelo", TextBox4.Text);
                cmd.Parameters.AddWithValue("@id_tipo_vehiculo", id_tipo_vehiculo.SelectedValue);
                cmd.Parameters.AddWithValue("@id_personal_entrega", idpersonalentrega.SelectedValue);

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
            id_tipo_vehiculo.Text = "";
            TextBox4.Text = "";
            idpersonalentrega.Text = "";
            TextBox1.Focus();
        }
        void actualizar()
        {
            SqlConnection conec;
            conec = new SqlConnection(cs);
            conec.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update Vehiculo set Patente=@patente,Marca=@marca,Modelo=@nodelo,idTipoVehiculo=@id_tipo_vehiculo,idPersonalEntrega=@id_personal_entrega  where idVehiculo=" + TextBox1.Text, conec);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@patente", TextBox2.Text);
                cmd.Parameters.AddWithValue("@marca", TextBox3.Text);
                cmd.Parameters.AddWithValue("@modelo", TextBox4.Text);
                cmd.Parameters.AddWithValue("@id_tipo_vehiculo", id_tipo_vehiculo.SelectedValue);
                cmd.Parameters.AddWithValue("@id_personal_entrega", idpersonalentrega.SelectedValue);
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
                SqlCommand cmd = new SqlCommand("update Vehiculo set estado=@estado where idVehiculo=" + TextBox1.Text, conec);
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
            Id_Tipo_Vehiculo();
            Id_Personal_Entrega();
            Llenar();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            actualizar();
        }
    }
}