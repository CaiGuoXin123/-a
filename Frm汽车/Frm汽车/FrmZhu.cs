using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm汽车
{
    public partial class FrmZhu : Form
    {
        public FrmZhu()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox8.Enabled = false;
            textBox8.Text = "无";
        }

        public ListView lvlist { get; set; }
        //保存可租用的集合
        Dictionary<string, Vehicle> vehicle = new Dictionary<string, Vehicle>();
        //保存租出的车的集合
        Dictionary<string, Vehicle> renvehicle = new Dictionary<string, Vehicle>();
        public void New()
        {
            listView1.GridLines = true;
            listView1.Items.Clear();
            ListViewItem listView = null;
            foreach (Vehicle item in vehicle.Values)
            {
                if (item is Car)
                {
                    listView = new ListViewItem();
                    listView.Text = item.LicenseNO1;
                    listView.SubItems.Add(item.Name1);
                    listView.SubItems.Add(item.Color1);
                    listView.SubItems.Add(item.DailyRent1.ToString());
                    listView.SubItems.Add(item.RentDate1.ToString());

                }
                else if (item is Truck)
                {
                    listView = new ListViewItem();
                    listView.Text = item.LicenseNO1;
                    listView.SubItems.Add(item.Name1);
                    listView.SubItems.Add(item.Color1);
                    listView.SubItems.Add(item.DailyRent1.ToString());
                    listView.SubItems.Add(item.RentDate1.ToString());
                    listView.SubItems.Add(((Truck)item).Load.ToString());
                }
                listView1.Items.Add(listView);
            }
        }
        public void init()
        {
            Vehicle truck = new Truck("红色", 240, "京A111", "奥迪", 3, 10);
            Vehicle car = new Car("黑色", 240, "京A222", "宝马", 3);
            vehicle.Add(truck.LicenseNO1, truck);
            vehicle.Add(car.LicenseNO1, car);

        }
        private void FrmZhu_Load(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;
            init();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            New();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选中一行");
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入姓名");
                return;
            }
            string carnum = listView1.SelectedItems[0].Text;
            Vehicle ve = vehicle[carnum];
            renvehicle.Add(carnum, ve);

            //删除原来的集合
            vehicle.Remove(carnum);

            //重新加载
            New();
            MessageBox.Show("租车成功");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Vehicle item in renvehicle.Values)
            {
                ListViewItem lv = null;
                if (item is Truck)
                {

                    lv = new ListViewItem(item.LicenseNO1);
                    lv.SubItems.Add(item.Name1);
                    lv.SubItems.Add(item.Color1);
                    lv.SubItems.Add(item.DailyRent1.ToString());
                    lv.SubItems.Add(item.RentDate1.ToString());
                    lv.SubItems.Add(((Truck)item).Load.ToString());
                }
                else if (item is Car)
                {
                    lv = new ListViewItem();
                    lv.Text = item.LicenseNO1;
                    lv.SubItems.Add(item.Name1);
                    lv.SubItems.Add(item.Color1);
                    lv.SubItems.Add(item.DailyRent1.ToString());
                    lv.SubItems.Add(item.RentDate1.ToString());
                }
                listView2.Items.Add(lv);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("请选择天数");
                return;

            }
            if (listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选中一行");
                return;
            }
            string carnum1 = listView2.SelectedItems[0].Text;
            Vehicle ve = renvehicle[carnum1];
            int num = Convert.ToInt32(textBox2.Text);
            double monly = 0;
            monly = num * ve.DailyRent1;

            MessageBox.Show("消费" + monly);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Control item in tabPage3.Controls)
            {
                if(item is TextBox)
                {
                    if(item.Text=="")
                    {
                        MessageBox.Show("请输入完整的车辆信息");
                        return;
                    }
                }
            }
            if (radioButton1.Checked)
            {
                Vehicle vhc = new Car(textBox3.Text, Convert.ToDouble(textBox7.Text), textBox4.Text, comboBox1.Text, Convert.ToInt32(textBox6.Text));
                vehicle.Add(vhc.LicenseNO1,vhc);
                MessageBox.Show("入库成功！");
                textBox3.Text = "";
            }
            if (radioButton2.Checked)
            {
                Vehicle vhc = new Truck(textBox3.Text, Convert.ToDouble(textBox7.Text), textBox4.Text, comboBox1.Text, Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox8.Text));
                vehicle.Add(vhc.LicenseNO1, vhc);
                MessageBox.Show("入库成功！");
                textBox3.Text = "";
                
            }
          
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox8.Enabled = true;
            textBox8.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
