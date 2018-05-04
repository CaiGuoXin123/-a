using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guanli2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Dictionary<string, HealthCheckSet> hea = new Dictionary<string, HealthCheckSet>();
        public HealthCheckItem height, weight, sight, hearing, liverFun, bWaves, bloodPressure;
        public Dictionary<string, HealthCheckItem> dic = new Dictionary<string, HealthCheckItem>();
        private void Form1_Load(object sender, EventArgs e)
        {

            height = new HealthCheckItem("身高", "用于检查身高", 30);
            weight = new HealthCheckItem("体重", "用于检查体重", 30);
            sight = new HealthCheckItem("视力", "用于检查视力", 50);
            hearing = new HealthCheckItem("听力", "用于检查听力", 50);
            liverFun = new HealthCheckItem("肝功能", "用于检查肝功能", 100);
            bWaves = new HealthCheckItem("B超", "用于检查B超", 100);
            bloodPressure = new HealthCheckItem("心电图", "用于检查心电图", 150);
            dic.Add(height.Name, height);
            dic.Add(weight.Name, weight);
            dic.Add(sight.Name, sight);
            dic.Add(hearing.Name, hearing);
            dic.Add(liverFun.Name, liverFun);
            dic.Add(bWaves.Name, bWaves);
            dic.Add(bloodPressure.Name, bloodPressure);
            HealthCheckSet he = new HealthCheckSet("入学体检", dic);
            hea.Add(he.Name, he);
            BindingSource ds = new BindingSource();
            ds.DataSource = hea.Keys;
            cbmli.DataSource = ds;
            BindingSource bs2 = new BindingSource();
            bs2.DataSource = dic.Keys;
            cbmmu.DataSource = bs2;
        }
        private void cbmli_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string, HealthCheckItem> dics = hea[cbmli.Text].HealthItem;
            BindingSource ds = new BindingSource();
            ds.DataSource = dics.Values;
            dataGridView1.DataSource = ds;
        }

        private void btntian_Click(object sender, EventArgs e)
        {
            
            foreach (HealthCheckItem item in dic.Values)
            {
                if(item.Name.Equals(cbmmu))
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = hea.Keys;
                    this.dataGridView1.DataSource = bs;
                }
            }
        }
    }
}
