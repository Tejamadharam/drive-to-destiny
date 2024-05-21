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



namespace drivetodestiny
{
    public partial class admin : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BindData();
        }
        private void BindData()
        {
            //  string["jobinformationconnectionstring"].connectionstring;
            DataTable dt = new DataTable();
            //  using(SqlConnection con=new SqlConnection(strconnstring))
            //  {
            string strquery = "select * from studentregistration";
            SqlCommand cmd = new SqlCommand(strquery, con);
            using (SqlDataAdapter sda = new SqlDataAdapter())
            {
                con.Open();
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            //}
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete  from studentregistration where Contact_No=" + TextBox1.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script language='JavaScript'>alert('Deleted successfull ');</script>");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}