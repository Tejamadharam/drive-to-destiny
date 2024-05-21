using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nextpage my = new Nextpage();
            my.Show();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Want to close the application", "ALERT", MessageBoxButtons.OKCancel) == DialogResult.OK)
                Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
            textBox1.Copy();
            textBox1.Paste();
            textBox2.Undo();
            textBox2.Copy();
            textBox2.Paste();
        
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
            textBox1.Copy();
            textBox1.Paste();
            textBox2.Undo();
            textBox2.Copy();
            textBox2.Paste(); 
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
            textBox1.Copy();
            textBox1.Paste();
            textBox2.Undo();
            textBox2.Copy();
            textBox2.Paste();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string c = "";
            openFileDialog1.InitialDirectory = "E:";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Text Files|*.txt|word documents|*.docx";
            openFileDialog1.Title = "Open Text Files";
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
                c = openFileDialog1.FileName;
            richTextBox1.LoadFile(c, RichTextBoxStreamType.PlainText);
        }

        private void moveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
            textBox1.Copy();
            textBox1.Paste();
            textBox2.Undo();
            textBox2.Copy();
            textBox2.Paste();
        }
    }
}
