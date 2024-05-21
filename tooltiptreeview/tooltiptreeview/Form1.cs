using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tooltiptreeview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip t1 = new ToolTip();
            System.Windows.Forms.ToolTip t2 = new ToolTip();
            t1.SetToolTip(this.textBox1, "Hello");
            t2.SetToolTip(this.textBox2, "Nsic");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            treeView1.Nodes.Add("Hello");
            treeView1.Nodes.Add("Cse");
            treeView1.Nodes.Add("This");
            treeView1.Nodes.Add("Doc");
            treeView1.Nodes.Add("Pics");
            treeView1.Nodes[0].Nodes.Add("Ece");
            treeView1.Nodes[0].Nodes.Add("Eee");
            treeView1.Nodes[1].Nodes.Add("Dot net");
            treeView1.Nodes[1].Nodes.Add("Java");
            treeView1.Nodes[2].Nodes.Add("D:");
            treeView1.Nodes[3].Nodes.Add("Teja");
        }
    }
}
