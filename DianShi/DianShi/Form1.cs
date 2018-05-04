using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DianShi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TreeNode allNodes = new TreeNode();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            inti();
        }
        public void jin()
        {
            //XmlDocument doc = new XmlDocument();
            //doc.Load("北京电视台.xml");
            //XmlNode root = doc.DocumentElement;
            //foreach (XmlNode item in root.ChildNodes)
            //{
            //    if (item.Name.Equals( "channelName"))
            //        {

            //            foreach (XmlNode items in item.ChildNodes)
            //            {
            //                TvProgram pr = new TvProgram();
            //                pr.PlayTime=items[]
            //            }

            //    }
            //}
            //TreeNode tr = new TreeNode();
            //TreeNode selectedNode = treeView1.SelectedNode;

        }
        public void inti()
        {
            TreeNode tr = new TreeNode("我的电视台");
            allNodes.Text = "所有电视台";
            sh();
            treeView1.Nodes.Add(tr);
            treeView1.Nodes.Add(allNodes);
        }
        public void sh()
        {
            ChannelManager manager = new ChannelManager();
            manager.show();
            foreach (ChannelBase item in manager.Dic.Values)
            {
                TreeNode tn = new TreeNode();
                tn.Text = item.ChannelName;
                tn.Tag = item;
                allNodes.Nodes.Add(tn);

            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode select = treeView1.SelectedNode;
            int level = select.Level;
            if (level == 1)
            {
                ChannelBase channel = (ChannelBase)select.Tag;
                channel.ProgramList1.Clear();
                channel.Fetch();
                dataGridView1.DataSource = channel.ProgramList1;
                //JiaRu();
            }
        }
        //存储北京电视台节目
        List<TvProgram> bj = new List<TvProgram>();
        //存储凤凰电视台节目
        List<TvProgram> fh = new List<TvProgram>();
        //存储我的电视台中的节目
        Dictionary<string, List<TvProgram>> dic = new Dictionary<string, List<TvProgram>>();
        public void JiaRu()
        {
            if (treeView1.SelectedNode.Parent != null && treeView1.SelectedNode.Parent.Text.Equals("我的电台"))
            {

                contextMenuStrip2.Items[1].Visible = false;
                contextMenuStrip2.Items[0].Visible = true;
            }
            else
            {
                contextMenuStrip2.Items[0].Visible = false;
                //contextMenuStrip2.Items[1].Visible = true;
            }
            if (treeView1.SelectedNode.Level == 0)
            {
                contextMenuStrip2.Items[0].Visible = false;
                // contextMenuStrip2.Items[1].Visible = false;

            }
            if (treeView1.SelectedNode.Text.Equals("北京电视台"))
            {
                dataGridView1.DataSource = bj;

            }
            else if (treeView1.SelectedNode.Text.Equals("凤凰电视台"))
            {
                dataGridView1.DataSource = fh;
            }
        }
        private void 加入我的电台ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string select = treeView1.SelectedNode.Text;
            //if(select.Equals("北京电视台"))
            //{
            //    TypeAChannel ta = new TypeAChannel();
            //    ta.Fetch();

            foreach (TreeNode item in treeView1.Nodes[0].Nodes)
            {
                if (item.Text.Equals(treeView1.SelectedNode.Text))
                {
                    MessageBox.Show("已有该频道");
                    return;
                }
            }
            ChannelBase channel = (ChannelBase)treeView1.SelectedNode.Tag;
            dic.Add(channel.ChannelName, channel.ProgramList1);
            TreeNode tn = new TreeNode();
            tn.Text = channel.ChannelName;
            tn.Tag = channel;
            treeView1.Nodes[0].Nodes.Add(tn);
        }

        private void 播放ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
