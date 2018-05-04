using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuanLI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] dri = DriveInfo.GetDrives();
            foreach (DriveInfo item in dri)
            {
                TreeNode tn = new TreeNode();
                tn.Text = item.Name;
                tn.Tag = item.Name;
                treeView1.Nodes.Add(tn);
            }
            ////添加根
            //TreeNode tr = new TreeNode();
            //tr.Tag = "D:\\";  ///完整路径
            //    tr.Text="D:\\"; 
            //treeView1.Nodes.Add(tr);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode bo = treeView1.SelectedNode;
            string nods = bo.Tag.ToString();
            DirectoryInfo  info = new DirectoryInfo(nods);//创建目录对象
            DirectoryInfo[] dirs = info.GetDirectories();//得到子目录的集合
            //循环绑定TreeView
            bo.Nodes.Clear();
            foreach (DirectoryInfo item in dirs)
            {
                TreeNode di = new TreeNode();
                di.Text = item.Name;
                di.Tag = item.FullName;
                bo.Nodes.Add(di);   //把节点添加到选择节点中
            }
            //得到目录下的子文件
            FileInfo[] fi = info.GetFiles();
            listView1.Items.Clear();
            //循环绑定ListView上
            foreach (FileInfo item in fi)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = item.Name;
                lv.SubItems.Add(item.Length * 1.0 / 1024 + "kb");
                lv.SubItems.Add(item.Extension);
                lv.SubItems.Add(item.FullName);
                listView1.Items.Add(lv);
            }
        }
    }
}
