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
    public partial class company_registration1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into companyregistration values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox5.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script language='JavaScript'>alert('registration successfull');window.location='registrationlogin.aspx'</script>");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("registrationlogin1.aspx");
        }
    }
}