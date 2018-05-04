using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DianShi
{
    public class ChannelManager
    {
        //双列泛型集合
        private Dictionary<string, ChannelBase> dic = new Dictionary<string, ChannelBase>();

        public Dictionary<string, ChannelBase> Dic
        {
            get { return dic; }
            set { dic = value; }
        }
        public void show()
        {
                XmlDocument doc = new XmlDocument();
                doc.Load("FullChannels.xml");
                XmlNode root = doc.DocumentElement;
                foreach (XmlNode item in root.ChildNodes)
                {
                    string type = item["channelType"].InnerText;
                    ChannelBase channe = ChannelFactory.CreateChannel(type);
                    channe.ChannelName = item["tvChannel"].InnerText;
                    channe.Path = item["path"].InnerText;
                    dic.Add(channe.ChannelName,channe);
            }
        }
    }
}
