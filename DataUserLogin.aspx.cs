using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class DataUserLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Security"].ConnectionString.ToString());
    SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Security"].ConnectionString.ToString());
    SqlCommand cmd;
    SqlDataReader dr;
    SqlDataReader dr1;
    SqlDataReader dr2;
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        cmd = new SqlCommand("select * from UserRegister where Name='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'", con);
        dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            con1.Open();
            cmd = new SqlCommand("select * from UserRegister where Name='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "' and Request='Accept'", con1);
            dr1 = cmd.ExecuteReader();
            if (dr1.Read())
            {
                Session["UserName"] = TextBox1.Text;
                Response.Redirect("DataUserHome.aspx");
            }
            else
            {
                Response.Write("<script>alert('Admin Not Accept Your Request')</script>");
            }
            con1.Close();
        }
        else
        {
            Response.Write("<script>alert('Invalid Username or Password')</script>");
        }
        con.Close();
    }
}