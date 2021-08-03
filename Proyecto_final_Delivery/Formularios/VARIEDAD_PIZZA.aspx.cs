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
    public partial class VARIEDAD_PIZZA : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;

        void agregar()
        {
            string estado = "ACTIVO";
            SqlConnection conec;
            conec = new SqlConnection(cs);
            conec.Open();

            if (txt_nombre.Text == "" || txt_ingrediente.Text == "")
            {
                Response.Write("DIGITE EL CODIGO");
            }
            else
            {



                try
                {
                    SqlCommand cmd = new SqlCommand("insert into VariedadPizza(VP_Nombre, Ingredientes) values(@nombre,@ingrediente)", conec);
                    cmd.CommandType = CommandType.Text;


                    cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                    cmd.Parameters.AddWithValue("@ingrediente", txt_ingrediente .Text);

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
                SqlDataAdapter adp = new SqlDataAdapter("select idVariedadPizza as 'ID VARIEDAD DE PIZZA', VP_Nombre as 'NOMBRE VARIEDAD DE PIZZA', Ingredientes as 'INGREDIENTES' from VariedadPizza ", conec);
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

        void limpiar()
        {
            txt_nombre.Text = "";
            txt_ingrediente.Text = "";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            cargar();
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btn_agregar_Click(object sender, EventArgs e)
        {
            agregar();
            cargar();
            limpiar();
        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}