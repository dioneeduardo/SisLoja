using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SisLojaWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection();
            SqlDataReader dr;

            con.ConnectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=SisLoja;Integrated Security=True";
            cmd.Connection = con;
            con.Open();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.CommandText = "ValidaUsuario";
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@Login", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@Senha", txtSenha.Text);

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Response.Write("Ok");
            }
            con.Close();

        }
    }
}