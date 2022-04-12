using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


public partial class DataProviderFileRequest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
        cmd = new SqlCommand("update FileRequest set Status='Owner' where RequestID='"+fileid+"'", con);
        cmd.ExecuteNonQuery();
        con.Close();

        Response.Write("<script>alert('File Request Send to the Owner')</script>");
    }
}