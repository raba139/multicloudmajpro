using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class CloudAdminDataOwnerDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Security"].ConnectionString.ToString());
    SqlCommand cmd;
    SqlDataAdapter da;
    DataTable dt = new DataTable();
    SqlDataReader dr;
    SqlConnection con4 = new SqlConnection(ConfigurationManager.ConnectionStrings["Security"].ConnectionString.ToString());
    SqlCommand cmd4;
    SqlConnection con5 = new SqlConnection(ConfigurationManager.ConnectionStrings["Security"].ConnectionString.ToString());
    SqlCommand cmd5;
    SqlDataReader dr5;

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        LinkButton lnkbtn = sender as LinkButton;
        GridViewRow gvrow = lnkbtn.NamingContainer as GridViewRow;
        // ID = Convert.ToInt32(GridView1.DataKeys[gvrow.RowIndex].Value.ToString());
        string name = gvrow.Cells[1].Text;
        con.Open();
        cmd = new SqlCommand("update OwnerRegister set Request='Accept' where Name='" + name + "'", con);
        cmd.ExecuteNonQuery();
        con.Close();
        
        Response.Write("<script>alert('Accepted')</script>");
        Response.Redirect("CloudAdminDataOwnerDetails.aspx");
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        LinkButton lnkbtn = sender as LinkButton;
        GridViewRow gvrow = lnkbtn.NamingContainer as GridViewRow;
        // ID = Convert.ToInt32(GridView1.DataKeys[gvrow.RowIndex].Value.ToString());
        string name = gvrow.Cells[1].Text;
        con.Open();
        cmd = new SqlCommand("update OwnerRegister set Request='Decline' where Name='" + name + "'", con);
        cmd.ExecuteNonQuery();
        con.Close();

        Response.Write("<script>alert('Declined')</script>");
        Response.Redirect("CloudAdminDataOwnerDetails.aspx");
    }
}