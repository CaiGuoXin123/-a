using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day05体检套餐
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //给医院 总共的体检项目 10个    身高  体重 视力   听力  肝功能 心电图 ，B超   血压 ，血常规
        public HealthItem height, weight, sight, hearing, liverFun, ekg, bWaves, bloodPressure, bloodTest;
        //1.2 套餐集合
        public Dictionary<string, HealthSet> hsets = new Dictionary<string, HealthSet>();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvHealthList.AutoGenerateColumns = false;
           

            //A套餐的体检项目集合
            Dictionary<string, HealthItem> healthItems=new Dictionary<string,HealthItem>();
            //初始化3个体检项目对象 
            height = new HealthItem("身高","用于检测身高",30);
            weight = new HealthItem("体重", "用于检测体重", 40);
            hearing = new HealthItem("听力", "用于检测听力", 30);


            healthItems.Add(height.HealthItemName,height);
            healthItems.Add(weight.HealthItemName, weight);
            healthItems.Add(hearing.HealthItemName, hearing);

            //01.构建出一个套餐对象  代表的是入学体检
            HealthSet setA = new HealthSet("入学体检", healthItems);

            //02.套餐对象归属于一个套餐集合
            hsets.Add(setA.HeahthName, setA);


            //B套餐的项目集合
            Dictionary<string, HealthItem> healthItemsB = new Dictionary<string, HealthItem>();
            //初始化3个体检项目对象 
            height = new HealthItem("身高", "用于检测身高", 30);
            weight = new HealthItem("体重", "用于检测体重", 40);

            healthItemsB.Add(height.HealthItemName, height);
            healthItemsB.Add(weight.HealthItemName, weight);
          
            //01.构建出一个套餐对象  代表的是入学体检
            HealthSet setB = new HealthSet("入职体检", healthItemsB);

            //02.套餐对象归属于一个套餐集合
            hsets.Add(setB.HeahthName, setB);

            //03.套餐集合绑定到下拉框 hsets BindingSource
            BindingSource bs2 = new BindingSource();
            bs2.DataSource = hsets.Keys;
            cboSets.DataSource = bs2;

        }

        private void cboSets_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string,HealthItem> dic= hsets[cboSets.Text].HealthItems;
            BindingSource bs=new BindingSource();
            bs.DataSource=dic.Values;
            dgvHealthList.DataSource = bs;
        }
    }
}
