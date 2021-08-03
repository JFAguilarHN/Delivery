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
    public partial class Tipo_pizza : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;

        void agregar()
        {
            string estado = "ACTIVO";
            SqlConnection conec;
            conec = new SqlConnection(cs);
            conec.Open();

            if (txt_nombre.Text == "" || txt_descripcion.Text=="")
            {
                Response.Write("DIGITE EL CODIGO");
            }
            else
            {



                try
                {
                    SqlCommand cmd = new SqlCommand("insert into TipoPizza(NombreTipoPizza, DescripTipoPizza) values(@nombre,@descripcion)", conec);
                    cmd.CommandType = CommandType.Text;


                    cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                    cmd.Parameters.AddWithValue("@descripcion", txt_descripcion.Text);
                  
                    cmd.ExecuteNonQuery();

                    Response.Write("<script>alert('REGISTRO ALMACENADO')</script>");
                   

                }

                catch (Exception e)
                {
                    Response.Write("ERROR");

                }
            }
            conec.Close();
        }

        void cargar()
        {
            SqlConnection conec;
            conec = new SqlConnection(cs);
            conec.Open();

            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select idTipoPizza as 'ID TIPO DE PIZZA', NombreTipoPizza as 'NOMBRE TIPO DE PIZZA', DescripTipoPizza as 'DESCRIPCION' from TipoPizza ", conec);
                DataTable tab = new DataTable();
                tab.Clear();
                adp.Fill(tab);
                tabla.DataSource = tab;
                tabla.DataBind();

            }
            catch (Exception e)
            {
                Response.Write("ERROR");
            }
            conec.Close();
        }



        protected void Page_Load(object sender, EventArgs e)
        {
            cargar();
        }

        protected void btn_agregar_Click(object sender, EventArgs e)
        {
            agregar();
        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = "";
            txt_descripcion.Text = "";
        }

        protected void btn_salir_Click(object sender, EventArgs e)
        {

        }

        protected void tabla_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}