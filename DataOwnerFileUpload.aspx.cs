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

public partial class DataOwnerFileUpload : System.Web.UI.Page
{
    public FileStream fs;
    string mergeFolder;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fileid();
            dl_secure();
        }
        if (Session["OwnerName"] != null)
        {
            TextBox5.Text = Session["OwnerName"].ToString();
        }
    }
    List<string> Packets = new List<string>();

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
    private void fileid()
    {
        string a = "";
        con.Open();
        cmd = new SqlCommand("select top 1 FileID from Server order by FileID desc", con);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            a = dr[0].ToString();
            int b = int.Parse(a);
            TextBox1.Text = (1 + b).ToString();
        }
        else
        {
            TextBox1.Text = "1";
        }
        con.Close();

    }

    private void dl_secure()
    {
        DropDownList1.Items.Add("Public");
        DropDownList1.Items.Add("Private");
    }




    public bool FHESplitFile(string SourceFile, int nNoofFiles)
    {

        bool Split = false;
        try
        {
            FileStream fs = new FileStream(SourceFile, FileMode.Open, FileAccess.Read);
            int SizeofEachFile = (int)Math.Ceiling((double)fs.Length / nNoofFiles);

            for (int i = 0; i < nNoofFiles; i++)
            {
                string baseFileName = Path.GetFileNameWithoutExtension(SourceFile);
                string Extension = Path.GetExtension(SourceFile);

                FileStream outputFile = new FileStream(Path.GetDirectoryName(SourceFile) + "\\" + baseFileName + "." +
                    i.ToString().PadLeft(3, Convert.ToChar("0")) + Extension + ".split", FileMode.Create, FileAccess.Write);

                mergeFolder = Path.GetDirectoryName(SourceFile);

                int bytesRead = 0;
                byte[] buffer = new byte[SizeofEachFile];

                if ((bytesRead = fs.Read(buffer, 0, SizeofEachFile)) > 0)
                {
                    outputFile.Write(buffer, 0, bytesRead);

                    string packet = baseFileName + "." + i.ToString().PadLeft(3, Convert.ToChar("0")) + Extension.ToString();
                    Packets.Add(packet);
                }

                outputFile.Close();

            }
            fs.Close();
        }
        catch (Exception Ex)
        {
            throw new ArgumentException(Ex.Message);
        }

        return Split;
    }

    private void abk()
    {
        char[] chararr = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        string aes = string.Empty;
        Random obj = new Random();
        int noofcharacters = Convert.ToInt32(8);
        for (int i = 0; i < noofcharacters; i++)
        {
            int pos = obj.Next(1, chararr.Length);
            if (!aes.Contains(chararr.GetValue(pos).ToString()))
            {
                aes += chararr.GetValue(pos);
            }
            else
            {
                i--;
            }
        }
        TextBox3.Text = aes;


        char[] chararr1 = "OPQRSTUVWXYZabcdefghijklmn01234567890123456789opqrstuvwxyzABCDEFGHIJKLMN".ToCharArray();
        string aes1 = string.Empty;
        Random obj1 = new Random();
        int noofcharacters1 = Convert.ToInt32(8);
        for (int j = 0; j < noofcharacters1; j++)
        {
            int pos = obj1.Next(1, chararr1.Length);
            if (!aes1.Contains(chararr1.GetValue(pos).ToString()))
            {
                aes1 += chararr1.GetValue(pos);
            }
            else
            {
                j--;
            }
        }
        TextBox4.Text = aes1;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            string filename = Path.GetFileName(FileUpload1.FileName);
            Stream str = FileUpload1.PostedFile.InputStream;
            BinaryReader br = new BinaryReader(str);
            byte[] size = br.ReadBytes((int)str.Length);

            FileUpload1.SaveAs(Server.MapPath("File/") + filename);
            FHESplitFile((Server.MapPath("File/") + filename), Convert.ToInt32(3));

            //FileUpload1.SaveAs((@"Desktop\") + filename);
            //FHESplitFile((@"Desktop\" + filename), Convert.ToInt32(3));

            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            provider.Key = ASCIIEncoding.ASCII.GetBytes("11224488");
            provider.IV = ASCIIEncoding.ASCII.GetBytes("11224488");

            ICryptoTransform transform = provider.CreateEncryptor(provider.Key, provider.IV);

            FileStream inputStream = new FileStream((Server.MapPath("File/") + filename), FileMode.Open, FileAccess.Read);

            //FileStream inputStream = new FileStream((@"Desktop\" + filename), FileMode.Open, FileAccess.Read);

            byte[] byteInput = new byte[inputStream.Length];
            inputStream.Read(byteInput, 0, byteInput.Length);
            inputStream.Close(); abk();
            String Name = TextBox2.Text;
            string key1 = TextBox3.Text;
            string key2 = TextBox4.Text;
            string Secure = DropDownList1.Text;

            string delete = DateTime.Now.AddHours(1).ToString();


            con.Open();
            cmd = new SqlCommand("insert into Server(FileName,UploadFile,FileType,FileData,FileKey1,FileKey2,Secure,OwnerName,DeleteTime)values(@Name,@File,@Type,@Data,@Key1,@Key2,@Secure,@OwnerName,@DeleteTime)", con);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@File", filename);
            cmd.Parameters.AddWithValue("@Type", "application/word");
            cmd.Parameters.AddWithValue("@Data", size);
            cmd.Parameters.AddWithValue("@Key1", key1);
            cmd.Parameters.AddWithValue("@Key2", key2);
            cmd.Parameters.AddWithValue("@Secure", Secure);
            cmd.Parameters.AddWithValue("@OwnerName", TextBox5.Text);
            cmd.Parameters.AddWithValue("@DeleteTime", delete);
            cmd.ExecuteNonQuery();
            con.Close();

            string filename1 = Path.GetFileName(Packets[0].ToString());
            con1.Open();
            cmd1 = new SqlCommand("insert into Server1(FileName,UploadFile)values(@Name,@File)", con1);
            cmd1.Parameters.AddWithValue("@Name", Name);
            cmd1.Parameters.AddWithValue("@File", filename1);
            cmd1.ExecuteNonQuery();
            con1.Close();

            string filename2 = Path.GetFileName(Packets[1].ToString());
            con2.Open();
            cmd2 = new SqlCommand("insert into Server2(FileName,UploadFile)values(@Name,@File)", con2);
            cmd2.Parameters.AddWithValue("@Name", Name);
            cmd2.Parameters.AddWithValue("@File", filename2);
            cmd2.ExecuteNonQuery();
            con2.Close();

            string filename3 = Path.GetFileName(Packets[2].ToString());
            con3.Open();
            cmd3 = new SqlCommand("insert into Server3(FileName,UploadFile)values(@Name,@File)", con3);
            cmd3.Parameters.AddWithValue("@Name", Name);
            cmd3.Parameters.AddWithValue("@File", filename3);
            cmd3.ExecuteNonQuery();
            con3.Close();

            Response.Write("<Script>alert('File Uploaded Successfully')</script>");

            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";

            fileid();

        }
        else
        {
            Response.Write("<Script>alert('Please Select a File')</script>");
        }
    }
}