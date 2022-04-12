using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

public partial class DataUserPublicFiles : System.Web.UI.Page
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
    SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Security"].ConnectionString.ToString());
    SqlCommand cmd;
    SqlCommand cmd1;
    SqlConnection con2 = new SqlConnection(ConfigurationManager.ConnectionStrings["Security"].ConnectionString.ToString());
    SqlCommand cmd2;
    SqlConnection con3 = new SqlConnection(ConfigurationManager.ConnectionStrings["Security1"].ConnectionString.ToString());
    SqlCommand cmd3;
    SqlConnection con4 = new SqlConnection(ConfigurationManager.ConnectionStrings["Security2"].ConnectionString.ToString());
    SqlCommand cmd4;
    SqlConnection con5 = new SqlConnection(ConfigurationManager.ConnectionStrings["Security3"].ConnectionString.ToString());
    SqlCommand cmd5;
    SqlDataAdapter da;
    DataTable dt = new DataTable();
    SqlDataReader dr;
    SqlDataReader dr1;

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        LinkButton lnkbtn = sender as LinkButton;
        GridViewRow gvrow = lnkbtn.NamingContainer as GridViewRow;
        fileid = Convert.ToInt32(GridView1.DataKeys[gvrow.RowIndex].Value.ToString());
        con1.Open();
        cmd1 = new SqlCommand("select FileName, FileType, FileData,UploadFile from Server where FileID=@Id", con1);
        cmd1.Parameters.AddWithValue("@Id", fileid);
        dr1 = cmd1.ExecuteReader();
        if (dr1.Read())
        {
            string filetype = dr1[3].ToString();
            string ext = Path.GetExtension(filetype);
            Response.ContentType = dr1["FileType"].ToString();
            Response.AddHeader("Content-Disposition", "attachment;filename=\"" + dr1["FileName"] + ext);
            Response.BinaryWrite((byte[])dr1["FileData"]);
            Response.End();
        }
        con1.Close();
        Response.Write("<script>alert('File Downloaded Successfully')</script>");
    }
}