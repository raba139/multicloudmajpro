using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class DataOwnerPublicFiles : System.Web.UI.Page
{
    string ownername;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["OwnerName"] != null)
        {
            TextBox5.Text = Session["OwnerName"].ToString();
            ownername = Session["OwnerName"].ToString();
        }
    }
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Security"].ConnectionString.ToString());
    SqlCommand cmd;
    SqlDataAdapter da;
    DataTable dt = new DataTable();
    SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Security1"].ConnectionString.ToString());
    SqlCommand cmd1;
    SqlConnection con2 = new SqlConnection(ConfigurationManager.ConnectionStrings["Security2"].ConnectionString.ToString());
    SqlCommand cmd2;
    SqlConnection con3 = new SqlConnection(ConfigurationManager.ConnectionStrings["Security3"].ConnectionString.ToString());
    SqlCommand cmd3;
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        LinkButton lnkbtn = sender as LinkButton;
        GridViewRow gvrow = lnkbtn.NamingContainer as GridViewRow;
        // ID = Convert.ToInt32(GridView1.DataKeys[gvrow.RowIndex].Value.ToString());
        string ID = gvrow.Cells[0].Text;

        con.Open();
        cmd = new SqlCommand("delete from Server where FileID='" + ID + "'", con);
        cmd.ExecuteNonQuery();
        con.Close();

        con1.Open();
        cmd1 = new SqlCommand("delete from Server1 where FileID='" + ID + "'", con1);
        cmd1.ExecuteNonQuery();
        con1.Close();

        con2.Open();
        cmd2 = new SqlCommand("delete from Server2 where FileID='" + ID + "'", con2);
        cmd2.ExecuteNonQuery();
        con2.Close();

        con3.Open();
        cmd3 = new SqlCommand("delete from Server3 where FileID='" + ID + "'", con3);
        cmd3.ExecuteNonQuery();
        con3.Close();

        Response.Write("<script>alert('Deleted')</script>");
    }
}