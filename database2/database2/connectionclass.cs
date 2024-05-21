using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database2
{
    class connectionclass
    {
        private string sqlstring;
        private string strcon;
        System.Data.SqlClient.SqlDataAdapter da1;
        public string sql
        {
            set { sqlstring = value; }
        }
        public string connectionstring
        {
            set
            {
                strcon = value;
            }
        }
        public System.Data.DataSet getconnection
        {
            get{return mydataset();} 
        }
        private System.Data.DataSet mydataset()
        {
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(strcon);
            con.Open();
            da1 = new System.Data.SqlClient.SqlDataAdapter(sqlstring, con);
            System.Data.DataSet dset = new System.Data.DataSet();
            da1.Fill(dset, "employee");
            con.Close();
            return dset;
        }
    }
}
