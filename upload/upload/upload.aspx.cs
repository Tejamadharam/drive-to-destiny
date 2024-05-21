using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO;


namespace upload
{
    public partial class upload : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                SqlCommand cmd = new SqlCommand("insert into resume Values('" + FileUpload1.HasFile + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                try
                {
                    if (FileUpload1.PostedFile.ContentType == "image/jpeg")
                    {
                        if (FileUpload1.PostedFile.ContentLength < 512000)
                        {
                            String FileName = Path.GetFileName(FileUpload1.FileName);
                            FileUpload1.SaveAs(Server.MapPath("~/") + FileName);
                            Label1.Text = "file uploaded successfully!";
                        }
                        else
                            Label1.Text = "file maximum size is 5mb";
                    }
                    else
                        Label1.Text = "only jpeg files are accepted!";
                }
                catch (Exception a)
                {
                    Label1.Text = "file is not uploaded" + a.Message;
                }

            }
        }
    }
}