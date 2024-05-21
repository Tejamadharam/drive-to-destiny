using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using second.ServiceReference1;

namespace second
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 n1 = Convert.ToInt32(textBox1.Text);
            Int32 n2 = Convert.ToInt32(textBox2.Text);
            
        }
    }
}
