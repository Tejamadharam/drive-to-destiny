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
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Select *from resume";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("select Resume_Name,type,data from  resume where id=@id", con);
            com.Parameters.AddWithValue("id", GridView1.SelectedRow.Cells[1].Text);
            SqlDataReader dr = com.ExecuteReader();


            if (dr.Read())
            {
                Response.Clear();
                Response.Buffer = true;
                Response.ContentType = dr["type"].ToString();
                Response.AddHeader("content-disposition", "attachment;filename=" + dr["Resume_Name"].ToString());     // to open file prompt Box open or Save file         
                Response.Charset = "";
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.BinaryWrite((byte[])dr["data"]);
                Response.End();
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            BindData();
        }
        private void BindData()
        {
            string s = DropDownList1.SelectedValue;
          //  string["jobinformationconnectionstring"].connectionstring;
            DataTable dt=new DataTable();
          //  using(SqlConnection con=new SqlConnection(strconnstring))
          //  {
                string strquery="select * from resume where Special_Skills=@s";
                SqlCommand cmd=new SqlCommand(strquery,con);
                cmd.Parameters.AddWithValue("@s",s);
                using(SqlDataAdapter sda=new SqlDataAdapter())
                {
                    con.Open();
                    sda.SelectCommand=cmd;
                    sda.Fill(dt);
                    GridView1.DataSource=dt;
                    GridView1.DataBind();
                }
            //}
        }
        }
    }
