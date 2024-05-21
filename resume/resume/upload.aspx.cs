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


namespace resume
{
    public partial class upload : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;

            string filePath = FileUpload1.PostedFile.FileName;
            string filename1 = Path.GetFileName(filePath);
            string ext = Path.GetExtension(filename1);
            string type = String.Empty;

            if (FileUpload1.HasFile)
            {

                try
                {
                    switch (ext)
                    {
                        case ".doc":
                            type = "application/word";
                            break;

                        case ".docx":
                            type = "application.word";
                            break;
                    }
                    if (type != String.Empty)
                    {
                        con.Open();
                        Stream fs = FileUpload1.PostedFile.InputStream;
                        BinaryReader br = new BinaryReader(fs);
                        Byte[] bytes = br.ReadBytes((Int32)fs.Length);
                        string query = "insert into  resume(Name,type,data)" + " values (@Name, @type, @Data)";
                        SqlCommand com = new SqlCommand(query, con);
                        com.Parameters.Add("@Name", SqlDbType.VarChar).Value = filename1;

                        com.Parameters.Add("@type", SqlDbType.VarChar).Value = type;

                        com.Parameters.Add("@Data", SqlDbType.Binary).Value = bytes;
                        com.ExecuteNonQuery();
                        Label1.ForeColor = System.Drawing.Color.Green;
                        Label1.Text = "Resume has been successfully Uploaded";

                    }
                    else
                    {
                        Label1.ForeColor = System.Drawing.Color.Red;
                        Label1.Text = "Select only Resume";
                    }
                }
                catch (Exception ex)
                {
                    Label1.Text = "Error:" + ex.Message.ToString();
                }

            }
        }
    }
}