using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuangLi
{
    class HealthCheckItem
    {
        private string name;     //项目名
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string bewrite;  //描述
        public string Bewrite
        {
            get { return bewrite; }
            set { bewrite = value; }
        }

        private int price;       //价格
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public HealthCheckItem()
        { }

        public HealthCheckItem(string name, int price, string bewrite)
        {
            this.name = name;
            this.price = price;
            this.bewrite = bewrite;
        }
        //public static Dictionary<string, List<HealthCheckItem>> SetDic = new Dictionary<string, List<HealthCheckItem>>();

        public static Dictionary<string, HealthCheckItem> ItemDic = new Dictionary<string, HealthCheckItem>()
        {
            {"身高",new HealthCheckItem("身高",5,"用于测量身高")},
            {"体重",new HealthCheckItem("体重",5,"用于测量体重")},
            {"视力",new HealthCheckItem("视力",5,"用于检查视力")},
            {"听力",new HealthCheckItem("听力",5,"用于检查听力")},
            {"肝功能",new HealthCheckItem("肝功能",200,"用于检测肝功能")},
            {"B超",new HealthCheckItem("B超",60,"用于B超检查")},
            {"心电图",new HealthCheckItem("心电图",100,"用于检查心电图")},
            {"肺活量",new HealthCheckItem("肺活量",8,"用于测量肺活量")}
        };

    } 
}
