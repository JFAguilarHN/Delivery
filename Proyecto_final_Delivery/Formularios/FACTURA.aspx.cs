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
    public partial class FACTURA : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;

        void EstadoFactura()
        {
            SqlConnection conectar = new SqlConnection(cs);
            conectar.Open();

            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select idEstadoFactura, EstadoFactura from EstadoFactura", conectar);
                DataTable tab = new DataTable();

                tab.Clear();
                adp.Fill(tab);
                DropDownList1.DataTextField = "EstadoFactura";
                DropDownList1.DataValueField = "idEstadoFactura";
                DropDownList1.DataSource = tab;
                DropDownList1.DataBind();


            }
            catch (Exception e)
            {

            }
        }

        void correlativo()
        {
            SqlConnection conec;
            conec = new SqlConnection(cs);
            conec.Open();

            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select ISNULL(max(cast(Num_Factura as numeric)),0)+1 as nuevo from Factura", conec);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                txt_num_factura.Text = Convert.ToString(ds.Tables[0].Rows[0]["nuevo"]);
            }
            catch (Exception e)
            {
                Response.Write("ERROR");
            }
            conec.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            txt_fecha.Text = DateTime.Now.ToShortDateString();
            txt_hora.Text = DateTime.Now.ToString("HH:mm:ss");
            correlativo();
            EstadoFactura();
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
          
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}