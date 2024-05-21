using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        connectionclass objconnect;
        string constring;
        DataSet ds;
        int maxrows;
        int i = 0;
        DataRow drow;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                objconnect = new connectionclass();
                constring = Properties.Settings.Default.connectiondataConnectionString;
                objconnect.connectionstring = constring;
                objconnect.sql = Properties.Settings.Default.sql;
                ds = objconnect.getconnection;
                maxrows = ds.Tables[0].Rows.Count;
                navigaterecords();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }
        private void navigaterecords()
        {
            drow = ds.Tables[0].Rows[i];
            texteid.Text = drow.ItemArray.GetValue(0).ToString();
            textename.Text = drow.ItemArray.GetValue(1).ToString();
            textsalary.Text = drow.ItemArray.GetValue(2).ToString();
            textdpt.Text = drow.ItemArray.GetValue(3).ToString();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (i != maxrows - 1)
            {
                i++;
                navigaterecords();
            }
            else
            {
                MessageBox.Show("No more records");
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
             if (i!=0)
            {
                i--;
                navigaterecords();
            }
            else
            {
                MessageBox.Show("No more records");
            }
        }
    }
}
