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
namespace database1
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\pc\documents\visual studio 2012\Projects\database1\database1\Database1.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into student values(" + textid.Text + ",'" + textname.Text + "','" + textcourse.Text + "')";
            cmd.ExecuteNonQuery();
            connection.Close();
            textid.Text = "";
            textname.Text = "";
            textname.Text = "";
            MessageBox.Show("Data inserted successfully");

        }
        public void display()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from student";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            display();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update student set Name='"+textname.Text+"' where Name='"+textid.Text+"' ";
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("data Updated successfully");
            }
            catch (Exception)
            {
                MessageBox.Show("trail unsuccessful");
            }
            finally
            {
                connection.Close();  
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from student where Id=" + textid.Text + "";
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("data deleted successfully");
            }
            catch (Exception)
            {
                MessageBox.Show("trail unsuccessful");
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from student where Id=" +textid.Text + "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
