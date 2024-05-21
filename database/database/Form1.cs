using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
 


namespace database
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\pc\documents\visual studio 2012\Projects\database\database\Database1.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText="insert into studenttable values("+textsid.Text+",'"+textsname.Text+"','"+textcourse.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            textsid.Text = "";
            textsname.Text = "";
            textcourse.Text = "";
            MessageBox.Show("Data inserted successfully");
        }
    }
}
