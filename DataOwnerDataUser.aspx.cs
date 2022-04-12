using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DataOwnerDataUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["OwnerName"] != null)
        {
            TextBox5.Text = Session["OwnerName"].ToString();
        }
    }
}