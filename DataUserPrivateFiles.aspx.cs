using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class DataUserPrivateFiles : System.Web.UI.Page
{
    string username;
    string filename;
    int fileid;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] != null)
        {
            TextBox5.Text = Session["UserName"].ToString();
            username = Session["UserName"].ToString();
        }
    }
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Security"].ConnectionString.ToString());
    SqlCommand cmd;
    SqlDataAdapter da;
    DataTable dt = new DataTable();
    SqlDataReader dr;
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        GridViewRow grdrow = (GridViewRow)((LinkButton)sender).NamingContainer;

        String fileid = grdrow.Cells[0].Text;
        string filename = grdrow.Cells[1].Text;
        string ownername = null;

        con.Open();
        cmd = new SqlCommand("select OwnerName from Server where FileID='" + fileid + "'", con);
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            ownername = dr[0].ToString();
        }
        con.Close();

        con.Open();
        cmd = new SqlCommand("insert into FileRequest values('" + username + "','" + ownername + "','" + fileid + "','" + filename + "','" + DateTime.Now.ToString() + "','Pending')", con);
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Write("<script>alert('File Request Send Successfully')</script>");
    }
}