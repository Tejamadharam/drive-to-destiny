using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contextmenu
{
    public partial class Nextpage : Form
    {
        public Nextpage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
            
        private void button4_Click(object sender, EventArgs e)
        {
            removenodes(treeView1.Nodes);
        }

        private void Nextpage_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("This pc");
            treeView1.Nodes.Add("TDocuments");
            treeView1.Nodes.Add("Favourites");
            treeView1.Nodes.Add("Desktop");
            treeView1.Nodes[1].Nodes.Add("This");
            treeView1.Nodes[2].Nodes.Add("pc");
        }
        List<TreeNode> checknodes = new List<TreeNode>();
        void removenodes(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.IsSelected)
                {
                    checknodes.Add(node);
                }
                else
                {
                    removenodes(node.Nodes);
                }
            }
                foreach(TreeNode Cnode in checknodes)
                {
                    nodes.Remove(Cnode);
            }

        }
    }
}
