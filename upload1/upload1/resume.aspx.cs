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

namespace upload1
{
    public partial class resume : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into resume values('" + TextBox2.Text + "','" + TextBox14.Text + "'," + TextBox3.Text + ",'" + TextBox13.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "'," + TextBox6.Text + ",'" + TextBox7.Text + "','" + DropDownList1.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "'," + TextBox11.Text + "," + TextBox12.Text + ")", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script language='JavaScript'>alert('registration successfull');window.location='registrationlogin.aspx'</script>");
            //Response.Redirect("registrationlogin.aspx");

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label17.Visible = true;

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
                        string query = "insert into  resume(Name,type,data)" + " values (@Resume_Name, @type, @Data)";
                        SqlCommand com = new SqlCommand(query, con);
                        com.Parameters.Add("@Resume_Name", SqlDbType.VarChar).Value = filename1;

                        com.Parameters.Add("@type", SqlDbType.VarChar).Value = type;

                        com.Parameters.Add("@Data", SqlDbType.Binary).Value = bytes;
                        com.ExecuteNonQuery();
                        Label17.ForeColor = System.Drawing.Color.Green;
                        Label17.Text = "Resume has been successfully Uploaded";

                    }
                    else
                    {
                        Label17.ForeColor = System.Drawing.Color.Red;
                        Label17.Text = "Select only Resume";
                    }
                }
                catch (Exception ex)
                {
                    Label17.Text = "Error:" + ex.Message.ToString();
                }

            }
        }
    }
}