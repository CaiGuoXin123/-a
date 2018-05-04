using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuangLi
{
    public partial class frmzhu : Form
    {
        public frmzhu()
        {
            InitializeComponent();
        }

        //List<HealthCheckItem> AllItems = new List<HealthCheckItem>();
        //List<HealthCheckItem> items = new List<HealthCheckItem>();
        private void frmzhu_Load(object sender, EventArgs e)
        {
            cbmmu.Items.Add("请选择");
            cbmmu.SelectedIndex = 0;
            RenovateItem();
            HealthChechSet set = new HealthChechSet();
            RenovateList();
            cbmli.SelectedIndex = 0;
            cbmmu.Enabled = true;
            btnshan.Enabled = true;
            btntian.Enabled = true;

           
        }
         private void RenovateItem()
        {
            foreach (KeyValuePair<string, HealthCheckItem> item in HealthCheckItem.ItemDic)
            {
                cbmmu.Items.Add(item.Key);
            }
        }
        //更新套餐列表
         private void RenovateList()
         {
             cbmli.Items.Clear();
             cbmli.Items.Add("请选择");
             foreach (KeyValuePair<string, List<HealthCheckItem>> item in HealthChechSet.SetDic)
             {
                 cbmli.Items.Add(item.Key);
             }
             if (cbmli.Items.Count > 2)
             {
                 cbmli.SelectedIndex = cbmli.Items.Count - 1;
             }
         }
        //int totalPrice = 0;
        //int Price;
        //public void CalcPrice()
        //{
            
        //    foreach (HealthCheckItem item in this.items)
        //    {
        //        totalPrice += item.Pr;
        //    }
        //    this.Price = totalPrice;
        //}
         

       
        private void Form1_Load(object sender, EventArgs e)
        {
          
           
        }
        private void info()
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbmmu_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
            /// <summary>
        /// 刷新DGV列表
        /// </summary>
        private void RenovateDGV()
        {
            //MessageBox.Show(cbmli.Text);
            dataGridView1.DataSource = new BindingList<HealthCheckItem>(HealthChechSet.SetDic[cbmli.Text]);
            label4.Text = PriceSum(cbmli.Text).ToString();
        }
        /// <summary>
        /// 检查总金额
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private int PriceSum(string key)
        {
            int sum = 0;
            foreach (HealthCheckItem item in HealthChechSet.SetDic[key])
            {
                sum += item.Price;
            }
            return sum;
        }

        private void btntian_Click(object sender, EventArgs e)
        {
            if (HealthChechSet.SetDic[cbmli.Text].Contains(HealthCheckItem.ItemDic[cbmmu.Text]))
            {
                MessageBox.Show(cbmli.Text + "套餐中已存在该检查项目!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HealthChechSet.DicAdd(HealthChechSet.SetDic[cbmli.Text], cbmmu.Text);
                RenovateDGV();
            }


        }

        private void btnshan_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("您确定要删除吗?", "警告!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                if (dataGridView1.SelectedRows[0] != null && dataGridView1.SelectedRows[0].Cells[0] != null && dataGridView1.SelectedRows[0].Cells[0].Value != null)
                {
                    //删除 套餐中所选的与内置检查项目相匹配的项
                    HealthChechSet.SetDic[cbmli.Text].Remove(HealthCheckItem.ItemDic[dataGridView1.SelectedRows[0].Cells[0].Value.ToString()]);
                    RenovateDGV();
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cbmli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmli.SelectedIndex > 0)
            {
                label2.Text = cbmli.Text;
                cbmmu.Enabled = true;
                RenovateDGV();
            }
            else
            {
                cbmmu.Enabled= true;
            }
            
        }

        private void btnjia_Click(object sender, EventArgs e)
        {
            if (txtming.Text!="")
            {
                HealthChechSet dic = new HealthChechSet(txtming.Text);
                foreach(string  item in HealthChechSet.SetDic.Keys)
                {
                    if(txtming.Text.Equals(item))
                    {
                        MessageBox.Show("已经存在" + txtming.Text + "套餐1");
                        return;

                    }
                 
                    RenovateList();

                }

            }
        }

    
    }
}
