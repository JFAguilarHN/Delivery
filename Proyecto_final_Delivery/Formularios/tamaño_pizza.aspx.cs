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

    public partial class tamaño_pizza : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;

        void agregar()
        {
            
            SqlConnection conec;
            conec = new SqlConnection(cs);
            conec.Open();

            if (txt_nombre.Text == "" || txt_cantporciones.Text == "")
            {
                Response.Write("DIGITE EL CODIGO");
            }
            else
            {



                try
                {
                    SqlCommand cmd = new SqlCommand("insert into TamañoPizza(TP_Nombre, TP_CantPorciones) values(@nombre,@porciones) ", conec);
                    cmd.CommandType = CommandType.Text;


                    cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text);
                    cmd.Parameters.AddWithValue("@porciones", txt_cantporciones.Text);

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
                SqlDataAdapter adp = new SqlDataAdapter("select idTamañoPizza as 'ID VARIEDAD DE PIZZA', TP_Nombre as 'NOMBRE TIPO DE PIZZA', TP_CantPorciones as 'CANTIDAD' from TamañoPizza ", conec);
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
            txt_cantporciones.Text = "";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            cargar();
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