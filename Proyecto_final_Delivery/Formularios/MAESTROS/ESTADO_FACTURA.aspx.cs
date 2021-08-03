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
    public partial class ESTADO_FACTURA : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;

        void agregar()
        {
            
            SqlConnection conec;
            conec = new SqlConnection(cs);
            conec.Open();

            if (txt_estadofactura.Text == "")
            {
                Response.Write("DIGITE EL CODIGO");
            }
            else
            {



                try
                {
                    SqlCommand cmd = new SqlCommand("insert into EstadoFactura(EstadoFactura) values (@EstadoFactura)", conec);
                    cmd.CommandType = CommandType.Text;


                    cmd.Parameters.AddWithValue("@EstadoFactura", txt_estadofactura.Text);

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

        void limpiar()
        {
            txt_estadofactura.Text = "";
            txt_idestadofactura.Text = "";
        }
        void cargar()
        {
            SqlConnection conec;
            conec = new SqlConnection(cs);
            conec.Open();

            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select idEstadoFactura as 'ID ID ESTADO DE FACTURA', EstadoFactura as 'ESTADO FACTURA' from EstadoFactura ", conec);
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
            txt_idestadofactura.Enabled = false;
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

        protected void tabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_idestadofactura.Text = tabla.SelectedRow.Cells[1].Text;
            txt_estadofactura.Text = tabla.SelectedRow.Cells[2].Text;
        }
    }
}