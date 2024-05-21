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


namespace resume1
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
                        string query = "insert into  resume1(Contact_No,Name,Spacial_Skills,Resume_Name,type,data)" + " values ("+TextBox12.Text+",'"+TextBox2.Text+"','"+TextBox5.Text+"',@Resume_Name, @type, @Data)";
                        SqlCommand com = new SqlCommand(query, con);
                        com.Parameters.Add("@Resume_Name", SqlDbType.VarChar).Value = filename1;

                        com.Parameters.Add("@type", SqlDbType.VarChar).Value = type;

                        com.Parameters.Add("@Data", SqlDbType.Binary).Value = bytes;
                        SqlCommand cmd = new SqlCommand("insert into resume(Name,Gender,Age,Mail_Id,Qualification,Spacial_Skills,Year_of_passed_out,Experience,Select_City,District,State,Country,Postal_code,Contact_No) values('" + TextBox2.Text + "','" + TextBox14.Text + "'," + TextBox3.Text + ",'" + TextBox13.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "'," + TextBox6.Text + ",'" + TextBox7.Text + "','" + DropDownList1.SelectedValue + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "'," + TextBox11.Text + "," + TextBox12.Text + ")", con);
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

        protected void Button4_Click(object sender, EventArgs e)
        {
           // con.Open();
           
           // cmd.ExecuteNonQuery();
           // con.Close();
           // Response.Write("<script language='JavaScript'>alert('registration successfull');window.location='registrationlogin.aspx'</script>");
           //Response.Redirect("registrationlogin.aspx");
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox14.Text = CheckBoxList1.SelectedValue;
        }
    }
}