using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05体检套餐
{
    //套餐  名称  价格    套餐（N个体检项）
    public class HealthSet
    {
        public HealthSet() { }
        //A套餐，该套餐对应的体检项目集合
        public HealthSet(string name, Dictionary<string, HealthItem> healthItems) 
        {
            this.HeahthName = name;
            this.healthItems = healthItems;
        }
        private string heahthName;

        public string HeahthName
        {
            get { return heahthName; }
            set { heahthName = value; }
        }
        private int healthPrice;

        public int HealthPrice
        {
            get { return healthPrice; }
            set { healthPrice = value; }
        }
        private Dictionary<string, HealthItem> healthItems = new Dictionary<string, HealthItem>();

        public Dictionary<string, HealthItem> HealthItems
        {
            get { return healthItems; }
            set { healthItems = value; }
        }

    }
}
