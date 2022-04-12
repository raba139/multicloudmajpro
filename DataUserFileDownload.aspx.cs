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
using System.Security.Cryptography;

public partial class DataUserFileDownload : System.Web.UI.Page
{
    string username;
    string filename;
    string fileid;
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

    protected void Button1_Click(object sender, EventArgs e)
    {
        string fn1 = null;
        string fn2 = null;
        string fn3 = null;
        con.Open();
        cmd = new SqlCommand("Select UserName,FileName,FileKey2 from SecretKey where UserName='" + username + "' and FileID='" + TextBox1.Text + "' and FileKey1='"+TextBox2.Text+"' and FileKey2='" + TextBox3.Text + "'", con);
        dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            con3.Open();
            cmd3 = new SqlCommand("Select * from server1", con3);
            dr1 = cmd3.ExecuteReader();
            if (dr1.Read())
            {
                fn1 = dr1[0].ToString();
            }
            con3.Close();
            con4.Open();
            cmd4 = new SqlCommand("Select * from server2", con4);
            dr1 = cmd4.ExecuteReader();
            if (dr1.Read())
            {
                fn2 = dr1[0].ToString();
            }
            con4.Close();
            con5.Open();
            cmd5 = new SqlCommand("Select * from server3", con5);
            dr1 = cmd5.ExecuteReader();
            if (dr1.Read())
            {
                fn3 = dr1[0].ToString();
            }
            con5.Close();
            
            fileid = TextBox1.Text;
            //gridviewdetaiils();

            con1.Open();
            cmd1 = new SqlCommand("select FileName, FileType, FileData,UploadFile from Server where FileID=@Id", con1);
            cmd1.Parameters.AddWithValue("@Id", fileid);
            dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                string filetype = dr1[3].ToString();
                string ext = Path.GetExtension(filetype);

                con2.Open();
                cmd2 = new SqlCommand("delete from SecretKey where UserName='" + TextBox5.Text + "' and FileID='" + TextBox1.Text + "'", con2);
                cmd2.ExecuteNonQuery();
                con2.Close();
                Response.ContentType = dr1["FileType"].ToString();
                Response.AddHeader("Content-Disposition", "attachment;filename=\"" + dr1["FileName"] + ext);
                Response.BinaryWrite((byte[])dr1["FileData"]);
                Response.End();
            }
            con1.Close();

            Response.Write("<script>alert('File Downloaded')</script>");
        }
        else
        {
            Response.Write("<script>alert('Invalid Data')</script>");
        }
        con.Close();

    }
}