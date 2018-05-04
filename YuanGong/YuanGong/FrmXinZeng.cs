using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YuanGong
{
    public partial class FrmXinZeng : Form
    {
        public FrmXinZeng()
        {
            InitializeComponent();
        }
        public FrmXinXi FrmParent { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SE se = new SE();
                se.ID1 = this.textBox1.Text.Trim();
                se.Age1 = Int32.Parse(this.textBox2.Text.Trim());
                se.Name1 = this.textBox3.Text.Trim();
                if (this.comboBox1.SelectedItem.ToString() == "男")
                {
                    se.Sex1 = Gender.男.ToString();
                }
                else
                {
                    se.Sex1 = Gender.女.ToString();
                }
                foreach (SE item in FrmParent.list)
                {
                    if (item.ID1 == se.ID1)
                    {
                        MessageBox.Show("此工号已经存在");
                        return;
                    }
                }
                FrmParent.list.Add(se);
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("出错：" + ex.Message);
            }
            finally
            {
                this.FrmParent.BinGrid(FrmParent.list);
            }
        }
    }
}
