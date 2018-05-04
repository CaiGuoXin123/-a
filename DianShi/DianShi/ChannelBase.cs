using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DianShi
{
   public abstract class ChannelBase     //频道基类
    {
       //频道名称
        public string ChannelName { get; set; }
       //频道路径
        public string Path { get; set; }
       //节目列表，该频道所有节目
        public List<TvProgram> TVlist { get; set; }
       //获取频道列表：通过Fetch方法获取该频道拥有的所有节目列表
        public abstract void Fetch();
        
        private List<TvProgram> ProgramList = new List<TvProgram>();

        public List<TvProgram> ProgramList1
        {
            get { return ProgramList; }
            set { ProgramList = value; }
        }
   }
}
