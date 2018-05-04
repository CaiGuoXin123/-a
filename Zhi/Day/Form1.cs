using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            TreeNode tr = new TreeNode();
            tr.Text = name;
          
            treeView1.Nodes.Add(tr);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            TreeNode tr = new TreeNode();
            tr.Text = name;
            TreeNode selectedNode = treeView1.SelectedNode;
            foreach (TreeNode item in selectedNode.Nodes)
            {
                if (item.Text == name)
                {
                    MessageBox.Show("================");
                    return;
                }
            }
            selectedNode.Nodes.Add(tr);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = treeView1.SelectedNode;
            MessageBox.Show(selectedNode.Text);
        }
    }
}
