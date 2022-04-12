using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DataUserFileKey : System.Web.UI.Page
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
}