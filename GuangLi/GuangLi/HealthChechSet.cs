using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuangLi
{
    class HealthChechSet
    {
        private int Price; //价格

        public int Price1
        {
            get { return Price; }
            set { Price = value; }
        }
        private string Name;  //名称

        public string Name1
        {
            get { return Name; }
            set { Name = value; }
        }
        private string Items;  //集合

        public string Items1
        {
            get { return Items; }
            set { Items = value; }
        }


        public List<HealthCheckItem> ItemList = new List<HealthCheckItem>();
        public static Dictionary<string, List<HealthCheckItem>> SetDic = new Dictionary<string, List<HealthCheckItem>>();


        public HealthChechSet()
        {
            this.ItemList = new List<HealthCheckItem>();
            //ItemList.Add(HealthCheckItem.ItemDic["身高"]);
            //ItemList.Add(HealthCheckItem.ItemDic["体重"]);
            //ItemList.Add(HealthCheckItem.ItemDic["视力"]);
            //ItemList.Add(HealthCheckItem.ItemDic["听力"]);
            //ItemList.Add(HealthCheckItem.ItemDic["肺活量"]);
            SetDic.Add("入学体检",this.ItemList);
        }

        public HealthChechSet(string name)
        {
            SetDic.Add(name,this.ItemList);
        }
            
        /// <summary>
        /// Dic_Values 添加
        /// </summary>
        /// <param name="str"></param>
        public static void DicAdd(List<HealthCheckItem> list,string str)
        {
           list.Add(HealthCheckItem.ItemDic[str]);
        }

    }
}
