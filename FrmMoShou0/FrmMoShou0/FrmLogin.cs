using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMoShou0
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FrmRegist it = new FrmRegist();
            it.Show();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPwd.Text.Trim().Equals("") && txtName.Text.Trim().Equals(""))
            {
                MessageBox.Show("用户名或密码不能为空！", "提示");
            }
            if(txtPwd.Text.Equals(LoginInfo.Password1) && txtName.Text.Equals(LoginInfo.Name1))
            {
                FrmMain fm = new FrmMain();
                fm.Name = txtName.Text;
                fm.Show();
            }

       
        }
      
     
    }
}
