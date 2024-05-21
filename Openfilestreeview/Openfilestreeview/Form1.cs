using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Openfilestreeview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path = @"E:\\NSIC DOCUMENTATION";

        private void btnshowfolder_Click(object sender, EventArgs e)
        {
            listdir(treeView1, path);
       }
        private void listdir(TreeView tview, string path)
        {
            tview.Nodes.Clear();
            var rootdirinfo = new DirectoryInfo(path);
            tview.Nodes.Add(creatednode(rootdirinfo));
        }
        private static TreeNode creatednode(DirectoryInfo dirinfo)
        {
            var dirnode = new TreeNode(dirinfo.Name);
            foreach (var dir in dirinfo.GetDirectories())
            {
                dirnode.Nodes.Add(creatednode(dir));
            }
            foreach (var file in dirinfo.GetFiles())
            {
                dirnode.Nodes.Add(new TreeNode(file.Name));
                //dirnode.Nodes.Add(new TreeNode(file.Name));
            }
            return dirnode;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            String treenodename = treeView1.SelectedNode.ToString().Replace("TreeNode:", String.Empty);
           // String treenodename = treeView1.SelectedNode.ToString().Replace("TreeNode:", String.Empty);
            MessageBox.Show(treenodename.ToString());
            System.Diagnostics.Process.Start(path+"\\"+treenodename);

        }
    }
}
