using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO.Compression;

public partial class File_Delete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Security"].ConnectionString.ToString());
    SqlCommand cmd;
    SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Security1"].ConnectionString.ToString());
    SqlCommand cmd1;
    SqlConnection con2 = new SqlConnection(ConfigurationManager.ConnectionStrings["Security2"].ConnectionString.ToString());
    SqlCommand cmd2;
    SqlConnection con3 = new SqlConnection(ConfigurationManager.ConnectionStrings["Security3"].ConnectionString.ToString());
    SqlCommand cmd3;
    SqlDataAdapter da;
    DataTable dt = new DataTable();
    DataSet ds = new DataSet();
    SqlConnection con4 = new SqlConnection(ConfigurationManager.ConnectionStrings["Security"].ConnectionString.ToString());
    SqlCommand cmd4;
    SqlConnection con5 = new SqlConnection(ConfigurationManager.ConnectionStrings["Security"].ConnectionString.ToString());
    SqlCommand cmd5;
    private void deletefile()
    {
        string time = DateTime.Now.ToString();
        string delete = "";

            con4.Open();
            cmd4 = new SqlCommand("delete from Server where DeleteTime='" + time + "'", con4);
            cmd4.ExecuteNonQuery();
            con4.Close();
    }

    protected void UpdateTimer_Tick(object sender, EventArgs e)
    {
        deletefile();
    }
}