using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace drivetodestiny
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            con.Open();
            try
            {
                string p1 = "select Company_Name,Password from companyregistration where Company_Name='" + TextBox1.Text + "'and Password='" + TextBox2.Text + "'";
                SqlCommand cmd = new SqlCommand(p1, con);
                string pass = cmd.ExecuteScalar().ToString();
                if (pass == TextBox1.Text)
                {
                    Session["company registration1"] = TextBox1.Text;
                    Response.Redirect("companies.aspx");
                }
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    try
                    {
                        string p2 = "select Name,Contact_No from studentregistration where Name='" + TextBox1.Text + "'and Contact_No='" + TextBox2.Text + "'";
                        SqlCommand cmd = new SqlCommand(p2, con);
                        string pass1 = cmd.ExecuteScalar().ToString();
                        if (pass1 == TextBox1.Text)
                        {
                            Session["company registration1"] = TextBox1.Text;
                            Response.Redirect("Homepage.aspx");
                        }
                    }
                    catch (Exception ex1)
                    {
                        if (ex1 != null)
                        {
                            if (TextBox1.Text == "admin" && TextBox2.Text == "admin")
                            {
                                Response.Redirect("admin.aspx");
                            }
                            
                        }
                        else
                        {
                            string p = ex1.ToString();
                        }
                    }
                }
              
                con.Close();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("registrationlogin.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("registrationlogin1.aspx");
        }
    }
}
