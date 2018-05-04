using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DianShi
{
  public  class TypeAChannel:ChannelBase //北京电视台
    {
      public override void Fetch()
      {
          
            XmlDocument doc = new XmlDocument();
            doc.Load("北京电视台.xml");
            XmlNode root = doc.DocumentElement;
            //找根节点  
            foreach (XmlNode item in root.ChildNodes)//遍历子节点
            {
                if (item.Name.Equals("tvProgramTable"))//判断条件是节点的Name是否是"tvProgramTable"
                {
                    foreach (XmlNode items in item.ChildNodes)//遍历子节点的子节点
                    {
                        TvProgram Tp = new TvProgram();
                        Tp.PlayTime = Convert.ToDateTime(items["playTime"].InnerText);
                        Tp.ShiDuan = items["meridien"].InnerText;
                        Tp.Path = items["path"].InnerText;
                        Tp.Name = items["programName"].InnerText;
                        ProgramList1.Add(Tp);//绑定到集合
                    }
                }


            }
      }
    }
}
