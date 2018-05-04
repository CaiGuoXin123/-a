using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day07_0300界面
{
   public class Piano:Instrument   //钢琴类
    {
       public override void Play()
       {
           MessageBox.Show("钢琴在演奏", "信息!", MessageBoxButtons.OK, MessageBoxIcon.Information);

       }
    }
}
