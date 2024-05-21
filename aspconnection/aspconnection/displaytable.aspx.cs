using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace aspconnection
{
    public partial class displaytable : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
            {
                if (!IsPostBack)
                {
                    binddata();
                }
            }
        private void binddata()
        {
            con.Open();
            DataTable dt = new DataTable();
            string str = "select * from contacts";
            SqlCommand cmd = new SqlCommand(str, con);
            using (SqlDataAdapter sd = new SqlDataAdapter())
            {
                sd.SelectCommand = cmd;
                sd.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            con.Close();
           }
        }
    }
