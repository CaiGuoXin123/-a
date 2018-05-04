using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DianShi
{
   public  class TvProgram
    {
       //播出时间
       public DateTime PlayTime { get;set;}
       //早上 中午 晚上
       public string ShiDuan { get; set; }
         
       public string Name { get; set; }
       //视频路径
       public string Path { get; set; }
    }
}
