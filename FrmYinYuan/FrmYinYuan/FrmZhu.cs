using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmYinYuan
{
    public partial class FrmZhu : Form
    {
        public FrmZhu()
        {
            InitializeComponent();
            inint();
        }
    

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
     
        Dictionary<string, Label> labels = new Dictionary<string, Label>();
        

        string key = string.Empty;
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node == null) return;
            if(node.Level!=1)return;
            key = treeView1.SelectedNode.Text;
            if(treeView1.SelectedNode.Level>0)
            {
                this.lblMovieName.Text = schedule.Items[key].Movie.Moviename;
                this.lblDirector.Text = schedule.Items[key].Movie.Directer;
                this.lblActor.Text = schedule.Items[key].Movie.Actor;
                this.lblPrice.Text = schedule.Items[key].Movie.Price.ToString();
               
                this.lblTime.Text = schedule.Items[key].Time;
                this.lblType.Text = schedule.Items[key].Movie.MovieType.ToString();
                this.pictureBox1.Image = Image.FromFile(schedule.Items[key].Movie.Poster);
                this.lblCalcPrice.Text = "";
            }

          
        }
        Dictionary<string, Label> list = new Dictionary<string, Label>();
        Label la=null;
        Cinema cinema = new Cinema();
        Seat seat = new Seat();
        private void inint()
        {
            int seatRow = 6;//行
            int seatLine = 7;//列
            for (int i = 0; i < seatRow; i++)
            {
                for (int q = 0; q < seatLine; q++)
                {
                    la=new Label();
                    la.BackColor=Color.Yellow;
                    la.Font=new System.Drawing.Font("宋体",14.25F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point,((byte)(134)));
                    la.AutoSize=false;
                    la.Size=new System.Drawing.Size(50,25);
                    la.Text=(q+1).ToString()+"-"+(i+1).ToString();
                    la.TextAlign=ContentAlignment.MiddleCenter;
                    la.Location = new Point(60 + (i * 90), 60 + (q * 60));
                    la.Click += new System.EventHandler(lblSet_Click);
                    tabPage2.Controls.Add(la);
                    list.Add(la.Text, la);
                    seat = new Seat((q + 1).ToString() + "-" + (i + 1).ToString(), Color.Yellow);
                    
                    cinema.Seats.Add(seat.SeatNum,seat);
                    
                    labels.Add(la.Text,la);
                }
            }


        }

        private void lblSet_Click(object sender, EventArgs e)
        {
            try
            {
                string seatNum = ((Label)sender).Text.ToString();
                string customerName = this.textBox2.Text.ToString();
                int discount = 0;
                string type = "";
                if (this.radioButton3.Checked)
                {
                    type = "student";
                    if (this.comboBox1.Text == null)
                    {
                        MessageBox.Show("请输入折扣数", "提示");
                        return;
                    }
                    else
                    {
                        discount = int.Parse(this.comboBox1.Text);
                    }

                }
                else if (this.radioButton2.Checked)
                {
                    if (string.IsNullOrEmpty(this.textBox2.Text))
                    {
                        MessageBox.Show("请输入增票者的姓名", "提示");
                        return;
                    }
                    else
                    {
                        type = "free";
                    }
                }
                string key1 = this.treeView1.SelectedNode.Text;
                Ticket newTicket = TicketUtil.CreateTicket(schedule.Items[key1],
                    cinema.Seats[seatNum], discount, customerName, type);
                if (cinema.Seats[seatNum].Color == Color.Yellow)
                {
                    DialogResult result;
                    result = MessageBox.Show("是否购买", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                       
                        cinema.Seats[seatNum].Color = Color.Red;

                        UpdateSeat(); //清空
                        MessageBox.Show("s");
                        newTicket.CalcPrice();
                        cinema.SoldTickets.Add(newTicket);
                        lblCalcPrice.Text = newTicket.Price.ToString();
                        newTicket.Print();
                    }
                    else if (result == DialogResult.No)
                    {
                        return;
                    }
                }
                else
                {
                    foreach (Ticket tic in cinema.SoldTickets)
                    {
                        if (tic.Seat.SeatNum == seatNum && tic.Scheduleitem.Time
                            == treeView1.SelectedNode.Text && tic.Scheduleitem.Movie.Moviename
                            == treeView1.SelectedNode.Parent.Text)
                        {
                            tic.Show();
                        }
                    }
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            
        }
        public void Show11()
        {
            foreach (Ticket item in cinema.SoldTickets)
            {
                foreach (Seat seat in cinema.Seats.Values)
                {
                    if ((item.Scheduleitem.Time == key) && (item.Seat.SeatNum == seat.SeatNum))
                    {
                        seat.Color = Color.Red;
                    }
                }
            }
            //UpdateSeat();
        }

        private void UpdateSeat()
        {
            foreach (string key in cinema.Seats.Keys)
            {
               
                labels[key].BackColor = cinema.Seats[key].Color;
            }
        }
        private void 获取新放映列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            schedule.LoadItems();
            InitTreeView();
        }
        Schedule schedule = new Schedule();
        private void InitTreeView() 
        {
            string movieName = string.Empty;
            TreeNode node = null;
            foreach (ScheduleItem item in schedule.Items.Values )
            {
                if(item.Movie.Moviename!=movieName)
                {
                    //一个item代表一个放映场次
                    node = new TreeNode(item.Movie.Moviename);
                    treeView1.Nodes.Add(node);
                    
                }
                TreeNode tn = new TreeNode(item.Time);
                node.Nodes.Add(tn);
                movieName = item.Movie.Moviename;
            }
        }

        private void FrmZhu_Load(object sender, EventArgs e)
        {
            this.radioButton1.Checked = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
          
               
           
                this.comboBox1.Enabled = false;
                this.textBox2.Enabled = true;
                this.comboBox1.SelectedIndex = -1;
          
                this.lblCalcPrice.Text="0";
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox1.Enabled = false;
            this.textBox2.Enabled = false;
            this.comboBox1.SelectedIndex = -1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.lblMovieName.Text.Equals(""))
            {
                MessageBox.Show("您还没选择电影!", "提示");
                return;
            }
            string[] arry = { "5", "6", "7", "8" };
            this.comboBox1.Enabled = true;
            this.textBox2.Enabled = false;
           
            this.comboBox1.DataSource = arry;
          
            if (this.lblPrice.Text!="")
            {
                int price = int.Parse(this.lblPrice.Text);
                int discount = int.Parse(this.comboBox1.Text);
                this.lblCalcPrice.Text = (price * discount / 10).ToString();
            }
          
        }
      
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if(radioButton3.Checked==true)
            {
                int price = int.Parse(this.lblPrice.Text);
                int discount = int.Parse(this.comboBox1.Text);
                this.lblCalcPrice.Text = (price * discount / 10).ToString();
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

      
    }
}
