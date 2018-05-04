using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuanGong
{
   public  class Record
    {
       //签到时间
        public DateTime SignInTime { get; set; }
       //签退时间
        public DateTime SignOuntTime { get; set; }
       //工号
        public string ID { get; set; }
       //姓名
        public string Name { get; set; }
    }
}
