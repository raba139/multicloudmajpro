using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class DataUserRegister : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Security"].ConnectionString.ToString());
    SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Security"].ConnectionString.ToString());
    SqlConnection con2 = new SqlConnection(ConfigurationManager.ConnectionStrings["Security"].ConnectionString.ToString());
    SqlConnection con3 = new SqlConnection(ConfigurationManager.ConnectionStrings["Security"].ConnectionString.ToString());
    SqlCommand cmd;
    SqlDataAdapter da;
    DataTable dt = new DataTable();
    SqlDataReader dr;
    SqlDataReader dr1;
    SqlDataReader dr2;
    DataSet ds = new DataSet();
    SqlConnection con4 = new SqlConnection(ConfigurationManager.ConnectionStrings["Security"].ConnectionString.ToString());
    SqlCommand cmd4;

    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        cmd = new SqlCommand("select * from UserRegister where Name='" + TextBox1.Text + "'", con);
        dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            Response.Write("<script>alert('Username already Exist')</script>");
        }
        else
        {
            con1.Open();
            cmd = new SqlCommand("select * from UserRegister where MobileNo='" + TextBox4.Text + "'", con1);
            dr1 = cmd.ExecuteReader();
            if (dr1.Read())
            {
                Response.Write("<script>alert('MobileNo already Exist')</script>");
            }
            else
            {
                con2.Open();
                cmd = new SqlCommand("select * from UserRegister where MailId='" + TextBox5.Text + "'", con2);
                dr2 = cmd.ExecuteReader();
                if (dr2.Read())
                {
                    Response.Write("<script>alert('MailId already Exist')</script>");
                }
                else
                {
                    con3.Open();
                    cmd = new SqlCommand("insert into UserRegister values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','Pending')", con3);
                    cmd.ExecuteNonQuery();
                    con3.Close();


                    Response.Write("<script>alert('Submited Successfully')</script>");
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";
                }
                dr2.Close();
                con2.Close();
            }
            dr1.Close();
            con1.Close();
        }
        dr.Close();
        con.Close();

    }
}