using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class DataOwnerFileRequest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["OwnerName"] != null)
        {
            TextBox5.Text = Session["OwnerName"].ToString();
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

        string rid = grdrow.Cells[0].Text;
        string username = grdrow.Cells[1].Text;
        string fileid = grdrow.Cells[2].Text;
        string filename = grdrow.Cells[3].Text;
        string filekey1 = null;
        string filekey2 = null;

        con.Open();
        cmd = new SqlCommand("select FileKey1,FileKey2 from Server where FileID='" + fileid + "'", con);
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            filekey1 = dr[0].ToString();
            filekey2 = dr[1].ToString();
        }
        con.Close();

        con.Open();
        cmd = new SqlCommand("insert into SecretKey values('" + username + "','" + fileid + "','" + filename + "','" + filekey1 + "','" + filekey2 + "')", con);
        cmd.ExecuteNonQuery();
        con.Close();

        

        con.Open();
        cmd = new SqlCommand("update FileRequest set Status='Key Sent' where RequestID='" + rid + "'", con);
        cmd.ExecuteNonQuery();
        con.Close();

        Response.Write("<script>alert('File Key send successfully')</script>");

    }
}